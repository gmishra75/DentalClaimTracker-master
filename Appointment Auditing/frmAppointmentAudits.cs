using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Appointment_Auditing
{
    public partial class frmAppointmentAudits : Form
    {
        public frmAppointmentAudits()
        {
            InitializeComponent();
        }

        private void frmAppointmentAudits_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            InitializeUserList();

            cmbDuration.SelectedIndex = 0;
            // changed, user, patient, appointment date, action, appt id
            
        }

        private void InitializeUserList()
        {
            appointment_audit utility = new appointment_audit();

            cmbUserList.Items.Clear();
            cmbUserList.Items.Add("All");

            foreach (string u in utility.UserList)
                cmbUserList.Items.Add(u);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmImportAppointmentAudit frmImport = new frmImportAppointmentAudit();

            frmImport.ShowDialog(this);
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            appointment_audit util = new appointment_audit();

            string sql = "SELECT * FROM appointment_audit WHERE  CAST(FLOOR(CAST(date_changed AS float)) AS DATETIME) >= '" + dtpStartDate.Value.ToShortDateString() +
                "' AND  CAST(FLOOR(CAST(date_changed AS float)) AS DATETIME) < '" + dtpStartDate.Value.AddDays((cmbDuration.SelectedIndex + 1)).ToShortDateString() + "'";

            if (cmbUserList.SelectedIndex > 0)
            {
                sql += " AND USER_CHANGED = '" + cmbUserList.Text + "'";
                
            }

            DataTable results = util.Search(sql);

            dgvAppointments.Rows.Clear();
            foreach (DataRow aMatch in results.Rows)
            {
                util.Load(aMatch);

                string apptDate;

                

                if (util.change_type == appointment_audit.ChangeTypes.Created || util.change_type == appointment_audit.ChangeTypes.CreatedBroken)
                {
                    if (util["n_APPTDATE"] == DBNull.Value)
                        apptDate = "";
                    else
                        apptDate = util.n_APPTDATE.ToShortDateString();

                    dgvAppointments.Rows.Add(util.DATE_CHANGED.ToString("M/d h:mm:ss"), util.USER_CHANGED.Trim(), util.n_PATNAME,
                        apptDate, util.change_type.ToString(), util.n_APPTID, FormatChangeList(util.ChangeList));
                }
                else
                {
                    if (util["APPTDATE"] == DBNull.Value)
                        apptDate = "";
                    else
                        apptDate = util.APPTDATE.ToShortDateString();

                    dgvAppointments.Rows.Add(util.DATE_CHANGED.ToString("M/d h:mm:ss"), util.USER_CHANGED.Trim(), util.PATNAME,
                        apptDate, util.change_type.ToString(), util.APPTID, FormatChangeList(util.ChangeList));
                }
            }

            lblChangedAppointments.Text = string.Format("Changed Appointments ({0})", dgvAppointments.Rows.Count);
        }

        private object FormatChangeList(List<Appointment_Audit_Change> list)
        {
            string allChanges = "";
            foreach (Appointment_Audit_Change aChange in list)
            {
                if (allChanges != "")
                    allChanges += "\n";
                allChanges += aChange.ToString();
            }

            return allChanges;
        }
    }
}
