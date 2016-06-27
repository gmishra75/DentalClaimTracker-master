using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class ctlMultiClaimCallClaimDisplay : UserControl
    {
        delegate void EmptyDelegate();
        public event EventHandler Minimized;
        public event EventHandler Maximized;
        public event EventHandler SaveChanges;
        public event EventHandler RequestViewClaim;
        public event EventHandler CallStarted;
        private claim _linkedClaim;
        bool _updatingRevisitDate = false;
        private int callDefaultHeight = 253;
        private call _currentCall;
        Timer callTimer;
        bool onHold = false;
        TimeSpan callTime;
        TimeSpan holdTime;

        public claim LinkedClaim
        {
            get { return _linkedClaim; }
            set { 
                _linkedClaim = value;
                ngDisplay.CurrentClaim = value;
            }
        }

        public call CurrentCall
        { 
            get { return _currentCall; }
            set 
            { 
                // Also need to set the Notes Grid
                _currentCall = value;
            }
        }

        public bool IsMinimized
        {
            get { return Height == lblTitle.Height; }
            set
            {
                if (value)
                    SetToMinimizeHeight();
                else
                    SetToMaximizeHeight();
            }
        }
        /// <summary>
        /// Do not use, left only for simplicity
        /// </summary>
        public ctlMultiClaimCallClaimDisplay()
        {
            InitializeComponent();
            InitializeStatusDropdown();

            callTimer = new Timer();
            callTimer.Interval = 1000;
            callTimer.Tick += new EventHandler(callTimer_Tick);
        }

        public ctlMultiClaimCallClaimDisplay(claim toShow)
        {
            InitializeComponent();
            InitializeStatusDropdown();
            LoadClaim(toShow);

            callTimer = new Timer();
            callTimer.Interval = 1000;
            callTimer.Tick += new EventHandler(callTimer_Tick);
        }

        /// <summary>
        /// Display the claim information 
        /// </summary>
        /// <param name="toShow"></param>
        public void LoadClaim(claim toShow, bool forceReload = false)
        {
            bool skipLoad = false;

            if (LinkedClaim != null && !forceReload)
            {
                if (LinkedClaim.id == toShow.id)
                    skipLoad = true;
            }

            if (!skipLoad)
            {
                LinkedClaim = toShow;
                ngDisplay.LoadNotes(toShow);

                string patientdob;

                if (toShow.patient_dob.HasValue)
                    patientdob = toShow.patient_dob.Value.ToShortDateString();
                else
                    patientdob = "Unknown DOB";

                lblTitle.Text = toShow.patient_last_name + ", " + toShow.patient_first_name
                    + "; " + patientdob + "; " +
                    toShow.patient_ssn;

                ctlSentDate.CurrentDate = toShow.sent_date;
                ctlResentDate.CurrentDate = toShow.resent_date;
                if (toShow.date_of_service.HasValue)
                    lblDateOfService.Text = toShow.date_of_service.Value.ToShortDateString();
                else
                    lblDateOfService.Text = "No DOS";
                txtChartNumber.Text = toShow.subscriber_number;
                txtInsuranceID.Text = toShow.subscriber_alternate_number;
                txtDoctorName.Text = toShow.DoctorName;
                txtNEA.Text = toShow.nea_number;

                string subscriberdobstring;

                if (toShow.subscriber_dob.HasValue)
                    subscriberdobstring = toShow.subscriber_dob.Value.ToShortDateString();
                else
                    subscriberdobstring = "Unknown DOB";

                txtSubsriberInfo.Text = toShow.SubscriberName + "; " + subscriberdobstring +
                    "; " + toShow.subscriber_ssn;

                foreach (claim_status aStatus in cmbStatus.Items)
                {
                    if (aStatus.id == toShow.status_id)
                    {
                        cmbStatus.SelectedItem = aStatus;
                        break;
                    }
                }


                ctlRevisitDate.CurrentDate = toShow.revisit_date;

                LoadProcedures(toShow);
                SetLastUserText();
            }
        }

        private void LoadProcedures(claim toLoad)
        {
            List<DisplayProcedure> procedureList = new List<DisplayProcedure>();

            foreach (procedure aProc in toLoad.LinkedProcedures)
            {
                procedureList.Add(new DisplayProcedure(aProc));
            }

            dgvProcedureData.DataSource = procedureList;

            int newHeight = dgvProcedureData.ColumnHeadersHeight;

            foreach (DataGridViewRow aRow in dgvProcedureData.Rows)
            {
                newHeight += aRow.Height;
            }

            dgvProcedureData.Height = newHeight + 2;

            dgvProcedureData.EnableHeadersVisualStyles = false;
            dgvProcedureData.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void InitializeStatusDropdown()
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

        private void SetLastUserText()
        {
            if (LinkedClaim.status_last_user_id > 0)
            {
                user u = new user(LinkedClaim.status_last_user_id);

                claim_status cs = LinkedClaim.LinkedStatus;
                string lastDate = LinkedClaim.status_last_date.Value.ToShortDateString();
                string nameDate = " " + u.username + ", " + lastDate + "";
                string lastText;

                if (cs == null)
                    lastText = "No status - " + nameDate;
                else
                    lastText = cs.name + " - " + nameDate;

                if (LinkedClaim.revisit_date.HasValue)
                {
                    lastText += "\nRevisit " +
                       LinkedClaim.revisit_date.Value.ToShortDateString() + " - " + nameDate;
                }

                lblLastStatus.Text = lastText;
            }
            else
            {
                lblLastStatus.Text = "No status/revisit";
            }
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

        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            Minimize();
        }

        private void cmdMaximize_Click(object sender, EventArgs e)
        {
            Maximize();
        }

        public void Maximize()
        {
            SetToMaximizeHeight();

            if (Maximized != null)
                Maximized(this, new EventArgs());

            StartCall();
        }

        /// <summary>
        /// Sets to the control to its default height without raising events
        /// </summary>
        public void SetToMaximizeHeight()
        {
            Height = callDefaultHeight;
        }

        public void Minimize()
        {
            SetToMinimizeHeight();
            cmdEndCall.PerformClick();
            if (Minimized != null)
                Minimized(this, new EventArgs());
        }

        /// <summary>
        /// Sets the control to its default Minimize height without raising events
        /// </summary>
        public void SetToMinimizeHeight()
        {
            this.Height = lblTitle.Height;
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            // Add row to call/claim table to show this claim was edited during current call
            if (CurrentCall == null)
            {
                // Get the current call ID
                SaveChanges(this, new EventArgs());
            }
            Save();
        }

        private void ngDisplay_NewNotes(object sender, EventArgs e)
        {
            if (CurrentCall == null)
            {
                SaveChanges(this, new EventArgs());
            }
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            AutoResize();
        }

        private void AutoResize()
        {
            if (Height == callDefaultHeight)
                Minimize();
            else
                Maximize();
        }

        internal void ClearStatus()
        {
            cmbStatus.SelectedIndex = -1;
            ctlRevisitDate.Clear();
        }

        public void Save()
        {
            CurrentCall.AddClaim(LinkedClaim);

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
                else if (LinkedClaim.status_id > 0)
                    newStatus = LinkedClaim.LinkedStatus;
                else
                    newStatus = null;

                LinkedClaim.SetStatusAndRevisitDate(newStatus, newRevisit);
            }

            ActiveUser.LogAction(ActiveUser.ActionTypes.ChangeClaimMultiClaim, LinkedClaim.id, "");
        }

        private void chkSetRevisitDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSetRevisitDate.Checked)
                if (ctlRevisitDate.CurrentDateText == "")
                {
                    _updatingRevisitDate = true;
                    ctlRevisitDate.CurrentDate = DateTime.Now.AddDays(System.Convert.ToDouble(nmbRevisitInterval.Value));
                    _updatingRevisitDate = false;
                }
        }

        private void lnkOpenClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (RequestViewClaim != null)
                RequestViewClaim(this, new EventArgs());
        }

        private void cmdFullCall_Click(object sender, EventArgs e)
        {
           
        }

        private void displayProcedureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ctlStatusHandler_AllChoicesMade(object sender, EventArgs e)
        {
            ShowNewCallControls(false, false);
            mainQuestionViewer.AddCategory(ctlStatusHandler.Category);

            if (ctlStatusHandler.Category.default_revisit_date > 0)
            {
                ctlRevisitDate.CurrentDate = DateTime.Now.AddDays(ctlStatusHandler.Category.default_revisit_date);
            }

            if (ctlStatusHandler.Category.linked_status > 0)
            {
                try
                {
                    cmbStatus.SelectedIndex = new claim_status(ctlStatusHandler.Category.linked_status).orderid;
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error in ctlMultiCallClaimDisplay", LogSeverity.Error, err, false);
#if DEBUG
                    MessageBox.Show("DEBUG: Error displaying status.\n" + err.Message);
#endif
                }
            }
        }

        /// <summary>
        /// Hides and shows the necessary panels when starting a new call, or reclassifying a call
        /// </summary>
        /// <param name="showNewCall"></param>
        /// <param name="showNewCallButton"></param>
        private void ShowNewCallControls(bool showClassification, bool showNewCallButton)
        {
            pnlCallInfo.Visible = !showNewCallButton;
            chkTalkedWithPerson.Visible = !showNewCallButton;

            if (showNewCallButton)
            {
                pnlNewCallTopPanel.Visible = false;
                mainQuestionViewer.Visible = false;
                ctlStatusHandler.Visible = false;
                
            }
            else
            {
                pnlNewCallTopPanel.Visible = !showClassification;
                mainQuestionViewer.Visible = !showClassification;

                ctlStatusHandler.Visible = showClassification;
            }
        }

        private void lnkReclassify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainQuestionViewer.HasCategory)
            {
                if (MessageBox.Show(this, "This will allow you to select a new set of questions for this call. Any questions already answered will be removed. Would you like to continue?",
                    "Reclassify Call?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
            }

            choice.ClearChoices(mainQuestionViewer.Choices);
            mainQuestionViewer.ClearAllCategories();
            ctlStatusHandler.Initialize(LinkedClaim.company_id);
            ShowNewCallControls(true, false);
        }

        private void cmdStartCall_Click(object sender, EventArgs e)
        {
            StartCall();
        }

        private void StartCall()
        {
            ShowNewCallControls(true, false);

            if (CurrentCall == null)
                InitializeNewCall();
        }

        private void InitializeNewCall()
        {
            CurrentCall = new call();
            CurrentCall.created_on = DateTime.Now;
            CurrentCall.claim_id = LinkedClaim.id;
            CurrentCall.OnHoldSeconds = 0;
            CurrentCall.operatordata = ActiveUser.UserObject.username;
            CurrentCall.updated_on = DateTime.Now;
            CurrentCall.StartTime = DateTime.Now;
            CurrentCall.parent_id = 0;
            CurrentCall.Save();
            ctlStatusHandler.Initialize(LinkedClaim.company_id);

            mainQuestionViewer.CurrentCall = CurrentCall;
            ngDisplay.CurrentCall = CurrentCall;
            ActiveUser.LogAction(ActiveUser.ActionTypes.StartCall, LinkedClaim.id, CurrentCall.id, LinkedClaim.PatientName);

            callTime = new TimeSpan();
            callTimer.Start();
            lblCallTime.Visible = true;
            ctlStatusHandler._category = null;

            ctlDataVerification.Initialize();

            if (CallStarted != null)
                CallStarted(this, new EventArgs());
        }

        void callTimer_Tick(object sender, EventArgs e)
        {
            callTime = callTime.Add(new TimeSpan(TimeSpan.TicksPerSecond));
            UpdateCallTimerLabel();

            if (onHold)
            {
                holdTime = holdTime.Add(new TimeSpan(TimeSpan.TicksPerSecond));
                UpdateHoldTimerLabel();
            }
        }

        private void UpdateCallTimerLabel()
        {
            if (lblCallTime.InvokeRequired)
                Invoke(new EmptyDelegate(UpdateCallTimerLabel));
            else
            {
                lblCallTime.Text = callTime.Hours.ToString("0") + ":" +
                    callTime.Minutes.ToString("00") + ":" + callTime.Seconds.ToString("00");
            }
        }

        private void UpdateHoldTimerLabel()
        {
            if (lblHoldTime.InvokeRequired)
                Invoke(new EmptyDelegate(UpdateHoldTimerLabel));
            else
            {
                lblHoldTime.Text = holdTime.Hours.ToString("0") + ":" +
                    holdTime.Minutes.ToString("00") + ":" + holdTime.Seconds.ToString("00");
            }
        }

        private void cmdEndCall_Click(object sender, EventArgs e)
        {
            TerminateCall();
        }

        public void TerminateCall()
        {
            if (CurrentCall != null)
            {
                ngDisplay.SaveNote();

                CurrentCall.OnHoldSeconds = System.Convert.ToInt32(holdTime.TotalSeconds);
                CurrentCall.DurationSeconds = System.Convert.ToInt32(callTime.TotalSeconds);
                CurrentCall.talked_to_human = chkTalkedWithPerson.Checked;
                if (ctlStatusHandler._category != null)
                    CurrentCall.call_status = ctlStatusHandler._category.id;
                CurrentCall.Save();

                /* Additional data tabs not currently on this form
                // Remove any additional info tabs that might still have information
                
                foreach (VerifyDataViewer vdv in additionalDataTabs)
                {
                    if (!tbcNewCallData.TabPages.Contains(vdv))
                    {
                        foreach (choice aChoice in vdv.DataViewer.Choices)
                        {
                            aChoice.Delete();
                        }
                    }
                }
                */


                ActiveUser.LogAction(ActiveUser.ActionTypes.EndCall, LinkedClaim.id, CurrentCall.id, "");
            }



            ShowNewCallControls(true, true);

            
            
            CurrentCall = null;
            
            
            ctlDataVerification.Initialize();
            mainQuestionViewer.ClearAllCategories();
            /* Additional data tabs not currently on this form
            additionalDataTabs.Clear();
            */
            callTimer.Stop();
            onHold = false;
            UpdateHoldTimerLabel();

            /* Additional data tabs not currently on this form
            foreach (TabPage aTab in tbcNewCallData.TabPages)
            {
                if (aTab is VerifyDataViewer)
                {
                    tbcNewCallData.TabPages.Remove(aTab);
                    aTab.Dispose();
                }
            }
            */

            Minimize();
            lblHoldTime.Text = "0:00:00";
            lblCallTime.Text = "0:00:00";
        }

        private void cmdStartHold_Click(object sender, EventArgs e)
        {
            if (onHold)
            {
                lblHoldTime.BackColor = System.Drawing.SystemColors.Control;
                cmdStartHold.Text = "On Hold";
            }
            else
            {
                lblHoldTime.BackColor = Color.Yellow;
                cmdStartHold.Text = "Off Hold";
            }
            onHold = !onHold;
        }

        private void spltContainterRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            lblTitle.Width = spltContainerLeft.SplitterDistance;
            pnlCallInfo.Width = spltContainterRight.SplitterDistance;
        }

        private void pnlCallInfo_DoubleClick(object sender, EventArgs e)
        {
            AutoResize();
        }

        private void txtNEA_Leave(object sender, EventArgs e)
        {
            _linkedClaim.nea_number = txtNEA.Text;
            _linkedClaim.Save();
        }
    }
}
