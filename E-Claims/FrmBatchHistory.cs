using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.AppSettings;

namespace NHDG.EClaims {
	/// <summary>The window that displays past reconcilied batches.</summary>
	public class FrmBatchHistory : Form {
		#region Control Declarations
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView listBatches;
		private System.Windows.Forms.ColumnHeader colBatchesBatchDate;
		private System.Windows.Forms.ContextMenu mnuBatches;
		private System.Windows.Forms.MenuItem mnuBatchesRefresh;
		private System.Windows.Forms.ColumnHeader colBatchesHandling;
		private System.Windows.Forms.ColumnHeader colBatchesNumTransactions;
		private System.Windows.Forms.ListView listTransactions;
		private System.Windows.Forms.ColumnHeader colTransactionsDate;
		private System.Windows.Forms.ColumnHeader colTransactionsName;
		private System.Windows.Forms.ColumnHeader colTransactionsType;
		private System.Windows.Forms.ColumnHeader colTransactionsCarrier;
		private System.Windows.Forms.ColumnHeader colTransactionsAmount;
		private System.Windows.Forms.ColumnHeader colBatchesBatchID;
		private System.Windows.Forms.ColumnHeader colTransactionsResubmit;
		private System.Windows.Forms.ColumnHeader colTransactionsResubmitBatchID;
		private System.Windows.Forms.ContextMenu mnuTransactions;
		private System.Windows.Forms.MenuItem mnuTransactionsToggleResubmit;
		private System.ComponentModel.Container components = null;
		#endregion


		/// <summary>Initializes an instance of FrmBatchHistory.</summary>
		public FrmBatchHistory() {
			InitializeComponent();
			StartEventProcessing();

			// Load the batch list.
			try {
				RefreshList();
			} catch (Exception ex) {
				Globals.Logger.Error("Could not load batches.", ex);
			}
		}


		/// <summary>Clean up any resources being used.</summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Refresh the lists.
		private void RefreshList() {
			Globals.Logger.Debug("Loading batch list...");
			listBatches.Items.Clear();
			listTransactions.Items.Clear();

			SqlCommand cmd = new SqlCommand("SELECT cb.CLAIMBATCHID, " +
											"       cb.BATCH_DATE, " +
											"       cb.HANDLING, " +
											"       COUNT(*) AS NUM_TRANSACTIONS " +
											"FROM NHDG_CLAIM_BATCHES cb " +
											"     INNER JOIN NHDG_CLAIM_TRANSACTIONS ct ON (cb.CLAIMBATCHID = ct.CLAIMBATCHID) " +
											"WHERE (cb.CLAIMBATCHID NOT IN (" + Globals.Settings.ExcludeBatchIDs + ")) " +
											"GROUP BY cb.CLAIMBATCHID, " +
											"         cb.BATCH_DATE, " +
											"         cb.HANDLING " +
											"ORDER BY cb.CLAIMBATCHID DESC", Globals.Database);
			SqlDataReader reader = cmd.ExecuteReader();
			ListViewItem lvi;
			while (reader.Read()) {
				lvi = new ListViewItem(reader.GetInt32(reader.GetOrdinal("CLAIMBATCHID")).ToString());
				lvi.SubItems.Add(reader.GetDateTime(reader.GetOrdinal("BATCH_DATE")).ToString("d"));
				lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("HANDLING")));
				lvi.SubItems.Add(reader.GetInt32(reader.GetOrdinal("NUM_TRANSACTIONS")).ToString());
				lvi.Tag = reader.GetInt32(reader.GetOrdinal("CLAIMBATCHID"));
				listBatches.Items.Add(lvi);
			}
			reader.Close();
			Globals.Logger.Debug("Batches loaded.");
		}


		#region Events
		// Hook into the event processing.
		private void StartEventProcessing() {
			this.listBatches.Click += new System.EventHandler(this.listBatches_Click);
			this.mnuBatchesRefresh.Click += new System.EventHandler(this.mnuBatchesRefresh_Click);
			this.mnuTransactionsToggleResubmit.Click += new System.EventHandler(this.mnuTransactionsToggleResubmit_Click);
		}

		// User wants to view a batch.
		private void listBatches_Click(object sender, System.EventArgs e) {
			if (listBatches.SelectedItems.Count != 1) { return; }
			listTransactions.Items.Clear();

			Globals.Logger.Info("Viewing batch " + listBatches.SelectedItems[0].Tag.ToString());


			// Get the individual transactions.
			Globals.Logger.Debug("Loading transaction list for " + listBatches.SelectedItems[0].Tag.ToString() + ".");
			SqlCommand cmd = new SqlCommand("SELECT CLAIM_ID, " +
											"       CLAIM_DB, " +
											"       CLAIM_DATE, " +
											"       CLAIM_ORD, " +
											"       CLAIM_TOTAL_BILLED, " +
											"       INS_NAME, " +
											"       PAT_LASTNAME, " +
											"       PAT_FIRSTNAME, " +
											"       PAT_MIDDLENAME, " +
											"       CLAIMBATCHID, " +
											"       RESUBMIT_FLAG, " +
											"       BATCH_RESUBMITTED " +
											"FROM NHDG_CLAIM_DETAILED_TRANSACTIONS " +
											"WHERE (CLAIMBATCHID = " + listBatches.SelectedItems[0].Tag.ToString() + ") " +
											"ORDER BY CLAIM_DATE, " +
											"         PAT_LASTNAME, " +
											"         PAT_FIRSTNAME, " +
											"         CLAIM_ORD", Globals.Database);
			SqlDataReader reader = null;
			try {
				reader = cmd.ExecuteReader();
				ListViewItem lvi;
				while (reader.Read()) {
					lvi = new ListViewItem(reader.GetDateTime(reader.GetOrdinal("CLAIM_DATE")).ToString("d"));
					lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("PAT_LASTNAME")) + ", " + reader.GetString(reader.GetOrdinal("PAT_FIRSTNAME")) + " " + reader.GetString(reader.GetOrdinal("PAT_MIDDLENAME")));
					lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("CLAIM_ORD")));
					lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("INS_NAME")));
					lvi.SubItems.Add(Utilities.FormatCurrency(reader.GetInt32(reader.GetOrdinal("CLAIM_TOTAL_BILLED"))));
					if (reader.IsDBNull(reader.GetOrdinal("RESUBMIT_FLAG"))) {
						lvi.SubItems.Add(string.Empty);
					} else {
						lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("RESUBMIT_FLAG")));
					}
					if (reader.IsDBNull(reader.GetOrdinal("BATCH_RESUBMITTED"))) {
						lvi.SubItems.Add(string.Empty);
					} else {
						lvi.SubItems.Add(reader.GetInt32(reader.GetOrdinal("BATCH_RESUBMITTED")).ToString());
					}
					lvi.Tag = new int[3] {
											reader.GetInt32(reader.GetOrdinal("CLAIM_ID")),
											reader.GetInt32(reader.GetOrdinal("CLAIM_DB")),
											reader.GetInt32(reader.GetOrdinal("CLAIMBATCHID"))
										 };
					listTransactions.Items.Add(lvi);
				}
				Globals.Logger.Debug("List retrieved.");
			} catch (Exception ex) {
				MessageBox.Show("There was an error when trying to retrieve the list of transactions.", "View Batch History");
				Globals.Logger.Error("There was an error retrieving the list of transactions.", ex);
			} finally {
				if (reader != null) { reader.Close(); }
			}
		}

		// Refresh the lists.
		private void mnuBatchesRefresh_Click(object sender, System.EventArgs e) {
			try {
				RefreshList();
			} catch (Exception ex) {
				Globals.Logger.Error("Could not load batches.", ex);
			}		
		}

		// Toggle the resubmit status of a transaction.
		private void mnuTransactionsToggleResubmit_Click(object sender, System.EventArgs e) {
			SqlCommand cmd;

			foreach (ListViewItem lvi in listTransactions.SelectedItems) {
				try {
					if (lvi.SubItems[5].Text == "Y") {
						// Already marked -- unmark it.
						cmd = new SqlCommand("UPDATE NHDG_CLAIM_TRANSACTIONS " +
											"SET RESUBMIT_FLAG = NULL " +
											"WHERE (CLAIM_ID = " + ((int[])lvi.Tag)[0].ToString() + ") " +
											"  AND (CLAIM_DB = " + ((int[])lvi.Tag)[1].ToString() + ") " +
											"  AND (CLAIMBATCHID = " + ((int[])lvi.Tag)[2].ToString() + ")", Globals.Database);
						if (cmd.ExecuteNonQuery() == 1) {
							lvi.SubItems[5].Text = string.Empty;
							Globals.Logger.Info("Unmarked transaction " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString() + " for resubmission.");
						} else {
							Globals.Logger.Error("Could not unmark transaction " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString() + " for resubmission.");
						}
					} else {
						if (lvi.SubItems[6].Text != string.Empty) {
							// Already been resubmitted -- deny.
							Globals.Logger.Debug("Tried to mark transaction " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString() + " for resubmission (already resubmitted).");
							MessageBox.Show("Cannot resubmit a transaction that has already been resubmitted.", "Resubmit");
						} else {
							// Mark it.
							cmd = new SqlCommand("UPDATE NHDG_CLAIM_TRANSACTIONS " +
												"SET RESUBMIT_FLAG = 'Y' " +
												"WHERE (CLAIM_ID = " + ((int[])lvi.Tag)[0].ToString() + ") " +
												"  AND (CLAIM_DB = " + ((int[])lvi.Tag)[1].ToString() + ") " +
												"  AND (CLAIMBATCHID = " + ((int[])lvi.Tag)[2].ToString() + ")", Globals.Database);
							if (cmd.ExecuteNonQuery() == 1) {
								lvi.SubItems[5].Text = "Y";
								Globals.Logger.Info("Marked transaction " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString() + " for resubmission.");
							} else {
								Globals.Logger.Error("Could not mark transaction " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString() + " for resubmission.");
							}
						}
					}
				} catch (Exception ex) {
					Globals.Logger.Error("There was an error when toggling resubmit status for " + ((int[])lvi.Tag)[0].ToString() + "/" + ((int[])lvi.Tag)[1].ToString() + "/" + ((int[])lvi.Tag)[2].ToString(), ex);
					MessageBox.Show("There was an error trying to resubmit the transaction.", "Resubmit");
				}
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBatches = new System.Windows.Forms.ListView();
			this.colBatchesBatchDate = new System.Windows.Forms.ColumnHeader();
			this.colBatchesHandling = new System.Windows.Forms.ColumnHeader();
			this.colBatchesNumTransactions = new System.Windows.Forms.ColumnHeader();
			this.mnuBatches = new System.Windows.Forms.ContextMenu();
			this.mnuBatchesRefresh = new System.Windows.Forms.MenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listTransactions = new System.Windows.Forms.ListView();
			this.colTransactionsDate = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsName = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsType = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsCarrier = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsAmount = new System.Windows.Forms.ColumnHeader();
			this.colBatchesBatchID = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsResubmit = new System.Windows.Forms.ColumnHeader();
			this.colTransactionsResubmitBatchID = new System.Windows.Forms.ColumnHeader();
			this.mnuTransactions = new System.Windows.Forms.ContextMenu();
			this.mnuTransactionsToggleResubmit = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.listBatches});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(720, 216);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Batches:";
			// 
			// listBatches
			// 
			this.listBatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.colBatchesBatchID,
																						  this.colBatchesBatchDate,
																						  this.colBatchesHandling,
																						  this.colBatchesNumTransactions});
			this.listBatches.ContextMenu = this.mnuBatches;
			this.listBatches.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBatches.FullRowSelect = true;
			this.listBatches.Location = new System.Drawing.Point(3, 16);
			this.listBatches.MultiSelect = false;
			this.listBatches.Name = "listBatches";
			this.listBatches.Size = new System.Drawing.Size(714, 197);
			this.listBatches.TabIndex = 0;
			this.listBatches.View = System.Windows.Forms.View.Details;
			// 
			// colBatchesBatchDate
			// 
			this.colBatchesBatchDate.Text = "Batch Date";
			this.colBatchesBatchDate.Width = 80;
			// 
			// colBatchesHandling
			// 
			this.colBatchesHandling.Text = "Handling";
			this.colBatchesHandling.Width = 150;
			// 
			// colBatchesNumTransactions
			// 
			this.colBatchesNumTransactions.Text = "Transactions";
			this.colBatchesNumTransactions.Width = 80;
			// 
			// mnuBatches
			// 
			this.mnuBatches.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.mnuBatchesRefresh});
			// 
			// mnuBatchesRefresh
			// 
			this.mnuBatchesRefresh.Index = 0;
			this.mnuBatchesRefresh.Text = "Refresh List";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 216);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(720, 4);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.listTransactions});
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 220);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(720, 249);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Details:";
			// 
			// listTransactions
			// 
			this.listTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							   this.colTransactionsDate,
																							   this.colTransactionsName,
																							   this.colTransactionsType,
																							   this.colTransactionsCarrier,
																							   this.colTransactionsAmount,
																							   this.colTransactionsResubmit,
																							   this.colTransactionsResubmitBatchID});
			this.listTransactions.ContextMenu = this.mnuTransactions;
			this.listTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listTransactions.FullRowSelect = true;
			this.listTransactions.Location = new System.Drawing.Point(3, 16);
			this.listTransactions.Name = "listTransactions";
			this.listTransactions.Size = new System.Drawing.Size(714, 230);
			this.listTransactions.TabIndex = 1;
			this.listTransactions.View = System.Windows.Forms.View.Details;
			// 
			// colTransactionsDate
			// 
			this.colTransactionsDate.Text = "Date";
			this.colTransactionsDate.Width = 80;
			// 
			// colTransactionsName
			// 
			this.colTransactionsName.Text = "Name";
			this.colTransactionsName.Width = 175;
			// 
			// colTransactionsType
			// 
			this.colTransactionsType.Text = "Type";
			this.colTransactionsType.Width = 80;
			// 
			// colTransactionsCarrier
			// 
			this.colTransactionsCarrier.Text = "Carrier";
			this.colTransactionsCarrier.Width = 150;
			// 
			// colTransactionsAmount
			// 
			this.colTransactionsAmount.Text = "Amount";
			this.colTransactionsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colTransactionsAmount.Width = 70;
			// 
			// colBatchesBatchID
			// 
			this.colBatchesBatchID.Text = "ID";
			this.colBatchesBatchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// colTransactionsResubmit
			// 
			this.colTransactionsResubmit.Text = "Resubmit";
			// 
			// colTransactionsResubmitBatchID
			// 
			this.colTransactionsResubmitBatchID.Text = "Resubmit BID";
			this.colTransactionsResubmitBatchID.Width = 78;
			// 
			// mnuTransactions
			// 
			this.mnuTransactions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.mnuTransactionsToggleResubmit});
			// 
			// mnuTransactionsToggleResubmit
			// 
			this.mnuTransactionsToggleResubmit.Index = 0;
			this.mnuTransactionsToggleResubmit.Text = "&Toggle Resubmit";
			// 
			// FrmBatchHistory
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.splitter1,
																		  this.groupBox1});
			this.Name = "FrmBatchHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Processed Batches";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
