using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmInsuranceGroupProviderEligibility : Form
    {
        private claim _formProviderClaim;
        private insurance_company_group _formGroup;

        public frmInsuranceGroupProviderEligibility(insurance_company_group icg)
        {
            InitializeComponent();
            _formGroup = icg;
            if (icg.primary_provider > 0)
            {
                FillText(txtPrimaryProvider, new claim(icg.primary_provider));
                btnAddRule.Enabled = true;
            }

            Text = icg.name + ": Provider Eligibility";
                
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelectProvider toShow = new frmSelectProvider();

            if (toShow.ShowDialog() == DialogResult.OK)
            {
                FillText(txtPrimaryProvider, toShow.SelectedClaim);
                _formProviderClaim = toShow.SelectedClaim;
                btnAddRule.Enabled = true;

                _formGroup.primary_provider = _formProviderClaim.id;
                _formGroup.Save();
            }
        }

        private void FillText(TextBox txtForProvider, claim claim)
        {
            txtForProvider.Text = claim.doctor_provider_id + " - " + claim.DoctorName;
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            frmEditProviderEligibilityRestriction addForm = new frmEditProviderEligibilityRestriction(_formProviderClaim, _formGroup.name);
            addForm.Show();
        }
    }
}