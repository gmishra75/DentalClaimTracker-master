using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C_DentalClaimTracker.Reporting
{
    public partial class frmCodePaymentHistory : Form
    {
        SqlConnection dbConnection;
        int fixedDuration = -1;

        public frmCodePaymentHistory()
        {
            InitializeComponent();
            LoadInsurance();
            LoadProviders();
        }

        private void LoadProviders()
        {
            clbProviders.Items.Clear();

            claim searchObject = new claim();

            DataTable providers = searchObject.Search("SELECT DISTINCT(doctor_provider_id), doctor_first_name, doctor_last_name FROM claims " +
                "WHERE doctor_provider_id IS NOT Null ORDER BY doctor_first_name, doctor_last_name");

            foreach (DataRow aProvider in providers.Rows)
            {
                if (aProvider["doctor_provider_id"].ToString().Trim() != "")
                    clbProviders.Items.Add(aProvider["doctor_provider_id"].ToString());
            }

            CheckAllProviders(true);

        }

        private void CheckAllProviders(bool toCheck)
        {

            for (int i = 0; i < clbProviders.Items.Count; i++)
                clbProviders.SetItemChecked(i, toCheck);
        }

        private void LoadInsurance()
        {
            clbInsuranceGroups.Items.Clear();
            insurance_company_group workingGroup = new insurance_company_group();

            foreach (DataRow aRow in workingGroup.GetAllData("name").Rows)
            {
                workingGroup = new insurance_company_group(aRow);
                clbInsuranceGroups.Items.Add(workingGroup, false);
            }

            company c = new company();
            foreach (DataRow aRow in c.GetAllData("name").Rows)
            {
                c = new company(aRow);
                clbInsurance.Items.Add(c, false);
            }
        }

        private void lnkLastMonth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDateValues(DateTime.Now.AddMonths(-1), DateTime.Now);
        }

        private void SetDateValues()
        {
            SetDateValues(dtpStart.Value);
        }

        private void SetDateValues(DateTime startDate)
        {
            if (fixedDuration > 0)
            {
                SetDateValues(startDate, startDate.AddMonths(fixedDuration));
            }
        }

        private void SetDateValues(DateTime startDate, DateTime endDate)
        {
            dtpStart.Value = startDate;
            dtpEnd.Value = endDate;
        }

        private void lnkLastCalendarMonth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int lastMonth = DateTime.Now.AddMonths(-1).Month;
            int lastYear = DateTime.Now.AddMonths(-1).Year;
            int lastDayOfMonth = DateTime.DaysInMonth(lastYear, lastMonth);
            SetDateValues(new DateTime(lastYear, lastMonth, 1), new DateTime(lastYear, lastMonth, lastDayOfMonth));
        }

        private void lnkLast6Months_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDateValues(DateTime.Now.AddMonths(-6), DateTime.Now);
        }

        private void lnkLastYear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDateValues(DateTime.Now.AddYears(-1), DateTime.Now);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                if (CheckFormValid())
                {
                    string sql = @"
SELECT
    amtpinspaid, COUNT(*) as 'count', adacode
FROM 
    DDB_PROC_LOG plog
INNER JOIN 
		DDB_claim claim ON claim.CLAIMID = plog.CLAIMID AND claim.CLAIMDB = plog.CLAIMDB 
INNER JOIN 
		dbo.DDB_PROC_CODE pCode ON plog.PROC_CODEID = pCode.PROC_CODEID AND plog.PROC_CODEDB = pCode.PROC_CODEDB
INNER JOIN 
	dbo.DDB_INSURANCE ins ON claim.INSID = ins.INSID AND claim.INSDB = ins.INSDB 
INNER JOIN 
    dbo.DDB_PAT ON claim.PATID = dbo.DDB_PAT.PATID AND claim.PATDB = dbo.DDB_PAT.PATDB 
INNER JOIN dbo.DDB_RSC ON claim.PROVID = dbo.DDB_RSC.URSCID 
WHERE
	amtpinspaid > 0 
    AND adacode LIKE '{0}'
    AND {1}
    AND {2}
    {3}
GROUP BY AMTPINSPAID, ADACode
ORDER BY AMTPINSPAID";

                    string procCode = txtProcedureCode.Text.Trim();

                    if (procCode == "")
                        procCode = "%";

                    sql = string.Format(sql, procCode, GetCompanyOrPatientCriteria(), GetDateCriteria(), GetProviderCriteria());

                    if (InitializeConnection())
                    {
                        int total = 0;
                        dgvMain.Rows.Clear();
                        SqlDataAdapter sda = new SqlDataAdapter(sql, dbConnection);
                        DataTable matches = new DataTable();
                        sda.Fill(matches);

                        foreach (DataRow aRow in matches.Rows)
                        {
                            double amount = Convert.ToDouble(aRow[0].ToString()) / 100;
                            dgvMain.Rows.Add(new object[] { amount.ToString("$#,0.00"), aRow[1], aRow[1], aRow[2], GetCompanyOrPatientCriteria(), GetDateCriteria(), aRow[0] });
                            total += (int)aRow[1];
                        }

                        lblResultsSummary.Text = "Results Summary: (" + total + ")";

                        foreach (DataGridViewRow aRow in dgvMain.Rows)
                        {
                            double percent = (Convert.ToDouble(aRow.Cells[1].Value) / total);
                            aRow.Cells[1].Value = percent.ToString("0.0%");
                        }

                        dbConnection.Close();

                    }
                    else
                    {
                        MessageBox.Show(this, "A connection with the Dentrix database could not be established");
                    }

                   

                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error trying to get results in frmCodePaymentHistory.Search", LogSeverity.Error, err);
                MessageBox.Show(this, "An error occurred while trying to get results. The system error message follows:\n\n" + err.Message);
            }
            
        }

        private object GetProviderCriteria()
        {
            string sqlCriteria = "";
            if (clbProviders.CheckedItems.Count > 0) // check for combo values
            {
                string criteriaString = "";    

                foreach(string providerID in clbProviders.CheckedItems)
                {
                    if (criteriaString != "")
                        criteriaString += ",";

                    criteriaString += "'" + providerID + "'";
                }

                sqlCriteria += string.Format(" AND RSCID IN ({0})", criteriaString);
            }

            return sqlCriteria;
        }

        private string GetDateCriteria()
        {
            return "plDate >= '" + dtpStart.Value.ToString("MM/dd/yyyy") + "' AND pldate <= '" + dtpEnd.Value.ToString("MM/dd/yyyy") + "'";
        }

        private bool InitializeConnection()
        {
            // Initialize stuff to actually process
            try
            {
                if (dbConnection.State != ConnectionState.Open)
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GetCompanyOrPatientCriteria()
        {
            string sqlCriteria = string.Empty;

            if (pnlPatientInformation.Visible)
            {
                string[] allCriteria = txtPatientName.Text.Replace(",", " ").Replace("  ", " ").Split(" "[0]);

                foreach (string aCriteria in allCriteria)
                {
                    if (sqlCriteria != string.Empty)
                        sqlCriteria += " OR ";

                    if (radSimilar.Checked)
                        sqlCriteria += string.Format("(FIRSTNAME Like '{0}' OR LASTNAME LIKE '{0}')", "%" + aCriteria + "%");
                    else
                        sqlCriteria += string.Format("(FIRSTNAME Like '{0}' OR LASTNAME LIKE '{0}')", aCriteria);
                }
            }
            else
            {
                List<company> allCompanies = SelectedCompanies();
                
                if (allCompanies.Count > 0)
                {
                    sqlCriteria = "INSCONAME in (";

                    foreach (company aCompany in SelectedCompanies())
                    {
                        sqlCriteria += "'" + aCompany.name + "',";
                    }
                    sqlCriteria = sqlCriteria.Substring(0, sqlCriteria.Length - 1);
                    sqlCriteria += ")";
                }
                else
                    sqlCriteria = "0 = 1"; // Should never happen, avoids crash if it does

                
            }

            return sqlCriteria;
        }

        private List<company> SelectedCompanies()
        {
            List<company> toReturn = new List<company>();

            foreach (company c in clbInsurance.CheckedItems)
            {
                toReturn.Add(c);
            }

            foreach (insurance_company_group aGroup in clbInsuranceGroups.CheckedItems)
            {
                List<company> matchingCompanies = aGroup.GetMatchingCompanies();
                CheckAdd(toReturn, matchingCompanies);
            }

            return toReturn;
        }

        private void CheckAdd(List<company> sourceList, List<company> toAdd)
        {
            foreach (company toCheck in toAdd)
            {
                bool hasMatch = false;
                foreach (company aComp in sourceList)
                {
                    if (aComp.id == toCheck.id)
                    {
                        hasMatch = true;
                        break;
                    }
                }

                if (!hasMatch)
                    sourceList.Add(toCheck);
            }
        }

        private bool CheckFormValid()
        {
            string errorMessage = string.Empty;
            
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(this, "The following error(s) prevented your search: " + errorMessage);
                return false;
            }
            else
                return true;
        }

        private void frmCodePaymentHistory_Load(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection(data_mapping_schema.GetDefaultSchema.GetConnectionString(false));
            dtpStart.Value = DateTime.Now.AddYears(-1);
            cmbDateDuration.SelectedIndex = 3;
        }

        private void txtProcedureCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowMatchingClaims()
        {
            pnlMatchingClaims.Visible = true;

            try
            {
                int amount = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[colAmountActual.Index].Value);

                string sql = "SELECT TOP " + nmbMaxMatches.Value;
                sql += @" 
    claim.claimid, claim.claimdb, deductable
FROM 
    DDB_PROC_LOG plog
INNER JOIN 
		DDB_claim claim ON claim.CLAIMID = plog.CLAIMID AND claim.CLAIMDB = plog.CLAIMDB 
INNER JOIN 
		dbo.DDB_PROC_CODE pCode ON plog.PROC_CODEID = pCode.PROC_CODEID AND plog.PROC_CODEDB = pCode.PROC_CODEDB
INNER JOIN 
	dbo.DDB_INSURANCE ins ON claim.INSID = ins.INSID AND claim.INSDB = ins.INSDB 
INNER JOIN dbo.DDB_PAT ON claim.PATID = dbo.DDB_PAT.PATID AND claim.PATDB = dbo.DDB_PAT.PATDB 
INNER JOIN dbo.DDB_RSC ON claim.PROVID = dbo.DDB_RSC.URSCID 
WHERE
	amtpinspaid = {3} 
    AND adacode = '{0}'
    AND {1}
    AND {2}
ORDER BY AMTPINSPAID";

                sql = string.Format(sql, dgvMain.SelectedRows[0].Cells[colProcCode.Index].Value, GetCompanyOrPatientCriteria(), GetDateCriteria(), amount);

                if (InitializeConnection())
                {
                    dgvMatches.Rows.Clear();
                    SqlDataAdapter sda = new SqlDataAdapter(sql, dbConnection);
                    DataTable matches = new DataTable();
                    claim c = new claim();
                    sda.Fill(matches);

                    foreach (DataRow aRow in matches.Rows)
                    {
                        string dentrixID = aRow[0].ToString();
                        string dentrixDB = aRow[1].ToString();
                        string deductable = aRow[2].ToString();

                        if (!c.LoadWithDentrixIDs(dentrixID, dentrixDB))
                        {
                            dgvMatches.Rows.Add(new object[] { dentrixID, dentrixDB, "Local not found." });
                        }
                        else
                        {
                            c.Load(matches.Rows[0]);

                            dgvMatches.Rows.Add(new object[] { c.PatientName, c.patient_dob.Value.ToShortDateString(), c.LinkedCompany.name, c.amount_of_claim, deductable,
                                c.date_of_service.HasValue ? c.date_of_service.Value.ToShortDateString() : "", 
                                c.claim_type_display(true), c.doctor_provider_id, c.subscriber_group_name, c.subscriber_group_number, dentrixID, dentrixDB, c});
                        }
                    }
                    dbConnection.Close();
                }
                else
                {
                    MessageBox.Show(this, "A connection with the Dentrix database could not be established");
                }


            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error showing matches in frmCodePaymentHistory.ShowMatchingClaims", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred showing the matches for this row. The error message is:\n\n" + err.Message);
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                ShowMatchingClaims();
                lblMatchingClaims.Text = "Matching Claims for " + dgvMain.SelectedRows[0].Cells[0].Value;
            }
        }

        private void dgvMatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                frmClaimManager toShow = new frmClaimManager((claim)dgvMatches.SelectedRows[0].Cells[colClaimObject.Index].Value, true);
                toShow.Show();
            }
        }

        private void lnkClearInsurance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (int i in clbInsurance.CheckedIndices)
                clbInsurance.SetItemChecked(i, false);
            

            foreach (int i in clbInsuranceGroups.CheckedIndices)
                clbInsuranceGroups.SetItemChecked(i, false);
            
        }

        private void cmbDateDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1, 3, 6, 12, Custom
            dtpEnd.Enabled = false;
            switch (cmbDateDuration.SelectedIndex)
            {
                case 0:
                    fixedDuration = 1;
                    break;
                case 1:
                    fixedDuration = 3;
                    break;
                case 2:
                    fixedDuration = 6;
                    break;
                case 3:
                    fixedDuration = 12;
                    break;
                default:
                    fixedDuration = -1;
                    dtpEnd.Enabled = true;
                    break;
            }

            if (fixedDuration > 0)
                SetDateValues();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            SetDateValues(dtpStart.Value);
        }

        private void ShowLabels(bool showInsurance, Button showButton, Button hideButton)
        {
            pnlInsuranceCompanies.Visible = showInsurance;
            pnlInsuranceGroups.Visible = showInsurance;
            pnlPatientInformation.Visible = !showInsurance;

            showButton.ForeColor = Color.Black;
            showButton.ImageIndex = 0;
            showButton.BackColor = Color.FromArgb(244, 155, 108); 

            // hideButton.ForeColor = Color.Gray;
            hideButton.ImageIndex = 1;
            hideButton.BackColor = Color.White;
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            ShowLabels(true, btnInsurance, btnPatient);
        }

        private void btnInformation_Click_1(object sender, EventArgs e)
        {
            ShowLabels(false, btnPatient, btnInsurance);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckAllProviders(false);
        }

    }
}
