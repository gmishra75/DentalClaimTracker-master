using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmBadPaymentClaimViewer : Form
    {
        private bad_payment_claims _formClaim;

        public bad_payment_claims FormClaim
        {
            get { return _formClaim; }
        }

        public frmBadPaymentClaimViewer(bad_payment_claims toView, string ClaimDate, string PatientName, string insuranceName, string ExpectedAmount, string ReceivedAmount)
        {
            InitializeComponent();
            LoadClaim(toView, ClaimDate, PatientName, insuranceName, ExpectedAmount, ReceivedAmount);
        }

        private void LoadClaim(bad_payment_claims toView, string ClaimDate, string PatientName, string insuranceName, string ExpectedAmount, string ReceivedAmount)
        {
            _formClaim = toView;
            Text = ClaimDate + ": " + PatientName + " thru " + insuranceName;
            lblExpectedAmount.Text = "Amount Expected: " + ExpectedAmount;
            lblAmountReceived.Text = "Amount Received: " + ReceivedAmount;
            txtNotes.Text = toView.notes;
            chkIssueResolved.Checked = _formClaim.is_verified;

            if (_formClaim.verified_by != "")
            {
                lblVerifiedBy.Visible = true;
                lblVerifiedBy.Text = "Verified by: " + _formClaim.verified_by;
            }
        }

        public string Notes
        {
            get { return txtNotes.Text; }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _formClaim.notes = txtNotes.Text;

            if (chkIssueResolved.Checked)
            {
                if (!_formClaim.is_verified)
                    _formClaim.verified_by = ActiveUser.UserObject.username;
            }
            else
                _formClaim.verified_by = "";

            _formClaim.is_verified = chkIssueResolved.Checked;
            _formClaim.Save();
            Close();
        }
    }
}