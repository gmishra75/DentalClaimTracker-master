using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace C_DentalClaimTracker
{
    public partial class frmImportData : Form
    {
        string IMPORTDATAPATH = Application.StartupPath + "\\importdate.xml";
        DateTime lastWrite;
        BackgroundWorker ImportThread = new BackgroundWorker();
        bool changesOnly = false;
        bool okToZap = false;
        delegate void ProgressDelegate(int increment, string text, bool updateStatusBox);
        delegate void StatusDelegate(string statusText, bool alert, bool addReport);
        delegate void EmptyDelegate();
        delegate void LabelDelegate(int labelIndex);
        int totalRows = 0;
        data_mapping_schema dms;
        int primaryClaimCount;
        int secondaryClaimCount;
        int predetermClaimCount;
        int secondaryPredetermClaimCount;
        int closedClaimCount;

        public frmImportData()
        {
            InitializeComponent();
            InitializeSchemaList();
            ImportThread.DoWork += new DoWorkEventHandler(ImportThread_DoWork);
            ImportThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ImportThread_RunWorkerCompleted);
        }

        private void InitializeSchemaList()
        {
            InitializeSchemaList("");   
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

            

            cmbSchema.Items.Add("Create new schema...");

            if (defaultValue == "")
            {
                cmbSchema.SelectedIndex = 0;
            }
            else
            {
                cmbSchema.SelectedIndex = cmbSchema.FindStringExact(defaultValue);
            }
        }

        private void frmImportData_Load(object sender, EventArgs e)
        {
            ShowLastImportDate();
            if (!ActiveUser.UserObject.SafeToImport)
            {
                string userList = string.Empty;
                foreach(user aUser in ActiveUser.UserObject.LoggedInUsers)
                {
                    if (aUser.id != ActiveUser.UserObject.id)
                        userList += aUser.username + "\n";
                }

                if (userList == string.Empty)
                {
                    BeginInvoke(new MethodInvoker(this.Close));
                }
                else
                {
                    if (MessageBox.Show(this, "The following users are currently logged in to the system.\n\n" + userList + "\nIf you continue, they might " +
                        "have problems with any claims they currently have open. Would you like to continue anyway?", "Continue with import?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        BeginInvoke(new MethodInvoker(this.Close));
                    }
                }
            }
        }

        private void ShowLastImportDate()
        {
            try
            {
                lastWrite = system_options.GetLastImportDate();
                lblLastImport.Text = "Last Import: " + lastWrite.ToShortDateString() + " " + lastWrite.ToShortTimeString();
            }
            catch
            {
                lblLastImport.Text = "Last Import: Unknown";
                chkMergeChanges.Enabled = false;
                chkMergeChanges.Checked = false;
            }
        }

        private void cmbSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_mapping_schema toLoad;
            if (cmbSchema.SelectedIndex == cmbSchema.Items.Count - 1)
            {
                toLoad = new data_mapping_schema();
                toLoad.schema_name = GenerateNewName();
                toLoad.data_type = DataMappingConnectionTypes.SQLServer;
                toLoad.allow_password_save = false;
                toLoad.Save();
                frmConfigureSchema toShow = new frmConfigureSchema(toLoad);
                toShow.ShowDialog();

                InitializeSchemaList(toShow.SchemaName);
            }
        }

        private string GenerateNewName()
        {
            string newNameBase = "New Schema";
            string currentName = newNameBase;
            int toAdd = 0;

            while (cmbSchema.FindString(currentName) >= 0)
            {
                toAdd++;
                currentName = newNameBase + toAdd;
            }

            return currentName;
        }

        private void lnkEditSchema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbSchema.SelectedIndex >= 0)
            {
                data_mapping_schema toLoad;
                if (cmbSchema.SelectedIndex == cmbSchema.Items.Count - 1)
                {
                    MessageBox.Show(this, "Cannot show the selected schema.");
                }
                else
                {
                    toLoad = (data_mapping_schema)cmbSchema.SelectedItem;
                    frmConfigureSchema toShow = new frmConfigureSchema(toLoad);
                    toShow.ShowDialog();


                    InitializeSchemaList(toShow.SchemaName);
                }
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            if (cmbSchema.SelectedIndex >= 0)
            {
                if (!chkMergeData.Checked)
                {
                    if (MessageBox.Show(this, "You have selected not to merge with existing information. All current data will be " +
                            "deleted, including calls, claim batches, and other information.\n\nAre you sure you want to do this?", "Import and Replace Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        okToZap = true;
                    }
                    else
                    {
                        CancelImport();
                        return;
                    }
                }
                else
                {
                    if (chkMergeChanges.Checked)
                    {
                        changesOnly = true;
                    }
                }
                Cursor = Cursors.WaitCursor;
                dms = (data_mapping_schema)cmbSchema.SelectedItem;
                ImportThread.RunWorkerAsync();
            }
        }

        private void ImportThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Cancelled)
            {
                CancelImport();
            }
            else
            {
                pbarProgress.Value = pbarProgress.Maximum;
                lblStatus.Text = "Operation complete!";
                
                // if (!chkSecondaryPredetermsOnly.Checked)
                system_options.SetLastImportDate(DateTime.Now); 
                ShowLastImportDate();
                AddStatus("The import completed successfully! " + totalRows + " rows were imported.");
                AddReportMessage(string.Format("The import completed successfully!\nPrimary: {0}\nSecondary: {1}\n" +
                    "Predeterm: {2}\nSecondary Predeterm: {3}\nTotal Open Claims: {4}", primaryClaimCount, secondaryClaimCount, predetermClaimCount, secondaryPredetermClaimCount, 
                    primaryClaimCount + secondaryClaimCount + predetermClaimCount + secondaryPredetermClaimCount));

                try
                {
                    string importFileName = Application.StartupPath + "\\Imports\\" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + " import.rtf";
                    Directory.CreateDirectory(Path.GetDirectoryName(importFileName));
                    rtxtReport.SaveFile(importFileName);
                    CreateLogFile("Import Successfully.");
                    Updateimporterror(false);
                }
                catch (Exception ex) { CreateLogFile(ex.ToString()); Updateimporterror(true); LoggingHelper.Log("Error creating import report file.", LogSeverity.Error, ex, false); }
                cmdImport.Enabled = false;
            }
        }

        private void AddStatus(string statusText, bool alert = false, bool addReport = false)
        {
            if (txtStatus.InvokeRequired)
            {
                this.Invoke(new StatusDelegate(AddStatus) , new object[] { statusText, alert, addReport });
            }
            else
            {
                txtStatus.AppendText(DateTime.Now.ToString("hh:mm:ss"), Color.DarkBlue);
                Color messageColor = Color.Black;
                if (alert)
                    messageColor = Color.Red;


                txtStatus.AppendText(string.Format(": {0} {1}", statusText, Environment.NewLine), messageColor);
                if (addReport)
                    AddReportMessage(statusText, alert);
                    
            }
        }

        private void AddReportMessage(string statusText, bool alert = false, bool addReport = false)
        {
            if (rtxtReport.InvokeRequired)
            {
                this.Invoke(new StatusDelegate(AddReportMessage), new object[] { statusText, alert, addReport });
            }
            else
            {
                rtxtReport.AppendText(DateTime.Now.ToString("hh:mm:ss"), Color.DarkBlue);
                Color messageColor = Color.Black;
                if (alert)
                    messageColor = Color.Red;


                rtxtReport.AppendText(string.Format(": {0} {1}", statusText, Environment.NewLine), messageColor);
            }
        }

        private void UpdateTypeCount()
        {
            if (lblPrimaryClaimCount.InvokeRequired)
                this.Invoke(new EmptyDelegate(UpdateTypeCount));
            else
            {
                lblPrimaryClaimCount.Text = "Primary\n" + primaryClaimCount;
                lblSecondaryClaimCount.Text = "Secondary\n" + secondaryClaimCount;
                lblPredetermClaimCount.Text = "Predeterm\n" + predetermClaimCount;
                lblSecondaryPreClaimCount.Text = "Secondary pre\n" + secondaryPredetermClaimCount;
            }
        }


        private void ImportThread_DoWork(object sender, DoWorkEventArgs e)
        {
            claim workingClaim = new claim();
            DataTable importData = new DataTable();
            DataTable importDataSecondaries = new DataTable();
            DataTable importDataPredeterms = new DataTable();
            DataTable importDataSecondaryPredeterms = new DataTable();
            system_options.SetImportFlag(true);
            primaryClaimCount = 0;
            secondaryClaimCount = 0;
            predetermClaimCount = 0;
            secondaryPredetermClaimCount = 0;
            closedClaimCount = 0;
            
            OleDbConnection oConnect;
            UpdateProgressBar(50, "Initiating Remote Connection...");


            #region Initiate Connection, Get Data
            try
            {
                oConnect = new OleDbConnection(dms.GetConnectionString(true));
            }
            catch (Exception err)
            {
                CreateLogFile(err.ToString());
                Updateimporterror(true);
                LoggingHelper.Log("An error occurred getting the connection string for a new connection in frmImportData.Import", LogSeverity.Error, err, false);
                e.Cancel = true;
                return;
            }



            OleDbDataAdapter oAdapter;
            // Use Connection object for the DataAdapter to retrieve all tables from selected Database
            try
            {
                oConnect.Open();
            }
            catch (Exception err)
            {
                CreateLogFile(err.ToString());
                Updateimporterror(true);
                LoggingHelper.Log("Could not connect to the database in frmImportdata.Import", LogSeverity.Error, err, false);
                e.Cancel = true;
                return;

            }


            
            try
            {
                    UpdateProgressBar(50, "Querying remote database (Standard)...");

                    // ************* Standard Claims
                    oAdapter = new OleDbDataAdapter(PrepareSQL(dms.sqlstatement, changesOnly), oConnect);
                    oAdapter.SelectCommand.CommandTimeout = System.Convert.ToInt32(nmbTimeout.Value);
                    oAdapter.Fill(importData);

                    UpdateProgressBar(10, "Querying remote database (Secondary)...");

                    // **************  Secondaries
                    if (dms.sqlstatementsecondaries != "")
                    {
                        oAdapter = new OleDbDataAdapter(PrepareSQL(dms.sqlstatementsecondaries, changesOnly), oConnect);
                        oAdapter.SelectCommand.CommandTimeout = System.Convert.ToInt32(nmbTimeout.Value);
                        oAdapter.Fill(importDataSecondaries);
                    }

                    UpdateProgressBar(10, "Querying remote database (Predeterms)...");

                    // *************** Predeterms
                    if (dms.sqlstatementpredeterms != "")
                    {
                        oAdapter = new OleDbDataAdapter(PrepareSQL(dms.sqlstatementpredeterms, changesOnly), oConnect);
                        oAdapter.SelectCommand.CommandTimeout = System.Convert.ToInt32(nmbTimeout.Value);
                        oAdapter.Fill(importDataPredeterms);
                    }

                    UpdateProgressBar(10, "Querying remote database (Secondary Predeterms)...");
                    // *************** Predeterms
                    if (dms.sqlstatementsecondarypredeterms != "")
                    {
                        oAdapter = new OleDbDataAdapter(PrepareSQL(dms.sqlstatementsecondarypredeterms, changesOnly), oConnect);
                        oAdapter.SelectCommand.CommandTimeout = System.Convert.ToInt32(nmbTimeout.Value);
                        oAdapter.Fill(importDataSecondaryPredeterms);
                    }
                
            }
            catch (Exception err)
            {
                CreateLogFile(err.ToString());
                Updateimporterror(true);
                LoggingHelper.Log("Error with SQL statement or connection in frmImportData.Import", LogSeverity.Error, err);
                MessageBox.Show(this, "There was an error with your SQL statement or with your connection.\n\n" + err.Message,
                    "Error retrieving data");
                CancelImport();
                return;
            }
            
            #endregion

            data_mapping_schema_data dmsd = new data_mapping_schema_data();
            dmsd.schema_id = dms.id;
            DataTable dataForSchema = dmsd.Search();

            // Generate our list of objects one time, and then use them for each iteration of rows
            List<data_mapping_schema_data> allMappedSchemaData = new List<data_mapping_schema_data>();
            foreach (DataRow aMapping in dataForSchema.Rows)
            {
                // For every row, need to get the data for every field
                dmsd = new data_mapping_schema_data();
                dmsd.Load(aMapping);
                allMappedSchemaData.Add(dmsd);
            }

            UpdateProgressBar(100, "Importing data...");

            if (okToZap)
            {
                company cmp = new company();
                cmp.Zap();

                workingClaim.Zap();

                call aCall = new call();
                aCall.Zap();

                company_contact_info info = new company_contact_info();
                info.Zap();

                procedure p = new procedure();
                p.Zap();

                choice c = new choice();
                c.Zap();

                notes n = new notes();
                n.Zap();

                claim_batch cb = new claim_batch();
                cb.Zap();

                batch_claim_list bcl = new batch_claim_list();
                bcl.Zap();
            }
            else
            {
                if (!changesOnly)
                    workingClaim.MarkAllImportsUpdated(false);
            }

            // Apply incremental updates to progress bar
            int currentRow = 0;

            totalRows = importData.Rows.Count + importDataSecondaries.Rows.Count + importDataPredeterms.Rows.Count + importDataSecondaryPredeterms.Rows.Count;
            decimal exactIncrementAmount;

            if (totalRows > 0)
                exactIncrementAmount = 500m / totalRows;
            else
                exactIncrementAmount = 500m;

            decimal incrementCounter = 0;
             
            int increment;

            if (exactIncrementAmount < 1)
                increment = 1;
            else
                increment = Convert.ToInt32(Math.Truncate(exactIncrementAmount));
            
            
                
            string lastClaimID = "";
            claim aClaim = new claim();
            company aCompany = new company();
            company_contact_info anInfo = new company_contact_info();
            procedure aProcedure = new procedure();



            for (int p = 0; p < 4; p++)
            {
                claim.ClaimTypes ct;
                DataTable thisImport;
                switch (p)
                {
                    case 0:
                        thisImport = importData;
                        ct = claim.ClaimTypes.Primary;
                        UpdateLabels(0);
                        break;
                    case 1:
                        thisImport = importDataSecondaries;
                        ct = claim.ClaimTypes.Secondary;
                        UpdateLabels(1);
                        break;
                    case 2:
                        thisImport = importDataPredeterms;
                        ct = claim.ClaimTypes.Predeterm;
                        UpdateLabels(2);
                        break;
                    default:
                        thisImport = importDataSecondaryPredeterms;
                        UpdateLabels(3);
                        ct = claim.ClaimTypes.SecondaryPredeterm;
                        break;
                }

                

                // Have data at this point, need to tie them to the internal mapping schema data
                foreach (DataRow anImportRow in thisImport.Rows)
                {
                    string newID = anImportRow[dms.claim_id_column].ToString();
                    string newDB = anImportRow[dms.claim_db_column].ToString();
                    bool isOnlyProcedureData;

                    if (newID == lastClaimID)
                    {
                        // We're only dealing with the import of "some" data
                        isOnlyProcedureData = true;
                    }
                    else
                    {
                        if (ct == claim.ClaimTypes.Primary)
                            primaryClaimCount++;
                        else if (ct == claim.ClaimTypes.Secondary)
                            secondaryClaimCount++;
                        else if (ct == claim.ClaimTypes.Predeterm)
                            predetermClaimCount++;
                        else
                            secondaryPredetermClaimCount++;

                        UpdateTypeCount();

                        aClaim = FindClaim(anImportRow, ct);
                        aCompany = FindCompany(anImportRow[dms.company_namecolumn].ToString());
                        anInfo = FindContactInfo(anImportRow["Ins_Co_Street1"].ToString(), aCompany.id, anImportRow["Ins_Co_Phone"].ToString());
                        lastClaimID = newID;
                        aClaim.ClearClaimProcedures();
                        isOnlyProcedureData = false;

                        // Check for "X" in provider field
                        try
                        {
                            if (aClaim.doctor_provider_id.StartsWith("X"))
                            {
                                AddStatus(string.Format("The claim for patient {0} on {1} uses an X provider ({2})", aClaim.PatientName, aClaim.DatesOfServiceString(), aClaim.doctor_provider_id), true, true);
                            }
                        }
                        catch (Exception err)
                        {
                            CreateLogFile(err.ToString());
                            Updateimporterror(true);
                            LoggingHelper.Log(err, false);
                        }
                    }

                    aProcedure = FindProcedure(anImportRow["PROC_LOGID"].ToString());

                    if (CommonFunctions.DBNullToString(anImportRow["DATERECEIVED"]) == "")
                        aClaim.open = 1;
                    else if (((DateTime)anImportRow["DATERECEIVED"]).Year == 1753)
                        aClaim.open = 1;
                    else
                    {
                        aClaim.open = 0;
                        UpdateStatusHistory(aClaim);
                    }


                    foreach (data_mapping_schema_data aMappedData in allMappedSchemaData)
                    {
                        // We do a check for is only procedure data to speed up processing
                        // It makes the code a little messier.

                        if (isOnlyProcedureData)
                        {
                            // If we're only importing the procedure data, none of the other information is important

                            if ((aMappedData.LinkedField.table_name == "claims") ||
                            (aMappedData.LinkedField.table_name == "companies") ||
                            (aMappedData.LinkedField.table_name == "company_contact_info"))
                            {
                                // Ignore
                            }
                            else if (aMappedData.LinkedField.table_name == "procedures")
                            {
                                if (aMappedData.LinkedField.field_name == "surf_string")
                                    aProcedure[aMappedData.LinkedField.field_name] = CommonFunctions.RemoveNonPrintableCharacters(anImportRow[aMappedData.mapped_to_text].ToString());
                                else if (aMappedData.LinkedField.field_name == "claim_id")
                                    aProcedure["claim_id"] = lastClaimID;
                                else
                                    aProcedure[aMappedData.LinkedField.field_name] = anImportRow[aMappedData.mapped_to_text];
                            }
                            else
                            {
                                LoggingHelper.Log("Uninitialized table name in frmImportData.Import", LogSeverity.Critical,
                                    new Exception("Uninitialized table name in import procedure."), true);
                            }
                        }
                        else
                        {
                            // This is a new claim - we need to get the data for every field
                            if (aMappedData.LinkedField.table_name == "claims")
                            {
                                aClaim[aMappedData.LinkedField.field_name] = anImportRow[aMappedData.mapped_to_text];
                            }
                            else if (aMappedData.LinkedField.table_name == "companies")
                            {
                                if (aMappedData.mapped_to_text != dms.company_namecolumn)
                                {
                                    aCompany[aMappedData.LinkedField.field_name] = anImportRow[aMappedData.mapped_to_text];
                                }
                            }
                            else if (aMappedData.LinkedField.table_name == "company_contact_info")
                            {
                                anInfo[aMappedData.LinkedField.field_name] = anImportRow[aMappedData.mapped_to_text];
                            }
                            else if (aMappedData.LinkedField.table_name == "procedures")
                            {
                                if (aMappedData.LinkedField.field_name == "surf_string")
                                    aProcedure[aMappedData.LinkedField.field_name] = CommonFunctions.RemoveNonPrintableCharacters(anImportRow[aMappedData.mapped_to_text].ToString());
                                else
                                    aProcedure[aMappedData.LinkedField.field_name] = anImportRow[aMappedData.mapped_to_text];
                            }
                            else
                            {
                                LoggingHelper.Log("Uninitialized table name in frmImport.Import", LogSeverity.Critical);
                                throw new Exception("Uninitialized table name in import procedure.");
                            }
                        }
                    }

                    aCompany.Save();



                    anInfo.company_id = aCompany.id;
                    if (CommonFunctions.DBNullToZero(anInfo["order_id"]) == 0)
                    {
                        anInfo.order_id = anInfo.GetNextOrderID();
                    }
                    anInfo.Save();


                    aClaim.company_id = aCompany.id;
                    aClaim.company_address_id = anInfo.order_id;
                    aClaim["import_update_flag"] = true;
                    aClaim.Save();

                    if (p == 0 || p == 2 || p == 3) // Only update the id if this is the primary claim or a predeterm
                        aProcedure.claim_id = aClaim.id;

                    aProcedure.Save();

                    currentRow++;

                    if (Math.Truncate(incrementCounter + exactIncrementAmount) != Math.Truncate(incrementCounter))
                    {
                        UpdateProgressBar(increment, string.Format("{0} / {1} procedures completed...", currentRow, totalRows), false);
                    }
                    incrementCounter += exactIncrementAmount;
                }

            }

            if (changesOnly)
            {
                // Grab all the deleted claims and mark them as closed here
                // Add a note that they have been deleted, I guess
                string deletedClaimsSQL = "SELECT CLAIMID, CLAIMDB " +
                    "FROM AUDIT_DDB_CLAIM " +
                    "WHERE N_CLAIMID is null " +
                    "AND CLAIMID is not null AND CLAIMDB is not null " +
                    "AND date_changed >= '" + lastWrite.ToString("G") + "'";
                DataTable deletedClaims = new DataTable();
                OleDbCommand cmd = new OleDbCommand(deletedClaimsSQL, oConnect);
                cmd.CommandTimeout = 90;
                
                oAdapter = new OleDbDataAdapter(cmd);

                oAdapter.Fill(deletedClaims);

                UpdateProgressBar(5, "Updating Local Status for Deleted Claims...");
                foreach (DataRow aDeletedClaim in deletedClaims.Rows)
                {
                    // Close the claims
                    DataTable matches = aClaim.Search("SELECT * FROM claims WHERE claimidnum = '" + aDeletedClaim["claimid"] +
                        "' and claimdb = '" + aDeletedClaim["claimdb"] + "'");

                    if (matches.Rows.Count > 0)
                    {
                        // This should honestly not load every claim
                        aClaim = new claim();
                        aClaim.Load(matches.Rows[0]);
                        aClaim.open = 0;
                        aClaim.Save();
                        UpdateStatusHistory(aClaim);
                        closedClaimCount++;
                    }
                }

            }
            else
                closedClaimCount = workingClaim.CloseClaimsWithoutUpdate();

            UpdateLabels(4);
            workingClaim.FixRevisitDateAfterImport();

        }

        private void UpdateLabels(int labelIndex)
        {
            if (lblPrimaryClaimCount.InvokeRequired)
            {
                this.Invoke(new LabelDelegate(UpdateLabels), new object[] { labelIndex });
            }
            else
            {
                Label[] labels = new Label[] { lblPrimaryClaimCount, lblSecondaryClaimCount, lblPredetermClaimCount, lblSecondaryPreClaimCount };

                for (int i = 0; i < 4; i++)
                {
                    if (i == labelIndex)
                        labels[i].BackColor = Color.LightGoldenrodYellow;
                    else if (i < labelIndex)
                        labels[i].BackColor = Color.LightGreen;
                    else
                        labels[i].BackColor = Color.WhiteSmoke;
                }
            }
        }


        private void UpdateStatusHistory(claim aClaim)
        {
            return;
            // Unknown error occurring here on import (property value empty or invalid - int i id)
            // TODO: Figure this out!
            try
            {
                claim_status_history csh = new claim_status_history();

                csh.claim_id = aClaim.id;
                csh.order_id = csh.GetNextOrderID();
                csh.user_id = C_DentalClaimTracker.Properties.Settings.Default.SystemUserID;
                csh.date_of_change = DateTime.Now;

                csh.old_status_id = aClaim.status_id;
                csh.new_status_id = C_DentalClaimTracker.Properties.Settings.Default.PaymentStatusID;

                csh.old_revisit_date = aClaim.revisit_date;
                csh.new_revisit_date = csh.old_revisit_date;
                csh.as_is_flag = false;
                csh.Save();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in update status history\n" + err.Message, LogSeverity.Critical);
                throw new Exception("An error occurred creating the status history for this change. Your save should continue as " +
                    "normal, but please notify a system administrator of this error:\n\n" + err.Message);
            }
        }

        private string PrepareSQL(string sql, bool ChangesOnly)
        {            
            sql = sql.Replace("[DAYSEARCH]", "1");
            
            if (ChangesOnly)
                sql = sql.Replace("[CHANGESONLY]", GetChangesOnlySQL());
            else
                sql = sql.Replace("[CHANGESONLY]", " AND (dbo.DDB_CLAIM.DATERECEIVED = CONVERT(DATETIME, '1753-03-02 00:00:00', 102)) AND ddb_claim.Status = 1 ");
            return sql;
        }

        private string GetChangesOnlySQL()
        {
            string lastImportDate = lastWrite.AddHours(-6).ToString("G");

            /*DateOfClaim (Claim table)
DDB_LAST_MOD (Claim table)
DDB_LAST_MOD (DDB_PAT_BASE)
ddb_last_mod (DDB_INSURANCE)
ddb_last_mod(DDB_ADDRESS) */
            // The last 3 tables are not included because in extraordinary number of patients, insurances, and addresses 
            // have a last mod date that appears to be inaccurate

            return  " AND (DDB_CLAIM.DateofClaim > CONVERT(DATETIME, '" + lastImportDate +
                "') OR DDB_CLAIM.DDB_LAST_MOD > CONVERT(DATETIME, '" + lastImportDate + "'))";
        }

        private void CancelImport()
        {
            lblStatus.Text = "Import Cancelled...";
            pbarProgress.Value = 0;
            Cursor = Cursors.Default;
            system_options.SetImportFlag(false);
        }

        private void UpdateProgressBar(int increment, string text, bool updateStatusBox = true)
        {
            if (pbarProgress.InvokeRequired)
            {
                this.Invoke(new ProgressDelegate(UpdateProgressBar), new object[] { increment, text, updateStatusBox });
            }
            else
            {
                pbarProgress.Increment(increment);
                lblStatus.Text = text;
                if (updateStatusBox)
                    AddStatus(text, false, true);
                pbarProgress.Refresh();
                lblStatus.Refresh();
            }
        }

        private procedure FindProcedure(string procID)
        {
            procedure toReturn = new procedure();

            DataTable results = toReturn.Search("SELECT * FROM procedures WHERE externalid = '" + procID + "'");

            if (results.Rows.Count > 0)
                toReturn.Load(results.Rows[0]);

            return toReturn;
        }


        private company_contact_info FindContactInfo(string addressField, int companyId, string phoneNum)
        {
            try
            {
                company_contact_info toReturn = new company_contact_info();
                string trimmedAddress = CommonFunctions.TrimSpaces(addressField);

                toReturn.address = trimmedAddress;
                toReturn.phone = phoneNum;

                DataTable results = toReturn.Search("SELECT * FROM company_contact_info WHERE company_id = " + companyId + 
                    " AND address = '" + trimmedAddress + "' AND phone = '" + phoneNum + "'");
                if (results.Rows.Count > 0)
                    toReturn.Load(results.Rows[0]);

                toReturn.address = trimmedAddress;
                return toReturn;
            }
            catch(Exception err)
            {
                // Somewhat dangerous, but it ensures that the import won't crash
                LoggingHelper.Log("Error in frmImportData.FindContactInfo", LogSeverity.Critical, err, true);
                return null;
            }
        }

        private company FindCompany(string CompanyName)
        {
            try
            {
                company toReturn = new company();
                string trimmedCompanyName = CommonFunctions.TrimSpaces(CompanyName);
                toReturn.name = trimmedCompanyName;

                toReturn.SearchType = DataObject.SearchTypes.Exact;
                DataTable results = toReturn.Search("SELECT * FROM companies WHERE name = '" + trimmedCompanyName + "'");
                if (results.Rows.Count > 0)
                    toReturn.Load(results.Rows[0]);

                toReturn.created_on = DateTime.Now;
                toReturn.name = trimmedCompanyName;

                toReturn.Save();
                return toReturn;
            }
            catch(Exception err)
            {
                // Somewhat dangerous, but it ensures that the import won't crash
                LoggingHelper.Log("Error in frmImportData.FindCompany", LogSeverity.Critical, err, true);
                return null;
            }
        }

        private claim FindClaim(DataRow anImportRow, claim.ClaimTypes claimType)
        {
            string importID = anImportRow[dms.claim_id_column].ToString();
            string importDB = anImportRow[dms.claim_db_column].ToString();
            try
            {
                claim c = new claim();
                c.claimidnum = importID;
                c.claimdb = importDB;
                DataTable matches = c.Search();

                if (matches.Rows.Count != 0)
                {
                    c.Load(matches.Rows[0]);
                }
                else
                {
                    // ****** Finding recreated claims *************
                    // Above, we checked for the common ID/DB match
                    // Here we try to find if a claim that is not in Tracker has been recreated
                    // We match by all fields minus 1 - if two primary fields have been changed 
                    // Tracker can't track it
                    // If we find a possible match, we check to see that the current claim isn't in Dentrix
                    // to avoid false positives

                    bool possibleMatchFound = false;
                    bool claimInDentrix = true;
                    claim workingClaim = new claim();
                    DateTime? dateOfService = null;

                    try
                    { dateOfService = Convert.ToDateTime(anImportRow["PLDATE"]); }
                    catch { }
                    string lastName = anImportRow["PatLastName"].ToString();
                    string firstName = anImportRow["PatFirstName"].ToString();
                    decimal amount = Convert.ToDecimal(anImportRow["TOTAL"]); // stored as cents
                    string doctorFirstName = anImportRow["DoctorFirstName"].ToString();
                    string doctorLastName = anImportRow["DoctorLastName"].ToString();
                    string subscriberInsuranceID = anImportRow["ID_NUM_ON_CLAIM"].ToString();
                    string matchingClaimInfo = matchingClaimInfo = string.Format("Patient: {0}, Doctor: {1}, Total: {2}, DOS: {3}, Ins ID: {4}, ID: {5}, Type: {6}", firstName + " " + lastName,
                                doctorFirstName + " " + doctorLastName, amount, dateOfService, subscriberInsuranceID, importID + " | " + importDB, claimType.ToString());
                    int? newClaimID = null;
                    


                    // Search for a patient match first. If the patient doesn't match try to match on the other two fields
                    workingClaim.patient_first_name = firstName;
                    workingClaim.patient_last_name = lastName;

                    workingClaim.open = 1;
                    DataTable patientMatches = workingClaim.Search();

                    if (patientMatches.Rows.Count > 0)
                    {
                        // Iterate through all rows where the patient data matches
                        foreach (DataRow aRow in patientMatches.Rows)
                        {
                            int numMatchesForclaim = 0;
                            workingClaim.Load(aRow);

                            if (workingClaim.amount_of_claim * 100 == amount)
                                numMatchesForclaim++;
                            if (workingClaim.doctor_first_name == doctorFirstName && workingClaim.doctor_last_name == doctorLastName)
                                numMatchesForclaim++;
                            if (workingClaim.date_of_service == dateOfService)
                                numMatchesForclaim++;
                            if (workingClaim.subscriber_alternate_number == subscriberInsuranceID)
                                numMatchesForclaim++;
                            if (workingClaim.claim_type == claimType)
                                numMatchesForclaim++;


                            if (numMatchesForclaim >= 4)
                            {
                                // Found a claim that appears to match
                                newClaimID = workingClaim.id;
                                possibleMatchFound = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Look for a match on date of service, amount, provider, insurance id, and type
                        workingClaim = new claim();
                        workingClaim.open = 1;
                        workingClaim.amount_of_claim = amount / 100;
                        workingClaim.doctor_first_name = doctorFirstName;
                        workingClaim.doctor_last_name = doctorLastName;
                        workingClaim.subscriber_alternate_number = subscriberInsuranceID;
                        workingClaim.claim_type = claimType;


                        string searchSQL = workingClaim.SearchSQL + string.Format(" AND DATEDIFF(d, [date_of_service], '{0}') = 0", dateOfService.GetValueOrDefault().ToShortDateString());
                        DataTable otherMatches = workingClaim.Search(searchSQL);
                        if (otherMatches.Rows.Count > 0)
                        {
                            newClaimID = (int) otherMatches.Rows[0]["id"];
                            possibleMatchFound = true;
                        }
                    }

                    if (possibleMatchFound)
                    {
                        // Check Dentrix to verify that the current ID/DB can't be found
                        if (newClaimID.HasValue && ClaimTrackerCommon.ClaimExists(new claim(newClaimID.Value))) // No match found
                        {
                            // Log this temporarily for recordkeeping
                            claimInDentrix = true;
                            AddReportMessage("Found a possible claim to merge, but the claim exists in Dentrix. Did not merge claim..." + matchingClaimInfo, true);
                            LoggingHelper.Log("Tried to merge a claim, but it was found in Dentrix. Claim info:\n" + matchingClaimInfo, LogSeverity.Information);
                        }    
                        else
                            claimInDentrix = false;
                        
                    }

                    if (!claimInDentrix && possibleMatchFound)
                    {
                        // Already loaded claim, should have "correct" data
                        c.Load(newClaimID.GetValueOrDefault(0));
                        AddReportMessage(string.Format("Merged a claim in Dentrix with an existing claim tracker claim. The claim's old ID/DB is {0}/{1}. The matching claim information is {2}",
                           c.claimidnum, c.claimdb, matchingClaimInfo), true);
                        
                        c.claimidnum = importID;
                        c.claimdb = importDB;
                        
                        LoggingHelper.Log("Successfully merged a claim. \n" + matchingClaimInfo, LogSeverity.Information);
                    }
                    else
                    {
                        AddReportMessage("New claim imported - " + matchingClaimInfo);
                        c.created_by = "Automatic Database Importer";
                        c.updated_on = null;
                    }
                }
                return c;
            }
            catch(Exception err)
            {
                // Somewhat dangerous, but it ensures that the import won't crash
                LoggingHelper.Log("Error in frmImportData.FindClaim", LogSeverity.Critical, err, false);
                claim c = new claim();
                c.claimidnum = importID;
                c.claimdb = importDB;
                return c;
            }
        }

        private void chkMergeData_CheckedChanged(object sender, EventArgs e)
        {
            chkMergeChanges.Enabled = chkMergeChanges.Checked;
        }

        private void frmImportData_FormClosing(object sender, FormClosingEventArgs e)
        {
            system_options.SetImportFlag(false);
        }

        private void btnSecondaryPredeterms_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAdvancedSettings_Click(object sender, EventArgs e)
        {

        }

        private void lblAdvancedSettings_DoubleClick(object sender, EventArgs e)
        {
            if (pnlAdvancedSettings.Height == nmbTimeout.Bottom + 15)
                pnlAdvancedSettings.Height = lblAdvancedSettings.Bottom;
            else
                pnlAdvancedSettings.Height = nmbTimeout.Bottom + 15;
        }

        private void lblAdvancedSettings_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateLogFile(string txt)
        {
            string LogFilePath = Application.StartupPath + "\\SaveLog\\ImportLogs_" + DateTime.Now.Year + "_ImportLog " + DateTime.Now.ToString("MM-dd-yyyy hh-mm") + ".rtf";
            string folderPath = Application.StartupPath + "\\SaveLog";
            // Directory.CreateDirectory(Path.GetDirectoryName(LogFileName));


            string path = LogFilePath;
            FileInfo fi = new FileInfo(path);
            DirectoryInfo di = new DirectoryInfo(folderPath);
            if (!di.Exists)
            {
                di.Create();
            }

            if (!fi.Exists)
            {
                fi.Create().Dispose();
            }

            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine(txt);
            tw.WriteLine(Environment.NewLine);
            tw.WriteLine(Environment.NewLine);
            tw.Close();

            //rtxtReport.SaveFile(importFileName);
        }
        private void Updateimporterror(bool flag)
        {
            system_options.importerror = true;
        }
    }
}