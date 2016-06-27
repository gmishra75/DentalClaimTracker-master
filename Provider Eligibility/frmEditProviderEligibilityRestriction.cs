using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmEditProviderEligibilityRestriction : Form
    {
        string _formProvider;
        claim _formFromProviderClaim;
        claim _formToProviderClaim;
        provider_eligibility_restrictions _formRestriction;
        BindingList<insurance_company_group> _includedGroups;


        public provider_eligibility_restrictions FormRestriction
        {
            get { return _formRestriction; }
        }

        public frmEditProviderEligibilityRestriction()
        {
            InitializeComponent();
            _formFromProviderClaim = new claim();
            _formToProviderClaim = new claim();
            _includedGroups = new BindingList<insurance_company_group>();
            lstGroupsIncluded.DataSource = _includedGroups;
            LoadProviders(true);
            LoadGroups(true);
            _formRestriction = new provider_eligibility_restrictions();
            
            ctlStartDate.CurrentDate = DateTime.Today;
            ctlEndDate.SetDefaultDate(DateTime.Today);
        }

        public frmEditProviderEligibilityRestriction(provider_eligibility_restrictions per)
        {
            InitializeComponent();
            _formFromProviderClaim = new claim();
            _formToProviderClaim = new claim();
            _includedGroups = new BindingList<insurance_company_group>();
            lstGroupsIncluded.DataSource = _includedGroups;
            LoadProviders(false);
            LoadGroups(false);
            _formRestriction = per;
            _formProvider = per.provider_id;
            
            try
            {
                if (per.provider_id == "")
                {
                    cmbForProvider.SelectedIndex = 0;
                }
                else
                    LoadProvider(true, _formFromProviderClaim.FindFirstClaimWithProvider(per.provider_id));

                LoadProvider(false, _formToProviderClaim.FindFirstClaimWithProvider(per.switch_to_provider_id));
            }
            catch
            {
                // Don't worry about it, doesn't have any matching claims. Only happens when debugging
                MessageBox.Show("Couldn't find a valid claim for this provider.");
            }

            ctlStartDate.CurrentDate = per.start_date;
            ctlEndDate.CurrentDate = per.end_date;

            if (per.is_advanced)
            {
                // obsolete
            }
            else
            {
                foreach(insurance_company_group icg in per.Groups)
                {
                    _includedGroups.Add(icg);
                }

                RefreshCompaniesInGroup();
            }

            chkEnabled.Checked = per.is_enabled;
        }

        public frmEditProviderEligibilityRestriction(claim FromProvider, string ForInsuranceGroup)
        {
            InitializeComponent();
            _formFromProviderClaim = new claim();
            _formToProviderClaim = new claim();
            LoadProviders(false);
            LoadGroups(true);
            Text = ForInsuranceGroup + ": Edit Provider Eligibility";

            _formProvider = FromProvider.doctor_provider_id;
            LoadProvider(true, FromProvider);
            // pnlForInsurance.Visible = false;
            // Height -= pnlForInsurance.Height;
            ctlStartDate.CurrentDate = DateTime.Today;
            ctlEndDate.SetDefaultDate(DateTime.Today);
        }

        private void LoadProviders(bool selectFirstProvider)
        {
            claim searchObject = new claim();

            DataTable providers = searchObject.Search("SELECT DISTINCT(doctor_provider_id), doctor_first_name, doctor_last_name FROM claims " +
                "WHERE doctor_provider_id IS NOT Null ORDER BY doctor_first_name, doctor_last_name");

            cmbForProvider.Items.Add("All");

            foreach (DataRow aRow in providers.Rows)
            {
                
                searchObject = new claim();
                searchObject = searchObject.FindFirstClaimWithProvider(aRow["doctor_provider_id"].ToString());

                ProviderEligibilityDisplay ped = new ProviderEligibilityDisplay(aRow["doctor_provider_id"].ToString(),
                    string.Format("{0} {1} ({2})", aRow["doctor_first_name"].ToString(), aRow["doctor_last_name"].ToString(), aRow["doctor_provider_id"].ToString()),
                    searchObject);

                cmbForProvider.Items.Add(ped);
                cmbToProvider.Items.Add(ped);
            }

            if (selectFirstProvider)
            {
                cmbForProvider.SelectedIndex = 0;
                cmbToProvider.SelectedIndex = 0;
            }
        }

        private void LoadGroups(bool selectFirstGroup)
        {
            insurance_company_group icgs = new insurance_company_group();

            DataTable allGroups = icgs.Search(icgs.SearchSQL + " ORDER BY name");

            foreach (DataRow aRow in allGroups.Rows)
                cmbInsuranceGroups.Items.Add(new insurance_company_group(aRow));

            if (cmbInsuranceGroups.Items.Count > 0)
                if (selectFirstGroup)
                    cmbInsuranceGroups.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to exit this form without saving?", "Exit Without Saving?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string forProvider;

                if (_formFromProviderClaim == null)
                    forProvider = "";
                else
                    forProvider = _formFromProviderClaim.doctor_provider_id;

                string toProvider = _formToProviderClaim.doctor_provider_id;
                DateTime? startDate = ctlStartDate.CurrentDate;
                DateTime? endDate;
                if (ctlEndDate.CurrentDateText != "")
                    endDate = ctlEndDate.CurrentDate;
                else
                    endDate = null;


                _formRestriction.start_date = startDate;
                _formRestriction.end_date = endDate;


                _formRestriction.provider_id = forProvider;
                _formRestriction.switch_to_provider_id = toProvider;
                _formRestriction.insurance_id = 0;
                _formRestriction.insurance_group_id = 0;
                _formRestriction.is_advanced = false;
                _formRestriction.is_enabled = chkEnabled.Checked;
                _formRestriction.Save();
                provider_eligibility_restrictions.SetGroups(_formRestriction.id, _includedGroups.ToList());

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private bool ValidateForm()
        {
            string Errors = string.Empty;

            // Could verify that same provider isn't selected in both spots
            // Could verify that there isn't already a rule for this provider with this date range

            if (cmbForProvider.SelectedIndex < 0)
                Errors += "\nThere is no 'For' provider.";
            else if (cmbToProvider.SelectedIndex < 0)
                Errors += "\nThere is no 'Switch To' provider.";
            else if (ctlStartDate.CurrentDateText == "")
                Errors += "\nThere is no Start Date listed.";
            else if (lstGroupsIncluded.Items.Count == 0)
                Errors += "\nThere are no Insurance Groups selected.";


            if (Errors != string.Empty)
            {
                MessageBox.Show(this, Errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void ClearRestrictions(string provider_id)
        {
            if (_formRestriction != null)
            {
                provider_eligibility_restrictions workingPER = new provider_eligibility_restrictions();
                string sql = "DELETE FROM provider_eligibility_restrictions WHERE provider_id = '" +
                    provider_id + "'";

                sql += " AND switch_to_provider_id = '" + _formRestriction.switch_to_provider_id +
                    "' AND start_date = '" + CommonFunctions.ToMySQLDate(_formRestriction.start_date.Value) + "'";

                workingPER.ExecuteNonQuery(sql);
            }
        }

        
        private void LoadProvider(bool isForProvider, claim claim)
        {
            ComboBox cmbProvider;
            if (isForProvider)
                cmbProvider = cmbForProvider;
            else
                cmbProvider = cmbToProvider;

            foreach (var item in cmbProvider.Items)
            {
                if (item is ProviderEligibilityDisplay)
                {
                    ProviderEligibilityDisplay ped = (ProviderEligibilityDisplay)item;
                    if (ped.ProviderID == claim.doctor_provider_id)
                    {
                        cmbProvider.SelectedItem = ped;
                        break;
                    }
                }
            }
        }

        private void ReloadSummaryText()
        {
            string SummaryText = @"{\rtf1\ansi For \b [FROMPROVIDER]\b0  \b [ICG]\b0  claims\par
use \b [TOPROVIDER]\b0  from \b [STARTDATE]\b0  [ENDDATE].}";

            SummaryText = SummaryText.Replace("[TOPROVIDER]", _formToProviderClaim.DoctorName);
            
            if (_formFromProviderClaim == null)
                SummaryText = SummaryText.Replace("[FROMPROVIDER]", "All Providers");
            else
                SummaryText = SummaryText.Replace("[FROMPROVIDER]", _formFromProviderClaim.DoctorName);

            SummaryText = SummaryText.Replace("[STARTDATE]", ctlStartDate.CurrentDateText);

            if (ctlEndDate.CurrentDateText != "")
                SummaryText = SummaryText.Replace("[ENDDATE]", string.Format(@"until \b {0}\b0 ", ctlEndDate.CurrentDateText));
            else
                SummaryText = SummaryText.Replace("[ENDDATE]", "indefinitely");

            SummaryText = SummaryText.Replace("[ICG]", cmbInsuranceGroups.Text);

            rtbRestrictionSummary.Rtf = SummaryText;
        }

        private void frmEditProviderEligibilityRestriction_Load(object sender, EventArgs e)
        {
            
        }

        private void lstForProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbForProvider.SelectedIndex > 0)
            {
                _formFromProviderClaim = ((ProviderEligibilityDisplay)cmbForProvider.SelectedItem).LinkedClaim;
                ReloadSummaryText();
            }
            else
            {
                _formFromProviderClaim = null;
                ReloadSummaryText();
            }

            
        }

        private void lstSwitchToProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbToProvider.SelectedIndex >= 0)
            {
                _formToProviderClaim = ((ProviderEligibilityDisplay)cmbToProvider.SelectedItem).LinkedClaim;
                ReloadSummaryText();
            }
        }

        private void ctlStartDate_Leave(object sender, EventArgs e)
        {
            ReloadSummaryText();
        }

        private void cmbInsuranceGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInsuranceGroups.SelectedIndex >= 0)
            {
                btnAddGroup.Enabled = true;
            }
        }

        /// <summary>
        /// Displays a list of all matching companies for currently selected groups
        /// </summary>
        private void RefreshCompaniesInGroup()
        {
            try
            {
                lstCompaniesInGroup.Items.Clear();
                foreach (insurance_company_group icg in _includedGroups)
                {
                    DataTable matches =
                        _formToProviderClaim.Search(insurance_company_group.GenerateCompanySQL("name", icg.FiltersTextOnly, false));

                    foreach (DataRow aRow in matches.Rows)
                    {
                        lstCompaniesInGroup.Items.Add(aRow["name"].ToString());
                    }
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error retrieving matches for criteria in frmEditProviderEligibilityRestrictions", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred retrieving the matches for this criteria. The error returned was:\n\n" + err.Message);
            }
        }

        private void lnkEditGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditInsuranceGroup tempForm = new frmEditInsuranceGroup();

            if (tempForm.ShowDialog() == DialogResult.OK)
            {
                LoadGroups(false);
                cmbInsuranceGroups.SelectedIndex = cmbInsuranceGroups.FindStringExact(tempForm.FormGroup.name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            _includedGroups.Add((insurance_company_group)cmbInsuranceGroups.SelectedItem);
            RefreshCompaniesInGroup();
            ReloadSummaryText();
        }

        private void lstGroupsIncluded_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveSelectedGroup();
            }
        }

        private void RemoveSelectedGroup()
        {
            if (lstGroupsIncluded.SelectedIndex >= 0)
            {
                _includedGroups.RemoveAt(lstGroupsIncluded.SelectedIndex);
                RefreshCompaniesInGroup();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedGroup();
        }

    }

    class ProviderEligibilityDisplay
    {
        public string ProviderID { get; set; }
        public string DisplayData { get; set; }
        public claim LinkedClaim { get; set; }

        public ProviderEligibilityDisplay(string providerID, string displayData, claim linkClaim)
        {
            ProviderID = providerID;
            DisplayData = displayData;
            LinkedClaim = linkClaim;
        }

        public override string ToString()
        {
            return DisplayData;
        }
    }
    
}