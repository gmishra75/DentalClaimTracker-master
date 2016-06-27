using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace C_DentalClaimTracker.Reporting
{
    public partial class frmClaimSendHistory : Form
    {
        OleDbConnection oConnect;
        OleDbDataAdapter oAdapter;

        public frmClaimSendHistory()
        {
            InitializeComponent();
        }

        private void frmClaimSendHistory_Load(object sender, EventArgs e)
        {
            data_mapping_schema dms = data_mapping_schema.GetDefaultSchema;

            dtpStart.Value = DateTime.Now.Subtract(new TimeSpan(365, 0, 0, 0));
            dtpEnd.Value = DateTime.Now;

            try
            {
                oConnect = new OleDbConnection(dms.GetConnectionString(true));
                oConnect.Open();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not connect to DB in frmClaimSendHistory_Load", LogSeverity.Error, err, false);
                MessageBox.Show(this, "A connection to the database could not be established.");
                return;
            }
        }

        private void Search()
        {
            try
            {
                List<int> monthValues = new List<int>();
                List<int> yearValues = new List<int>();
                DataTable resultData = new DataTable();
                string sql = "";
                DateTime workingDate = dtpStart.Value;

                while (workingDate <= dtpEnd.Value)
                {
                    monthValues.Add(workingDate.Month);
                    yearValues.Add(workingDate.Year);

                    workingDate = workingDate.AddMonths(1);
                }

                for (int i = 0; i < monthValues.Count; i++)
                {
                    if (sql != string.Empty)
                        sql += " UNION ";

                    sql += CreateSQL(monthValues[i], yearValues[i]);
                }

                sql += " ORDER BY 1";

                if (sql != string.Empty)
                {
                    // ************* Standard Claims
                    oAdapter = new OleDbDataAdapter(sql, oConnect);
                    oAdapter.Fill(resultData);
                    dgvMain.Rows.Clear();
                    foreach (DataRow aRow in resultData.Rows)
                    {
                        dgvMain.Rows.Add(new object[] { aRow[0], aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], aRow[9], aRow[10]  });
                    }
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("An error occurred retrieving the data in frmClaimSendHistory.Search.", LogSeverity.Error, err, false);
                MessageBox.Show("An unexpected error occurred retrieving data.\n\n" + err.Message);
            }
        }

        private string CreateSQL(int month, int year)
        {
            // INNER JOIN DDB_INSURANCE i ON c.insurance_id = i.id " +

            string toReturn =
                "SELECT '" + year + "-" + month.ToString("00") + "' AS 'monyear', COUNT(*) AS 'Total Claims', " +
                GenerateSQL(month, year, -1, 30, "Paid <=30", true) + ", " +
                GenerateSQL(month, year, 30, 45, "Paid 31-45", true) + ", " +
                GenerateSQL(month, year, 45, 60, "Paid 46-60", true) + ", " +
                GenerateSQL(month, year, 60, 75, "Paid 61-75", true) + ", " +
                GenerateSQL(month, year, 75, -1, "Paid > 75", true) + ", " +
                GenerateSQL(month, year, -1, -1, "Paid", true) + ", " +
                GenerateUnpaidSQL(month, year, true) + ", " +
                "'" + month + "' AS 'Month', '" + year + "' AS 'Year' " +
                "FROM DDB_CLAIM_BASE c " +
                "    WHERE " + UniversalWhereClause(month, year);

            return toReturn;


            /* Old method
                "(SELECT COUNT(*) FROM DDB_CLAIM c " + 
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) < 30 AND DATEDIFF (d, dateofclaim, datereceived) >= 0) AS 'Paid <30', " +
                "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) >= 30 " +
                "    AND DATEDIFF (d, dateofclaim, datereceived) <= 45) AS 'Paid 30-45', " +
                "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) > 45 " +
                "    AND DATEDIFF (d, dateofclaim, datereceived) <= 60) AS 'Paid 46-60', " +
                "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) > 60 " +
                "    AND DATEDIFF (d, dateofclaim, datereceived) <= 75) AS 'Paid 61-75', " +
                "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) > 75) AS 'Paid >75', " +
                "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATERECEIVED IS NOT NULL AND DATEDIFF (d, dateofclaim, datereceived) >= 0) AS 'Paid', " +
                 */
        }

        /// <summary>
        /// Generates the SQL for the "unpaid" portion
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="isCount"></param>
        /// <returns></returns>
        private string GenerateUnpaidSQL(int month, int year, bool isCount)
        {
            string finalSQL = "(SELECT ";
            
            if (isCount)
                finalSQL += "Count(*)";
            else
                finalSQL += "claimid, claimdb";

            finalSQL += " FROM DDB_CLAIM c WHERE " + UniversalWhereClause(month, year) +
               "    AND (DATERECEIVED IS NULL OR DATERECEIVED < '1-1-1950'))";
            
            if (isCount)
                finalSQL += " AS 'Unpaid'";

            return finalSQL;
        }

        /// <summary>
        /// Returns a portion of a sql statement with the given month and year as parameters. Use -1 for less than to ignore
        /// See method for example output
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="greater_than"></param>
        /// <param name="less_than"></param>
        /// <param name="p_3"></param>
        /// <param name="isCount"></param>
        /// <returns></returns>
        private string GenerateSQL(int month, int year, int greater_than, int less_than, string colName, bool isCount)
        {
            /* Example Output
              "(SELECT COUNT(*) FROM DDB_CLAIM c " +
                "    WHERE " + UniversalWhereClause(month, year) +
                "    AND DATEDIFF (d, dateofclaim, datereceived) > 45 " +
                "    AND DATEDIFF (d, dateofclaim, datereceived) <= 60) AS 'Paid 46-60'"
             */

            string finalSQL = "(SELECT ";
            
            if (isCount)
                finalSQL += "Count(*)";
            else
                finalSQL += "claimid, claimdb";

            finalSQL += " FROM DDB_CLAIM c WHERE " + UniversalWhereClause(month, year) +
                " AND DATEDIFF (d, dateofclaim, datereceived) > " + greater_than;

            if (less_than > 0)
                finalSQL += " AND DATEDIFF (d, dateofclaim, datereceived) <= " + less_than;
            finalSQL += ")";

            if (colName != string.Empty)
                 finalSQL += "AS '" + colName + "'";

            return finalSQL;
        }


        /// <summary>
        /// This is the where clause used when retrieving each of the separate pieces of the results. Any criteria that should apply
        /// to everything should be put here (dates, specific companies, etc)
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private string UniversalWhereClause(int month, int year)
        {
            return "MONTH(DATEOFCLAIM) = " + month + " AND YEAR(DATEOFCLAIM) = " + year;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string sourceSQL = "";
                    int month = Convert.ToInt32(dgvMain[9, e.RowIndex].Value);
                    int year = Convert.ToInt32(dgvMain[10, e.RowIndex].Value);

                    switch (e.ColumnIndex)
                    {
                        case 1:
                            sourceSQL = "SELECT claimid, claimdb FROM ddb_claim_base WHERE " + UniversalWhereClause(month, year);
                            break;
                        case 2:
                            sourceSQL = GenerateSQL(month, year, -1, 30, string.Empty, false);
                            break;
                        case 3:
                            sourceSQL = GenerateSQL(month, year, 30, 45, string.Empty, false);
                            break;
                        case 4:
                            sourceSQL = GenerateSQL(month, year, 45, 60, string.Empty, false);
                            break;
                        case 5:
                            sourceSQL = GenerateSQL(month, year, 60, 75, string.Empty, false);
                            break;
                        case 6:
                            sourceSQL = GenerateSQL(month, year, 75, -1, string.Empty, false);
                            break;
                        case 7:
                            sourceSQL = GenerateSQL(month, year, -1, -1, string.Empty, false);
                            break;
                        case 8:
                            sourceSQL = GenerateUnpaidSQL(month, year, false);
                            break;
                    }
                    DataTable resultData = new DataTable();
                    oAdapter = new OleDbDataAdapter(sourceSQL, oConnect);
                    oAdapter.Fill(resultData);
                    dgvMatches.Rows.Clear();
                    pnlMatchingClaims.Visible = true;
                    foreach (DataRow aRow in resultData.Rows)
                    {
                        AddRow(aRow[0].ToString(), (string) aRow[1].ToString());
                    }
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error retrieving result in frmClaimSendHistory.dgvMain_CellDoubleClick.", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred attempting to retrieve these results. The error is:\n\n" + err.Message);
            }
        }

        private void AddRow(string dentrixID, string dentrixDB)
        {
            claim c = new claim();
            c.claimidnum = dentrixID;
            c.claimdb = dentrixDB;

            DataTable matches = c.Search();

            if (matches.Rows.Count == 0)
            {
                dgvMatches.Rows.Add(new object[] { dentrixID, dentrixDB, "Local not found." });
            }
            else 
            {
                c.Load(matches.Rows[0]);

                dgvMatches.Rows.Add(new object[] { c.PatientName, c.patient_dob.Value.ToShortDateString(), c.LinkedCompany.name, c.amount_of_claim, c.date_of_service, 
                    c.claim_type_display(true), c.doctor_provider_id, dentrixID, dentrixDB, c});

                if (matches.Rows.Count > 1)
                {
                    MessageBox.Show(this, "There were multiple local matches found for the claim " + c.PatientName + " with DOS " + c.date_of_service +
                        ". Please let an administrator know about this issue.");
                }
            }
            
        }

        private void dgvMatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                if (dgvMatches[colClaimObject.Index, e.RowIndex].Value != null)
                {
                    frmClaimManager toShow = new frmClaimManager((claim)dgvMatches[colClaimObject.Index, e.RowIndex].Value);
                    toShow.Show();
                }
            }
        }
    }
}