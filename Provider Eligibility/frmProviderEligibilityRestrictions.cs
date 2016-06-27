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
    public partial class frmProviderEligibilityRestrictions : Form
    {
        ViewModes formViewMode = ViewModes.Current;
        public frmProviderEligibilityRestrictions()
        {
            InitializeComponent();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            frmEditProviderEligibilityRestriction toShow = new frmEditProviderEligibilityRestriction();
            try
            { toShow.ShowDialog(); }
            catch { }

            InitializeProviderList(cmbCurrentProvider.Text);
            LoadRules();
        }

        private void LoadRules()
        {
            provider_eligibility_restrictions workingPER = new provider_eligibility_restrictions();

            string sql = "SELECT * FROM provider_eligibility_restrictions";

            if (cmbCurrentProvider.SelectedIndex > 0)
                sql += string.Format(" WHERE provider_id = '{0}'", ((ProviderInfoDisplay)cmbCurrentProvider.SelectedItem).ProviderID);
            
            sql += " ORDER BY provider_id, start_date";

            DataTable allMatches = workingPER.Search(sql);

            pnlEnabled.Controls.Clear();
            pnlDisabled.Controls.Clear();
            
            foreach (DataRow aRow in allMatches.Rows)
            {
                workingPER = new provider_eligibility_restrictions();
                workingPER.Load(aRow);

                if (workingPER.insurance_group_id > 0)
                {
                    // Temporary safeguard since we are switching to multiple storage - take the value out and put it in the table
                    provider_eligibility_restrictions.AddGroup(workingPER.id, workingPER.insurance_group_id, true);
                    workingPER.insurance_group_id = 0;
                    workingPER.Save();
                }

                string fromProvider;

                if (workingPER.provider_id == "")
                    fromProvider = "ALL";
                else
                    fromProvider = workingPER.provider_id;

                try
                {
                    fromProvider = provider_eligibility_restrictions.FindClaimByProviderID(fromProvider).DoctorName + " (" + fromProvider + ")";
                }
                catch { }
                

                // Add rich text box with text summarytext
                Panel pnl = new Panel();
                pnl.Dock = DockStyle.Top;
                pnl.Height = 40;
                pnl.Padding = new Padding(0, 0, 0, 0);
                pnl.BackColor = BackColor;

                RichTextBox rtb = new RichTextBox();
                rtb.Dock = DockStyle.Fill;
                rtb.Font = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 10.0f);
                rtb.Rtf = GenerateRulesText(workingPER);
                rtb.ReadOnly = true;
                rtb.Tag = workingPER;

                Button btn = new Button();
                btn.Text = "Edit";
                btn.Click += Edit_Click;
                btn.Tag = rtb;
                btn.Font = new System.Drawing.Font(new FontFamily("Microsoft Sans Serif"), 10.0f);
                btn.Dock = DockStyle.Right;


                pnl.Controls.Add(rtb);
                pnl.Controls.Add(btn);

                if (!workingPER.is_enabled || (workingPER.end_date.HasValue && workingPER.end_date < DateTime.Today))
                    pnlDisabled.Controls.Add(pnl);
                else
                    pnlEnabled.Controls.Add(pnl);

                pnl.BringToFront();
            }

            lblCurrent.Text = string.Format("Active ({0})", pnlEnabled.Controls.Count);
            lblDisabled.Text = string.Format("Inactive ({0})", pnlDisabled.Controls.Count);
        }

        private string GenerateRulesText(provider_eligibility_restrictions workingPER)
        {
            string SummaryText = @"{\rtf1\ansi \b [FORPROVIDER]:  [ICG]\b0  [TIME] \par Use [TOPROVIDER] from [STARTDATE][ENDDATE]}";
            
            string end_date = "";
            if (workingPER.end_date.HasValue)
                end_date = workingPER.end_date.Value.ToShortDateString();

            string filterList;
            if (workingPER.is_advanced)
                filterList = "Custom (" + workingPER.GetCompanyCriteriaAsString() + ")";
            else
                filterList = string.Join(", ", workingPER.Groups.Select(x=>x.name));

            
            string toProvider = workingPER.switch_to_provider_id;
            
            try
            {
                toProvider = provider_eligibility_restrictions.FindClaimByProviderID(toProvider).DoctorName + " (" + toProvider + ")";
            }
            catch { }

            string forProvider = workingPER.provider_id;

            try
            {
                if (forProvider == "")
                    forProvider = "All Providers";
                else
                    forProvider = provider_eligibility_restrictions.FindClaimByProviderID(forProvider).DoctorName + " (" + forProvider + ")";
            }
            catch { } // No claims for this provider 

            SummaryText = SummaryText.Replace("[TOPROVIDER]", toProvider);
            SummaryText = SummaryText.Replace("[FORPROVIDER]", forProvider);
            SummaryText = SummaryText.Replace("[STARTDATE]", workingPER.start_date.Value.ToShortDateString());

            if (end_date != "")
                SummaryText = SummaryText.Replace("[ENDDATE]", "-" + end_date);
            else
                SummaryText = SummaryText.Replace("[ENDDATE]", " on");

            if (!workingPER.is_enabled)
                SummaryText = SummaryText.Replace("[TIME]", @"  \i (Disabled)\i0 ");
            else if (workingPER.start_date.GetValueOrDefault() > DateTime.Now)
                SummaryText = SummaryText.Replace("[TIME]", @"  \i (Future)\i0 ");
            else if (workingPER.end_date.HasValue)
                if (workingPER.end_date.Value < DateTime.Now)
                    SummaryText = SummaryText.Replace("[TIME]", @"  \i (Past)\i0 ");

            SummaryText = SummaryText.Replace("[TIME]", @"");

            SummaryText = SummaryText.Replace("[ICG]", filterList);

            return SummaryText;
        }

        private void frmProviderEligibilityRestrictions_Load(object sender, EventArgs e)
        {
            formViewMode = ViewModes.Current;
            InitializeProviderList("");
        }

        private void InitializeProviderList(string defaultValue)
        {
            cmbCurrentProvider.Items.Clear();

            string sql = "SELECT DISTINCT provider_id FROM provider_eligibility_restrictions";

            if (!chkShowXProviders.Checked)
                sql += " WHERE provider_id NOT LIKE 'X%' AND provider_id NOT LIKE '%X'";

            sql += " ORDER BY provider_id";

            DataTable provs = new claim().Search(sql);

            cmbCurrentProvider.Items.Add("All Restrictions");

            foreach (DataRow aRow in provs.Rows)
            {
                cmbCurrentProvider.Items.Add(new ProviderInfoDisplay(aRow[0].ToString().Trim()));
            }

            if (defaultValue != "")
            {
                cmbCurrentProvider.SelectedIndex = cmbCurrentProvider.FindStringExact(defaultValue);
            }
            else
            {
                if (cmbCurrentProvider.Items.Count > 1)
                    cmbCurrentProvider.SelectedIndex = 1;
                else
                    cmbCurrentProvider.SelectedIndex = 0;
            }
        }

        void Edit_Click(object sender, EventArgs e)
        {
            RichTextBox linkedrtb = (RichTextBox) ((Button)sender).Tag;
            provider_eligibility_restrictions per = (provider_eligibility_restrictions) linkedrtb.Tag;

            frmEditProviderEligibilityRestriction toShow = 
                new frmEditProviderEligibilityRestriction(per);
            toShow.ShowDialog(this);
            LoadRules();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {
            ToggleLabel(ViewModes.Current, true, lblCurrent, lblDisabled);
        }

        private void lblDisabled_Click(object sender, EventArgs e)
        {
            ToggleLabel(ViewModes.Disabled, false, lblDisabled, lblCurrent);
        }

        private void ToggleLabel(ViewModes viewMode, bool isEnabled, Label activeLabel, Label inactiveLabel)
        {
            formViewMode = viewMode;
            pnlEnabled.Visible = isEnabled;
            pnlDisabled.Visible = !isEnabled;
            activeLabel.BackColor = Color.SteelBlue;
            activeLabel.ForeColor = Color.White;
            activeLabel.BorderStyle = BorderStyle.Fixed3D;
            inactiveLabel.BackColor = Color.LightSteelBlue;
            inactiveLabel.ForeColor = Color.Black;
            inactiveLabel.BorderStyle = BorderStyle.FixedSingle;
        }


        private void Select(Label lblSelected)
        {
            List<Label> unselected = new List<Label>();
            Label selected = lblSelected;

            unselected.AddRange(new Label[] { lblCurrent, lblDisabled });
            unselected.Remove(lblSelected);

            selected.BackColor = Color.SteelBlue;
            selected.ForeColor = Color.White;
            selected.BorderStyle = BorderStyle.Fixed3D;

            foreach (Label aLabel in unselected)
            {
                aLabel.BackColor = Color.LightSteelBlue;
                aLabel.ForeColor = Color.Black;
                aLabel.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            frmEligibilityTests toShow = new frmEligibilityTests();
            toShow.Show();
        }

        private void cmbCurrentProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRules();
        }

        private void chkShowXProviders_CheckedChanged(object sender, EventArgs e)
        {
            InitializeProviderList(cmbCurrentProvider.Text);
        }

        
    }

    enum ViewModes
    {
        Current, Future, Expired, Disabled
    }

    class ProviderInfoDisplay
    {
        public string ProviderID { get; set; }
        public string ProviderFullDisplay { get; set; }

        public ProviderInfoDisplay(string providerID)
        {
            ProviderID = providerID;

            if (providerID == "")
                ProviderFullDisplay = "All Providers";
            else
            {
                try
                {
                    ProviderFullDisplay = provider_eligibility_restrictions.FindClaimByProviderID(providerID).DoctorName + " (" + providerID + ")";
                }
                catch {
                    ProviderFullDisplay = providerID;
                }
            }
        }

        public override string ToString()
        {
            return ProviderFullDisplay;
        }
    }
}