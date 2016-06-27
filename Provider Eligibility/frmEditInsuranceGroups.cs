using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmEditInsuranceGroup : Form
    {
        insurance_company_group _formGroup;
        bool _showExcluded = false;
        public frmEditInsuranceGroup()
        {
            InitializeComponent();
            _formGroup = new insurance_company_group();
        }

        public frmEditInsuranceGroup(insurance_company_group grp)
        {
            InitializeComponent();
            _formGroup = grp;

            LoadFormGroup();
        }

        private void LoadFormGroup()
        {
            txtName.Text = _formGroup.name;
            txtSwitchToProvider.Text = _formGroup.description;
            chkContainsMultipleCarriers.Checked = _formGroup.multiple_carriers;
            foreach (insurance_company_groups_filters icgf in _formGroup.Filters)
            {
                lstProcFilterList.Items.Add(icgf.filter_text);
            }
            RefreshMatches();
        }

        public insurance_company_group FormGroup
        {
            get { return _formGroup; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to exit this form without saving?", "Exit Without Saving?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                _formGroup.name = txtName.Text;
                _formGroup.description = txtSwitchToProvider.Text;
                _formGroup.multiple_carriers = chkContainsMultipleCarriers.Checked;
                _formGroup.Save();

                _formGroup.SaveFilters(lstProcFilterList.Items);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateForm()
        {
            string Errors = string.Empty;

            if (txtName.Text == "")
                Errors += "\nYou must specify a name for this group.";

            if (Errors != string.Empty)
            {
                MessageBox.Show(this, Errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        
        private void frmEditProviderEligibilityRestriction_Load(object sender, EventArgs e)
        {
            
        }

        private void txtProcFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdAddFilter.PerformClick();
        }

        private void cmdAddFilter_Click(object sender, EventArgs e)
        {
            txtProcFilter.Text = txtProcFilter.Text.Trim();

            string validationErrors = string.Empty;
            if (txtProcFilter.Text == "")
                validationErrors += "\nPlease enter some filter text.";
            
            if (lstProcFilterList.FindStringExact(txtProcFilter.Text) >= 0)
                validationErrors += "\nThis filter already exists.";


            if (txtProcFilter.Text.StartsWith("NOT  ", StringComparison.CurrentCultureIgnoreCase))
                validationErrors += "\nOnly one space is allowed after the word 'NOT'";

            if (txtProcFilter.Text.StartsWith("NOT ", StringComparison.CurrentCultureIgnoreCase))
            {
                // Change it to all caps if necessary
                if (!txtProcFilter.Text.StartsWith("NOT ", StringComparison.CurrentCulture))
                    txtProcFilter.Text = "NOT " + txtProcFilter.Text.Substring(4);
            }

            if (txtProcFilter.Text.Contains("%"))
            {
                string text = txtProcFilter.Text.Replace("NOT ", "");
                if (text.StartsWith("%"))
                    text = text.Substring(1);

                if (text.EndsWith("%"))
                    text = text.Substring(0, text.Length - 1);

                if (text.Contains("%")) // if it still has a % symbol after removing the first and last characters
                    validationErrors += "\nThe % mark can only be placed at the beginning or the end of filter.";
                
            }


            if (validationErrors == string.Empty)
            {
                lstProcFilterList.Items.Add(CommonFunctions.MakeDataSafe(txtProcFilter.Text));
                txtProcFilter.Text = "";
                txtProcFilter.Focus();
                RefreshMatches();
            }
            else
            {
                MessageBox.Show("Could not add your filter for the following reason(s):\n" + validationErrors);
            }

            
        }

        private void lstProcFilterList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (lstProcFilterList.SelectedIndex >= 0) {
                    lstProcFilterList.Items.RemoveAt(lstProcFilterList.SelectedIndex);
                    RefreshMatches();
                }
        }

        private void cmdRefreshMatches_Click(object sender, EventArgs e)
        {
            RefreshMatches();
        }

        private void RefreshMatches()
        {
            try
            {
                DataTable matches =
                    _formGroup.Search(insurance_company_group.GenerateCompanySQL("name", GetFormFilters(), _showExcluded));

                lstMatches.Items.Clear();
                foreach (DataRow aRow in matches.Rows)
                {
                    lstMatches.Items.Add(aRow["name"].ToString());
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error retrieving matches for criteria in frmEditInsuranceGroup.RefreshMatches", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred retrieving the matches for this criteria. The error returned was:\n\n" + err.Message);
            }
        }

        private List<string> ConvertFiltersToString(List<insurance_company_groups_filters> filters)
        {
            List<string> toReturn = new List<string>();
            foreach (insurance_company_groups_filters icgf in filters)
                toReturn.Add(icgf.filter_text);

            return toReturn;
        }

        private List<string> GetFormFilters()
        {
            List<string> toReturn = new List<string>();
            foreach (string icgf in lstProcFilterList.Items)
                toReturn.Add(icgf);

            return toReturn;
        }

        private void lnkProviderEligibility_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInsuranceGroupProviderEligibility toShow = new frmInsuranceGroupProviderEligibility(_formGroup);
            toShow.Show();
        }

        private void lnkShowExcluded_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _showExcluded = !_showExcluded;

            if (_showExcluded)
            {
                lnkShowExcluded.Text = "Show Matches";
                lblMatches.Text = "Showing Excluded Companies";
            }
            else
            {
                lnkShowExcluded.Text = "Show Excluded";
                lblMatches.Text = "Showing Matching Companies";
            }

            RefreshMatches();
        }
    }

    
}