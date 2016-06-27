using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmClaimStatus : Form
    {
        bool _updatingRevisitDate = false;
        claim _formClaim;
        private bool _asIs = false;

        public bool AsIs
        {
            get { return _asIs; }
            set { _asIs = value; }
        }



        public frmClaimStatus(claim workingClaim, string Status, bool revisitChecked, DateTime? revisitDate)
        {
            InitializeComponent();
            InitializeStatusDropdown();

            _formClaim = workingClaim;
            cmbStatus.SelectedIndex = cmbStatus.FindStringExact(Status);
            chkSetRevisitDate.Checked = revisitChecked;
            ctlRevisitDate.CurrentDate = revisitDate;
            SetLastUserText();
        }

        private void SetLastUserText()
        {
            if (_formClaim.status_last_user_id > 0)
            {
                user u = new user(_formClaim.status_last_user_id);

                claim_status cs = _formClaim.LinkedStatus;
                string lastDate = _formClaim.status_last_date.Value.ToShortDateString();
                string nameDate = " (" + u.username + ", " + lastDate + ")";


                if (cs == null)
                    lblLastStatus.Text = "Last status left empty." + nameDate;
                else
                    lblLastStatus.Text = "Last status set to " + cs.name + ". " + nameDate;

                if (_formClaim.revisit_date.HasValue)
                    lblLasRevisitDate.Text = "Last revisit date set to " +
                       _formClaim.revisit_date.Value.ToShortDateString() + ". " + nameDate;
                else
                    lblLasRevisitDate.Text = "Last revisit date not set. " + nameDate;

            }
            else
            {
                lblLastStatus.Text = "No previous status set.";
                lblLasRevisitDate.Text = "No previous revisit date set.";
            }
        }

        private void InitializeStatusDropdown()
        {
            claim_status cs = new claim_status();
            DataTable allcs = cs.GetVisibleStatus();
                

            foreach (DataRow aRow in allcs.Rows)
            {
                cs = new claim_status();
                cs.Load(aRow);

                cmbStatus.Items.Add(cs);
            }
        }

        private void cmdAsIs_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CreateStatusHistory(true);
            AsIs = true;
            Close();
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        public void Save()
        {
            DateTime? oldRevisitDate = _formClaim.revisit_date;
            int oldID = _formClaim.status_id;

            if ((chkSetRevisitDate.Checked) || (cmbStatus.SelectedIndex > -1))
            {
                DateTime? newRevisit = null;
                claim_status newStatus;

                if (chkSetRevisitDate.Checked)
                    newRevisit = ctlRevisitDate.CurrentDate;
                else
                    newRevisit = null;

                if (cmbStatus.SelectedIndex > -1)
                    newStatus = (claim_status)cmbStatus.SelectedItem;
                else
                    newStatus = null;

                _formClaim.SetStatusAndRevisitDate(newStatus, newRevisit);
            }

            DialogResult = DialogResult.OK;
        }

        private void CreateStatusHistory(bool as_is_flag)
        {
            try
            {
                claim_status currentStatus;
                if (cmbStatus.SelectedIndex >= 0)
                    currentStatus = (claim_status)cmbStatus.SelectedItem;
                else
                    currentStatus = null;

                if (chkSetRevisitDate.Checked)
                    _formClaim.CreateStatusHistory(currentStatus, ctlRevisitDate.DateValue, as_is_flag); 
                else
                    _formClaim.CreateStatusHistory(currentStatus, _formClaim.revisit_date, as_is_flag);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in frmClaimStatus.CreateStatusHistory\n" + err.Message, LogSeverity.Error);
                MessageBox.Show(this, "An error occurred creating the status history for this change. Your save should continue as " +
                    "normal, but please notify a system administrator of this error:\n\n" + err.Message, "Error saving note",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctlRevisitDate_ValueChanged(object sender, EventArgs e)
        {
            if (!_updatingRevisitDate)
            {
                DateTime? newDate = ctlRevisitDate.CurrentDate;

                if (newDate.HasValue)
                {
                    TimeSpan difference = newDate.Value.Date - DateTime.Now.Date;
                    if (Convert.ToInt32(nmbRevisitInterval.Value) != difference.Days)
                    {
                        try
                        {
                            if (difference.Days >= 0)
                                nmbRevisitInterval.Value = Convert.ToDecimal(difference.Days);
                            else
                            {
                                if (nmbRevisitInterval.Value != 14)
                                    nmbRevisitInterval.Value = 14;
                                else
                                    nmbRevisitInterval_ValueChanged(null, null);
                            }

                        }
                        catch { } // Ignore, invalid entry
                    }
                }
            }
        }

        private void nmbRevisitInterval_ValueChanged(object sender, EventArgs e)
        {
            _updatingRevisitDate = true;
            ctlRevisitDate.CurrentDate = DateTime.Now.AddDays(System.Convert.ToDouble(nmbRevisitInterval.Value));
            _updatingRevisitDate = false;
        }

        private void frmClaimStatus_Load(object sender, EventArgs e)
        {

        }

    }
}