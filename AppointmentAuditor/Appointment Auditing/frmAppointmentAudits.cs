using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
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
            int deletedRows = 0;
            int brokenRows = 0;
            int createdRows = 0;
            int timeChange = 0;
            int statusChange = 0;
            int otherChange = 0;
            List<int> total = new List<int>() { 0, 0, 0};
            List<int> newPatient = new List<int>() { 0, 0, 0};
            List<int> totalDaysBetween = new List<int>() { 0, 0, 0};
            List<int> totalApptsCreated = new List<int>() { 0, 0, 0};
            const int DentalIndex = 0;
            const int HygieneIndex = 1;
            const int OtherIndex = 2;
            int currentTypeIndex = 0;
            


            List<List<string>> patientIDs = new List<List<string>>();

            #region Individual Stats
            string sql = "SELECT * FROM appointment_audit WHERE  CAST(FLOOR(CAST(date_changed AS float)) AS DATETIME) >= '" + dtpStartDate.Value.ToShortDateString() +
                "' AND  CAST(FLOOR(CAST(date_changed AS float)) AS DATETIME) < '" + dtpStartDate.Value.AddDays((cmbDuration.SelectedIndex + 1)).ToShortDateString() + "'";

            if (cmbUserList.SelectedIndex > 0)
            {
                sql += " AND USER_CHANGED = '" + cmbUserList.Text + "'";
                
            }

            DataTable results = util.Search(sql);

            dgvAppointments.Rows.Clear();
            string lastPatient = "";
            DateTime lastChangeDate = DateTime.Now;


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
                    bool isGrouped = false;

                    if (chkGroupSimilar.Checked)
                    {
                        if (util.PATNAME == lastPatient && util.DATE_CHANGED == lastChangeDate)
                        {
                            if (dgvAppointments.Rows.Count > 0)
                            {
                                dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells[colApptDate.DisplayIndex].Value = "Multiple";
                                dgvAppointments.Rows[dgvAppointments.Rows.Count - 1].Cells[colApptID.DisplayIndex].Value = "Multiple";
                                isGrouped = true;
                            }
                        }
                        else
                        {
                            lastPatient = util.PATNAME;
                            lastChangeDate = util.DATE_CHANGED;
                        }
                    }

                    if (!isGrouped)
                    {
                        if (util["APPTDATE"] == DBNull.Value)
                            apptDate = "";
                        else
                            apptDate = util.APPTDATE.ToShortDateString();

                        dgvAppointments.Rows.Add(util.DATE_CHANGED.ToString("M/d h:mm:ss"), util.USER_CHANGED.Trim(), util.PATNAME,
                            apptDate, util.change_type.ToString(), util.APPTID, FormatChangeList(util.ChangeList));
                    }
                }


                #region General Stats

                switch (util.change_type)
                {
                    case appointment_audit.ChangeTypes.Created:
                        createdRows++;
                        break;
                    case appointment_audit.ChangeTypes.CreatedBroken:
                        createdRows++;
                        brokenRows++;
                        break;
                    case appointment_audit.ChangeTypes.Broken:
                        brokenRows++;
                        break;
                    case appointment_audit.ChangeTypes.Deleted:
                        deletedRows++;
                        break;
                    case appointment_audit.ChangeTypes.Status:
                        statusChange++;
                        break;

                    case appointment_audit.ChangeTypes.Time_Operatory:
                        timeChange++;
                        break;
                    case appointment_audit.ChangeTypes.Other:
                        otherChange++;
                        break;
                    case appointment_audit.ChangeTypes.Unbroken:
                        otherChange++;
                        break;
                }

                List<string> thisPatient = new List<string>() { util.PATID.ToString(), util.PATDB.ToString() };
                bool found = false;
                foreach (List<string> aPatient in patientIDs)
                {
                    if (aPatient[0] == thisPatient[0] && aPatient[1] == thisPatient[1])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    patientIDs.Add(thisPatient);

                #endregion

                #region Dental / Hygiene stats


                if (util.ProviderIDString.StartsWith("D"))
                    currentTypeIndex = DentalIndex;
                else if (util.ProviderIDString.StartsWith("H"))
                    currentTypeIndex = HygieneIndex;
                else
                    currentTypeIndex = OtherIndex;

                total[currentTypeIndex]++;
                    
                if (util.change_type == appointment_audit.ChangeTypes.Created)
                {
                    // Check for changes to average creation date -> schedule date                        
                    if (util.n_APPTDATE > new DateTime(1900, 1, 1))
                    {
                        totalApptsCreated[currentTypeIndex]++;
                        totalDaysBetween[currentTypeIndex] += Convert.ToInt32((util.n_APPTDATE - util.n_CREATEDATE).TotalDays);
                    }
                    else if (util.APPTDATE > new DateTime(1990, 1, 1))
                    {
                        totalApptsCreated[currentTypeIndex]++;
                        totalDaysBetween[currentTypeIndex] += Convert.ToInt32((util.APPTDATE - util.CREATEDATE).TotalDays);
                    }
                    
                    // Check to see if it's for a new patient
                    if (util.IsNewPatient)
                        newPatient[currentTypeIndex]++;

                }

                #endregion


            }

            lblChangedAppointments.Text = string.Format("Changed Appointments ({0})", dgvAppointments.Rows.Count);
            #endregion

            lblBroken.Text = brokenRows.ToString();
            lblCreated.Text = createdRows.ToString();
            lblDeleted.Text = deletedRows.ToString();
            lblStatus.Text = statusChange.ToString();
            lblTime.Text = timeChange.ToString();
            lblTotalPatients.Text = patientIDs.Count.ToString();
            lblOther.Text = otherChange.ToString();
            lblTotalChanges.Text = results.Rows.Count.ToString();

            lblDentalTotal.Text = total[DentalIndex].ToString();
            if (totalDaysBetween[DentalIndex] > 0)
                lblDentalAverageDays.Text = ((double)totalDaysBetween[DentalIndex] / (double)totalApptsCreated[DentalIndex]).ToString("0.0");
            else
                lblDentalAverageDays.Text = "N/A";
            lblDentalNewPatients.Text = newPatient[DentalIndex].ToString();

            lblHygieneTotal.Text = total[HygieneIndex].ToString();
            if (totalDaysBetween[HygieneIndex] > 0)
                lblHygieneAverageDays.Text = ((double)totalDaysBetween[HygieneIndex] / (double)totalApptsCreated[HygieneIndex]).ToString("0.0");
            else
                lblHygieneAverageDays.Text = "N/A";
            lblHygieneNewPatients.Text = newPatient[HygieneIndex].ToString();

            lblOtherTotal.Text = total[OtherIndex].ToString();
            if (totalDaysBetween[OtherIndex] > 0)
                lblOtherAverageDays.Text = ((double)totalDaysBetween[OtherIndex] / (double)totalApptsCreated[OtherIndex]).ToString("0.0");
            else
                lblOtherAverageDays.Text = "N/A";
            lblOtherNewPatients.Text = newPatient[OtherIndex].ToString();

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

        public object List { get; set; }

        
    }
}
