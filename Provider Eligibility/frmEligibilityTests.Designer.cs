namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmEligibilityTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEligibilityTests));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dtpDOS = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunTestAllInsurance = new System.Windows.Forms.Button();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHideHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProviderFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pnlHelp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnHelp);
            this.pnlTop.Controls.Add(this.groupBox2);
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(605, 86);
            this.pnlTop.TabIndex = 0;
            // 
            // dtpDOS
            // 
            this.dtpDOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOS.Location = new System.Drawing.Point(232, 35);
            this.dtpDOS.Name = "dtpDOS";
            this.dtpDOS.Size = new System.Drawing.Size(107, 20);
            this.dtpDOS.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of Service";
            // 
            // btnRunTestAllInsurance
            // 
            this.btnRunTestAllInsurance.Location = new System.Drawing.Point(12, 19);
            this.btnRunTestAllInsurance.Name = "btnRunTestAllInsurance";
            this.btnRunTestAllInsurance.Size = new System.Drawing.Size(100, 45);
            this.btnRunTestAllInsurance.TabIndex = 5;
            this.btnRunTestAllInsurance.Text = "Run Test for Every Insurance";
            this.btnRunTestAllInsurance.UseVisualStyleBackColor = true;
            this.btnRunTestAllInsurance.Click += new System.EventHandler(this.btnRunTestAllInsurance_Click);
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Location = new System.Drawing.Point(112, 38);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFilter.TabIndex = 3;
            // 
            // btnRunTests
            // 
            this.btnRunTests.Location = new System.Drawing.Point(6, 19);
            this.btnRunTests.Name = "btnRunTests";
            this.btnRunTests.Size = new System.Drawing.Size(100, 45);
            this.btnRunTests.TabIndex = 2;
            this.btnRunTests.Text = "Run Standard Tests";
            this.btnRunTests.UseVisualStyleBackColor = true;
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider Filter";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnAddTest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(252, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProvider,
            this.colInsurance,
            this.colDateOfService,
            this.colResult,
            this.colIsChanged,
            this.colID});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 225);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(605, 311);
            this.dgvResults.TabIndex = 2;
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            this.colProvider.Width = 120;
            // 
            // colInsurance
            // 
            this.colInsurance.HeaderText = "Insurance";
            this.colInsurance.Name = "colInsurance";
            this.colInsurance.ReadOnly = true;
            this.colInsurance.Width = 200;
            // 
            // colDateOfService
            // 
            this.colDateOfService.HeaderText = "DOS";
            this.colDateOfService.Name = "colDateOfService";
            this.colDateOfService.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "New Provider";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.Width = 120;
            // 
            // colIsChanged
            // 
            this.colIsChanged.HeaderText = "Change";
            this.colIsChanged.Name = "colIsChanged";
            this.colIsChanged.ReadOnly = true;
            this.colIsChanged.Width = 60;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::C_DentalClaimTracker.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(576, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(26, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTest.Image = global::C_DentalClaimTracker.Properties.Resources.add;
            this.btnAddTest.Location = new System.Drawing.Point(500, 0);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(105, 42);
            this.btnAddTest.TabIndex = 4;
            this.btnAddTest.Text = "Add Standard Tests";
            this.btnAddTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.Controls.Add(this.label3);
            this.pnlHelp.Controls.Add(this.label5);
            this.pnlHelp.Controls.Add(this.btnHideHelp);
            this.pnlHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelp.Location = new System.Drawing.Point(0, 86);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(605, 139);
            this.pnlHelp.TabIndex = 3;
            this.pnlHelp.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(605, 91);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHideHelp
            // 
            this.btnHideHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHideHelp.Location = new System.Drawing.Point(0, 0);
            this.btnHideHelp.Name = "btnHideHelp";
            this.btnHideHelp.Size = new System.Drawing.Size(605, 23);
            this.btnHideHelp.TabIndex = 1;
            this.btnHideHelp.Text = "^ Hide ^";
            this.btnHideHelp.UseVisualStyleBackColor = true;
            this.btnHideHelp.Click += new System.EventHandler(this.btnHideHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunTests);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchFilter);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Tests";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtProviderFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRunTestAllInsurance);
            this.groupBox2.Controls.Add(this.dtpDOS);
            this.groupBox2.Location = new System.Drawing.Point(240, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 73);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Insurance Tests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Provider Filter";
            // 
            // txtProviderFilter
            // 
            this.txtProviderFilter.Location = new System.Drawing.Point(118, 35);
            this.txtProviderFilter.Name = "txtProviderFilter";
            this.txtProviderFilter.Size = new System.Drawing.Size(100, 20);
            this.txtProviderFilter.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(605, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Help";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEligibilityTests
            // 
            this.AcceptButton = this.btnRunTests;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 578);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmEligibilityTests";
            this.Text = "Provider Eligibility Tests";
            this.Load += new System.EventHandler(this.frmEligibilityTests_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pnlHelp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunTests;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.Button btnRunTestAllInsurance;
        private System.Windows.Forms.DateTimePicker dtpDOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHideHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProviderFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}