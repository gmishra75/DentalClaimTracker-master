using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmEligibilityTests : Form
    {
        string providerFilter = "";
        DateTime dos;

        public frmEligibilityTests()
        {
            InitializeComponent();
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void RunTests()
        {
            PrepSearch();
            providerFilter = txtSearchFilter.Text;
            Thread oThread = new Thread(new ThreadStart(RunTestsThreading));
            oThread.Start();   
        }

        private void PrepSearch()
        {
            btnRunTests.Enabled = false;
            btnRunTestAllInsurance.Enabled = false;
            dgvResults.Rows.Clear();
        }

        private void RunTestsThreading()
        {
            // Get list of tests then iterate through, adding them one at a time
            provider_eligibility_test_rules petr = new provider_eligibility_test_rules();
            
            DataTable dt;

            petr.provider = providerFilter;
            petr.SearchType = DataObject.SearchTypes.Contains;
            dt = petr.Search(petr.SearchSQL + " ORDER BY provider");

            foreach (DataRow aRow in dt.Rows)
            {
                petr.Load(aRow);

                string newProvider = provider_eligibility_restrictions.FindEligibilityRestrictions(petr.provider, petr.insurance, petr.date_of_service);

                Invoke((MethodInvoker)delegate { dgvResults.Rows.Add(new object[] { petr.provider, petr.insurance, petr.date_of_service.ToShortDateString(), 
                    newProvider, newProvider == "" ? "" : "*", petr.id } ) ; });
                
            }

            Invoke((MethodInvoker)delegate { btnRunTests.Enabled = true; btnRunTestAllInsurance.Enabled = true; });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEligibilityTests_Load(object sender, EventArgs e)
        {
            dtpDOS.Value = DateTime.Now;
        }


        private void btnAddTest_Click(object sender, EventArgs e)
        {
            frmAddUnitTest toShow = new frmAddUnitTest();
            toShow.ShowDialog();
        }

        private void btnRunTestAllInsurance_Click(object sender, EventArgs e)
        {
            if (txtProviderFilter.Text.Trim() == "")
            {
                MessageBox.Show(this, "This test must be run for only one provider. Please enter a provider search filter.");
            }
            else
            {
                RunAllInsuranceSearch();
            }

        }

        private void RunAllInsuranceSearch()
        {
            PrepSearch();
            providerFilter = txtProviderFilter.Text;
            dos = dtpDOS.Value;
            Thread oThread = new Thread(new ThreadStart(RunAllInsuranceThreading));
            oThread.Start();
        }

        private void RunAllInsuranceThreading()
        {
            company c = new company();
            DataTable dt = c.GetAllData("name");
            List<provider_eligibility_restrictions> allRestrictions = provider_eligibility_restrictions.GetAllDataAsList();

            foreach (DataRow aRow in dt.Rows)
            {
                string newProvider = provider_eligibility_restrictions.FindEligibilityRestrictions(providerFilter, aRow["name"].ToString(), dos, allRestrictions, "");

                Invoke((MethodInvoker)delegate
                {
                    dgvResults.Rows.Add(new object[] { providerFilter, aRow["name"].ToString(), dos.ToShortDateString(), 
                    newProvider, newProvider == "" ? "" : "*", 0 });
                });

            }

            Invoke((MethodInvoker)delegate { btnRunTests.Enabled = true; btnRunTestAllInsurance.Enabled = true; });
        }

        private void btnHideHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlHelp.Visible = true;
        }
    }
}
