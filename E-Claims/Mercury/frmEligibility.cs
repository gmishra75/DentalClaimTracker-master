using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    public partial class frmEligibility : Form
    {
        private enum FormSearchMode
        {
            Unsent, Tomorrow, AllUpcoming, Rejected, Sent
        }

        public enum Eligibility_Status
        {
            Unsent = -1,
            Rejected = 0,
            Verified = 1,
            Sent = 2
        }

        Thread t;
        ParameterizedThreadStart ts;
        int ActiveThreadID;
        FormSearchMode _searchMode = FormSearchMode.Unsent;
        private delegate void EmptyDelegate();
        private delegate void UpdateLabelDelegate(Label lbl, int quantity);
        private delegate void StringDelegate(string s);
        int maxResults;
        Label lastDateLabel;
        int numAppointmentsCurrentDate;
        int numAppointmentsFound;
        frmFTPTransfers ftpTransfer;

        public frmEligibility()
        {
            InitializeComponent();
            ts = new ParameterizedThreadStart(FullImport);
            btnAdvanced.Visible = ActiveUser.UserObject.is_admin;
            ftpTransfer = new frmFTPTransfers(true, false);
            ftpTransfer.FullUploadCompleted += ftpTransfer_FullUploadCompleted;
        }

        private void frmEligibility_Load(object sender, EventArgs e)
        {
            dtpImportFromDate.Value = DateTime.Now;
            ImportEligibilityData();
        }

        private void ImportEligibilityData()
        {
            try
            {
                t = new Thread(ts);
                ActiveThreadID = t.ManagedThreadId;
                maxResults = System.Convert.ToInt32(nmbMaxResults.Value);
                pnlTop.Enabled = false;
                btnCheckEligibility.Enabled = false;

                string sql = string.Format("SELECT APPTID, APPTDB, APPTDate, PatName, ApptLen, Time_Hour, Time_Minute, ApptReason, DDB_Last_Mod " +
                " FROM DDB_APPT" +
                " WHERE OPTYPE = 3 AND Amount > 0 AND DDB_Last_Mod > '{0}'", system_options.LastEligibilityDate.ToShortDateString());

                Debug.WriteLine(" thread started.");

                if (t.ManagedThreadId == ActiveThreadID)
                {
                    pnlLoading.Visible = true;
                    t.Start(sql);
                }
                else
                    Debug.WriteLine("Aborting search thread " + Thread.CurrentThread.ManagedThreadId);

            }
            catch (Exception err)
            {
                string errData = err.Message;
                Exception temp = err;
                while (temp.InnerException != null)
                {
                    temp = temp.InnerException;
                    errData += "\n\n" + temp.Message;
                }
                LoggingHelper.Log("Error in frmEligibility.ImportEligibilityData", LogSeverity.Warning, err);
                ShowError("There was an error retrieving search results. There may be a problem with your database connection.");
                
            }
        }

        private void ShowError(string s)
        {
            if (lblError.InvokeRequired)
            {
                StringDelegate sd = new StringDelegate(ShowError);
                Invoke(sd, new object[] { s });
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = s;
            }
        }

        private void lnkFullImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string sql = string.Format("SELECT APPTID, APPTDB, APPTDate, PatName, ApptLen, Time_Hour, Time_Minute, ApptReason, DDB_Last_Mod " +
                        " FROM         DDB_APPT" +
                        " WHERE     (OPTYPE = 3) AND Amount > 0 AND APPTDate > '{0}'", dtpImportFromDate.Value.ToShortDateString());

                FullImport(sql);
            }
            catch (Exception err)
            {
                ShowError("An unexpected error occurred attempting this full import.\n\n" + err.Message);
            }
        }

        private void FullImport(object sql)
        {
            data_mapping_schema dms = data_mapping_schema.GetDefaultSchema;
            OleDbConnection oConnect;
            DataTable resultData = new DataTable();
            OleDbDataAdapter oAdapter;

            try
            {
                oConnect = new OleDbConnection(dms.GetConnectionString(true));
                oConnect.Open();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not connect to DB in frmClaimSendHistory_Load", LogSeverity.Error, err, false);
                ImportTouchup();
                return;
            }



            oAdapter = new OleDbDataAdapter(sql.ToString(), oConnect);
            oAdapter.Fill(resultData);

            foreach (DataRow aRow in resultData.Rows)
            {
                CheckCreateEligibility(aRow);
            }

            system_options.LastEligibilityDate = DateTime.Now;

            ImportTouchup();
        }

        private void ImportTouchup()
        {
            if (lblMaxResults.InvokeRequired)
            {
                EmptyDelegate d = new EmptyDelegate(ImportTouchup);
                Invoke(d);
            }
            else
            {
                pnlTop.Enabled = true;
                btnCheckEligibility.Enabled = true;
                Search();
                pnlLoading.Visible = false;
            }
        }

        /// <summary>
        /// Checks to see if a given record exists in our system. If so, updates it. If not, creates it.
        /// </summary>
        /// <param name="aRow"></param>
        /// <returns></returns>
        private void CheckCreateEligibility(DataRow aRow)
        {
            eligibility_data egd = new eligibility_data();
            egd.dentrix_id = Convert.ToInt32(aRow["APPTID"].ToString());
            egd.dentrix_db = Convert.ToInt32(aRow["APPTDB"].ToString());
            DataTable matches = egd.Search();

            if (matches.Rows.Count > 0)
            {
                // We have a copy of this stored locally
                egd.Load(matches.Rows[0]);
            }

            // appt_date PatName, ApptLen, Time_Hour, Time_Minute, ApptReason
            egd.patient_name = aRow["PatName"].ToString();
            egd.appt_length = Convert.ToInt32(aRow["ApptLen"]);
            DateTime apptDay = Convert.ToDateTime(aRow["apptdate"].ToString());
            egd.appt_date = new DateTime(apptDay.Year, apptDay.Month, apptDay.Day, Convert.ToInt32(aRow["Time_Hour"]), Convert.ToInt32(aRow["Time_Minute"]), 0);
            egd.procedure_info = aRow["apptReason"].ToString();

            egd.Save();
        }

        private void Search()
        {
            if (pnlResults.InvokeRequired)
            {
                EmptyDelegate ed = new EmptyDelegate(Search);
                Invoke(ed);
            }
            else
            {
                eligibility_data ed = new eligibility_data();
                DataTable matches = ed.Search(BuildSQL());
                DateTime? lastDate = new DateTime(1900, 1, 1);
                numAppointmentsFound = matches.Rows.Count;

                pnlResults.SuspendLayout();
                pnlResults.Controls.Clear();

                foreach (DataRow aRow in matches.Rows)
                {
                    ed = new eligibility_data();
                    ed.Load(aRow);
                    AddAppointment(ed, lastDate);
                    lastDate = ed.appt_date;
                }
                pnlResults.ResumeLayout();
                UpdateLastLabelSafe(lastDateLabel, numAppointmentsCurrentDate);
                UpdateBinCounts();
            }
        }

        private void UpdateBinCounts()
        {
            if (btnTomorrow.InvokeRequired)
            {
                EmptyDelegate ed = new EmptyDelegate(UpdateBinCounts);
                Invoke(ed);
            }
            else
            {
                eligibility_data ed = new eligibility_data();
                UpdateBinCount(ed.Search(BuildSQL(true, FormSearchMode.Unsent)).Rows[0][0].ToString(), 
                    btnUnverified, "Unsent", _searchMode == FormSearchMode.Unsent);
                UpdateBinCount(ed.Search(BuildSQL(true, FormSearchMode.Rejected)).Rows[0][0].ToString(), 
                    btnRejected, "Rejected", _searchMode == FormSearchMode.Rejected);
                UpdateBinCount(ed.Search(BuildSQL(true, FormSearchMode.Tomorrow)).Rows[0][0].ToString(), 
                    btnTomorrow, "Tomorrow", _searchMode == FormSearchMode.Tomorrow);
                UpdateBinCount(ed.Search(BuildSQL(true, FormSearchMode.AllUpcoming)).Rows[0][0].ToString(), 
                    btnUpcoming, "All Upcoming", _searchMode == FormSearchMode.AllUpcoming);
                UpdateBinCount(ed.Search(BuildSQL(true, FormSearchMode.Sent)).Rows[0][0].ToString(),
                    btnSent, "Sent", _searchMode == FormSearchMode.Sent);
            }
        }

        /// <summary>
        /// Uses the SQL passed to get a count value to display on a given button
        /// </summary>
        /// <param name="count">How many are in the current bin</param>
        /// <param name="toUpdate">Which button should we update</param>
        /// <param name="baseText">What is the base text for the button</param>
        /// <param name="isSelected">Is the button currently selected</param>
        private void UpdateBinCount(string count, Button toUpdate, string baseText, bool isSelected)
        {
            string newText = baseText + "\n(";
            if (isSelected)
                newText += numAppointmentsFound + "\\";

            newText += count + ")";
            toUpdate.Text = newText;
        }

       
        private void AddAppointment(eligibility_data ed, DateTime? lastDate)
        {
            if (lastDate.Value.Date != ed.appt_date.Date)
            {
                if (lastDateLabel != null)
                    UpdateLastLabelSafe(lastDateLabel, numAppointmentsCurrentDate);

                Label dateHeader = new Label();
                lastDateLabel = dateHeader;
                numAppointmentsCurrentDate = 0;

                dateHeader.AutoSize = false;
                dateHeader.Text = ed.appt_date.ToLongDateString();
                dateHeader.BorderStyle = BorderStyle.FixedSingle;
                dateHeader.BackColor = Color.SteelBlue;
                dateHeader.ForeColor = Color.White;
                dateHeader.TextAlign = ContentAlignment.MiddleLeft;
                dateHeader.Font = new Font(new FontFamily("Tahoma"), 10.0f, FontStyle.Bold);
                dateHeader.Height = 40;

                pnlResults.Controls.Add(dateHeader);

                dateHeader.Dock = DockStyle.Top;
                dateHeader.BringToFront();
                
            }

            ctlPatientEligibility toAdd = new ctlPatientEligibility(ed);
            toAdd.BorderStyle = BorderStyle.FixedSingle;
            pnlResults.Controls.Add(toAdd);
            numAppointmentsCurrentDate++;
            toAdd.Dock = DockStyle.Top;
            toAdd.BringToFront();

        }

        private void UpdateLastLabelSafe(Label lbl, int quantity)
        {
            if (lbl.InvokeRequired)
            {
                UpdateLabelDelegate uld = new UpdateLabelDelegate(UpdateLastLabelSafe);
                Invoke(uld, new object[] { lbl, quantity });
            }
            else
            {
                lbl.Text += " (" + quantity + " appointments scheduled)";
            }
        }

        private string BuildSQL()
        {
            return BuildSQL(false, _searchMode);
        }

        private string BuildSQL(bool isCount, FormSearchMode searchMode)
        {
            eligibility_data ed = new eligibility_data();
            string sql;

            if (isCount)
                sql = string.Format("SELECT COUNT(*) FROM eligibility_data WHERE CAST(appt_date AS DATE) >= Cast(GetDate() AS DATE) ", nmbMaxResults.Value.ToString());
            else
                sql = string.Format("SELECT TOP {0} * FROM eligibility_data WHERE CAST(appt_date AS DATE) >= Cast(GetDate() AS DATE) ", nmbMaxResults.Value.ToString());

            if (searchMode == FormSearchMode.Unsent)
            {
                sql += " AND (last_check = null OR last_check < '1-2-1900')";
            }
            else if (searchMode == FormSearchMode.Tomorrow)
            {
                sql += string.Format(" AND CAST(appt_date AS DATE) = CAST('{0}' AS DATE)", DateTime.Today.AddDays(1));
            }
            else if (searchMode == FormSearchMode.AllUpcoming)
            {
                sql += ""; // No additional criteria required
            }
            else if (searchMode == FormSearchMode.Rejected)
            {
                sql += " AND last_check > '1-2-1900' AND last_status = 0";
            }
            else if (searchMode == FormSearchMode.Sent)
            {
                sql += " AND last_check > '1-2-1900' AND last_status = 2";
            }

            if (!isCount)
                sql += " ORDER BY appt_date asc";

            return sql;
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            pnlAdvanced.Visible = !pnlAdvanced.Visible;
            if (pnlAdvanced.Visible)
                btnAdvanced.Text = "Advanced\n\n<<";
            else
                btnAdvanced.Text = "Advanced\n\n>>";
        }

        private void lblMaxResults_Click(object sender, EventArgs e)
        {

        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            SetButtonAppearance((Button) sender);
            Search();
        }

        private void SetButtonAppearance(Button toHighlight)
        {
            List<Button> allButtons = new List<Button>(new Button[] { btnTomorrow, btnUpcoming, btnUnverified, btnRejected, btnSent });

            foreach (Button aButton in allButtons)
            {
                if (aButton == toHighlight)
                {
                    aButton.FlatStyle = FlatStyle.Flat;
                    aButton.BackColor = Color.Thistle;
                    if (aButton == btnTomorrow)
                        _searchMode = FormSearchMode.Tomorrow;
                    else if (aButton == btnUpcoming)
                        _searchMode = FormSearchMode.AllUpcoming;
                    else if (aButton == btnUnverified)
                        _searchMode = FormSearchMode.Unsent;
                    else if (aButton == btnRejected)
                        _searchMode = FormSearchMode.Rejected;
                    else if (aButton == btnSent)
                        _searchMode = FormSearchMode.Sent;
                }
                else
                {
                    aButton.FlatStyle = FlatStyle.Standard;
                    aButton.BackColor = System.Drawing.SystemColors.Control;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MarkAllChecked(true);
        }

        private void lnkUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MarkAllChecked(false);
        }

        private void MarkAllChecked(bool isChecked)
        {
            foreach (Control aControl in pnlResults.Controls)
            {
                if (aControl is ctlPatientEligibility)
                    ((ctlPatientEligibility) aControl).CheckState = isChecked;
            }
        }

        private void btnCheckEligibility_Click(object sender, EventArgs e)
        {
            CheckEligibility();
        }

        private void CheckEligibility()
        {
            data_mapping_schema dms = data_mapping_schema.GetDefaultSchema;
            OleDbConnection oConnect;
            DataTable resultData = new DataTable();
            OleDbDataAdapter oAdapter;

            try
            {
                oConnect = new OleDbConnection(dms.GetConnectionString(true));
                oConnect.Open();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not connect to DB to send claims", LogSeverity.Error, err, false);
                return;
            }

            string sql = @"SELECT appt.patNAme as patient, 
payer.inscoName AS PAYER_NAME, payer.insID + '-' + payer.insDB AS Payer_ID, payer.STREET AS PAYER_ADDRESS1, payer.STREET2 AS PAYER_ADDRESS2, payer.CITY AS PAYER_CITY, payer.STATE AS PAYER_STATE,payer.ZIP AS PAYER_ZIP, 
appt.APPTDATE AS APPT_DATE, appt.time_hour AS APPT_HOUR, appt.time_minute AS APPT_MINUTE,
prov.NAME_FIRST AS Provider_FirstName, prov.NAME_LAST AS Provider_LastName, prov.ID1 AS Provider_NPI, prov.STATEID AS Provider_LicenseNo, 'CT' AS provider_state,
insured.idnum as Subscriber_ID, sub.lastname AS Subscriber_LastName, sub.firstname AS Subscriber_FirstName, sub.gender AS Subscriber_Gender, sub.birthdate AS Subscriber_DOB, payer.GroupNum as GroupNo, dep.patID + '-' + dep.patDB AS SubscriberDependentID,
dep.PRINSREL AS PatientRelation,
dep.patID + '-' + dep.PATDB as Dependent_ID, dep.LastName as Dependent_LastName, dep.FirstName as Dependent_FirstName, dep.gender AS Dependent_Gender, dep.BirthDate as Dependent_DOB

FROM DDB_APPT appt
INNER JOIN DDB_PAT_BASE dep ON (appt.PATID = dep.PATID AND appt.PATDB = dep.PATDB)
INNER JOIN DDB_INSURED insured ON (dep.PRINSUREDID = insured.INSUREDID AND dep.PRINSUREDDB = insured.insuredDB)
INNER JOIN DDB_INSURANCE_BASE payer ON (insured.insID = payer.insID AND insured.INSDB = payer.insDB)
INNER JOIN DDB_PAT_BASE sub ON (insured.insuredPartyID = sub.PATID AND insured.insuredPartyDB = sub.PATDB)
INNER JOIN DDB_RSC_BASE prov ON (prov.URSCID = appt.PRPROVID AND prov.RSCDB = appt.PRPROVDB)
WHERE (OPTYPE = 3) AND (";

            string whereClause = "";
            foreach (Control aControl in pnlResults.Controls)
            {
                if (aControl is ctlPatientEligibility)
                {
                    ctlPatientEligibility anAppointment = (ctlPatientEligibility) aControl;
                    if (anAppointment.CheckState)
                    {
                        if (whereClause != "")
                            whereClause += " OR";
                        whereClause += string.Format(" (APPTID = {0} AND APPTDB = {1})", anAppointment.EligibilityData.dentrix_id, anAppointment.EligibilityData.dentrix_db);
                    }
                }
            }

            sql += whereClause + ")";


            oAdapter = new OleDbDataAdapter(sql, oConnect);
            oAdapter.Fill(resultData);

            string fullDocAsList = EligibilityHelper.ConvertFromTable(resultData);

            ftpTransfer.Initialize();
            ftpTransfer.Show();

            ftpTransfer.UpdateMainLabel("Creating files to send to Mercury...", false);

            ParameterizedThreadStart ts = new ParameterizedThreadStart(UploadThreadSafe);
            Thread t = new Thread(ts);
            t.Start(fullDocAsList);
        }

        private void UploadThreadSafe(object cb)
        {
            ftpTransfer.dataToUpload = new List<string> { (string) cb };
            ftpTransfer.StartFileUpload();
        }

        void ftpTransfer_UploadErrors(List<string> id1, List<string> id2)
        {
            Search();
        }

        void ftpTransfer_FullUploadCompleted(object sender, EventArgs e)
        {
            if (pnlResults.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => ftpTransfer_FullUploadCompleted(sender, e)));
            }
            else
            {
                // Have an email in, but we just want to refresh the search here. FTP form needs to figure out the status on the claims

                // Mark all as "waiting" or "sent"


                string sql = string.Format("UPDATE eligibility_data SET last_check = '{0}', last_status = {1}", DateTime.Now.ToShortDateString(), Convert.ToString((int)Eligibility_Status.Sent));
                string whereClause = " WHERE ID IN(";

                foreach (Control aControl in pnlResults.Controls)
                {
                    if (aControl is ctlPatientEligibility)
                    {
                        ctlPatientEligibility anAppointment = (ctlPatientEligibility)aControl;
                        if (whereClause != " WHERE ID IN(")
                            whereClause += ",";
                        whereClause += anAppointment.EligibilityData.id;
                    }
                }

                whereClause += ")";
                claim c = new claim();
                c.ExecuteNonQuery(sql + whereClause);

                Search();
            }
        }


    }
}
