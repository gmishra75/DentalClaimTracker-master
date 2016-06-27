namespace C_DentalClaimTracker
{
    partial class frmImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportData));
            this.cmbSchema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkEditSchema = new System.Windows.Forms.LinkLabel();
            this.chkMergeData = new System.Windows.Forms.CheckBox();
            this.chkMergeChanges = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbTimeout = new System.Windows.Forms.NumericUpDown();
            this.cmdImport = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLastImport = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.pnlAdvancedSettings = new System.Windows.Forms.Panel();
            this.lblAdvancedSettings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtReport = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSecondaryPreClaimCount = new System.Windows.Forms.Label();
            this.lblPredetermClaimCount = new System.Windows.Forms.Label();
            this.lblSecondaryClaimCount = new System.Windows.Forms.Label();
            this.lblPrimaryClaimCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeout)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlAdvancedSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSchema
            // 
            this.cmbSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchema.Enabled = false;
            this.cmbSchema.FormattingEnabled = true;
            this.cmbSchema.Location = new System.Drawing.Point(3, 43);
            this.cmbSchema.Name = "cmbSchema";
            this.cmbSchema.Size = new System.Drawing.Size(170, 21);
            this.cmbSchema.TabIndex = 0;
            this.cmbSchema.SelectedIndexChanged += new System.EventHandler(this.cmbSchema_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a schema";
            // 
            // lnkEditSchema
            // 
            this.lnkEditSchema.AutoSize = true;
            this.lnkEditSchema.Location = new System.Drawing.Point(98, 27);
            this.lnkEditSchema.Name = "lnkEditSchema";
            this.lnkEditSchema.Size = new System.Drawing.Size(76, 13);
            this.lnkEditSchema.TabIndex = 2;
            this.lnkEditSchema.TabStop = true;
            this.lnkEditSchema.Text = "Edit Schema...";
            this.lnkEditSchema.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditSchema_LinkClicked);
            // 
            // chkMergeData
            // 
            this.chkMergeData.AutoSize = true;
            this.chkMergeData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMergeData.Checked = true;
            this.chkMergeData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMergeData.Location = new System.Drawing.Point(243, 27);
            this.chkMergeData.Name = "chkMergeData";
            this.chkMergeData.Size = new System.Drawing.Size(140, 17);
            this.chkMergeData.TabIndex = 3;
            this.chkMergeData.Text = "Merge with existing data";
            this.chkMergeData.UseVisualStyleBackColor = true;
            this.chkMergeData.CheckedChanged += new System.EventHandler(this.chkMergeData_CheckedChanged);
            // 
            // chkMergeChanges
            // 
            this.chkMergeChanges.AutoSize = true;
            this.chkMergeChanges.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMergeChanges.Location = new System.Drawing.Point(223, 50);
            this.chkMergeChanges.Name = "chkMergeChanges";
            this.chkMergeChanges.Size = new System.Drawing.Size(160, 17);
            this.chkMergeChanges.TabIndex = 26;
            this.chkMergeChanges.Text = "Only change updated claims";
            this.chkMergeChanges.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data Retrieval Timeout (seconds)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmbTimeout
            // 
            this.nmbTimeout.Location = new System.Drawing.Point(6, 89);
            this.nmbTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbTimeout.Name = "nmbTimeout";
            this.nmbTimeout.Size = new System.Drawing.Size(62, 20);
            this.nmbTimeout.TabIndex = 24;
            this.nmbTimeout.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // cmdImport
            // 
            this.cmdImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImport.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_orange;
            this.cmdImport.Location = new System.Drawing.Point(248, 0);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(149, 64);
            this.cmdImport.TabIndex = 21;
            this.cmdImport.Text = "&Import";
            this.cmdImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdImport.UseVisualStyleBackColor = true;
            this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblStatus);
            this.pnlBottom.Controls.Add(this.pbarProgress);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 375);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(397, 36);
            this.pnlBottom.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(395, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Waiting to start...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarProgress
            // 
            this.pbarProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbarProgress.Location = new System.Drawing.Point(0, 21);
            this.pbarProgress.Maximum = 1000;
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(395, 13);
            this.pbarProgress.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLastImport);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 51);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // lblLastImport
            // 
            this.lblLastImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastImport.Location = new System.Drawing.Point(3, 16);
            this.lblLastImport.Name = "lblLastImport";
            this.lblLastImport.Size = new System.Drawing.Size(232, 32);
            this.lblLastImport.TabIndex = 0;
            this.lblLastImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(0, 64);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(397, 288);
            this.txtStatus.TabIndex = 25;
            this.txtStatus.Text = "";
            // 
            // pnlAdvancedSettings
            // 
            this.pnlAdvancedSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdvancedSettings.Controls.Add(this.nmbTimeout);
            this.pnlAdvancedSettings.Controls.Add(this.chkMergeChanges);
            this.pnlAdvancedSettings.Controls.Add(this.lblAdvancedSettings);
            this.pnlAdvancedSettings.Controls.Add(this.chkMergeData);
            this.pnlAdvancedSettings.Controls.Add(this.label2);
            this.pnlAdvancedSettings.Controls.Add(this.label1);
            this.pnlAdvancedSettings.Controls.Add(this.cmbSchema);
            this.pnlAdvancedSettings.Controls.Add(this.lnkEditSchema);
            this.pnlAdvancedSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdvancedSettings.Location = new System.Drawing.Point(0, 352);
            this.pnlAdvancedSettings.Name = "pnlAdvancedSettings";
            this.pnlAdvancedSettings.Size = new System.Drawing.Size(397, 23);
            this.pnlAdvancedSettings.TabIndex = 26;
            // 
            // lblAdvancedSettings
            // 
            this.lblAdvancedSettings.BackColor = System.Drawing.Color.White;
            this.lblAdvancedSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdvancedSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdvancedSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvancedSettings.Location = new System.Drawing.Point(0, 0);
            this.lblAdvancedSettings.Name = "lblAdvancedSettings";
            this.lblAdvancedSettings.Size = new System.Drawing.Size(395, 23);
            this.lblAdvancedSettings.TabIndex = 21;
            this.lblAdvancedSettings.Text = "Advanced Settings (double-click)";
            this.lblAdvancedSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdvancedSettings.Click += new System.EventHandler(this.lblAdvancedSettings_Click_1);
            this.lblAdvancedSettings.DoubleClick += new System.EventHandler(this.lblAdvancedSettings_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cmdImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 64);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxtReport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 411);
            this.panel1.TabIndex = 28;
            // 
            // rtxtReport
            // 
            this.rtxtReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtReport.Location = new System.Drawing.Point(0, 69);
            this.rtxtReport.Name = "rtxtReport";
            this.rtxtReport.Size = new System.Drawing.Size(446, 342);
            this.rtxtReport.TabIndex = 2;
            this.rtxtReport.Text = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSecondaryPreClaimCount);
            this.panel3.Controls.Add(this.lblPredetermClaimCount);
            this.panel3.Controls.Add(this.lblSecondaryClaimCount);
            this.panel3.Controls.Add(this.lblPrimaryClaimCount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 69);
            this.panel3.TabIndex = 1;
            // 
            // lblSecondaryPreClaimCount
            // 
            this.lblSecondaryPreClaimCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSecondaryPreClaimCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondaryPreClaimCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryPreClaimCount.Location = new System.Drawing.Point(344, 30);
            this.lblSecondaryPreClaimCount.Name = "lblSecondaryPreClaimCount";
            this.lblSecondaryPreClaimCount.Size = new System.Drawing.Size(100, 37);
            this.lblSecondaryPreClaimCount.TabIndex = 4;
            this.lblSecondaryPreClaimCount.Text = "Secondary Pre\r\n0";
            this.lblSecondaryPreClaimCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPredetermClaimCount
            // 
            this.lblPredetermClaimCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPredetermClaimCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPredetermClaimCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredetermClaimCount.Location = new System.Drawing.Point(229, 30);
            this.lblPredetermClaimCount.Name = "lblPredetermClaimCount";
            this.lblPredetermClaimCount.Size = new System.Drawing.Size(100, 37);
            this.lblPredetermClaimCount.TabIndex = 3;
            this.lblPredetermClaimCount.Text = "Predeterm\r\n0";
            this.lblPredetermClaimCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondaryClaimCount
            // 
            this.lblSecondaryClaimCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSecondaryClaimCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondaryClaimCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryClaimCount.Location = new System.Drawing.Point(114, 30);
            this.lblSecondaryClaimCount.Name = "lblSecondaryClaimCount";
            this.lblSecondaryClaimCount.Size = new System.Drawing.Size(100, 38);
            this.lblSecondaryClaimCount.TabIndex = 2;
            this.lblSecondaryClaimCount.Text = "Secondary\r\n0";
            this.lblSecondaryClaimCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrimaryClaimCount
            // 
            this.lblPrimaryClaimCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrimaryClaimCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrimaryClaimCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryClaimCount.Location = new System.Drawing.Point(-1, 30);
            this.lblPrimaryClaimCount.Name = "lblPrimaryClaimCount";
            this.lblPrimaryClaimCount.Size = new System.Drawing.Size(100, 37);
            this.lblPrimaryClaimCount.TabIndex = 1;
            this.lblPrimaryClaimCount.Text = "Primary\r\n0";
            this.lblPrimaryClaimCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Import Report";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 411);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAdvancedSettings);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportData";
            this.Text = "Import Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImportData_FormClosing);
            this.Load += new System.EventHandler(this.frmImportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeout)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlAdvancedSettings.ResumeLayout(false);
            this.pnlAdvancedSettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSchema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkEditSchema;
        private System.Windows.Forms.CheckBox chkMergeData;
        private System.Windows.Forms.Button cmdImport;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbTimeout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLastImport;
        private System.Windows.Forms.CheckBox chkMergeChanges;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Panel pnlAdvancedSettings;
        private System.Windows.Forms.Label lblAdvancedSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecondaryPreClaimCount;
        private System.Windows.Forms.Label lblPredetermClaimCount;
        private System.Windows.Forms.Label lblSecondaryClaimCount;
        private System.Windows.Forms.Label lblPrimaryClaimCount;
        private System.Windows.Forms.RichTextBox rtxtReport;

    }
}