using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.Claims;
using NHDG.NHDGCommon.AppSettings;
using NHDG.EClaims.Handling;
using log4net;

namespace NHDG.EClaims
{
    /// <summary>The main window for the application.</summary>
    public class frmMain : Form
    {
        #region Control Declarations
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listClaims;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuHelpAbout;
        private System.Windows.Forms.MenuItem mnuFileRefreshList;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnuFileExit;
        private System.Windows.Forms.ColumnHeader colClaimsDate;
        private System.Windows.Forms.ColumnHeader colClaimsName;
        private System.Windows.Forms.ColumnHeader colClaimsType;
        private System.Windows.Forms.ColumnHeader colClaimsAmount;
        private System.Windows.Forms.ColumnHeader colClaimsHandling;
        private System.Windows.Forms.ColumnHeader colClaimsCarrier;
        private System.Windows.Forms.ContextMenu mnuClaims;
        private System.Windows.Forms.MenuItem mnuHandling;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuFileViewPastClaims;
        private System.ComponentModel.Container components = null;
        #endregion


        /// <summary>Initializes an instance of FrmMain.</summary>
        public frmMain()
        {
            // Build and initialize the form.
            InitializeComponent();
            StartEventProcessing();

            // Connect to the database.
            try
            {
                Globals.Logger.Debug("Opening database connection...");
                Globals.Database = new SqlConnection(SettingsManager.Instance.Settings["EClaims"].DatabaseConnection.GetSqlConnectionString("Application Name=EClaims"));
                Globals.Database.Open();
                Globals.Logger.Debug("Database open.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open connection to database.", "EClaims");
                Globals.Logger.Error("Could not open connection to database.", ex);
            }

            // Load the claim list.
            FrmWait f = null;
            try
            {
                f = new FrmWait();
                f.Message.Text = "Please wait while the information is retrieved...";
                f.Show(); Application.DoEvents();
                RefreshList();
            }
            catch (Exception ex)
            {
                Globals.Logger.Warn("Could not load claims.", ex);
            }
            finally
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
            }

            // Build the handling menus.
            foreach (ClaimHandler hc in Globals.Settings.Handlers)
            {
                mnuClaims.MenuItems.Add(hc.Name, new System.EventHandler(this.SetHandling));
                mnuHandling.MenuItems.Add(hc.Name, new System.EventHandler(this.SetHandling));
            }
            mnuClaims.MenuItems.Add("-");
            mnuClaims.MenuItems.Add("Clear Handling", new System.EventHandler(this.SetNone));
            mnuHandling.MenuItems.Add("-");
            mnuHandling.MenuItems.Add("Clear Handling", new System.EventHandler(this.SetNone));
        }


        /// <summary>Clean up any resources being used.</summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                // Close out the database, just in case.
                if (Globals.Database != null)
                {
                    if (Globals.Database.State != System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            Globals.Logger.Debug("Closing database connection...");
                            Globals.Database.Close();
                            Globals.Logger.Debug("Database closed.");
                        }
                        catch (Exception ex)
                        {
                            Globals.Logger.Error("Could not close database.", ex);
                        }
                    }
                }
            }
            base.Dispose(disposing);
        }


        // Refresh the list.
        private void RefreshList()
        {
            Globals.Logger.Debug("Loading claim list...");

            listClaims.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT CLAIM_ID, " +
                                            "       CLAIM_DB, " +
                                            "       CLAIM_DATE, " +
                                            "       CLAIM_ORD, " +
                                            "       CLAIM_TOTAL_BILLED, " +
                                            "       INS_NAME, " +
                                            "       PAT_LASTNAME, " +
                                            "       PAT_FIRSTNAME, " +
                                            "       PAT_MIDDLENAME " +
                                            "FROM NHDG_CLAIM_UNRECONCILED_TRANSACTIONS " +
                                            "ORDER BY CLAIM_DATE, " +
                                            "         PAT_LASTNAME, " +
                                            "         PAT_FIRSTNAME, " +
                                            "         CLAIM_ORD", Globals.Database);
            SqlDataReader reader = cmd.ExecuteReader();
            ListViewItem lvi;
            while (reader.Read())
            {
                lvi = new ListViewItem(reader.GetDateTime(reader.GetOrdinal("CLAIM_DATE")).ToString("d"));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("PAT_LASTNAME")) + ", " + reader.GetString(reader.GetOrdinal("PAT_FIRSTNAME")) + " " + reader.GetString(reader.GetOrdinal("PAT_MIDDLENAME")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("CLAIM_ORD")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("INS_NAME")));
                lvi.SubItems.Add(Utilities.FormatCurrency(reader.GetInt32(reader.GetOrdinal("CLAIM_TOTAL_BILLED"))));
                lvi.SubItems.Add(string.Empty);
                lvi.Tag = new int[2] { reader.GetInt32(reader.GetOrdinal("CLAIM_ID")), reader.GetInt32(reader.GetOrdinal("CLAIM_DB")) };

                listClaims.Items.Add(lvi);
            }
            reader.Close();

            Globals.Logger.Debug("Claims loaded.");
        }


        // Determines whether or not the user has started making processing decisions.
        private bool HasStartedProcessing()
        {
            foreach (ListViewItem lvi in listClaims.Items)
            {
                if (lvi.SubItems[5].Text != string.Empty)
                {
                    return true;
                }
            }

            return false;
        }


        #region Events
        // Hook into the event processing.
        private void StartEventProcessing()
        {
            this.Closing += new CancelEventHandler(this.FrmMain_Closing);
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.mnuFileViewPastClaims.Click += new System.EventHandler(this.mnuFileViewPastClaims_Click);
            this.mnuFileRefreshList.Click += new System.EventHandler(this.mnuFileRefreshList_Click);
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
        }

        // Warn them if they started to process the claims.
        private void FrmMain_Closing(object sender, CancelEventArgs e)
        {
            if (HasStartedProcessing())
            {
                e.Cancel = (MessageBox.Show("You have started to process the claims. Exit anyway?", "EClaims", MessageBoxButtons.YesNo) == DialogResult.No);
                if (!e.Cancel)
                {
                    Globals.Logger.Info("Batch aborted.");
                }
            }
        }

        // Process the claims.
        private void btnProcess_Click(object sender, System.EventArgs e)
        {
            // Make sure they want to do this.
            if (MessageBox.Show("Process the claims as defined?", "Process", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // Show the 'please wait' dialog.
            FrmWait f = new FrmWait();
            f.Message.Text = "Please wait while the claims are processed.";
            f.Show();
            btnProcess.Enabled = false;
            Application.DoEvents();

            Globals.Logger.Info("Processing claims...");
            SqlTransaction trans = Globals.Database.BeginTransaction();

            // Work the claims one handling method at a time.
            bool success = true;
            ClaimHandler ch;
            Claim cl;
            Globals.Settings.ResetHandlers();
            foreach (ListViewItem lvi in listClaims.Items)
            {
                if (lvi.SubItems[5].Text != string.Empty)
                {
                    ch = Globals.Settings.GetHandlerByName(lvi.SubItems[5].Text);
                    if (ch.Batch == null) { ch.CreateBatch(trans); }
                    try
                    {
                        cl = new Claim(((int[])lvi.Tag)[0], ((int[])lvi.Tag)[1], trans);
                        try
                        {
                            ValidateClaim.Validate(cl);
                        }
                        catch (Exception ex2)
                        {
                            if (MessageBox.Show("Warning: " + lvi.SubItems[0].Text + " Claim for " + lvi.SubItems[1].Text + " (" + lvi.SubItems[4].Text + ": " + lvi.SubItems[3].Text + ") failed validation. Process anyway?" + Environment.NewLine + Environment.NewLine + ex2.Message, "Process Claims", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                Globals.Logger.Info("Claim " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + " not added to batch. " + ex2.Message);
                                continue;
                            }
                        }
                        ch.AddClaim(trans, cl);
                    }
                    catch (Exception ex)
                    {
                        Globals.Logger.Error("Could not add claim " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + " to batch.", ex);
                        success = false;
                    }
                }
            }
            trans.Commit();


            // Process the electronic claims.
            foreach (ClaimHandler c in Globals.Settings.Handlers)
            {
                if ((c is ElectronicClaimHandler) && (c.Batch != null))
                {
                    Globals.Logger.Info("Executing post-processing for handler " + c.Name + " (batch " + c.Batch.BatchInformation.BatchID.ToString() + ")...");
                    try
                    {
                        ((ElectronicClaimHandler)c).Process();
                    }
                    catch (Exception ex)
                    {
                        Globals.Logger.Error("Processing failed.", ex);
                        success = false;
                    }
                    Globals.Logger.Info("Post-processing complete for handler " + c.Name + " (batch " + c.Batch.BatchInformation.BatchID.ToString() + ").");
                }
            }

            // Let them know we're done.
            Globals.Logger.Info("Claim processing complete.");
            if (success)
            {
                MessageBox.Show("Claim processing complete.", "Process");
            }
            else
            {
                MessageBox.Show("Claim processing completed with errors. See log for details.", "Process");
            }

            // Reload the claim list.
            try
            {
                f.Message.Text = "Please wait while the information is retrieved...";
                Application.DoEvents();
                RefreshList();
            }
            catch (Exception ex)
            {
                Globals.Logger.Warn("Could not load claims.", ex);
            }
            finally
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
            }

            btnProcess.Enabled = true;
        }

        // User wants to view past batches/claims.
        private void mnuFileViewPastClaims_Click(object sender, System.EventArgs e)
        {
            FrmBatchHistory f = new FrmBatchHistory();
            Globals.Logger.Debug("Viewing batch history.");
            f.Show();
        }

        // Refresh the list.
        private void mnuFileRefreshList_Click(object sender, System.EventArgs e)
        {
            // Warn them if they have stuff selected.
            if (HasStartedProcessing())
            {
                if (MessageBox.Show("This will wipe out your current selections. Refresh anyway?", "Refresh Lists", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            // Reload the claim list.
            FrmWait f = null;
            try
            {
                f = new FrmWait();
                f.Message.Text = "Please wait while the information is retrieved...";
                f.Show(); Application.DoEvents();
                RefreshList();
            }
            catch (Exception ex)
            {
                Globals.Logger.Warn("Could not load claims.", ex);
            }
            finally
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
            }
        }

        // Exit the application.
        private void mnuFileExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // Show the about diaGlobals.Logger.
        private void mnuHelpAbout_Click(object sender, System.EventArgs e)
        {
            Globals.Logger.Debug("Viewing Help|About.");
            NHDGCommon.FrmAbout f = new NHDGCommon.FrmAbout();
            f.SetFields("EClaims", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            f.ShowDialog();
        }

        // Set the claims' handling type.
        private void SetHandling(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lvi in listClaims.SelectedItems)
            {
                lvi.SubItems[5].Text = ((MenuItem)sender).Text;
            }
        }

        // Clear the claims' handling type.
        private void SetNone(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lvi in listClaims.SelectedItems)
            {
                lvi.SubItems[5].Text = string.Empty;
            }
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileViewPastClaims = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuFileRefreshList = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuHandling = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClaims = new System.Windows.Forms.ListView();
            this.colClaimsDate = new System.Windows.Forms.ColumnHeader();
            this.colClaimsName = new System.Windows.Forms.ColumnHeader();
            this.colClaimsType = new System.Windows.Forms.ColumnHeader();
            this.colClaimsCarrier = new System.Windows.Forms.ColumnHeader();
            this.colClaimsAmount = new System.Windows.Forms.ColumnHeader();
            this.colClaimsHandling = new System.Windows.Forms.ColumnHeader();
            this.mnuClaims = new System.Windows.Forms.ContextMenu();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFile,
																					this.mnuHandling,
																					this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFileViewPastClaims,
																					this.menuItem1,
																					this.mnuFileRefreshList,
																					this.menuItem5,
																					this.mnuFileExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileViewPastClaims
            // 
            this.mnuFileViewPastClaims.Index = 0;
            this.mnuFileViewPastClaims.Text = "View &Past Claims";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // mnuFileRefreshList
            // 
            this.mnuFileRefreshList.Index = 2;
            this.mnuFileRefreshList.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.mnuFileRefreshList.Text = "&Refresh List";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 4;
            this.mnuFileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuHandling
            // 
            this.mnuHandling.Index = 1;
            this.mnuHandling.Text = "H&andling";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuHelpAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 0;
            this.mnuHelpAbout.Text = "&About";
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProcess.Location = new System.Drawing.Point(0, 414);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(692, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "&Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listClaims);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unprocessed Insurance Claims:";
            // 
            // listClaims
            // 
            this.listClaims.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.colClaimsDate,
																						 this.colClaimsName,
																						 this.colClaimsType,
																						 this.colClaimsCarrier,
																						 this.colClaimsAmount,
																						 this.colClaimsHandling});
            this.listClaims.ContextMenu = this.mnuClaims;
            this.listClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClaims.FullRowSelect = true;
            this.listClaims.Location = new System.Drawing.Point(3, 16);
            this.listClaims.Name = "listClaims";
            this.listClaims.Size = new System.Drawing.Size(686, 395);
            this.listClaims.TabIndex = 0;
            this.listClaims.View = System.Windows.Forms.View.Details;
            // 
            // colClaimsDate
            // 
            this.colClaimsDate.Text = "Date";
            this.colClaimsDate.Width = 80;
            // 
            // colClaimsName
            // 
            this.colClaimsName.Text = "Name";
            this.colClaimsName.Width = 170;
            // 
            // colClaimsType
            // 
            this.colClaimsType.Text = "Type";
            this.colClaimsType.Width = 80;
            // 
            // colClaimsCarrier
            // 
            this.colClaimsCarrier.Text = "Carrier";
            this.colClaimsCarrier.Width = 150;
            // 
            // colClaimsAmount
            // 
            this.colClaimsAmount.Text = "Amount";
            this.colClaimsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colClaimsAmount.Width = 70;
            // 
            // colClaimsHandling
            // 
            this.colClaimsHandling.Text = "Handling";
            this.colClaimsHandling.Width = 115;
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(692, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcess);
            this.Menu = this.mnuMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHDG Electronic Insurace Claim Generator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnProcess_Click_1(object sender, System.EventArgs e)
        {

        }
    }
}
