using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace C_DentalClaimTracker
{
    public partial class frmSettings : Form
    {
        bool _saved = false;
        bool _isDBOnly = false;
        string oldServerName;
        string oldDBName;
        string oldApex;
        bool oldAdvanced;
        string oldEclaimsSave;
        string oldApexConfigLocation;
        bool oldPaymentLine;
        string oldComputerName;

        public frmSettings()
        {
            InitializeComponent();
            StandardInitialization();
        }

        public frmSettings(bool dbOnly)
        {
            InitializeComponent();
            _isDBOnly = dbOnly;

            if (dbOnly)
            {
                oldServerName = Properties.Settings.Default.ServerNameSQL;
                oldDBName = Properties.Settings.Default.DatabaseName;
                txtApexConfigLocation.Enabled = false;
                txtEclaimsSaveFolder.Enabled = false;
                txtLocalName.Enabled = false;
                panel1.Enabled = false;
                groupBox1.Enabled = false;
                chkEclaimsShowSecondaryAmounts.Enabled = false;
                chkResendRevisit.Enabled = false;
                chkResendStatus.Enabled = false;
                chkUseAdvancedVideo.Enabled = false;
                nmbMaxClaimsInBatch.Enabled = false;
                chkStatusOnApex.Enabled = false;
                chkApexRevisitDate.Enabled = false;
                nmbApexRevisitDate.Enabled = false;
            }
            else
                StandardInitialization();
        }

        public void StandardInitialization()
        {

            InitializeStatusDropdown();
            InitializeOverrideState();
            oldServerName = Properties.Settings.Default.ServerNameSQL;
            oldDBName = Properties.Settings.Default.DatabaseName;
            oldApex = Properties.Settings.Default.ApexSiteURL;
            oldAdvanced = Properties.Settings.Default.UseAdvancedVideo;
            oldApexConfigLocation = Properties.Settings.Default.ApexEDIConfigLocation;
            oldPaymentLine = Properties.Settings.Default.ShowPaymentLineOnSecondary;
            oldComputerName = Properties.Settings.Default.LocalComputerName;

            try
            {
                oldEclaimsSave = system_options.ApexEDISaveFolder;
                txtEclaimsSaveFolder.Text = oldEclaimsSave;
                if (system_options.ResendStatus >= 0)
                {
                    int resendStatus = system_options.ResendStatus;
                    chkResendStatus.Checked = true;
                    foreach (claim_status cs in cmbResendStatus.Items)
                    {
                        if (cs.id == resendStatus)
                        {
                            cmbResendStatus.SelectedItem = cs;
                            break;
                        }
                    }
                }
                else
                {
                    chkResendStatus.Checked = false;
                    cmbResendStatus.SelectedIndex = -1;
                }

                if (system_options.ResendRevisit >= 0)
                {
                    chkResendRevisit.Checked = true;
                    nmbResendRevisit.Value = system_options.ResendRevisit;
                }
                else
                {
                    chkResendRevisit.Checked = false;
                    nmbResendRevisit.Value = 14;
                }

                if (system_options.ApexSendStatus > 0)
                {
                    chkStatusOnApex.Checked = true;
                    int status = system_options.ApexSendStatus;
                    
                    foreach (claim_status cs in cmbStatusOnApex.Items)
                    {
                        if (cs.id == status)
                        {
                            cmbStatusOnApex.SelectedItem = cs;
                            break;
                        }
                    }
                }
                else
                {
                    chkStatusOnApex.Checked = false;
                    cmbStatusOnApex.SelectedIndex = -1;
                }

                chkApexRevisitDate.Checked = system_options.ApexRevisitDateEnabled;
                nmbApexRevisitDate.Value = Convert.ToDecimal(system_options.ApexRevisitDate);
                
                if (system_options.ApexResendStatus > 0)
                {
                    chkStatusOnApexResend.Checked = true;
                    int status = system_options.ApexResendStatus;

                    foreach (claim_status cs in cmbStatusOnApexResend.Items)
                    {
                        if (cs.id == status)
                        {
                            cmbStatusOnApexResend.SelectedItem = cs;
                            break;
                        }
                    }
                }
                else
                {
                    chkStatusOnApexResend.Checked = false;
                    cmbStatusOnApexResend.SelectedIndex = -1;
                }

                chkLimitPredetermOnSearch.Checked = system_options.LimitPredetermsOnSearch;
                dtpPredetermLimitDate.Value = system_options.PredetermSearchDateMinimum;

                // Quick Notes
                txtQNB1.Text = system_options.GetQuickNote(1, false);
                txtQNF1.Text = system_options.GetQuickNote(1, true);
                txtQNB2.Text = system_options.GetQuickNote(2, false);
                txtQNF2.Text = system_options.GetQuickNote(2, true);
                txtQNB3.Text = system_options.GetQuickNote(3, false);
                txtQNF3.Text = system_options.GetQuickNote(3, true);
                txtQNB4.Text = system_options.GetQuickNote(4, false);
                txtQNF4.Text = system_options.GetQuickNote(4, true);

                cmbOverrideStateProviderID.Text = system_options.OverrideStateProviderID;
                cmbOverrideStateNewProviderID.Text = system_options.OverrideStateNewProviderID;
                txtOverrideStateState.Text = system_options.OverrideStateState;

                chkOverrideProviderByState.Checked = system_options.OverrideStateEnabled;
                try
                {
                    if (system_options.OverrideStateInsurance == -1) // No selection
                        cmbOverrideStateInsurance.SelectedIndex = -1;
                    else if (system_options.OverrideStateInsurance == 0) // All
                        cmbOverrideStateInsurance.SelectedIndex = 0;
                    else
                    {
                        foreach(insurance_company_group aGroup in cmbOverrideStateInsurance.Items)
                        {
                            if (aGroup.id == system_options.OverrideStateInsurance)
                            {
                                cmbOverrideStateInsurance.SelectedItem = aGroup;
                                break;
                            }
                        }
                    }
                }
                catch { system_options.OverrideStateInsurance = -1; }

            }



            catch { }

            try
            {
                lblLocalComputerName.Text = "Local Computer Name (" + Environment.MachineName + ")";
            }
            catch { }

            chkEclaimsShowSecondaryAmounts.Checked = system_options.EclaimsSecondaryShowExtraInfo;
            
            try { nmbMaxClaimsInBatch.Value = system_options.MaxClaimsInBatch; }
            catch { nmbMaxClaimsInBatch.Value = 100; }

        }

        private void InitializeOverrideState()
        {
            // 2 provider boxes and insurance groups box

            claim searchObject = new claim();

            cmbOverrideStateProviderID.Items.Clear();
            cmbOverrideStateProviderID.Items.Add("All");
            cmbOverrideStateNewProviderID.Items.Clear();

            claim.OverrideProviderList().ForEach(p =>
            {
                cmbOverrideStateProviderID.Items.Add(p.doctor_provider_id);
                cmbOverrideStateNewProviderID.Items.Add(p.doctor_provider_id);
                
            });

            insurance_company_group icgs = new insurance_company_group();

            DataTable allGroups = icgs.Search(icgs.SearchSQL + " ORDER BY name");

            foreach (DataRow aRow in allGroups.Rows)
                cmbOverrideStateInsurance.Items.Add(new insurance_company_group(aRow));

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            _saved = false;
            Close();
        }

        private void Revert()
        {
            if (!_isDBOnly)
            {
                txtServerName.Text = oldServerName;
                txtDatabaseName.Text = oldDBName;
                chkUseAdvancedVideo.Checked = oldAdvanced;
                txtEclaimsSaveFolder.Text = oldEclaimsSave;
                txtApexConfigLocation.Text = oldApexConfigLocation;
                txtLocalName.Text = oldComputerName;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (_isDBOnly)
            {
                try
                {

                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error saving application settings.", LogSeverity.Error, err);
                    MessageBox.Show(this, "An error occurred saving application settings.\n\n" + err.Message, "Unknown error.");
                }
            }
            else
            {
                try
                {

                    system_options.ApexEDISaveFolder = txtEclaimsSaveFolder.Text;
                    if (chkResendRevisit.Checked)
                        system_options.ResendRevisit = Convert.ToInt32(nmbResendRevisit.Value);
                    else
                        system_options.ResendRevisit = -1;

                    if (chkResendStatus.Checked)
                        if (cmbResendStatus.SelectedIndex >= 0)
                            system_options.ResendStatus = ((claim_status)cmbResendStatus.SelectedItem).id;
                        else
                            system_options.ResendStatus = -1;
                    else
                        system_options.ResendStatus = -1;

                    if (chkStatusOnApex.Checked)
                        if (cmbStatusOnApex.SelectedIndex >= 0)
                            system_options.ApexSendStatus = ((claim_status)cmbStatusOnApex.SelectedItem).id;
                        else
                            system_options.ApexSendStatus = -1;
                    else
                        system_options.ApexSendStatus = -1;

                    if (chkStatusOnApexResend.Checked)
                        if (cmbStatusOnApexResend.SelectedIndex >= 0)
                            system_options.ApexResendStatus = ((claim_status)cmbStatusOnApexResend.SelectedItem).id;
                        else
                            system_options.ApexResendStatus = -1;
                    else
                        system_options.ApexResendStatus = -1;

                    system_options.ApexRevisitDateEnabled = chkApexRevisitDate.Checked;
                    system_options.ApexRevisitDate = Convert.ToInt32(nmbApexRevisitDate.Value);

                    system_options.EclaimsSecondaryShowExtraInfo = chkEclaimsShowSecondaryAmounts.Checked;
                    system_options.MaxClaimsInBatch = Convert.ToInt32(nmbMaxClaimsInBatch.Value);
                    system_options.LimitPredetermsOnSearch = chkLimitPredetermOnSearch.Checked;
                    system_options.PredetermSearchDateMinimum = dtpPredetermLimitDate.Value;

                    // Quick Notes
                    system_options.SaveQuickNote(1, txtQNB1.Text, txtQNF1.Text);
                    system_options.SaveQuickNote(2, txtQNB2.Text, txtQNF2.Text);
                    system_options.SaveQuickNote(3, txtQNB3.Text, txtQNF3.Text);
                    system_options.SaveQuickNote(4, txtQNB4.Text, txtQNF4.Text);

                    
                    system_options.OverrideStateNewProviderID = cmbOverrideStateNewProviderID.Text;
                    system_options.OverrideStateState = txtOverrideStateState.Text;

                    if (cmbOverrideStateInsurance.SelectedIndex >= 0)
                        system_options.OverrideStateInsurance = ((insurance_company_group)cmbOverrideStateInsurance.SelectedItem).id;
                    else
                        system_options.OverrideStateInsurance = 0;

                    system_options.OverrideStateEnabled = chkOverrideProviderByState.Checked;

                    if (cmbOverrideStateProviderID.SelectedIndex < 0 || cmbOverrideStateProviderID.SelectedIndex == 0) // No selection
                        system_options.OverrideStateProviderID = "";
                    else
                        system_options.OverrideStateProviderID = cmbOverrideStateProviderID.Text;    






                }
                catch { }


                C_DentalClaimTracker.Properties.Settings.Default.Save(); // Completely superfluous
                _saved = true;

                if (txtServerName.Text != oldServerName || txtDatabaseName.Text != oldDBName)
                {
                    MessageBox.Show(this, "Changes to the server name require an application restart. Exiting application...",
                        "Restart required.");
                    Application.Exit();
                }
                Close();
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_saved)
                Revert();
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            try
            {
                user u = new user();

                MessageBox.Show(this, "Connected successfully to " + txtServerName.Text + ".", "Connection successful", 
                    MessageBoxButtons.OK);
            }
            catch(Exception err)
            {
                string errorMessage = err.Message;

                while (err.InnerException != null)
                {
                    errorMessage += "\n" + err.InnerException.Message;
                    err = err.InnerException;
                }
                if (MessageBox.Show(this, "Could not connect to the SQL Server at " + txtServerName.Text + 
                    ". \n\nSystem error message:\n " + errorMessage, "Connection failed",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    cmdTest.PerformClick();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeStatusDropdown()
        {
            claim_status cs = new claim_status();
            DataTable allcs = cs.GetAllData("orderid");

            foreach (DataRow aRow in allcs.Rows)
            {
                cs = new claim_status();
                cs.Load(aRow);

                cmbResendStatus.Items.Add(cs);
                cmbStatusOnApex.Items.Add(cs);
                cmbStatusOnApexResend.Items.Add(cs);
            }
        }

        private void chkResendStatus_CheckedChanged(object sender, EventArgs e)
        {
            cmbResendStatus.Enabled = chkResendStatus.Checked;
        }

        private void chkResendRevisit_CheckedChanged(object sender, EventArgs e)
        {
            nmbResendRevisit.Enabled = chkResendRevisit.Checked;
        }

        private void chkStatusOnApex_CheckedChanged(object sender, EventArgs e)
        {
            cmbStatusOnApex.Enabled = chkStatusOnApex.Checked;
        }

        private void chkStatusOnApexResend_CheckedChanged(object sender, EventArgs e)
        {
            cmbStatusOnApexResend.Enabled = chkStatusOnApexResend.Checked;  
        }

        private void lnkOpenConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(this, "Changes to the server name require an application restart.");
            
            CommonFunctions.OpenDirectory(
                System.IO.Path.GetDirectoryName(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath));


        }

        private void chkApexRevisitDate_CheckedChanged(object sender, EventArgs e)
        {
            nmbApexRevisitDate.Enabled = chkApexRevisitDate.Checked;
        }
    }
}