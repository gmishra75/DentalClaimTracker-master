namespace C_DentalClaimTracker.Appointment_Auditing
{
    partial class frmImportAppointmentAudit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLastImport = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmbFullImportDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbTimeout = new System.Windows.Forms.NumericUpDown();
            this.chkMergeData = new System.Windows.Forms.CheckBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.cmdImport = new System.Windows.Forms.Button();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.btnCalculateChangeTypes = new System.Windows.Forms.Button();
            this.btnImportDentrixProviders = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFullImportDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeout)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLastImport);
            this.groupBox2.Location = new System.Drawing.Point(206, 0);
            this.groupBox2.MaximumSize = new System.Drawing.Size(200, 1000);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 43);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // lblLastImport
            // 
            this.lblLastImport.Location = new System.Drawing.Point(3, 16);
            this.lblLastImport.Name = "lblLastImport";
            this.lblLastImport.Size = new System.Drawing.Size(177, 23);
            this.lblLastImport.TabIndex = 0;
            this.lblLastImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmbFullImportDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmbTimeout);
            this.groupBox1.Controls.Add(this.chkMergeData);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(200, 1000);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "full days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "import past";
            // 
            // nmbFullImportDuration
            // 
            this.nmbFullImportDuration.Enabled = false;
            this.nmbFullImportDuration.Location = new System.Drawing.Point(74, 43);
            this.nmbFullImportDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbFullImportDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbFullImportDuration.Name = "nmbFullImportDuration";
            this.nmbFullImportDuration.Size = new System.Drawing.Size(62, 21);
            this.nmbFullImportDuration.TabIndex = 26;
            this.nmbFullImportDuration.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "data retrieval timeout (seconds)";
            // 
            // nmbTimeout
            // 
            this.nmbTimeout.Location = new System.Drawing.Point(4, 74);
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
            this.nmbTimeout.Size = new System.Drawing.Size(62, 21);
            this.nmbTimeout.TabIndex = 24;
            this.nmbTimeout.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // chkMergeData
            // 
            this.chkMergeData.AutoSize = true;
            this.chkMergeData.Checked = true;
            this.chkMergeData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMergeData.Location = new System.Drawing.Point(6, 20);
            this.chkMergeData.Name = "chkMergeData";
            this.chkMergeData.Size = new System.Drawing.Size(144, 17);
            this.chkMergeData.TabIndex = 3;
            this.chkMergeData.Text = "Merge with existing data";
            this.chkMergeData.UseVisualStyleBackColor = true;
            this.chkMergeData.CheckedChanged += new System.EventHandler(this.chkMergeData_CheckedChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblStatus);
            this.pnlBottom.Controls.Add(this.pbarProgress);
            this.pnlBottom.Controls.Add(this.btnImportDentrixProviders);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 208);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(680, 42);
            this.pnlBottom.TabIndex = 28;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(506, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Waiting to start...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarProgress
            // 
            this.pbarProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbarProgress.Location = new System.Drawing.Point(0, 27);
            this.pbarProgress.Maximum = 1000;
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(506, 13);
            this.pbarProgress.TabIndex = 23;
            // 
            // cmdImport
            // 
            this.cmdImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImport.Location = new System.Drawing.Point(551, 43);
            this.cmdImport.MaximumSize = new System.Drawing.Size(200, 1000);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(126, 56);
            this.cmdImport.TabIndex = 27;
            this.cmdImport.Text = "&Import";
            this.cmdImport.UseVisualStyleBackColor = true;
            this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbStatus.Location = new System.Drawing.Point(0, 101);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(680, 107);
            this.rtbStatus.TabIndex = 29;
            this.rtbStatus.Text = "";
            // 
            // btnCalculateChangeTypes
            // 
            this.btnCalculateChangeTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateChangeTypes.Location = new System.Drawing.Point(206, 49);
            this.btnCalculateChangeTypes.MaximumSize = new System.Drawing.Size(200, 1000);
            this.btnCalculateChangeTypes.Name = "btnCalculateChangeTypes";
            this.btnCalculateChangeTypes.Size = new System.Drawing.Size(200, 47);
            this.btnCalculateChangeTypes.TabIndex = 30;
            this.btnCalculateChangeTypes.Text = "&Calculate Change Types\r\n(Run after import)";
            this.btnCalculateChangeTypes.UseVisualStyleBackColor = true;
            this.btnCalculateChangeTypes.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // btnImportDentrixProviders
            // 
            this.btnImportDentrixProviders.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImportDentrixProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportDentrixProviders.Location = new System.Drawing.Point(506, 0);
            this.btnImportDentrixProviders.MaximumSize = new System.Drawing.Size(200, 1000);
            this.btnImportDentrixProviders.Name = "btnImportDentrixProviders";
            this.btnImportDentrixProviders.Size = new System.Drawing.Size(172, 40);
            this.btnImportDentrixProviders.TabIndex = 34;
            this.btnImportDentrixProviders.Text = "Import Dentrix Providers\r\n(Run with new Providers)";
            this.btnImportDentrixProviders.UseVisualStyleBackColor = true;
            this.btnImportDentrixProviders.Click += new System.EventHandler(this.btnImportDentrixProviders_Click);
            // 
            // frmImportAppointmentAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 250);
            this.Controls.Add(this.btnCalculateChangeTypes);
            this.Controls.Add(this.cmdImport);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportAppointmentAudit";
            this.ShowIcon = false;
            this.Text = "Import Appointment Audits";
            this.Load += new System.EventHandler(this.frmImportAppointmentAudit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFullImportDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbTimeout)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLastImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbTimeout;
        private System.Windows.Forms.CheckBox chkMergeData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmbFullImportDuration;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Button cmdImport;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Button btnCalculateChangeTypes;
        private System.Windows.Forms.Button btnImportDentrixProviders;
    }
}