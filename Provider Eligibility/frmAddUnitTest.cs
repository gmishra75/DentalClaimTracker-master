using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmAddUnitTest : Form
    {
        public frmAddUnitTest()
        {
            InitializeComponent();
            InitializeInsuranceList();
        }

        private void InitializeInsuranceList()
        {
            company comp = new company();
            cmbInsurance.Items.Clear();
            foreach (DataRow c in comp.GetAllData("name").Rows)
            {
                cmbInsurance.Items.Add(c["name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorText = "";

            if (txtProvider.Text == "")
            {
                errorText = "Please enter a provider.";
            }
            if (cmbInsurance.Text == "" || cmbInsurance.FindStringExact(cmbInsurance.Text) < 0)
            {
                errorText += " Please enter a valid insurance.";
            }

            lblErrorText.Text = errorText;

            if (errorText == "")
            {
                provider_eligibility_test_rules petr = new provider_eligibility_test_rules();

                petr.provider = txtProvider.Text;
                petr.insurance = cmbInsurance.Items[cmbInsurance.FindStringExact(cmbInsurance.Text)].ToString();
                petr.date_of_service = dtpDOS.Value;

                petr.Save();

                txtProvider.Text = "";
                cmbInsurance.Text = "";
                txtProvider.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
