using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmViewActionLog : Form
    {
        private bool _loading = false;
        public frmViewActionLog()
        {
            InitializeComponent();
        }

        private void frmViewActionLog_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            _loading = true;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            InitializeUserDropdown();
            _loading = false;
            Search();
        }

        private void InitializeUserDropdown()
        {
            cmbUsers.Items.Clear();
            if (ActiveUser.UserObject.is_admin)
            {
                cmbUsers.Items.Add("All Users");

                foreach (user aUser in ActiveUser.UserObject.GetAllUsers)
                {
                    cmbUsers.Items.Add(aUser);
                }
            }
            else
            {
                cmbUsers.Items.Add(ActiveUser.UserObject);
            }
            cmbUsers.SelectedIndex = 0;
        }


        /// <summary>
        /// Doesn't work if the form is in loading mode
        /// </summary>
        private void Search()
        {
            if (_loading == false)
            {
                string SQL = "SELECT * FROM user_action_log WHERE ";
                user_action_log ual = new user_action_log();


                if (cmbUsers.SelectedIndex > 0)
                    SQL += "user_id = " + ((user)cmbUsers.SelectedItem).id;
                else
                    SQL += "1 = 1";

                if (chkSearchDateRange.Checked)
                {
                    SQL += " AND action_taken_time > '" + CommonFunctions.ToMySQLDate(dtpStartDate.Value) +
                        "' AND action_taken_time < '" + CommonFunctions.ToMySQLDate(dtpEndDate.Value.AddDays(1)) + "'";
                }

                if (!chkShowLogins.Checked)
                {
                    SQL += " AND action_id NOT IN(" + (int)ActiveUser.ActionTypes.Login + "," +
                        (int)ActiveUser.ActionTypes.Logout + ")";
                }

                SQL += " ORDER BY order_id desc";
                DataTable matches = ual.Search(SQL);
                dgvMain.Rows.Clear();
                foreach (DataRow anAction in matches.Rows)
                {
                    ual = new user_action_log();
                    ual.Load(anAction);

                    object[] toAdd;

                    if (((ActiveUser.ActionTypes)ual.action_id == ActiveUser.ActionTypes.ViewClaim) 
                        || ((ActiveUser.ActionTypes)ual.action_id == ActiveUser.ActionTypes.ResendClaim)
                        || ((ActiveUser.ActionTypes)ual.action_id == ActiveUser.ActionTypes.SubmitClaim)
                        || ((ActiveUser.ActionTypes)ual.action_id == ActiveUser.ActionTypes.ReviewClaim))
                    {
                        toAdd = new object[] { ual.LinkedUser.username, ual.action_taken_time.ToString("MM-dd-yy HH:mm"), ((ActiveUser.ActionTypes) ual.action_id).ToString(),
                        ual.additional_notes, "Claim"};
                    }
                    else if ((ActiveUser.ActionTypes)ual.action_id == ActiveUser.ActionTypes.StartCall)
                    {
                        toAdd = new object[] { ual.LinkedUser.username, ual.action_taken_time.ToString("MM-dd-yy HH:mm"), ((ActiveUser.ActionTypes) ual.action_id).ToString(),
                        ual.additional_notes, "Call"};
                    }
                    else
                    {
                        toAdd = new object[] { ual.LinkedUser.username, ual.action_taken_time.ToString("MM-dd-yy HH:mm"), ((ActiveUser.ActionTypes) ual.action_id).ToString(),
                        ual.additional_notes, "" };
                    }

                    dgvMain.Rows.Add(toAdd);
                    dgvMain.Rows[dgvMain.Rows.Count - 1].Tag = ual;
                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colClaim.Index)
            {
                if (e.RowIndex >= 0)
                {
                    user_action_log ual = (user_action_log)dgvMain.Rows[e.RowIndex].Tag;
                    if (CommonFunctions.DBNullToZero(ual["call_id"]) > 0)
                    {
                        call toShow = new call(ual.call_id);
                        pnlShowCall.Visible = true;
                        ctlCallDisplay.DisplayCall(toShow);
                        lblCallInfo.Text = toShow.operatordata + " " + toShow.created_on;
                        pnlShowCall.Visible = true;
                    }
                    else if (CommonFunctions.DBNullToZero(ual["claim_id"]) > 0)
                    {
                        try
                        {
                            frmClaimManager toShow = new frmClaimManager(new claim(ual.claim_id));
                            toShow.Show();
                        }
                        catch {
                            MessageBox.Show(this, "An error occurred showing the selected claim.");
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkSearchDateRange_CheckedChanged(object sender, EventArgs e)
        {
            grpDateRange.Enabled = chkSearchDateRange.Checked;
            Search();
        }

        private void chkShowLogins_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmdHideShowCall_Click(object sender, EventArgs e)
        {
            pnlShowCall.Visible = false;
        }
    }
}