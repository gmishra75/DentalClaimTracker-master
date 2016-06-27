using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmApexRulesEdit : Form
    {
        apex_rules_rulelist _formARR;

        /// <summary>
        /// Pass null if you want to add a new ruleslist
        /// </summary>
        /// <param name="toUse"></param>
        public frmApexRulesEdit(apex_rules_rulelist toUse)
        {
            InitializeComponent();

            if (toUse == null)
                _formARR = new apex_rules_rulelist();
            else
            {
                _formARR = toUse;
                LoadRules();

            }
        }

        private void LoadRules()
        {
            txtName.Text = _formARR.name;
            chkPredeterm.Checked = _formARR.apply_predeterm;
            chkPrimary.Checked = _formARR.apply_primary;
            chkSecondary.Checked = _formARR.apply_secondary;
            txtRuleText.Text = _formARR.rule_text;

            foreach (apex_rules_procedure_codes arpc in _formARR.LinkedProcedureCodes)
            {
                lstProcFilterList.Items.Add(arpc.procedure_code);
            }

            foreach (apex_rules_companies arc in _formARR.LinkedInsurance)
            {
                lstInsuranceFilters.Items.Add(arc.company_info);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show(this, "Please give the rule a unique name.");
            }
            else if (txtRuleText.Text == "")
            {
                MessageBox.Show(this, "Please specify the text you'd like to use in this rule.");
            }
            else
            {
                try
                {
                    _formARR.DeleteAllLinkedData();

                    _formARR.name = txtName.Text;
                    _formARR.apply_predeterm = chkPredeterm.Checked;
                    _formARR.apply_primary = chkPrimary.Checked;
                    _formARR.apply_secondary = chkSecondary.Checked;
                    _formARR.rule_text = txtRuleText.Text;
                    if (_formARR.priority == 10000) // If this doesn't have a set priority yet
                        _formARR.priority = _formARR.GetLastPriority();
                    _formARR.Save();

                    _formARR.AddProcedureCodes(lstProcFilterList.Items);
                    _formARR.AddInsuranceCompanyFilter(lstInsuranceFilters.Items);

                    Close();
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Could not save rule in frmApexRulesEdit.Save", LogSeverity.Error, err, false);
                    MessageBox.Show(this, "An unexpected error occurred saving this rule. Your rule did not save properly. Please report the " +
                        "following message to an administrator.\n\n" + err.Message);
                }
            }
        }

        private void cmdAddProcedure_Click(object sender, EventArgs e)
        {
            if (txtProcFilter.Text.Trim() != "")
            {

                if (!StringExists(lstProcFilterList, txtProcFilter.Text))
                {
                    lstProcFilterList.Items.Add(txtProcFilter.Text);
                }
                txtProcFilter.Text = "";
                txtProcFilter.Focus();
            }
        }

        private bool StringExists(ListBox lstToSearch, string searchString)
        {
            foreach (string anItem in lstToSearch.Items)
            {
                if (anItem == searchString)
                    return true;
            }

            return false;
        }

        private void cmdAddInsuranceFilter_Click(object sender, EventArgs e)
        {
            if (txtInsuranceFilter.Text.Trim() != "")
            {
                if (!StringExists(lstInsuranceFilters, txtInsuranceFilter.Text))
                {
                    lstInsuranceFilters.Items.Add(txtInsuranceFilter.Text);
                }
                txtInsuranceFilter.Text = "";
                txtInsuranceFilter.Focus();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProcFilter_Enter(object sender, EventArgs e)
        {
            AcceptButton = cmdAddProcedure;
        }

        private void txtProcFilter_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void txtInsuranceFilter_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void txtInsuranceFilter_Enter(object sender, EventArgs e)
        {
            AcceptButton = cmdAddInsuranceFilter;
        }

        private void lstProcFilterList_KeyDown(object sender, KeyEventArgs e)
        {
            CheckDelete(lstProcFilterList, e);
        }

        private void CheckDelete(ListBox lstToCheck, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstToCheck.SelectedIndex >= 0)
                    lstToCheck.Items.Remove(lstToCheck.SelectedItem);
            }
        }

        private void lstInsuranceFilters_KeyDown(object sender, KeyEventArgs e)
        {
            CheckDelete(lstInsuranceFilters, e);
        }
    }
}