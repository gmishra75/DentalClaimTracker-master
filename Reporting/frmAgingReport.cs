using C_DentalClaimTracker.Reporting.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Reporting
{
    public partial class frmAgingReport : Form
    {
        public frmAgingReport()
        {
            InitializeComponent();
        }

        public bool IncludePrimary
        {
            get { return chkShowPrimary.Checked; }
            set { chkShowPrimary.Checked = value; }
        }

        public bool IncludeSecondary
        {
            get { return chkShowSecondary.Checked; }
            set { chkShowSecondary.Checked = value; }
        }

        public bool IncludePredeterm
        {
            get { return chkShowPredeterms.Checked; }
            set { chkShowPredeterms.Checked = value; }
        }

        public decimal DateCriteria 
        {
            get { return nmbDate.Value; }
            set { nmbDate.Value = value; }
        }

        public string ClinicCriteria { get; set; } // Is SQL, ie = " AND clinic_id IN (30)


        private void SetReportSource()
        {
            List<AgingReportRow> reportData = new List<AgingReportRow>();
            
            claim c = new claim();
            company_contact_info cci = new company_contact_info();
            c.company_address_id = 0;

            string SQL = @"SELECT co.name as company_name, group_name as group_plan, group_num , cci.phone as company_phone,
c.id as claim_id, sent_date, date_of_service, subscriber_first_name + ' ' + subscriber_last_name AS subscriber,
CASE c.claim_type WHEN 0 THEN 'P' WHEN 1 THEN 'S' ELSE 'PRE' END AS 'Type', c.subscriber_alternate_number as idnum, patient_first_name + ' ' + patient_last_name AS patient,
patient_dob as Birthday, c.amount_of_claim as Total, revisit_date, cs.name as current_status

 FROM claims c INNER JOIN companies co ON c.company_id = co.id INNER JOIN company_contact_info cci ON 
cci.order_id = c.company_address_id AND co.id = cci.company_id LEFT JOIN claimstatus cs ON cs.id = c.status_id ";

            
            string claimsToInclude = "-1";
            string reportName = string.Empty;
            if (chkShowPrimary.Checked)
            {
                reportName = "Primary";
                claimsToInclude += ",0";
            }
            if (chkShowSecondary.Checked)
            {
                if (reportName != string.Empty)
                    reportName += " and ";

                reportName += "Secondary";
                claimsToInclude += ",1";
            }
            if (chkShowPredeterms.Checked)
            {
                if (reportName != string.Empty)
                    reportName += " and ";

                reportName += "Predeterm";
                claimsToInclude += ",2,3";
            }
            string whereClause = string.Format(" WHERE claim_type IN({0}) AND DATEDIFF(d, sent_date, GETDATE()) > {1} {2} AND [open] = 1", claimsToInclude, DateCriteria, ClinicCriteria);

            DataTable allMatches = c.Search(SQL + whereClause + " ORDER BY company_name, group_plan");
            
            foreach (DataRow aRow in allMatches.Rows)
            {
                AgingReportRow ar = new AgingReportRow();
                ar.CompanyName = aRow["company_name"].ToString();
                ar.GroupNumber = aRow["group_num"].ToString();
                ar.GroupPlan = aRow["group_plan"].ToString() == "" ? "[No Plan Name]" : aRow["group_plan"].ToString(); // give it a default val if blank
                try { ar.CompanyPhone = new PhoneObject(aRow["company_phone"].ToString()).FormattedPhone; }
                catch { ar.CompanyPhone = aRow["company_phone"].ToString(); }

                ar.SentDate = Convert.ToDateTime(aRow["sent_date"]);
                ar.DateOfService = Convert.ToDateTime(aRow["date_of_service"]);
                ar.Subscriber = aRow["subscriber"].ToString();

                ar.Type = aRow["type"].ToString();
                ar.IDNum = aRow["idnum"].ToString();
                ar.Patient = aRow["patient"].ToString();

                if (CommonFunctions.DBNullToString(aRow["birthday"]) == "")
                    ar.Birthday = new DateTime(1901, 1, 1);
                else
                    ar.Birthday = Convert.ToDateTime(aRow["birthday"]);

                ar.Total = Convert.ToDecimal(aRow["total"]) / 100;

                if (CommonFunctions.DBNullToString(aRow["revisit_date"]) == "")
                    ar.RevisitDate = "";
                else
                    ar.RevisitDate = Convert.ToDateTime(aRow["revisit_date"]).ToString("M/d/yy");
                ar.CurrentStatus = aRow["current_status"].ToString();

                

                reportData.Add(ar);
            }


            AgingReportRowBindingSource.DataSource = reportData;

            reportName += string.Format(" (> {0} days)", DateCriteria.ToString("0"));
            rptvMain.ShowParameterPrompts = false;
            rptvMain.LocalReport.ReportPath = "Reporting\\PriorityReport.rdlc";
            rptvMain.LocalReport.SetParameters(new ReportParameter("ReportName", reportName));
            
            
            rptvMain.RefreshReport();
        }

        private void frmAgingReport_Load(object sender, EventArgs e)
        {
            SetReportSource();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetReportSource();
        }
    }
}
