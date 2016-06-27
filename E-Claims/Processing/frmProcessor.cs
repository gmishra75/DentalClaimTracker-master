using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NHDG.EClaims;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Threading;
using System.Collections;
using System.Xml;
using System.Reflection;
using C_DentalClaimTracker.E_Claims.Processing;

namespace C_DentalClaimTracker.E_Claims
{
    public partial class frmProcessor : Form
    {
        List<DataGridViewRow> printRows;
        List<DataGridViewColumn> printListColumns;
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        DataGridViewCellStyle _apexRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _ansRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _paperRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _defaultRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _notInBatchRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _mercuryRow = new DataGridViewCellStyle();
        DataGridViewCellStyle _verifiedRow = new DataGridViewCellStyle();
        delegate void SearchDelegate(UnsubmittedSearchResultList usrl);
        DataGridView dgvToUse;
        SqlConnection dbConnection;
        Thread handledBatchesThread;
        ParameterizedThreadStart pendingBatchesThreadStart;
        ParameterizedThreadStart paidBatchesThreadStart;
        ParameterizedThreadStart mainThreadStart;
        Thread searchThread;
        delegate void TouchupDelegate(List<object[]> allData);
        delegate void PendingTouchupDelegate(PendingSearchResultList psrl);
        delegate void PaidTouchupDelegate(PaidSearchResultList psrl);
        public static string CLMFOLDER = system_options.ApexEDISaveFolder;
        public static string MERCURYCLMFOLDER = system_options.MercurySaveFolder;
        public static string APEXFILENAME = "apex.clm";
        data_mapping_schema dms;
        List<provider_eligibility_restrictions> restrictions = provider_eligibility_restrictions.GetAllDataAsList();
        int activeThreadID = 0;
        int handledBatchesThreadID = 0;
        public string MercuryXMLSaveFolder { get; set; }
        public EventHandler<EventArgs> XMLCreationCompleted;
        C_DentalClaimTracker.E_Claims.Mercury.frmFTPTransfers ftpTransfer;
        int maxResults = 0;
        int currentSearchResultCount = 0;

        public enum HandlingTypes
        {
            Paper,
            ApexEDI,
            ANS,
            Unclassified
        }

        public frmProcessor()
        {
            InitializeComponent();
            pendingBatchesThreadStart = new ParameterizedThreadStart(InitializePendingBatches);
            paidBatchesThreadStart = new ParameterizedThreadStart(InitializePaidBatches);
            mainThreadStart = new ParameterizedThreadStart(SearchThreadSafe);
            InitializeSchemaList("Dentrix");
            InitializeCompanyNames();
            InitializeColors();
            InitializeProviders();
            InitializePrintListColumns();
            ctlPatientDOB.CurrentDate = DateTime.Now;
            ctlPatientDOB.CurrentDate = null;
            dgvToUse = dgvResults;
            dbConnection = new SqlConnection(((data_mapping_schema)cmbSchema.SelectedItem).GetConnectionString(false));
            XMLCreationCompleted += XMLCreationComplete;
            ftpTransfer = new Mercury.frmFTPTransfers();
            ftpTransfer.UploadErrors += ftpTransfer_UploadErrors;
        }

        private void InitializePrintListColumns()
        {
            printListColumns = new List<DataGridViewColumn>();
            printListColumns.AddRange(new DataGridViewColumn[] { colMainDate, colMainPatient, colMainProvider, colMainType, colMainCompany, colMainAmount });
        }


        

        private void InitializeProviders()
        {
            claim searchObject = new claim();

            DataTable providers = searchObject.Search("SELECT DISTINCT(doctor_provider_id), doctor_first_name, doctor_last_name FROM claims " +
                "WHERE doctor_provider_id IS NOT Null AND doctor_provider_id != '' AND doctor_provider_id NOT LIKE 'H%' ORDER BY doctor_provider_id");

            cmbProviderID.Items.Clear();
            cmbProviderID.Items.Add("");
            ctxtProviderList.Items.Add("", null, new EventHandler(ctxtProviderList_Click));
            claim.OverrideProviderList().ForEach(p =>
            {
                cmbProviderID.Items.Add(p.doctor_provider_id);
                ctxtProviderList.Items.Add(p.doctor_provider_id, null, new EventHandler(ctxtProviderList_Click));
            });
        }

        private void ctxtProviderList_Click(object sender, EventArgs e)
        {
            string clickedProvider = ((ToolStripItem)sender).Text;
            if (dgvResults.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow aRow in dgvResults.SelectedRows)
                {
                    claim c = (claim)aRow.Cells[colMainClaimObject.DisplayIndex].Value;
                    c.override_address_provider = clickedProvider;
                    c.Save();
                }

                SearchThreadSafe(BuildSQL());
            }
            else
            {
                MessageBox.Show(this, "Please check one or more claims to perform this action.");
            }
        }

        private void InitializeSchemaList()
        {
            InitializeSchemaList("");
        }

        private void InitializeCompanyNames()
        {
            company cmps = new company();
            DataTable dt = cmps.Search(cmps.SearchSQL + " ORDER BY name");

            foreach (DataRow aCompany in dt.Rows)
            {
                cmps = new company();
                cmps.Load(aCompany);
                cmbCompanyDropdown.Items.Add(cmps);
            }
        }

        private void InitializeSchemaList(string defaultValue)
        {
            data_mapping_schema aSchema = new data_mapping_schema();

            DataTable allSchemas = aSchema.Search(aSchema.SearchSQL + " ORDER BY schema_name");

            cmbSchema.Items.Clear();

            foreach (DataRow aRow in allSchemas.Rows)
            {
                aSchema = new data_mapping_schema();
                aSchema.Load(aRow);

                cmbSchema.Items.Add(aSchema);
            }

            if (defaultValue == "")
            {
                cmbSchema.SelectedIndex = 0;
            }
            else
            {
                cmbSchema.SelectedIndex = cmbSchema.FindStringExact(defaultValue);
            }
        }

        private void InitializeColors()
        {

            Color clrPAPER = Color.LightYellow;
            Color clrAPEX = Color.LightSteelBlue;
            Color clrANS = Color.DarkSeaGreen;
            Color clrMercury = Color.SteelBlue;

            _paperRow.BackColor = clrPAPER;
            _apexRow.BackColor = clrAPEX;
            _ansRow.BackColor = clrANS;
            _notInBatchRow.BackColor = Color.LightGray;
            _verifiedRow.BackColor = Color.LightGray;
            _mercuryRow.BackColor = clrMercury;
        }

        #region Processing Code

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            // This datagrid view was used to identify selections
            cmdProcess.Enabled = false;
            SqlTransaction trans;
            try
            {
                if (InitializeConnection())
                    trans = dbConnection.BeginTransaction();
                else
                {
                    LoggingHelper.Log("Error in frmProcessor.Process. Dentrix DB connection failed.", LogSeverity.Error);
                    throw new Exception("Dentrix DB connection failed");
                }
            }
            catch
            {
                MessageBox.Show(this, "Could not connect to Dentrix DB to begin processing. Verify your database connection settings are correct.");
                cmdProcess.Enabled = true;
                return;
            }

            try
            {
                NHDG.NHDGCommon.Claims.ClaimBatch cb = new NHDG.NHDGCommon.Claims.ClaimBatch();

                if (dgvResults.SelectedRows.Count > 0)
                {
                    try
                    {
                        string apexErrors = string.Empty;
                        string ansErrors = string.Empty;
                        string mercuryErrors = string.Empty;
                        List<claim> apexProcessedClaims = new List<claim>();
                        List<claim> paperClaims = new List<claim>();
                        List<claim> ansClaims = new List<claim>();
                        List<claim> mercuryClaims = new List<claim>();

                        foreach (DataGridViewRow aClaim in dgvResults.Rows)
                        {
                            claim thisClaim = (claim)aClaim.Cells[colMainClaimObject.Name].Value;
                            if (aClaim.DefaultCellStyle == _apexRow)
                            {
                                apexProcessedClaims.Add(thisClaim);
                            }
                            else if (aClaim.DefaultCellStyle == _ansRow)
                            {
                                // Handle as an ANS
                                ansClaims.Add(thisClaim);
                            }
                            else if (aClaim.DefaultCellStyle == _paperRow)
                            {
                                paperClaims.Add(thisClaim);
                                ActiveUser.LogAction(ActiveUser.ActionTypes.SubmitClaim, thisClaim.id, "Paper Submit");
                            }
                            else if (aClaim.DefaultCellStyle == _mercuryRow)
                            {
                                mercuryClaims.Add(thisClaim);
                            }
                        }


                        if (apexProcessedClaims.Count > 0)
                        {
                            // Verify they don't go over the limit of allowable claims
                            bool tooManyClaims = false;
                            claim_batch currentBatch = GetCurrentApexBatch();
                            int currentBatchCount = 0;

                            if (currentBatch != null)
                                currentBatchCount = currentBatch.GetMatchingClaims().Count;

                            if (currentBatchCount + apexProcessedClaims.Count > system_options.MaxClaimsInBatch)
                                tooManyClaims = true;

                            if (tooManyClaims)
                            {
                                MessageBox.Show(this, "The maximum number of claims allowed in a batch is " + system_options.MaxClaimsInBatch + ". Please send the existing apex " +
                                    "batch or lower the number of claims going into this batch (Claims attempted: " + apexProcessedClaims.Count + ", Claims in current batch: "
                                    + currentBatchCount + ").", "Too many claims in batch", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {

                                NHDG.NHDGCommon.Claims.Claim c;
                                List<claim> errorClaims = new List<claim>();
                                foreach (claim thisClaim in apexProcessedClaims)
                                {
                                    try
                                    {
                                        c = new NHDG.NHDGCommon.Claims.Claim(thisClaim, trans, true, true);
                                        cb.Claims.Add(c);

                                        c.CleanAddresses();
                                        ActiveUser.LogAction(ActiveUser.ActionTypes.SubmitClaim, thisClaim.id, "Apex Submit");
                                    }

                                    catch
                                    {
                                        apexErrors += "\n" + thisClaim.created_on.Value.ToShortDateString() + ", " +
                                            thisClaim.PatientLastNameCommaFirst + "; " + thisClaim.LinkedCompany.name;
                                        errorClaims.Add(thisClaim);
                                    }
                                }

                                errorClaims.ForEach(ec => apexProcessedClaims.Remove(ec));

                                ProcessApexClaimBatch(cb, apexErrors, apexProcessedClaims, GetCurrentApexBatch(), false);
                            }
                        }

                        if (ansClaims.Count > 0)
                        {
                            // Process the ansClaims here, not working yet
                            MessageBox.Show("ANS claims cannot currently be processed. These claims will not be added to an ANS batch.");
                        }

                        if (paperClaims.Count > 0)
                        {
                            claim_batch paperBatch = claim_batch.GetPaperBatchForToday();


                            foreach (claim toAdd in paperClaims)
                            {
                                paperBatch.AddClaim(toAdd.id);
                                if (system_options.ApexRevisitDateEnabled)
                                    toAdd.SetStatusAndRevisitDate(null, DateTime.Now.AddDays(system_options.ApexRevisitDate));
                            }
                        }

                        if (mercuryClaims.Count > 0)
                        {
                            
                            bool tooManyClaims = false;
                            claim_batch currentBatch = claim_batch.NewMercuryBatch();
                            
                            if (mercuryClaims.Count > system_options.MaxClaimsInBatch)
                                tooManyClaims = true;

                            if (tooManyClaims)
                            {
                                MessageBox.Show(this, "The maximum number of claims allowed in a batch is " + system_options.MaxClaimsInBatch + ". Please lower the number of claims in this batch. " +
                                    "(Claims attempted: " + mercuryClaims.Count + ").", "Too many claims in batch", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {

                                NHDG.NHDGCommon.Claims.Claim c;
                                foreach (claim thisClaim in mercuryClaims)
                                {
                                    try
                                    {
                                        c = new NHDG.NHDGCommon.Claims.Claim(thisClaim, trans, true, true);
                                        cb.Claims.Add(c);
                                        c.CleanAddresses();

                                        Dictionary<string, string> payerInfo = GetMercuryPayerID(c);

                                        if (payerInfo != null)
                                        {
                                            thisClaim.payer_id = payerInfo["id"];
                                            thisClaim.payer_name = payerInfo["name"];
                                        }
                                        thisClaim.Save();
                                        
                                        ActiveUser.LogAction(ActiveUser.ActionTypes.SubmitClaim, thisClaim.id, "Mercury Submit");
                                    }

                                    catch
                                    {
                                        mercuryErrors = "\n" + thisClaim.created_on.Value.ToShortDateString() + ", " +
                                            thisClaim.PatientLastNameCommaFirst + "; " + thisClaim.LinkedCompany.name;
                                    }
                                }
                                ProcessMercuryClaimBatch(cb, mercuryErrors, mercuryClaims, currentBatch);
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        LoggingHelper.Log("Error in frmProcessor.Process.", LogSeverity.Error, err, false);
                        MessageBox.Show(this, "An unexpected error occurred processing the claims.\n" + err.Message, "Unexpected error.");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select at least one claim to process.");
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in frmProcessor.Process (2)", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred attempting to process this claim. Please report this error to an administrator:\n\n" +
                    err.Message, "Error Processing Claim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                trans.Commit();
            }

            cmdProcess.Enabled = true;
            SearchPrimary(true);

        }

        /// <summary>
        /// Tries to find a match for the payer on this claim. If a match isn't found, pops up a form asking the user to choose one.
        /// </summary>
        /// <param name="c"></param>
        private Dictionary<string, string> GetMercuryPayerID(NHDG.NHDGCommon.Claims.Claim c)
        {
            mercury_payer_list mpl = new mercury_payer_list();
            Dictionary<string, string> easyMatches = mpl.SearchIncludeAlias(c.GeneralInformation.Carrier.Name);

            if (easyMatches == null)
            {
                // Ask the user to select a payer id
                Mercury.frmFindMercuryPayer toShow = new Mercury.frmFindMercuryPayer(c.GeneralInformation.Carrier.Name);
                toShow.ShowDialog();

                easyMatches = new Dictionary<string, string>();
                easyMatches.Add("id", toShow.PayerID);
                easyMatches.Add("name", toShow.PayerName);
            }


            return easyMatches;
        }

       

        /// <summary>
        /// Looks at the local file system to determine if a new batch needs to be created
        /// </summary>
        /// <returns></returns>
        private claim_batch GetCurrentApexBatch()
        {
            // Check to see if a file exists. If it does, look at the "create date" for the file, and try to find a batch
            // If we can't find a batch that matches, then use the most recent batch
            // CLMFOLDER = system options clm folder
            // APEXFILENAME - name of apex file
            string apexFilePath = CLMFOLDER + APEXFILENAME;
            claim_batch toReturn = null;

            if (File.Exists(apexFilePath))
            {
                DateTime fileDate = File.GetCreationTime(apexFilePath);
                toReturn = claim_batch.FindApexBatchWithDate(fileDate);

            }

            return toReturn;
        }

        /// <summary>
        /// Takes a claim_batch and converts it to a series of XML files. Puts them in a unique folder based on date/time of creation
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="mercuryErrors"></param>
        /// <param name="mercuryClaims"></param>
        /// <param name="currentBatch"></param>
        private void ProcessMercuryClaimBatch(NHDG.NHDGCommon.Claims.ClaimBatch cb, string mercuryErrors, List<claim> mercuryClaims, claim_batch currentBatch, bool isResend = false)
        {
            
            ftpTransfer.Initialize();
            ftpTransfer.Show();

            ftpTransfer.UpdateMainLabel("Creating files to send to Mercury...", false);

            MercuryXMLUploadData uData = new MercuryXMLUploadData();

            uData.cb = cb;
            uData.mercuryClaims = mercuryClaims;
            uData.mercuryErrors = mercuryErrors;
            uData.currentBatch = currentBatch;
            uData.isResend = isResend;

            ConvertBatchToXML(uData);

            #region Claim Split/Code Changer (currently disabled)
            /* Can't do this split, but slight changes will let me - it wants a file, but just converts the file to a claim batch. Let's just send it a claim batch
            try
            {
                NHDG.ProphySplitter.ProphySplitter ps = new NHDG.ProphySplitter.ProphySplitter();
                ps.PerformSplit(xmlPath);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error Splitting Procedures in frmProcessor.ProcessApexClaimBatch", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred splitting the procedures (for example, splitting D1110 into " +
                    "multiple procedures. Please report the following error to a system administrator: \n\n" + err.Message, "Error Splitting");
            }
            */

            /* Can't do this either, but same as above - it actually wants to work with a batch
            try
            {
                NHDG.ClaimCodeChanger.ClaimCodeChanger.Process(xmlPath);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error formatting codes in frmProcessor.ProcessApexClaimBatch", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred formatting the codes for the claim.\n\n" +
                    err.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
            #endregion

        }

        internal void ConvertBatchToXML(MercuryXMLUploadData uploadData)
        {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(ConvertBatchToXMLThreadSafe);
            Thread t = new Thread(ts);
            t.Start(uploadData);
        }

        private void ConvertBatchToXMLThreadSafe(object cb)
        {
            MercuryXMLUploadData uploadData = (MercuryXMLUploadData)cb;

            string saveFolder = MERCURYCLMFOLDER + DateTime.Now.ToString("g").Replace("/", "-").Replace(":", "-");

            if (Directory.Exists(saveFolder))
            {
                int toAdd = 2;
                while (Directory.Exists(saveFolder + " - " + toAdd))
                    toAdd++;
                saveFolder = saveFolder + " - " + toAdd;
            }
            else
            {
                if (!Directory.Exists(MERCURYCLMFOLDER))
                    Directory.CreateDirectory(MERCURYCLMFOLDER);
            }

            saveFolder += "\\";
            Directory.CreateDirectory(saveFolder);


            foreach (claim aClaim in uploadData.mercuryClaims)
            {
                if (uploadData.isResend)
                {
                    uploadData.currentBatch.SetSentDate(aClaim.id);
                    uploadData.currentBatch.AddClaim(aClaim.id);
                    aClaim.SetApexResendStatus(); // Current using same values from Apex 
                }
                else
                {
                    uploadData.currentBatch.AddClaim(aClaim.id);
                    aClaim.SetApexStatus();  // Current using same values from Apex 
                }

                aClaim.CreateSentHistory(clsClaimEnums.SentMethods.Mercury, uploadData.isResend);
            }

            // Check for provider eligibility restrictions
            for (int i = 0; i < uploadData.mercuryClaims.Count; i++)
            {
                ClaimTrackerCommon.CheckForEligibilityRestrictions(uploadData.mercuryClaims[i], (NHDG.NHDGCommon.Claims.Claim)uploadData.cb.Claims[i]);
            }

            MercuryXMLSaveFolder = saveFolder;

            // Convert to Mercury format
            List<string> fileData = Mercury.MercuryHelper.ConvertBatchToXML(uploadData.cb, MercuryXMLSaveFolder);
            
            ftpTransfer.dataToUpload = fileData;
            ftpTransfer.StartFileUpload();
        }

        public void XMLCreationComplete(object sender, EventArgs e)
        {
            
        }

        void ftpTransfer_UploadErrors(List<string> id1, List<string> id2)
        {
            if (id1.Count > 0)
            {
                claim_batch errorBatch = new claim_batch();

                errorBatch.batch_date = DateTime.Now;
                errorBatch.handling = clsClaimEnums.SentMethods.Mercury;
                errorBatch.batch_info = "Mercury Error Batch";
                errorBatch.source = 0;
                errorBatch.server_name = C_DentalClaimTracker.General.RegistryData.LocalComputerName;
                errorBatch.Save();
                
                // Some files had errors when attempting to upload them
                for (int i = 0; i < id1.Count; i++)
                {
                    errorBatch.AddClaim(id1[0], id2[0]);
                }

                RefreshResults();
            }
        }


        public void ProcessApexClaimBatch(NHDG.NHDGCommon.Claims.ClaimBatch cb, string apexErrors, List<claim> apexProcessedClaims, claim_batch currentBatch, bool isResend)
        {
            // Create DB Batch as well
            string xmlPath;
            string ediPath;
            DateTime batchDate = DateTime.Now;
            if (currentBatch == null)
            {
                currentBatch = new claim_batch();

                currentBatch.batch_date = batchDate;
                currentBatch.handling = clsClaimEnums.SentMethods.ApexEDI;
                currentBatch.batch_info = "Apex Batch";
                currentBatch.source = 0;
                currentBatch.server_name = Properties.Settings.Default.LocalComputerName;
                currentBatch.Save();
            }
            else
            {
                // Current batch already initialized
            }



            foreach (claim aClaim in apexProcessedClaims)
            {
                if (isResend)
                {
                    currentBatch.SetSentDate(aClaim.id);
                    if (!aClaim.InCurrentApexResendBatch())
                        currentBatch.AddClaim(aClaim.id);
                    aClaim.SetApexResendStatus();
                }
                else
                {
                    currentBatch.AddClaim(aClaim.id);
                    aClaim.SetApexStatus();
                }

                aClaim.CreateSentHistory(clsClaimEnums.SentMethods.ApexEDI, isResend);
                

            }

            xmlPath = currentBatch.XMLSavePath;

            if (File.Exists(xmlPath))
            {
                xmlPath = currentBatch.SaveFolder + CommonFunctions.DateToFilePathFormat(DateTime.Now) + ".xml";
            }

            ediPath = Path.ChangeExtension(xmlPath, ".apexedi");

            if (!Directory.Exists(currentBatch.SaveFolder))
                Directory.CreateDirectory(currentBatch.SaveFolder);

            // Check for provider eligibility restrictions
            for (int i = 0; i < apexProcessedClaims.Count; i++)
            {
                // Note that if the claim data is overridden, then eligibility restrictions won't apply
                ClaimTrackerCommon.CheckForEligibilityRestrictions(apexProcessedClaims[i], (NHDG.NHDGCommon.Claims.Claim)cb.Claims[i]);
            }

            // Handle all APEX stuff
            NHDG.NHDGCommon.Utilities.SerializeToFile(cb, typeof(NHDG.NHDGCommon.Claims.ClaimBatch), xmlPath);

            try
            {
                NHDG.ProphySplitter.ProphySplitter ps = new NHDG.ProphySplitter.ProphySplitter();
                ps.PerformSplit(xmlPath);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error Splitting Procedures in frmProcessor.ProcessApexClaimBatch", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred splitting the procedures (for example, splitting D1110 into " +
                    "multiple procedures. Please report the following error to a system administrator: \n\n" + err.Message, "Error Splitting");
            }

            try
            {
                NHDG.ClaimCodeChanger.ClaimCodeChanger.Process(xmlPath);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error formatting codes in frmProcessor.ProcessApexClaimBatch", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred formatting the codes for the claim.\n\n" +
                    err.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                bool setDate = true;
                if (File.Exists(CLMFOLDER + APEXFILENAME))
                    setDate = false;
                else
                {
                    if (!Directory.Exists(CLMFOLDER))
                        Directory.CreateDirectory(CLMFOLDER);
                }

                NHDG.ApexEDI.ApexEDI.Process(xmlPath, ediPath);
                NHDG.ApexEDI.ApexEDI.Process(xmlPath, CLMFOLDER + APEXFILENAME);


                try
                {
                    if (setDate)
                        File.SetCreationTime(CLMFOLDER + APEXFILENAME, batchDate);
                    // currentBatch.batch_date = File.GetCreationTime(CLMFOLDER + APEXFILENAME);
                    // currentBatch.Save();
                }
                catch { }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("An error occurred transforming the file into ApexEDI format in frmProcessor.ProcessApexClaimBatch.", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred transforming the file into ApexEDI format.\n\n" +
                    err.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (C_DentalClaimTracker.Properties.Settings.Default.EclaimsOpenOutputAfterProcess)
                CommonFunctions.OpenDirectory(currentBatch.SaveFolder);

            if (apexErrors != string.Empty)
            {
                MessageBox.Show(this, "The following APEX claims had errors being processed and were not included in this batch:\n\n" +
                    apexErrors + "\n\nAll other claims were processed normally.", "Claim Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void frmProcessor_Load(object sender, EventArgs e)
        {
            if (!ActiveUser.UserObject.is_admin)
            {
                tbcMain.TabPages.Remove(tabSchema);
            }

            dtpPaidEndDate.Value = DateTime.Now;
            ctlUnusualPaymentEndDate.CurrentDate = DateTime.Now;
            dtpPaidStartDate.Value = DateTime.Now.AddDays(-30);
            ctlUnusualPaymentStartDate.CurrentDate = dtpPaidStartDate.Value;
            cmbGradStudents.SelectedIndex = 0;

            SearchPrimary(true);
            dgvResults.Select();
        }

        private bool InitializeConnection()
        {
            // Initialize stuff to actually process
            try
            {
                if (dbConnection.State != ConnectionState.Open)
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch(Exception ex)
            {
                cmdProcess.Enabled = false;
                return false;
            }
        }

        private void SearchPrimary(bool useMultiThreading)
        {
            maxResults = Convert.ToInt32(nmbMaxResultsMain.Value);
            if (useMultiThreading)
            {
                searchThread = new Thread(mainThreadStart);
                activeThreadID = searchThread.ManagedThreadId;
                searchThread.Start(BuildSQL());
            }
            else
                SearchThreadSafe(BuildSQL());
        }

        private void SearchThreadSafe(object searchSQL)
        {
            claim c = new claim();
            DataTable dt = c.Search((string) searchSQL);
            List<object[]> allData = new List<object[]>();
            UnsubmittedSearchResultList usrl = new UnsubmittedSearchResultList();
            currentSearchResultCount = dt.Rows.Count;

            foreach (DataRow aRow in dt.Rows)
            {
                if (Thread.CurrentThread.ManagedThreadId != activeThreadID)
                    return; 

                c = new claim();
                c.Load((int)aRow["id"]);
                string provider_info = GetProviderInfo(c, restrictions);;
                string batch_info = GetBatchInfo(c);

                if ((provider_info.Contains("(") && (chkHideClaimsWithProvSwitch.Checked)))
                {
                    // Don't add the row, we are hiding these rows
                }
                else
                {
                    usrl.Add(new UnsubmittedSearchResult(c.created_on, c.PatientLastNameCommaFirst, provider_info, c.claim_type_display(true), aRow["name"].ToString(),
                        c.amount_of_claim, c.handlingEmptyString, batch_info, c.claimidnum, c.claimdb, c));
                }

                if (usrl.Count > maxResults)
                {
                    break;
                }
            }

            dgvToUse = dgvResults;

            if (Thread.CurrentThread.ManagedThreadId != activeThreadID)
                return;
            else
                TouchupSearchResults(usrl);

        }

        private void TouchupSearchResults(UnsubmittedSearchResultList usrl)
        {
            if (dgvResults.InvokeRequired)
            {
                SearchDelegate sd = new SearchDelegate(TouchupSearchResults);
                Invoke(sd, new object[] { usrl });
            }
            else
            {
                bsUnsubmitted.DataSource = usrl;

                
                if (currentSearchResultCount <= maxResults)
                    lblMatchesFound.Text = string.Format("{0} matching claims", currentSearchResultCount);
                else
                    lblMatchesFound.Text = string.Format("{0}/{1} matching claims (MAX)", maxResults, currentSearchResultCount);

                lblAllClaimsWarning.Enabled = chkShowAllClaims.Checked;
                pnlHandling.Enabled = !chkShowAllClaims.Checked;
                cmdProcess.Enabled = !chkShowAllClaims.Checked;

                colMainClaimBatch.Visible = chkShowAllClaims.Checked;

                AutoMarkRows();

                if (dgvResults.SortedColumn != null)
                {
                    if (dgvResults.SortOrder == System.Windows.Forms.SortOrder.Descending)
                        dgvResults.Sort(dgvResults.SortedColumn, ListSortDirection.Descending);
                    else
                        dgvResults.Sort(dgvResults.SortedColumn, ListSortDirection.Ascending);
                }
            }
        }

        private string GetBatchInfo(claim forClaim)
        {
            string toReturn = "";
            foreach (claim_batch cb in forClaim.LinkedBatches())
            {
                toReturn += cb.id + ", ";
            }

            if (toReturn.Length > 0) // Remove final comma
                toReturn = toReturn.Substring(0, toReturn.Length - 2);

            return toReturn;
        }

        private void AddRows(DataGridView toAdd, List<object[]> allData)
        {
            dgvResults.Rows.Clear();
            foreach (object[] aRow in allData)
            {
                toAdd.Rows.Add(aRow);
            }
        }

        private string GetProviderInfo(claim c, List<provider_eligibility_restrictions> allRestrictions)
        {
            string provider_info = "";
            try
            {
                // Check for provider eligibility substitutions, add doctor name as ()
                provider_info = c.doctor_last_name;

                if (c.CheckForAddressOverride)
                    provider_info += string.Format(" ({0})", c.override_address_provider);
                else
                {
                    claim switchToClaim = provider_eligibility_restrictions.FindEligibilityRestrictions(c, allRestrictions);
                    if (switchToClaim != null)
                        provider_info += " (" + switchToClaim.doctor_provider_id + ")";
                }
                
                
            }
            catch { System.Diagnostics.Debug.WriteLine("Error getting provider info in process form."); }
            return provider_info;
        }

        /// <summary>
        /// Iterates through the rows, marking any rows with a handling method
        /// </summary>
        private void AutoMarkRows()
        {
            foreach (DataGridViewRow aRow in dgvResults.Rows)
            {
                if (CommonFunctions.DBNullToString(aRow.Cells[colMainHandling.Name].Value) == "Paper")
                    MarkRow(_paperRow, "Paper", aRow);
                else if (CommonFunctions.DBNullToString(aRow.Cells[colMainHandling.Name].Value) == "ApexEDI")
                    MarkRow(_apexRow, "ApexEDI", aRow);
                else if (CommonFunctions.DBNullToString(aRow.Cells[colMainHandling.Name].Value) == "ANS")
                    MarkRow(_ansRow, "ANS", aRow);
                else if (CommonFunctions.DBNullToString(aRow.Cells[colMainHandling.Name].Value) == "Mercury")
                    MarkRow(_mercuryRow, "Mercury", aRow);
            }
        }

        private void SearchPendingBatches()
        {
            dgvToUse = dgvPendingBatches;
            lblPendingBatches.Text = "Pending Batches (Searching...)";
            tbcMain.Enabled = false;
            InitializeHandledBatchesThreadSafe(BuildBatchSQL(), true);
        }

        private void InitializeHandledBatchesThreadSafe(string searchSQL, bool isPending)
        {
            dgvToUse.Rows.Clear();
            dgvToUse.SuspendLayout();

            if (isPending)
                handledBatchesThread = new Thread(pendingBatchesThreadStart);
            else
                handledBatchesThread = new Thread(paidBatchesThreadStart);

            handledBatchesThread.Start(searchSQL);
            handledBatchesThreadID = handledBatchesThread.ManagedThreadId;
        }


        private void InitializePendingBatches(object searchSQL)
        {
            claim_batch cb = new claim_batch();
            DataTable dt = cb.Search((string)searchSQL);
            List<object[]> allData = new List<object[]>();
            PendingSearchResultList psrl = new PendingSearchResultList();
            foreach (DataRow aRow in dt.Rows)
            {
                if (handledBatchesThreadID != Thread.CurrentThread.ManagedThreadId)
                    return;


                decimal amount = 0;
                string pendingClaimString;
                cb = new claim_batch();
                cb.Load((int)aRow["id"]);

                List<claim> allClaims = cb.GetMatchingClaims();
                string inString = string.Empty;
                foreach (claim aClaim in allClaims)
                {
                    inString += aClaim.id + ",";
                    amount += aClaim.amount_of_claim;
                }
                inString = inString.TrimEnd(",".ToCharArray());
                if (inString == string.Empty)
                {
                    pendingClaimString = "0/0";
                }
                else
                {
                    pendingClaimString = cb.Search("SELECT Count(*) FROM claims WHERE id IN ( " + inString +
                        ") AND [open] <> 1").Rows[0][0].ToString() + "/" + allClaims.Count;
                }

                psrl.Add(new PendingSearchResult(cb.id.ToString(), cb.batch_date.ToString("M-d-yyyy H:mm"), amount, cb.handling.ToString(), cb.batch_info, cb.server_name,
                    pendingClaimString, cb, allClaims));
            }

            if (handledBatchesThreadID != Thread.CurrentThread.ManagedThreadId)
                return;

            PendingSearchTouchup(psrl);
        }

        private void InitializePaidBatches(object searchSQL)
        {
            claim_batch cb = new claim_batch();
            DataTable dt = cb.Search((string)searchSQL);
            List<object[]> allData = new List<object[]>();
            PaidSearchResultList psrl = new PaidSearchResultList();
            foreach (DataRow aRow in dt.Rows)
            {
                if (handledBatchesThreadID != Thread.CurrentThread.ManagedThreadId)
                    return;
                

                string pendingClaimString;
                cb = new claim_batch();
                cb.Load((int)aRow["id"]);

                List<claim> allClaims = cb.GetMatchingClaims();
                string inString = string.Empty;
                foreach (claim aClaim in allClaims)
                {
                    inString += aClaim.id + ",";
                }
                inString = inString.TrimEnd(",".ToCharArray());

                if (inString == string.Empty)
                {
                    pendingClaimString = "0/0";
                }
                else
                {
                    pendingClaimString = cb.Search("SELECT Count(*) FROM claims WHERE id IN ( " + inString +
                        ") AND [open] <> 1").Rows[0][0].ToString() + "/" + allClaims.Count;
                }

                psrl.Add(new PaidSearchResult(cb.id.ToString(), cb.batch_date.ToString("M-d-yyyy H:mm"), cb.handling.ToString(), cb.batch_info, cb.server_name,
                    pendingClaimString, cb, allClaims));
            }

            if (handledBatchesThreadID != Thread.CurrentThread.ManagedThreadId) 
                return;

            PaidSearchTouchup(psrl);
        }

        private void PendingSearchTouchup(PendingSearchResultList psrl)
        {
            if (lblPendingBatches.InvokeRequired)
            {
                Invoke(new PendingTouchupDelegate(PendingSearchTouchup), new object[] { psrl});
            }
            else
            {
                bsPending.DataSource = psrl;
                FinalSearchTouchup(new List<object[]>());
            }
        }

        private void PaidSearchTouchup(PaidSearchResultList psrl)
        {
            if (lblPaidBatches.InvokeRequired)
            {
                Invoke(new PaidTouchupDelegate(PaidSearchTouchup), new object[] { psrl });
            }
            else
            {
                bsPaid.DataSource = psrl;
                FinalSearchTouchup(new List<object[]>());
            }
        }


        private void FinalSearchTouchup(List<object[]> allData)
        {
            if (lblPendingBatches.InvokeRequired)
            {
                Invoke(new TouchupDelegate(FinalSearchTouchup), new object[] { allData });
            }
            else
            {
                foreach (object[] toAdd in allData)
                    dgvToUse.Rows.Add(toAdd);

                if (dgvToUse.SortedColumn != null)
                {
                    if (dgvToUse.SortOrder == System.Windows.Forms.SortOrder.Descending)
                        dgvToUse.Sort(dgvToUse.SortedColumn, ListSortDirection.Descending);
                    else
                        dgvToUse.Sort(dgvToUse.SortedColumn, ListSortDirection.Ascending);
                }
                dgvToUse.ResumeLayout();

                lblPendingBatches.Text = "Pending Batches (" + dgvPendingBatches.Rows.Count + ")";
                lblPaidBatches.Text = "Paid Batches (" + dgvPaidBatches.Rows.Count + ")";
                lblMatchesFound.Text = "Unsubmitted claims (" + dgvResults.Rows.Count + ")";
                tbcMain.Enabled = true;
            }
        }

        private void SearchPaidBatches()
        {
            dgvToUse = dgvPaidBatches;
            lblPaidBatches.Text = "Paid Batches (Searching...)";
            tbcMain.Enabled = false;
            InitializeHandledBatchesThreadSafe(BuildPaidBatchSQL(), false);
        }

        private string BuildPaidBatchSQL()
        {
            string toReturn = "SELECT * FROM claim_batch WHERE id NOT IN " +
                "(SELECT batch_id FROM batch_claim_list WHERE claim_id IN " +
                "(SELECT id FROM claims WHERE [open] = 1)) AND batch_date > '" + dtpPaidStartDate.Value.ToShortDateString() +
                "' AND batch_date < '" + dtpPaidEndDate.Value.ToShortDateString() + "' ORDER BY batch_date";

            return toReturn;
        }

        private string BuildBatchSQL()
        {
            string toReturn = "SELECT * FROM claim_batch WHERE id IN " +
                "(SELECT batch_id FROM batch_claim_list WHERE claim_id IN " +
                "(SELECT id FROM claims WHERE [open] = 1)) ORDER BY batch_date desc";

            return toReturn;
        }

        /// <summary>
        /// Returns the SQL statement required to fetch the relevant data
        /// </summary>
        /// <returns></returns>
        private string BuildSQL()
        {
            string showAllClaims = "";

            if (!chkShowAllClaims.Checked)
                showAllClaims = "and c.id NOT IN (SELECT claim_ID FROM batch_claim_list WHERE still_in_batch = 1) "; 

            string toReturn = "SELECT c.id, cmp.name FROM claims c LEFT JOIN Companies cmp ON c.company_id = cmp.id";
            toReturn += " WHERE c.[open] = 1 " + showAllClaims +
            BuildAdditionalWhere() + " ORDER BY c.created_on, c.revisit_date desc, cmp.name";

            return toReturn;
        }

        #region Various "Where" related functions

        private string BuildAdditionalWhere()
        {
            string toReturn = string.Empty;

            if (cmbCompanyDropdown.Text != "")
            {

                string companyName = string.Empty;

                if (cmbCompanyDropdown.FindStringExact(cmbCompanyDropdown.Text) >= 0)
                    toReturn += BuildWhereSingle("cmp.name", cmbCompanyDropdown.Text, DataTypes.Text, DataObject.SearchTypes.Exact);
                else
                    toReturn += BuildWhereSingle("cmp.name", cmbCompanyDropdown.Text, DataTypes.Text);
            }

            toReturn += BuildWherePatientName(txtPatientName.Text, DataTypes.Text);
            toReturn += BuildWhereSingle("c.patient_dob", ctlPatientDOB.CurrentDateText, DataTypes.Date);
            if (CommonFunctions.IsNumeric(txtClaimAmount.Text))
            {
                // Have to multiply whatever they put in by 100, blech
                toReturn += BuildWhereSingle("c.amount_of_claim", (System.Convert.ToDecimal(txtClaimAmount.Text) * 100).ToString("#"), DataTypes.Numeric);
            }
            else
                txtClaimAmount.Text = "";
            toReturn += BuildWhereSingle("c.subscriber_group_number", txtGroupNum.Text, DataTypes.Text);
            toReturn += BuildWhereSingle("c.subscriber_group_name", txtGroupPlan.Text, DataTypes.Text);

            // Claim types (special rules for predeterm
            string typesString = "";

            if (chkPrimary.Checked)
                typesString += "c.claim_type = " + (int)claim.ClaimTypes.Primary;
            if (chkSecondary.Checked)
            {
                if (typesString != string.Empty)
                    typesString += " OR ";

                typesString += "c.claim_type = " + (int)claim.ClaimTypes.Secondary;
            }
            if (chkPredeterm.Checked)
            {
                if (typesString != string.Empty)
                    typesString += " OR ";

                
                    typesString += "c.claim_type = " + (int)claim.ClaimTypes.Predeterm + " OR c.claim_type = " +
                        (int)claim.ClaimTypes.SecondaryPredeterm;
            }

            if (typesString == "")
                typesString = "(c.claim_type = -1)";


            toReturn += " AND (" + typesString + ")";

            if (system_options.LimitPredetermsOnSearch)
             toReturn += " AND c.date_of_service > '" + CommonFunctions.ToMySQLDate(system_options.PredetermSearchDateMinimum) + "'";


            // DHKO - Additional code for obrien only
            if (cmbProviderID.SelectedIndex > 0)
                toReturn += BuildWhereSingle("c.doctor_provider_id", cmbProviderID.Text, DataTypes.Text);


            // Grad students
            if (cmbGradStudents.SelectedIndex == 0)
                toReturn += BuildWhereSingle("c.subscriber_group_number", Properties.Settings.Default.GradStudentGroupNum, DataTypes.Text, DataObject.SearchTypes.NotEqual);
            else if (cmbGradStudents.SelectedIndex == 1)
                toReturn += BuildWhereSingle("c.subscriber_group_number", Properties.Settings.Default.GradStudentGroupNum, DataTypes.Text, DataObject.SearchTypes.Exact);
            

                

                return toReturn;
        }

        private string BuildWherePatientName(string data, DataTypes dataTypes)
        {
            if (data == "")
                return "";
            else
            {
                string toReturn = " AND (";
                data = data.Replace(",", "");
                data = data.Replace("%", "");

                CommonFunctions.FormattedName formattedName = CommonFunctions.GetFormattedName(data);



                if (formattedName.LastName != "")
                {
                    toReturn += "((patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%')";
                    toReturn += " OR (patient_first_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'))";
                }
                else
                {
                    toReturn += "patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " OR patient_first_name LIKE '%" + data.Replace("'", "''") + "%'";
                    toReturn += " OR patient_last_name LIKE '%" + data.Replace("'", "''") + "%'";
                }

                toReturn += ")";

                return toReturn;
            }
        }

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="data"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string BuildWhereSingle(string colName, string data, DataTypes dt, DataObject.SearchTypes st)
        {
            if (data == "")
                return "";
            else
            {
                string safeData = data.Replace("'", "''");
                string toReturn = " AND ";

                if (dt == DataTypes.Text)
                {
                    if (st == DataObject.SearchTypes.Contains)
                        toReturn += colName + " LIKE '%" + safeData + "%'";
                    else if (st == DataObject.SearchTypes.BeginsWith)
                        toReturn += colName + " LIKE '" + safeData + "%'";
                    else if (st == DataObject.SearchTypes.NotEqual)
                        toReturn += string.Format("{0} <> '{1}'", colName, safeData);
                    else
                        toReturn += colName + " = '" + safeData + "'";
                }
                else if (dt == DataTypes.Numeric)
                {
                    if (st == DataObject.SearchTypes.NotEqual)
                        toReturn = string.Format("{0} <> {1}", colName, safeData);
                    else 
                        toReturn += colName + " = " + safeData;
                }
                else if (dt == DataTypes.Date)
                {
                    // Have to do special processing for the date
                    DateTime myDate = System.Convert.ToDateTime(safeData);
                    string dateWhere = "YEAR({colname}) = '" + myDate.Year + "' AND MONTH({colname}) = '" +
                        myDate.Month + "' AND DAY({colname}) = '" + myDate.Day + "'";
                    dateWhere = dateWhere.Replace("{colname}", colName);

                    toReturn += dateWhere;
                }


                return toReturn;
            }
        }

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="data"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string BuildWhereSingle(string colName, string data, DataTypes dt)
        {
            return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.Contains);
        }

        #endregion

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvSender = (DataGridView)sender;
            if (dgvSender.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell aCell in dgvSender.SelectedCells)
                {
                    dgvSender.Rows[aCell.RowIndex].Selected = true;
                }
            }
        }

        /// <summary>
        /// Marks selected rows as being handled as a certain type of row
        /// </summary>
        /// <param name="style"></param>
        /// <param name="text"></param>
        private void MarkSelectedRows(DataGridViewCellStyle style, string text)
        {
            foreach (DataGridViewRow aRow in dgvResults.SelectedRows)
            {
                MarkRow(style, text, aRow);
            }
        }

        /// <summary>
        /// Marks a specific row as being handled in a certain way
        /// </summary>
        /// <param name="style"></param>
        /// <param name="text"></param>
        /// <param name="aRow"></param>
        private void MarkRow(DataGridViewCellStyle style, string text, DataGridViewRow aRow)
        {
            aRow.DefaultCellStyle = style;
            aRow.Cells[colMainHandling.Name].Value = text;
            
            claim toSave = (claim) aRow.Cells[colMainClaimObject.Name].Value;
            toSave.handling = text;
            toSave.Save();
        }

        private void dgvResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Almost always captured at form level now, left for posterity

            if (e.KeyChar.ToString().ToUpper() == "R")
            {
                MarkSelectedRows(_paperRow, "Paper");
                MoveToNextLine();
            }
            else if (e.KeyChar.ToString().ToUpper() == "E")
            {
                MarkSelectedRows(_apexRow, "ApexEDI");
                MoveToNextLine();
            }
            else if (e.KeyChar.ToString().ToUpper() == "U")
            {
                MarkSelectedRows(_defaultRow, "");
                MoveToNextLine();
            }
            else if (e.KeyChar.ToString().ToUpper() == "V")
                ViewClaim();
            else if (e.KeyChar.ToString().ToUpper() == "M")
            {
                MarkSelectedRows(_mercuryRow, "Mercury");
                MoveToNextLine();
            }
        }

        private void MoveToNextLine()
        {
            if (dgvResults.SelectedRows.Count == 1)
            {
                int currentIndex = dgvResults.SelectedRows[0].Index;
                if (currentIndex < dgvResults.Rows.Count - 1)
                {
                    dgvResults.CurrentCell = dgvResults.Rows[currentIndex + 1].Cells[0];
                    dgvResults.Rows[currentIndex + 1].Selected = true;
                    dgvResults.Rows[currentIndex].Selected = false;

                }
            }
        }

        private void lnkEditSchema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbSchema.SelectedIndex >= 0)
            {
                data_mapping_schema toLoad;

                toLoad = (data_mapping_schema)cmbSchema.SelectedItem;
                frmConfigureSchema toShow = new frmConfigureSchema(toLoad);
                toShow.ShowDialog();


                InitializeSchemaList(toShow.SchemaName);
            }
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshResults();
            if (tbcMain.SelectedTab == tabUnsubmitted)
                AcceptButton = cmdApplyFilter;
            else if (tbcMain.SelectedTab == tabPending)
                AcceptButton = null;
            else if (tbcMain.SelectedTab == tabPaid)
                AcceptButton = cmdRefresh;
            else if (tbcMain.SelectedTab == tabUnusual)
                AcceptButton = cmdUnusualPaymentsSearch;
            else if (tbcMain.SelectedTab == tabSchema)
                AcceptButton = null;
        }

        private void RefreshResults()
        {
            if (tbcMain.SelectedTab == tabUnsubmitted)
            {
                SearchPrimary(true);
            }
            else if (tbcMain.SelectedTab == tabPending)
            {
                SearchPendingBatches();
            }
            else if (tbcMain.SelectedTab == tabPaid)
            {
                SearchPaidBatches();
            }
            else if (tbcMain.SelectedTab == tabUnusual)
                SearchUnusualPayAmounts();
            else if (tbcMain.SelectedTab == tabSchema)
            {
            }
        }

       


        private void SearchUnusualPayAmounts()
        {
            if (SearchDatesValid())
            {
                dgvUnusualClaims.Rows.Clear();
                lblUnusualPayAmountClaims.Text = "Claims with an Unusual Pay amount (Searching...)";
                tbcMain.Enabled = false;


                SearchUnusualPayAmountsThreadSafe(new object[] { chkShowVerifiedClaims.Checked, ctlUnusualPaymentStartDate.CurrentDate.Value.ToShortDateString(), 
                                    ctlUnusualPaymentEndDate.CurrentDate.Value.ToShortDateString() });
                /*
                            ParameterizedThreadStart ts = new ParameterizedThreadStart(SearchUnusualPayAmountsThreadSafe);
            
                                if (t.IsAlive)
                                    t.Abort();

                                t = new Thread(ts);
                                t.Start(new object[] { chkShowVerifiedClaims.Checked, ctlUnusualPaymentStartDate.CurrentDate.Value.ToShortDateString(), 
                                    ctlUnusualPaymentEndDate.CurrentDate.Value.ToShortDateString() });
                             */
            }
        }

        private void SearchUnusualPayAmountsThreadSafe(object showVerifiedClaims)
        {
            List<object[]> toAdd = new List<object[]>();
            OleDbConnection oConnect;
            try
            {
                try
                {
                    oConnect = new OleDbConnection(dms.GetConnectionString(true));
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error in frmProcessor.SearchUnusualPaymentAmountsThreadSafe. No DB connection.", LogSeverity.Error, err, false);
                    MessageBox.Show("There was an error creating the database connection.\n\n" + err.Message);
                    return;
                }


                DataTable unusualData = new DataTable();
                OleDbDataAdapter oAdapter;
                // Use Connection object for the DataAdapter to retrieve all tables from selected Database
                try
                {
                    oConnect.Open();
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error in frmProcessor.SearchUnusualPaymentAmountsThreadSafe. Could not connect to DB.", LogSeverity.Error, err, false);
                    MessageBox.Show(this, "Could not connect to the database.\n\n" + err.Message,
                        "Error retrieving data");
                    return;

                }
                try
                {
                    string sql = BuildUnusualPayAmountSQL(((object[])showVerifiedClaims)[1].ToString(),
                        ((object[])showVerifiedClaims)[2].ToString());

                    if (sql != "")
                    {

                        oAdapter = new OleDbDataAdapter(sql, oConnect);
                        oAdapter.SelectCommand.CommandTimeout = 300;
                        oAdapter.Fill(unusualData);

                        bool showVerified = (bool)((object[])showVerifiedClaims)[0];

                        foreach (DataRow aRow in unusualData.Rows)
                        {
                            // Check for a local copy of the claim
                            int localID = 0;
                            claim localClaim = new claim();

                            bool not_verified = true;

                            DataTable claimMatches = localClaim.Search("SELECT * FROM claims WHERE claimidnum = '" + aRow["claimid"] +
                                "' AND claimdb = '" + aRow["claimdb"] + "'");
                            if (claimMatches.Rows.Count > 0)
                            {
                                localClaim = new claim();
                                localClaim.Load(claimMatches.Rows[0]);
                                localID = localClaim.id;
                            }
                            else
                                localClaim = null;

                            // Check for notes for this claim
                            string noteText = "";
                            bad_payment_claims bpc = new bad_payment_claims();
                            if (!bpc.CheckLoad(aRow["claimid"].ToString(), aRow["claimdb"].ToString()))
                                bpc = null;
                            else
                            {

                                not_verified = !bpc.is_verified;
                                noteText = bpc.notes;
                            }

                            bool addRow;
                            bool colorRow;

                            if (not_verified)
                            {
                                addRow = true;
                                colorRow = false;
                            }
                            else
                            {
                                if (!showVerified)
                                {
                                    addRow = false;
                                    colorRow = false;
                                }
                                else
                                {
                                    addRow = true;
                                    colorRow = true;
                                }
                            }

                            if (addRow)
                            {
                                toAdd.Add(new object[] { localID > 0, aRow["Date Received"], aRow["LastName"].ToString() + ", " + aRow["FirstName"].ToString(),
                                    ConvertType(aRow["Type"].ToString()), aRow["Carrier"].ToString(), 
                                    NHDG.NHDGCommon.Utilities.FormatCurrency((int) aRow["Amount"]), NHDG.NHDGCommon.Utilities.FormatCurrency((int) aRow["TOTALRECEIVED"]), 
                                    noteText, localClaim, aRow["claimid"], aRow["claimDB"], bpc, colorRow});
                            }
                        }
                    }


                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error in SQL statement or connection in frmProcessor.SearchUnusualPaymentAmountsThreadSafe", LogSeverity.Error, err, false);
                    MessageBox.Show("There was an error with your SQL statement or with your connection.\n\n" + err.Message,
                        "Error retrieving data");
                    return;
                }
                TouchupUnusualBatches(toAdd);

            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error occurred searching for unusual pay amounts in frmProcessor.SearchUnusualPayAmountsThreadSafe.", LogSeverity.Error, err, false);
                MessageBox.Show("An unexpected error occurred searching for unusual pay amounts.\n\n" + err.Message);
            }
        }

        /// <summary>
        /// Looks at the unusual pay amounts table and creates the where section of a sql statement for it
        /// </summary>
        /// <returns></returns>
        private string BuildUnusualPayAmountSQL(string startDate, string endDate)
        {
            string baseSQL =
                "SELECT claim.claimID, claim.claimDB, datereceived as 'Date Received', LastName, FirstName, claim.INSType as 'Type'," +
                         " insconame AS 'Carrier', totalbilled as 'Amount', dateofclaim, totalreceived" +
                          " FROM DDB_CLAIM claim" +
                          " INNER JOIN DDB_PAT ON claim.PATID = DDB_PAT.PATID AND claim.PATDB = DDB_PAT.PATDB" +
                          " INNER JOIN DDB_INSURANCE ON claim.INSID = DDB_INSURANCE.INSID AND claim.INSDB = DDB_INSURANCE.INSDB" +
                          " INNER JOIN DDB_PROC_LOG proc_log ON claim.CLAIMID = proc_log.CLAIMID AND claim.CLAIMDB = proc_log.CLAIMDB" +
                          " INNER JOIN dbo.DDB_PROC_CODE proc_code ON proc_log.PROC_CODEID = proc_code.PROC_CODEID AND  proc_log.PROC_CODEDB = proc_code.PROC_CODEDB" +
                          " WHERE dateofclaim > '" + startDate +
                          "' AND dateofclaim < '" + endDate +
                          "' [REPLACEWHERE] " +
                          " AND datereceived > 1/1/1754 ";

            string returnSQL = "";

            unusual_payment_rules upr = new unusual_payment_rules();
            DataTable allPayAmounts = upr.Search(upr.SearchSQL + " ORDER BY order_id");

            foreach (DataRow aRule in allPayAmounts.Rows)
            {
                // column name - TOTALRECEIVED
                if (returnSQL == "")
                    returnSQL = baseSQL;
                else
                    returnSQL += " UNION " + baseSQL;
                upr.Load(aRule);
                string thisSQL = " AND (";

                if (upr.process_code != "")
                {
                    thisSQL += "proc_code.ADACODE IN ('" + upr.process_code + "') AND ";
                }



                string op = "";

                switch (upr.operator_code)
                {
                    case unusual_payment_rules.OperatorCodes.EqualTo:
                        op = "= ";
                        break;
                    case unusual_payment_rules.OperatorCodes.GreaterThan:
                        op = "> ";
                        break;
                    case unusual_payment_rules.OperatorCodes.LessThan:
                        op = "< ";
                        break;
                }


                if (upr.amount_type_code == unusual_payment_rules.AmountTypeCodes.Dollars)
                {
                    thisSQL += "TOTALRECEIVED " + op;
                }
                else
                {
                    // get the percentage
                    // Colname - TOTALBILLED

                    thisSQL += "(TOTALRECEIVED / TOTALBILLED) * 100 " + op;
                }

                thisSQL += upr.amount;


                thisSQL += ")";

                returnSQL = returnSQL.Replace("[REPLACEWHERE]", thisSQL); ;
            }

            if (returnSQL != "")
                returnSQL += " ORDER BY dateofclaim";

            return returnSQL;
        }

        private void TouchupUnusualBatches(List<object[]> allData)
        {
            if (dgvUnusualClaims.InvokeRequired)
            {
                TouchupDelegate td = new TouchupDelegate(TouchupUnusualBatches);
                Invoke(td, new object[] { allData });
            }
            else
            {
                dgvUnusualClaims.SuspendLayout();
                foreach (object[] aRow in allData)
                {
                    dgvUnusualClaims.Rows.Add(aRow);
                    if ((bool)aRow[12])
                        dgvUnusualClaims.Rows[dgvUnusualClaims.Rows.Count - 1].DefaultCellStyle = _verifiedRow;
                }
                dgvUnusualClaims.ResumeLayout();
                lblUnusualPayAmountClaims.Text = "Claims with an Unusual Pay amount (" + dgvUnusualClaims.Rows.Count + ")";
                tbcMain.Enabled = true;
            }
        }


        private object ConvertType(string p)
        {
            if (p == "0")
                return "PRIMARY";
            else
                return "SECONDARY";
        }

        private bool SearchDatesValid()
        {
            string errorMessage = string.Empty;
            if (!ctlUnusualPaymentStartDate.CurrentDate.HasValue)
                errorMessage = "Please enter a value in the 'Start Date' box.";
            else if (!ctlUnusualPaymentEndDate.CurrentDate.HasValue)
                errorMessage = "Please enter a value in the 'End Date' box.";
            else if (ctlUnusualPaymentStartDate.CurrentDate.Value > ctlUnusualPaymentEndDate.CurrentDate.Value)
                errorMessage = "Please enter a start date that is before the end date.";


            if (errorMessage != string.Empty)
            {
                MessageBox.Show(this, errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }


        private void ShowSelectedBatch()
        {
            dgvClaimsInPendingBatch.SuspendLayout();
            dgvClaimsInPendingBatch.Rows.Clear();
            if (dgvPendingBatches.SelectedRows.Count > 0)
            {
                List<object[]> allRows = new List<object[]>();
                foreach (claim c in (List<claim>)dgvPendingBatches.SelectedRows[0].Cells[colClaimList.Name].Value)
                {
                    object[] aRow = new object[] { c.created_on, c.PatientLastNameCommaFirst, 
                        GetProviderInfo(c, restrictions), c.claim_type_display(true), c.LinkedCompany.name, 
                        c.amount_of_claim, ConvertToPaidUnpaid(c.open), 
                        GetLastDate(c), 
                        GetCurrentBatch(c),
                        
                        c.claimidnum, c.claimdb, c };

                    allRows.Add(aRow);
                }

                foreach (object[] aRow in allRows)
                {
                    dgvClaimsInPendingBatch.Rows.Add(aRow);    
                }
            }
            dgvClaimsInPendingBatch.ResumeLayout();
        }

        private string GetCurrentBatch(claim c)
        {
            DataTable getMatch = c.Search("SELECT * FROM claim_batch cb" +
                " LEFT JOIN batch_claim_list bcl ON cb.id = bcl.batch_id" +
                " WHERE claim_id = " + c.id +
                " ORDER BY last_send_date desc");

            if (getMatch.Rows.Count > 0)
            {
                object val = getMatch.Rows[0][0];
                if ((val == DBNull.Value) || (val.ToString() == ""))
                    return "";
                else
                    return val.ToString();

            }
            else
                return "";
        }

        private string GetLastDate(claim c)
        {
            DataTable getMatch = c.Search("SELECT last_send_date FROM batch_claim_list WHERE" +
                " claim_id = " + c.id + " ORDER by last_send_date desc");

            if (getMatch.Rows.Count > 0)
            {
                object val = getMatch.Rows[0][0];
                if ((val == DBNull.Value) || (val.ToString() == ""))
                    return "";
                else
                {

                    try
                    {
                        return Convert.ToDateTime(val).ToShortDateString();
                    }
                    catch
                    {
                        return "";
                    }
                }

            }
            else
                return "";
        }

        private string ConvertToPaidUnpaid(int p)
        {
            if (p == 1)
                return "Unpaid";
            else
                return "Paid";
        }

        private void ViewClaim()
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                /* Used for viewing claims as a set, discarded in favor of 
                the old "Next Claim" functionality. */
                List<claim> lc = new List<claim>();
                try
                {
                    foreach (DataGridViewRow aRow in dgvResults.Rows)
                    {
                        lc.Add((claim)aRow.Cells[colMainClaimObject.Name].Value);
                    }



                    frmClaimManager toShow = new frmClaimManager(false, lc, (claim)dgvResults.SelectedRows[0].Cells[colMainClaimObject.Name].Value);


                    // frmClaimManager toShow = new frmClaimManager((claim)dgvResults.SelectedRows[0].Cells["colClaimObject"].Value, true);

                    int X = C_DentalClaimTracker.Properties.Settings.Default.EclaimsViewClaimsX;
                    int Y = C_DentalClaimTracker.Properties.Settings.Default.EclaimsViewClaimsY;

                    if (IsOnScreen(X + 20, Y + 20))
                    {
                        toShow.StartPosition = FormStartPosition.Manual;
                        toShow.Left = X;
                        toShow.Top = Y;
                    }

                    toShow.Show();
                }
                catch(Exception err)
                {
                    MessageBox.Show(this, "An unexpected error occurred showing the claim.\n\n" + err.Message);
                }
            }
        }

        public bool IsOnScreen(int X, int Y)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Point formTopLeft = new Point(X, Y);

                if (screen.WorkingArea.Contains(formTopLeft))
                {
                    return true;
                }
            }

            return false;
        }


        private void ShowSelectedPaidBatch()
        {
            dgvPaidBatchClaims.Rows.Clear();
            if (dgvPaidBatches.SelectedRows.Count > 0)
            {
                foreach (claim c in (List<claim>)dgvPaidBatches.SelectedRows[0].Cells[colPaidClaimList.Name].Value)
                {
                    dgvPaidBatchClaims.Rows.Add(new object[] { c.created_on, c.PatientLastNameCommaFirst, 
                        GetProviderInfo(c, restrictions), c.claim_type_display(true), c.LinkedCompany.name, 
                        c.amount_of_claim, ConvertToPaidUnpaid(c.open), c.claimidnum, c.claimdb, c });
                }
            }
        }

        private void dgvBatchesForClaim_MouseUp(object sender, MouseEventArgs e)
        {
            // Load context menu on right mouse click
            DataGridView.HitTestInfo hitTestInfo;
            if (e.Button == MouseButtons.Right)
            {
                hitTestInfo = dgvClaimsInPendingBatch.HitTest(e.X, e.Y);
                // If column is first column
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    dgvClaimsInPendingBatch.Rows[hitTestInfo.RowIndex].Cells[0].Selected = true;
                    ctextProcessedClaims.Show(dgvClaimsInPendingBatch, new Point(e.X, e.Y));
                }
            }
        }

        private void ViewPendingSelectedClaims()
        {
            if (dgvClaimsInPendingBatch.SelectedRows.Count > 0)
            {
                claim selectedClaim;

                selectedClaim = (claim)dgvClaimsInPendingBatch.SelectedRows[0].Cells[colClaimInBatchClaim.Name].Value;

                frmClaimManager toShow = new frmClaimManager(selectedClaim, false);
                toShow.Show();
            }
        }

        private void ResubmitClaims(HandlingTypes handlingTypes)
        {
            string closedClaims = string.Empty;
            claim_batch currentBatch = (claim_batch)dgvPendingBatches.SelectedRows[0].Cells[colPendingBatchesBatch.Name].Value;
            foreach (DataGridViewRow aClaim in dgvClaimsInPendingBatch.SelectedRows)
            {
                claim thisClaim = (claim)aClaim.Cells[colClaimInBatchClaim.Name].Value;

                if (thisClaim.open == 1)
                {
                    // Remove the claim from the batch
                    currentBatch.ExecuteNonQuery("UPDATE batch_claim_list SET still_in_batch = false WHERE " +
                        "claim_id = " + thisClaim.id +
                        " AND batch_id = " + currentBatch.id);                    

                    thisClaim.handling = "";
                    thisClaim.Save();
                }
                else
                {
                    closedClaims += "\n" + thisClaim.created_on.Value.ToShortDateString() + ", " +
                             thisClaim.PatientLastNameCommaFirst + "; " + thisClaim.LinkedCompany.name;
                }
            }

            int selectedBatch = dgvPendingBatches.SelectedRows[0].Index;

            if (closedClaims != string.Empty)
            {
                MessageBox.Show(this, "The following claims have already been paid and cannot be resubmitted:\n" + closedClaims,
                    "Closed Claims", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // At the end, refresh display of data
            SearchPendingBatches();

            try
            {
                dgvPendingBatches.Rows[selectedBatch].Selected = true;
            }
            catch { }
        }

        private void DeleteBatch()
        {
            if (dgvPendingBatches.SelectedRows.Count > 0)
            {
                bool okToDelete = false;



                if (((List<claim>)dgvPendingBatches.SelectedRows[0].Cells[colClaimList.Name].Value).Count == 0)
                    okToDelete = true;
                else
                {
                    bool hasPaidClaims = false;

                    foreach (claim aClaim in (List<claim>)dgvPendingBatches.SelectedRows[0].Cells[colClaimList.Name].Value)
                    {
                        if (aClaim.open != 1)
                        {
                            hasPaidClaims = true;
                            break;
                        }
                    }
                    if (hasPaidClaims) // has no unPaid claims
                    {
                        MessageBox.Show(this, "This batch cannot be deleted, some of the claims in it have already been paid.", "Batch has paid claims");
                    }
                    else if (MessageBox.Show(this, "Are you sure you want to delete this batch? All claims inside of it will be marked 'Unclassified'.",
                    "Delete Batch?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        okToDelete = true;

                }


                if (okToDelete)
                {
                    ((claim_batch)dgvPendingBatches.SelectedRows[0].Cells[colPendingBatchesBatch.Name].Value).Delete();
                    SearchPendingBatches();
                }
            }
        }

        private void PrintMainSelectedClaims()
        {
            List<claim> toPrint = new List<claim>();

            foreach (DataGridViewRow aRow in dgvResults.SelectedRows)
            {
                toPrint.Add((claim)aRow.Cells[colMainClaimObject.Name].Value);
            }

            if (toPrint.Count > 0)
            {
                if (InitializeConnection())
                    C_DentalClaimTracker.ClaimTrackerCommon.PrintClaims(toPrint, dbConnection);
                else
                    MessageBox.Show("Unable to connect to Dentrix to print claim.", "No connection to Dentrix", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
        }

        private void printClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPendingSelectedClaims();
        }

        private void PrintPendingSelectedClaims()
        {
            List<claim> toPrint = new List<claim>();

            foreach (DataGridViewRow aRow in dgvClaimsInPendingBatch.SelectedRows)
            {
                toPrint.Add((claim)aRow.Cells[colClaimInBatchClaim.Name].Value);
            }

            if (toPrint.Count > 0)
            {
                if (InitializeConnection())
                {
                    C_DentalClaimTracker.ClaimTrackerCommon.PrintClaims(toPrint, dbConnection);
                    dbConnection.Close();
                }
                else
                    MessageBox.Show("Unable to connect to Dentrix to print claim.", "No connection to Dentrix", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
        }

        #region Generic Boring Events

        private void cmdDeleteBatch_Click(object sender, EventArgs e)
        {
            DeleteBatch();
        }

        private void cmdPendingPrint_Click(object sender, EventArgs e)
        {
            PrintPendingSelectedClaims();
        }

        private void cmdPendingView_Click(object sender, EventArgs e)
        {
            ViewPendingSelectedClaims();
        }

        private void cmdPendingUnclassified_Click(object sender, EventArgs e)
        {
            ResubmitClaims(HandlingTypes.Unclassified);
        }

        private void cmdMainPrintClaim_Click(object sender, EventArgs e)
        {
            PrintMainSelectedClaims();
        }

        private void cmdMarkMainPaper_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_paperRow, "Paper");
        }

        private void cmdMarkMainApexEDI_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_apexRow, "ApexEDI");
        }

        private void cmdMarkMainANS_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_ansRow, "ANS");
        }

        private void cmdMarkMainUnclassified_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_defaultRow, "");
        }

        private void cmdMainViewClaim_Click(object sender, EventArgs e)
        {
            ViewClaim();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintMainSelectedClaims();
        }

        private void mnuDeleteBatch_Click(object sender, EventArgs e)
        {
            DeleteBatch();
        }



        private void paperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_paperRow, "Paper");
        }

        private void apexEDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_apexRow, "ApexEDI");
        }

        private void aNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_ansRow, "ANS");
        }

        private void mnuProcessOptionUnclassified_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_defaultRow, "");
        }

        private void dgvPendingBatches_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView_SelectionChanged(sender, e);
            ShowSelectedBatch();

            bool isApex = SelectedPendingBatchIsApex();

            cmdViewOutput.Enabled = isApex;
            mnuReprocess.Enabled = isApex;
        }


        private void viewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewClaim();
        }

        private void paperToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvResults.SelectAll();
            MarkSelectedRows(_paperRow, "Paper");
        }

        private void apexEDIToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvResults.SelectAll();
            MarkSelectedRows(_apexRow, "ApexEDI");
        }

        private void aNSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvResults.SelectAll();
            MarkSelectedRows(_ansRow, "ANS");
        }

        private void unclassifiedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvResults.SelectAll();
            MarkSelectedRows(_defaultRow, "");
        }

        private void dgvPaidBatches_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView_SelectionChanged(sender, e);
            ShowSelectedPaidBatch();
        }

        private void mnuClaimsInBatchViewClaim_Click(object sender, EventArgs e)
        {
            ViewPendingSelectedClaims();
        }

        private void unclassifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResubmitClaims(HandlingTypes.Unclassified);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            SearchPaidBatches();
        }
        private void mnuReprocess_Click(object sender, EventArgs e)
        {
            ResendProcessedClaims();
        }
        private void cmdResend_Click(object sender, EventArgs e)
        {
            ResendProcessedClaims();
            RefreshResults();
        }
        private void cmdViewOutput_Click(object sender, EventArgs e)
        {
            ViewPendingBatchOutput();
        }

        private void mnuOpenBatchOutput_Click(object sender, EventArgs e)
        {
            ViewPendingBatchOutput();
        }

        #endregion

        /// <summary>
        /// Reprocess the selected pending claims, re-adding their information to the apex.clm file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResendProcessedClaims(bool asApex = true)
        {

            if (dgvClaimsInPendingBatch.SelectedRows.Count > 0)
            {
                List<claim> processedClaims = new List<claim>();
                

                foreach (DataGridViewRow aClaim in dgvClaimsInPendingBatch.SelectedRows)
                {
                    claim thisClaim = (claim)aClaim.Cells[colClaimInBatchClaim.Name].Value;

                    processedClaims.Add(thisClaim);
                    thisClaim.SetResendStatus();
                    ActiveUser.LogAction(ActiveUser.ActionTypes.ResendClaim, thisClaim.id, "Apex Resend");
                }

                if (asApex)
                    ProcessClaimsList(processedClaims, claim_batch.GetApexResendBatchForToday(), true);
                else
                    ProcessClaimsList(processedClaims, claim_batch.GetMercuryResendBatchForToday(), true, false);
            }
        }

        public void ResendClaimApex(claim toResend)
        {
            try
            {
                List<claim> claimList = new List<claim>();
                claimList.Add(toResend);

                ProcessClaimsList(claimList, claim_batch.GetApexResendBatchForToday(), true);
            }
            catch (Exception ex)
            {
                LoggingHelper.Log(ex);
            }
        }

        public void ResendClaimsListApex(List<claim> toResend)
        {
            ProcessClaimsList(toResend, claim_batch.GetApexResendBatchForToday(), true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toProcess"></param>
        /// <param name="currentBatch"></param>
        public void ProcessClaimsList(List<claim> toProcess, claim_batch currentBatch, bool isResend, bool isApex = true)
        {
            NHDG.NHDGCommon.Claims.ClaimBatch cb = new NHDG.NHDGCommon.Claims.ClaimBatch();
            string apexErrors = string.Empty;
            List<claim> errorClaims = new List<claim>();

            SqlTransaction trans;
            try
            {
                try
                {
                    if (InitializeConnection())
                        trans = dbConnection.BeginTransaction();
                    else
                    {
                        LoggingHelper.Log("Dentrix DB connection failed in frmProcessor.ProcessClaims List", LogSeverity.Error);
                        throw new Exception("Dentrix DB Connection failed");
                    }
                }
                catch(Exception err)
                {
                    LoggingHelper.Log("No connection to Dentrix DB in frmProcessor.ProcessClaimsList.", LogSeverity.Error, err, false);
                    MessageBox.Show(this, "Could not connect to Dentrix DB to begin processing. Verify your database connection settings are correct.");
                    return;
                }

                foreach (claim thisClaim in toProcess)
                {
                    NHDG.NHDGCommon.Claims.Claim c;
                    try
                    {
                        c = new NHDG.NHDGCommon.Claims.Claim(thisClaim, trans, true, true);
                        cb.Claims.Add(c);

                        if (!isApex)
                        {
                            Dictionary<string, string> payerInfo = GetMercuryPayerID(c);
                            if (payerInfo != null)
                            {
                                thisClaim.payer_id = payerInfo["id"];
                                thisClaim.payer_name = payerInfo["name"];
                            }
                            thisClaim.Save();
                        }
                    }
                    catch
                    {
                        apexErrors += "\n" + thisClaim.created_on.Value.ToShortDateString() + ", " +
                            thisClaim.PatientLastNameCommaFirst + "; " + thisClaim.LinkedCompany.name;

                        errorClaims.Add(thisClaim);

                    }
                }
                trans.Commit();

                foreach (claim aClaim in errorClaims)
                    toProcess.Remove(aClaim);

                if (isApex)
                    ProcessApexClaimBatch(cb, apexErrors, toProcess, currentBatch, isResend);
                else
                    ProcessMercuryClaimBatch(cb, apexErrors, toProcess, currentBatch, isResend);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error processing batch in frmProcessor.ProcessClaimsList", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An unexpected error occurred reprocessing the claim or claim batch.\n\n" + err.Message);
            }
        }

        private bool SelectedPendingBatchIsApex()
        {
            bool toReturn = false;
            if (dgvPendingBatches.SelectedRows.Count > 0)
                if (((claim_batch) dgvPendingBatches.SelectedRows[0].Cells[colPendingBatchesBatch.Index].Value).handling == clsClaimEnums.SentMethods.ApexEDI)
                    toReturn = true;

            return toReturn;
        }

        private void ViewPendingBatchOutput()
        {
            if (SelectedPendingBatchIsApex())
            {
                string fPath = ((claim_batch)dgvPendingBatches.SelectedRows[0].Cells[colPendingBatchesBatch.Name].Value).SaveFolder;

                if (Directory.Exists(fPath))
                {
                    CommonFunctions.OpenDirectory(fPath);
                }
                else
                    MessageBox.Show(this, "The output file for the selected batch could not be found on this machine. It has been moved " +
                        "or the batch was not created at this computer.", "Batch output not found");
            }
        }

        private void cmdApplyFilter_Click(object sender, EventArgs e)
        {
            RefreshResults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchUnusualPayAmounts();
        }

        private void cmdViewUnusualClaim_Click(object sender, EventArgs e)
        {
            OpenUnusualClaim();
        }

        private void OpenUnusualClaim()
        {
            if (dgvUnusualClaims.SelectedRows.Count > 0)
            {
                DataGridViewRow aRow = dgvUnusualClaims.SelectedRows[0];
                if (aRow.Cells[colLocalClaim.Name].Value != null)
                {
                    claim toLoad = (claim)aRow.Cells[colLocalClaim.Name].Value;
                    // There is a local id, open the claim
                    frmClaimManager toShow = new frmClaimManager(toLoad);
                    toShow.Show();
                }
            }
        }

        private void cmdEditNotes_Click(object sender, EventArgs e)
        {
            EditUnusualClaimNotes();
        }

        private void EditUnusualClaimNotes()
        {
            if (dgvUnusualClaims.SelectedRows.Count > 0)
            {
                DataGridViewRow aRow = dgvUnusualClaims.SelectedRows[0];
                bad_payment_claims toView;
                if (aRow.Cells[colBadPaymentClaim.Name].Value != null)
                {
                    // Already exists, show current
                    toView = (bad_payment_claims)aRow.Cells[colBadPaymentClaim.Name].Value;
                }
                else
                {
                    toView = new bad_payment_claims();
                    toView.claimid = aRow.Cells[colExternalClaimID.Name].Value.ToString();
                    toView.claimdb = aRow.Cells[colExternalDBID.Name].Value.ToString();
                    toView.is_verified = false;
                    toView.Save();
                }

                frmBadPaymentClaimViewer toShow = new frmBadPaymentClaimViewer(toView, ((DateTime)aRow.Cells[colDate.Name].Value).ToShortDateString(), aRow.Cells[colPatientName.Name].Value.ToString(),
                    aRow.Cells[colCarrier.Name].Value.ToString(), aRow.Cells[colAmount.Name].Value.ToString(), "0");
                if (toShow.ShowDialog() == DialogResult.OK)
                {
                    dgvUnusualClaims.SelectedRows[0].Cells[colBadPaymentClaim.Name].Value = toShow.FormClaim;
                    dgvUnusualClaims.SelectedRows[0].Cells[colNotes.Name].Value = toShow.Notes;

                    if (toShow.FormClaim.is_verified)
                    {
                        dgvUnusualClaims.SelectedRows[0].DefaultCellStyle = _verifiedRow;
                    }
                }
            }
        }

        private void cmdPrintUnusualClaim_Click(object sender, EventArgs e)
        {
            PrintUnusualClaims();
        }

        private void PrintUnusualClaims()
        {
            MessageBox.Show("This doesn't work yet.");
        }

        private void mnuPrintUnusualClaim_Click(object sender, EventArgs e)
        {
            PrintUnusualClaims();
        }

        private void mnuViewUnusualClaim_Click(object sender, EventArgs e)
        {
            OpenUnusualClaim();
        }

        private void mnuEditUnusualClaimNotes_Click(object sender, EventArgs e)
        {
            EditUnusualClaimNotes();
        }

        private void lnkOpenCLM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Directory.Exists(CLMFOLDER))
                {
                    CommonFunctions.OpenDirectory(CLMFOLDER);
                }
                else
                {
                    if (ActiveUser.UserObject.is_admin)
                        MessageBox.Show(this, "The path '" + CLMFOLDER + "' does not exist. As an administrator, you can change this in the administrative menu.");

                    else
                        MessageBox.Show(this, "The .clm folder does not exist or is not correctly set. Please speak to a system administrator to correct this problem.");
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not access folder in frmProcessor.lnkOpenCLM_LinkClicked", LogSeverity.Error, err, false);
                MessageBox.Show(this, "The system returned an error trying to access the specified folder. The error returned is:\n\n" + err.Message);
            }
        }

        private void lnkGotoApex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmApexBrowser toShow = new frmApexBrowser();
                toShow.ShowDialog();


                // System.Diagnostics.Process.Start(C_DentalClaimTracker.Properties.Settings.Default.ApexSiteURL);
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not open site on process claims form", LogSeverity.Error, err, false);
                MessageBox.Show("The site could not be opened. The error returned was:\n\n" + err.Message);
            }
        }

        private void cmbSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSchema.SelectedIndex >= 0)
                dms = (data_mapping_schema)cmbSchema.SelectedItem;
        }

        private void panel10_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvResults_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewClaim();
        }

        /// <summary>
        /// Call this method after saving a handling type to a claim from another form. If the claim is currently being displayed
        /// it will update the display.
        /// </summary>
        /// <param name="toMark"></param>
        public void MarkClaimHandled(claim toMark)
        {
            if (tbcMain.SelectedTab == tabUnsubmitted)
            {
                DataGridViewRow markingRow = FindRow(toMark);

                if (toMark != null)
                {
                    if (toMark.handling == "Paper")
                        MarkRow(_paperRow, "Paper", FindRow(toMark));
                    else if (toMark.handling == "ApexEDI")
                        MarkRow(_apexRow, "ApexEDI", FindRow(toMark));
                    else if (toMark.handling == "Unclassified")
                        MarkRow(_defaultRow, "Unclassified", FindRow(toMark));
                    else if (toMark.handling == "Mercury")
                        MarkRow(_mercuryRow, "Mercury", FindRow(toMark));
                }
            }
        }

        private DataGridViewRow FindRow(claim toMark)
        {
            DataGridViewRow toReturn = null;

            foreach (DataGridViewRow aRow in dgvResults.Rows)
            {
                claim toCheck = (claim)aRow.Cells[colMainClaimObject.Name].Value;

                if (toCheck.id == toMark.id)
                {
                    toReturn = aRow;
                    break;
                }
            }

            return toReturn;
        }

        private void frmProcessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvResults.Focused)
            {

                if (e.KeyChar.ToString().ToUpper() == "R")
                {
                    MarkSelectedRows(_paperRow, "Paper");
                    MoveToNextLine();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "E")
                {
                    MarkSelectedRows(_apexRow, "ApexEDI");
                    MoveToNextLine();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "U")
                {
                    MarkSelectedRows(_defaultRow, "");
                    MoveToNextLine();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "M")
                {
                    MarkSelectedRows(_mercuryRow, "Mercury");
                    MoveToNextLine();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "V")
                {
                    ViewClaim();
                    e.Handled = true;
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUnusualClaims_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenUnusualClaim();
        }

        private void dgvClaimsInPendingBatch_DoubleClick(object sender, EventArgs e)
        {
            cmdPendingView.PerformClick();
        }

        private void btnSetToCustomAddress_Click(object sender, EventArgs e)
        {
            ctxtProviderList.Show(btnSetToCustomAddress.PointToScreen(Point.Empty).X + btnSetToCustomAddress.Width, btnSetToCustomAddress.PointToScreen(Point.Empty).Y);
        }

        private void frmProcessor_Shown(object sender, EventArgs e)
        {
            SearchPrimary(true);
        }

        private void btnPendingToCustomAddress_Click(object sender, EventArgs e)
        {
            List<claim> toPrint = new List<claim>();
            string clickedProvider = "";

            foreach (DataGridViewRow aRow in dgvClaimsInPendingBatch.SelectedRows)
            {
                claim c = (claim)aRow.Cells[colClaimInBatchClaim.Name].Value;
                c.override_address_provider = clickedProvider;
                c.Save();


                string providerText = aRow.Cells[colPendingProvider.Name].Value.ToString();
                if (!providerText.Contains("("))
                {
                    providerText += " (KO)";
                    aRow.Cells[colPendingProvider.Name].Value = providerText;
                }
            }

            
        }

        private void chkShowAllClaims_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAllClaims.Checked)
                lblAllClaimsWarning.BackColor = Color.LightYellow;
            else
                lblAllClaimsWarning.BackColor = DefaultBackColor;
        }

        private void cmdMarkMainMercury_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_mercuryRow, "Mercury");
        }

        private void mercuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkSelectedRows(_mercuryRow, "Mercury");
        }

        private void mercuryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvResults.SelectAll();
            MarkSelectedRows(_mercuryRow, "Mercury");
        }

        private void btnResendMercury_Click(object sender, EventArgs e)
        {
            ResendProcessedClaims(false);
            RefreshResults();
        }

        private void frmProcessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ftpTransfer != null)
            {
                ftpTransfer.Close();
                ftpTransfer.Dispose();
            }
        }

        private void cmdPrintList_Click(object sender, EventArgs e)
        {
            printRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow dgvr in dgvResults.Rows)
            {
                if (dgvr.Selected)
                    printRows.Add(dgvr);
            }

            PrintDialog objPPdialog = new PrintDialog();

            objPPdialog.Document = printDocument1;
            printDocument1.DocumentName = "Claim List";
            if (objPPdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void cmdPrintAll_Click(object sender, EventArgs e)
        {
            printRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow dgvr in dgvResults.Rows)
                printRows.Add(dgvr);

            PrintDialog objPPdialog = new PrintDialog();

            objPPdialog.Document = printDocument1;
            printDocument1.DocumentName = "Claim List";
            if (objPPdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                StringFormat strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in printListColumns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in printListColumns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= printRows.Count - 1)
                {
                    DataGridViewRow GridRow = printRows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary", new Font(dgvResults.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(dgvResults.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dgvResults.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvResults.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(new Font(dgvResults.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in printListColumns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents        
                        
                        foreach (DataGridViewColumn aCol in printListColumns)
                        {
                            DataGridViewCell Cel = GridRow.Cells[aCol.Name];
                            if (Cel.Value != null)
                            {
                                string printValue = Cel.Value is DateTime ? ((DateTime)Cel.Value).ToShortDateString() : Cel.Value.ToString();

                                e.Graphics.DrawString(printValue, Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPendingBatchInSearch_Click(object sender, EventArgs e)
        {
            OpenSelectedPendingInSearch();
        }

        private void OpenSelectedPendingInSearch()
        {
            if (dgvPendingBatches.SelectedRows.Count > 0)
            {
                try
                {
                    string batchNum = dgvPendingBatches.SelectedRows[0].Cells[colPendingBatchNumber.DisplayIndex].Value.ToString();

                    frmSearchClaim searcher = new frmSearchClaim();
                    searcher.SetBatchNo(batchNum);
                    searcher.ShowAllTab();
                    searcher.Show();
                    // searcher.SearchThreadSafe(true);
                }
                catch (Exception e)
                {
                    LoggingHelper.Log(e, false);
                    MessageBox.Show(this, "Tracker couldn't open this batch - try searching for it manually.");
                }
            }
        }

        private void openInSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedPendingInSearch();
        }

        private void cmdResendPendingBatch_Click(object sender, EventArgs e)
        {
            if (dgvClaimsInPendingBatch.Rows.Count > 0)
            {
                List<claim> processedClaims = new List<claim>();


                foreach (DataGridViewRow aClaim in dgvClaimsInPendingBatch.Rows)
                {
                    claim thisClaim = (claim)aClaim.Cells[colClaimInBatchClaim.Name].Value;

                    processedClaims.Add(thisClaim);
                    thisClaim.SetResendStatus();
                    ActiveUser.LogAction(ActiveUser.ActionTypes.ResendClaim, thisClaim.id, "Apex Resend");
                }

                ProcessClaimsList(processedClaims, claim_batch.GetApexResendBatchForToday(), true);
            }
        }

        
    }

    class MercuryXMLUploadData
    {
        public NHDG.NHDGCommon.Claims.ClaimBatch cb {get; set; }
        public string mercuryErrors {get; set; }
        public List<claim> mercuryClaims { get; set; }
        public claim_batch currentBatch {get; set; } 
        public bool isResend { get; set; }
    }
}