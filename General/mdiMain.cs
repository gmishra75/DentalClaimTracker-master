using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using C_DentalClaimTracker.E_Claims;
using System.Data.SqlClient;
using System.Xml;
using C_DentalClaimTracker.General;

namespace C_DentalClaimTracker
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;
        private static mdiMain _instance = null;
        const string ECLAIMOUTPUT = "eClaims.exe";
        public frmStartScreenWPFContainer PrimaryStartScreen { get; set; }

        public static mdiMain Instance()
        {
            if (_instance == null)
            {
                _instance = new mdiMain();
            }


            return _instance;
        }

        private mdiMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the target form. Will always open a new window.
        /// </summary>
        /// <param name="toShow"></param>
        private void ShowNewForm(Form toShow)
        {
            // Make it a child of this MDI form before showing it.
            toShow.MdiParent = this;
            toShow.Show();
        }

        /// <summary>
        /// Shows a form, but searches app to find if the form is already open and shows existing if possible
        /// </summary>
        /// <param name="toShow"></param>
        public void ShowForm(Form toShow)
        {
            bool formFound = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == toShow.Name)
                {
                    toShow.Dispose();
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.BringToFront();
                    formFound = true;
                }
            }

            if (!formFound)
            {
                toShow.MdiParent = this;
                toShow.StartPosition = FormStartPosition.WindowsDefaultLocation;
                toShow.Show();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSearchClaims_Click(object sender, EventArgs e)
        {
            frmSearchClaim toShow = new frmSearchClaim();
            ShowForm(toShow);
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            /*
            Hide();
            frmLogin loginForm = new frmLogin();

            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                General.frmStartScreenWPFContainer toShow = new General.frmStartScreenWPFContainer(this);

                toShow.Show();
                

                
                if (ActiveUser.UserObject.UserData.open_search_form)
                {
                    frmSearchClaim toShow = new frmSearchClaim();
                    ShowForm(toShow);
                }

                if (ActiveUser.UserObject.UserData.open_eclaims_form)
                {
                    frmProcessor toShow = new frmProcessor();
                    ShowForm(toShow);
                }
                 
            }
            else
            {
                Application.Exit();
            }
          */
        }

        private void mnuImport_Click(object sender, EventArgs e)
        {

            frmImportData toShow = new frmImportData();
            ShowForm(toShow);

        }

        private void mnuEditQuestionTree_Click(object sender, EventArgs e)
        {
            ShowForm(new frmEditQuestionTree());
        }

        private void mnuEclaims_Click(object sender, EventArgs e)
        {
            //NHDG.EClaims.frmMain toShow = new NHDG.EClaims.frmMain();
            //toShow.Show(this);
        }

        private void mnuProcessClaims_Click(object sender, EventArgs e)
        {
            
            ShowForm(new frmProcessor());
        }

        private void mnuSyncWithEclaims_Click(object sender, EventArgs e)
        {

            data_mapping_schema dms;
            SqlConnection dbConnection;
            try
            {
                dms = new data_mapping_schema();
                dms.Load(3);
                dbConnection = new SqlConnection(dms.GetConnectionString(false));
                dbConnection.Open();
            }
            catch
            {
                MessageBox.Show(this, "Could not open connection to Dentrix database.", "Could not connect");
                return;
            }

            try
            {
                // Remove all batches with a source of external, then pull them all back in
                claim_batch toDelete = new claim_batch();

                toDelete.ExecuteNonQuery("DELETE claim_batch, batch_claim_list FROM claim_batch " +
                    " LEFT JOIN batch_claim_list ON claim_batch.id = batch_claim_list.batch_id WHERE source = 1");
                // Got rid of the existing external stuff, now pull in the stuff from the last few months
                // NHDG_CLAIM_BATCHES - CLAIMBATCHID, BATCH_DATE, HANDLING ("Paper", "Electronic (ApexEDI)"
                // NHDG_CLAIM_TRANSACTIONS - CLAIM_ID, CLAIM_DB, CLAIMBATCHID, RESUBMIT_FLAG (char?), BATCH_RESUBMITTED

                Dictionary<string, int> batchIDData = new Dictionary<string, int>(); // Update this as I iterate through claim batches, we'll grab all the items for valid 
                // bacthes in a 2nd sql statement
                string batchIDList = "";

                SqlCommand command = new SqlCommand("SELECT * FROM NHDG_CLAIM_BATCHES cb " +
                    "WHERE DATEDIFF(\"dd\", cb.BATCH_DATE, GETDATE()) < 200", dbConnection);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    claim_batch cb = new claim_batch();

                    cb.batch_date = (DateTime)reader["batch_date"];
                    cb.handling = ConvertHandlingFromDentrix(reader["handling"].ToString());
                    cb.batch_info = "Imported from Eclaims";
                    cb["source"] = 1;
                    cb.Save();
                    batchIDData.Add(reader["claimbatchid"].ToString(), cb.id);
                }

                reader.Close();
                if (batchIDData.Count > 0)
                {
                    foreach (KeyValuePair<string, int> kvp in batchIDData)
                    {
                        batchIDList += kvp.Key + ",";
                    }
                    batchIDList = batchIDList.TrimEnd(",".ToCharArray());
                    //Clipboard.SetText(batchIDList);
                    //MessageBox.Show("Here's my batchid list (it's in the clipboard): " + batchIDList);

                    string searchSQL = "SELECT * FROM NHDG_CLAIM_TRANSACTIONS WHERE CLAIMBATCHID IN (" + batchIDList +
                        ")";
                    command = new SqlCommand(searchSQL, dbConnection);

                    //Clipboard.SetText(searchSQL);
                    //MessageBox.Show("And here's the search sql: " + searchSQL);
                    reader = command.ExecuteReader();
                    string bigMessageBox = "";
                    int foundCount = 0;
                    while (reader.Read())
                    {
                        int claimID = FindClaim(reader["claim_id"].ToString(), reader["claim_db"].ToString());

                        bigMessageBox += reader["claim_id"].ToString() + " | ";

                        if (claimID > 0)
                        {
                            batch_claim_list bcl = new batch_claim_list();
                            claim_batch cb = new claim_batch(batchIDData[reader["claimbatchid"].ToString()]);
                            bcl.batch_id = cb.id;
                            bcl.claim_id = claimID;
                            bcl.still_in_batch = reader["resubmit_flag"].ToString() != "Y";
                            bcl["last_send_date"] = cb.batch_date;
                            bcl.Save();

                            foundCount++;
                        }
                    }

                    //MessageBox.Show("Here are the claimIDs that were searched for. ( " + foundCount + " were found.)\n" + bigMessageBox);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(this, "An unexpected error occurred syncing data.\n\n" + ex.Message);
            }

            MessageBox.Show(this, "Sync successful!", "Sync with Eclaims", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        

        private clsClaimEnums.SentMethods ConvertHandlingFromDentrix(string handling)
        {
            if (handling.ToUpper() == "PAPER")
                return clsClaimEnums.SentMethods.Paper;
            else
                return clsClaimEnums.SentMethods.ApexEDI;
        }

        private string ConvertHandlingToDentrix(string handling)
        {
            if (handling.ToUpper() == "PAPER")
                return "Paper";
            else
                return "Electronic (ApexEDI)";
        }

        private int FindClaim(string claimID, string claimDB)
        {
            claim toFind = new claim();
            DataTable results = toFind.Search("SELECT id FROM claims WHERE claimidnum = " + claimID +
                " AND claimdb = " + claimDB);

            if (results.Rows.Count > 0)
                return System.Convert.ToInt32(results.Rows[0]["id"].ToString());
            else
                return 0;
        }

        private void sendEclaimsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string XMLPATH = Application.StartupPath + "\\syncdata.xml";
            // start by getting the date everything was sent out from the xml file
            DateTime lastWrite = new DateTime(1999, 12, 31);
            bool okToContinue = true;

            if (File.Exists(XMLPATH))
            {
                XmlDocument toOpen = new XmlDocument();
                toOpen.Load(XMLPATH);

                try
                {
                    XmlElement ele = toOpen.DocumentElement;
                    lastWrite = System.Convert.ToDateTime(ele.InnerText);
                }
                catch
                {
                    // assume the data is corrupt and there was no last write date.
                    okToContinue = MessageBox.Show(this, "The file that specifies which batches have been sent to eclaims has been corrupted. Would you like to continue and " +
                        "send all batches to eclaims?", "Sync File Corrupt", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes;
                }
            }
            int count = 0;

            if (okToContinue)
            {

                // Get the claims to process
                List<claim_batch> cbList = new List<claim_batch>();
                claim_batch cb = new claim_batch();
                string searchSQL = "SELECT * FROM claim_batch WHERE batch_date > CAST('" + CommonFunctions.ToMySQLDateTime(lastWrite)
                + "' AS DATETIME) AND SOURCE = 0";
                DataTable dt = cb.Search(searchSQL);
                count = dt.Rows.Count;

                foreach (DataRow aBatch in dt.Rows)
                {
                    cb = new claim_batch();
                    cb.Load(aBatch);
                    cbList.Add(cb);
                }



                // Add the claims as claims in Dentrix
                // NHDG_CLAIM_BATCHES - CLAIMBATCHID, BATCH_DATE, HANDLING ("Paper", "Electronic (ApexEDI)"
                // NHDG_CLAIM_TRANSACTIONS - CLAIM_ID, CLAIM_DB, CLAIMBATCHID, RESUBMIT_FLAG (char?), BATCH_RESUBMITTED
                data_mapping_schema dms = new data_mapping_schema(3);
                SqlConnection dbConnection = new SqlConnection(dms.GetConnectionString(false));

                try
                {
                    dbConnection.Open();

                    foreach (claim_batch aBatch in cbList)
                    {
                        SqlCommand sc = new SqlCommand("INSERT INTO NHDG_CLAIM_BATCHES (batch_date, handling) VALUES ('" +
                            CommonFunctions.ToMySQLDateTime(aBatch.batch_date) + "', '" + ConvertHandlingToDentrix(aBatch.handlingAsString) +
                            "')", dbConnection);
                        sc.ExecuteNonQuery();

                        sc.CommandText = "SELECT IDENT_CURRENT('NHDG_CLAIM_BATCHES')";
                        SqlDataReader getID = sc.ExecuteReader();
                        getID.Read();
                        int lastID = System.Convert.ToInt32(getID[0]);
                        getID.Close();

                        // Insert all the claims in the batch into nhdg_claim_transactions
                        foreach (claim aClaim in aBatch.GetMatchingClaims())
                        {
                            sc.CommandText = "INSERT INTO NHDG_CLAIM_TRANSACTIONS (CLAIM_ID, CLAIM_DB, CLAIMBATCHID) " +
                                " VALUES (" + aClaim.claimidnum + "," + aClaim.claimdb + "," + lastID + ")";
                            sc.ExecuteNonQuery();
                        }

                    }
                }
                catch
                {
                    okToContinue = false;
                    MessageBox.Show("There was an error getting the data into the Dentrix database. The process cannot continue.");
                }



            }
            if (okToContinue)
            {
                XmlDocument toSave = new XmlDocument();
                XmlNode toChange;
                if (File.Exists(XMLPATH))
                {
                    toSave.Load(XMLPATH);
                    toChange = toSave.DocumentElement;
                }
                else
                {
                    toChange = toSave.AppendChild(toSave.CreateNode(XmlNodeType.Element, "SyncData", ""));
                    toChange = toSave.DocumentElement.AppendChild(toSave.CreateTextNode("LastUpdate"));
                }

                toChange.InnerText = DateTime.Now.ToString();
                toSave.Save(XMLPATH);

                MessageBox.Show(count + " batches synced successfully.");
            }


            else
            {
                MessageBox.Show("Please contact a system administrator to fix the problems you encountered while syncing.");
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox toShow = new frmAboutBox();
            toShow.ShowDialog();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmSettings toShow = new frmSettings();
            toShow.ShowDialog(this);
        }

        private void mnuUserSettings_Click(object sender, EventArgs e)
        {
            frmUserControlPanel toShow = new frmUserControlPanel(ActiveUser.UserObject);
            toShow.ShowDialog(this);
        }

        private void mnuDownloadUpdate_Click(object sender, EventArgs e)
        {
            string updaterPath = Application.StartupPath + "\\DCTUpdater.exe";

            if (File.Exists(updaterPath))
            {
                if (MessageBox.Show(this, "Claim Tracker needs to be shutdown in order to check for updates. Is this OK?",
            "Can I shutdown?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(updaterPath);
                    Application.Exit();
                }
            }
            else
                MessageBox.Show(this, "Could not find the updater program. Make sure it's in the same folder as Claim Tracker.");

        }

        private void mnuEditCallStatus_Click(object sender, EventArgs e)
        {
            frmStatusManager toShow = new frmStatusManager();
            ShowForm(toShow);
        }

        private void mnuUserManager_Click(object sender, EventArgs e)
        {
            if (ActiveUser.UserObject.is_admin)
            {
                frmUserManager toShow = new frmUserManager();
                toShow.Show();
            }
            else
            {
                MessageBox.Show(this, "You must be an administrator to access this feature.");
            }
        }

        public void HideAdminMenu()
        {
            adminToolStripMenuItem.Visible = ActiveUser.UserObject.is_admin;
        }

        private void mnuUnusualPayment_Click(object sender, EventArgs e)
        {
            ShowForm(new frmUnusualPaymentRules());
        }

        private void userActionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmViewActionLog());
        }

        private void mnuMultipleClaimCall_Click(object sender, EventArgs e)
        {
            ShowForm(new frmMultiClaimCall());
        }

        private void mnuProviderEligibility_Click(object sender, EventArgs e)
        {
            ShowForm(new C_DentalClaimTracker.Provider_Eligibility.frmProviderEligibilityRestrictions());
        }

        private void mnuEditApexRules_Click(object sender, EventArgs e)
        {
            ShowForm(new frmApexRulesManager());
        }

        private void claimHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Reporting.frmClaimSendHistory());
        }

        private void mnuInsuranceGroups_Click(object sender, EventArgs e)
        {
            ShowForm(new Provider_Eligibility.frmInsuranceGroups());
        }

        private void mnuCodePaymentHistory_Click(object sender, EventArgs e)
        {
            ShowForm(new C_DentalClaimTracker.Reporting.frmCodePaymentHistory());
        }

        private void mnuSystemDebug_Click(object sender, EventArgs e)
        {
            ShowForm(new DebugForm());
        }

        private void mnuEligibility_Click(object sender, EventArgs e)
        {
            ShowForm(new C_DentalClaimTracker.E_Claims.Mercury.frmEligibility());
        }

        private void mnuEditApexSchema_Click(object sender, EventArgs e)
        {
            ShowForm(new C_DentalClaimTracker.E_Claims.frmEditApexSchema());
        }

        private void mnuAppointmentAudit_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + "AppointmentAuditor.exe";

            if (File.Exists(fileName))
                CommonFunctions.StartFile(fileName);
            else
                MessageBox.Show("Appointment Auditor not found at " + fileName + ". Could not load application.");
        }

        private void openApplicationFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFunctions.OpenDirectory(Application.StartupPath);
        }

        private void mnuProviderEligibilityTests_Click(object sender, EventArgs e)
        {
            ShowForm(new Provider_Eligibility.frmEligibilityTests());
        }

        private void mnuNewClaimSearch_Click(object sender, EventArgs e)
        {
            ShowForm(new Claims_Primary.frmSearchClaimWPFContainer());
        }

        private void quickSearchTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Claims_Primary.frmSearchClaimWPFContainer());
        }

        private void tstrReturnToBasic_Click(object sender, EventArgs e)
        {
            PrimaryStartScreen.Show();
            Hide();
        }

        private void mnuPriorityReport_Click(object sender, EventArgs e)
        {
            user_preferences up = new user_preferences(ActiveUser.UserObject.id);
            Reporting.frmAgingReport fa = new Reporting.frmAgingReport();
            fa.IncludePrimary = true;
            fa.IncludeSecondary = true;
            fa.DateCriteria = up.reports_minimumdays;            
            fa.Show();
        }
    }
}
