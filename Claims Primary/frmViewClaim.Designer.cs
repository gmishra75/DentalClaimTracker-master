namespace C_DentalClaimTracker
{
    partial class frmViewClaim
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewClaim));
            this.cmdNextClaim = new System.Windows.Forms.Button();
            this.cmdPreviousClaim = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.pnlClaimData = new System.Windows.Forms.Panel();
            this.lnkViewClaimChangeHistory = new System.Windows.Forms.LinkLabel();
            this.label32 = new System.Windows.Forms.Label();
            this.nmbRevisitInterval = new System.Windows.Forms.NumericUpDown();
            this.chkSetRevisitDate = new System.Windows.Forms.CheckBox();
            this.pnlLeftPanel = new System.Windows.Forms.Panel();
            this.pnlRightPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.callManager = new C_DentalClaimTracker.CallManager();
            this.ctlRevisitDate = new C_DentalClaimTracker.ctlDateEntry();
            this.ctlHandlingDisplay = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.label34 = new System.Windows.Forms.Label();
            this.ctlBatchDate = new C_DentalClaimTracker.ctlDateEntry();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbHandling = new System.Windows.Forms.ComboBox();
            this.chkInBatch = new System.Windows.Forms.CheckBox();
            this.ctlClaimDisplayPatient = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.ctlPatientDOB = new C_DentalClaimTracker.ctlDateEntry();
            this.txtPatientState = new System.Windows.Forms.TextBox();
            this.txtPatientCity = new System.Windows.Forms.TextBox();
            this.txtPatientAddress2 = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientZIP = new System.Windows.Forms.TextBox();
            this.txtPatientSSN = new System.Windows.Forms.TextBox();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayInsurance = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.txtInsuranceState = new System.Windows.Forms.TextBox();
            this.lnkViewCompanyContactInfo = new System.Windows.Forms.LinkLabel();
            this.txtInsuranceAddress = new System.Windows.Forms.TextBox();
            this.cmbInsuranceCarrier = new System.Windows.Forms.ComboBox();
            this.txtInsuranceAddress2 = new System.Windows.Forms.TextBox();
            this.txtInsuranceCity = new System.Windows.Forms.TextBox();
            this.txtInsuranceZIP = new System.Windows.Forms.TextBox();
            this.txtInsurancePhone = new System.Windows.Forms.TextBox();
            this.lblInsuranceCity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkCreateCompany = new System.Windows.Forms.LinkLabel();
            this.lnkEditCompany = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayDoctor = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDoctorTaxID = new System.Windows.Forms.TextBox();
            this.txtDoctorLicenseID = new System.Windows.Forms.TextBox();
            this.txtDoctorBC = new System.Windows.Forms.TextBox();
            this.txtDoctorPhone = new System.Windows.Forms.TextBox();
            this.txtDoctorFax = new System.Windows.Forms.TextBox();
            this.txtDoctorAddress2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDoctorAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDoctorState = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtDoctorZIP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDoctorCity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayGeneral = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.ctlTracerDate = new C_DentalClaimTracker.ctlDateEntry();
            this.ctlOnHoldDate = new C_DentalClaimTracker.ctlDateEntry();
            this.ctlResentDate = new C_DentalClaimTracker.ctlDateEntry();
            this.ctlSentDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayNotes = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.ctlClaimDisplaySubscriber = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.txtSubscriberName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ctlSubscriberDOB = new C_DentalClaimTracker.ctlDateEntry();
            this.txtSubscriberAltID = new System.Windows.Forms.TextBox();
            this.txtSubscriberID = new System.Windows.Forms.TextBox();
            this.txtSubscriberGroupName = new System.Windows.Forms.TextBox();
            this.txtSubscriberAddress = new System.Windows.Forms.TextBox();
            this.txtSubscriberGroupNum = new System.Windows.Forms.TextBox();
            this.txtSubscriberSSN = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSubscriberZIP = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSubscriberAddress2 = new System.Windows.Forms.TextBox();
            this.txtSubscriberState = new System.Windows.Forms.TextBox();
            this.txtSubscriberCity = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayServices = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.dgvProcedureData = new System.Windows.Forms.DataGridView();
            this.linkedProcedureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcedureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToothRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateOfService = new System.Windows.Forms.TextBox();
            this.nmbClaimAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClaimData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRevisitInterval)).BeginInit();
            this.pnlLeftPanel.SuspendLayout();
            this.pnlRightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ctlHandlingDisplay.SuspendLayout();
            this.ctlClaimDisplayPatient.SuspendLayout();
            this.ctlClaimDisplayInsurance.SuspendLayout();
            this.ctlClaimDisplayDoctor.SuspendLayout();
            this.ctlClaimDisplayGeneral.SuspendLayout();
            this.ctlClaimDisplayNotes.SuspendLayout();
            this.ctlClaimDisplaySubscriber.SuspendLayout();
            this.ctlClaimDisplayServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedureData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbClaimAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNextClaim
            // 
            this.cmdNextClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNextClaim.Location = new System.Drawing.Point(269, 5);
            this.cmdNextClaim.Name = "cmdNextClaim";
            this.cmdNextClaim.Size = new System.Drawing.Size(73, 24);
            this.cmdNextClaim.TabIndex = 9;
            this.cmdNextClaim.Text = "Claim &>>";
            this.cmdNextClaim.UseVisualStyleBackColor = true;
            this.cmdNextClaim.Visible = false;
            this.cmdNextClaim.Click += new System.EventHandler(this.cmdNextClaim_Click);
            // 
            // cmdPreviousClaim
            // 
            this.cmdPreviousClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPreviousClaim.Location = new System.Drawing.Point(190, 5);
            this.cmdPreviousClaim.Name = "cmdPreviousClaim";
            this.cmdPreviousClaim.Size = new System.Drawing.Size(73, 24);
            this.cmdPreviousClaim.TabIndex = 8;
            this.cmdPreviousClaim.Text = "&<< Claim";
            this.cmdPreviousClaim.UseVisualStyleBackColor = true;
            this.cmdPreviousClaim.Visible = false;
            this.cmdPreviousClaim.Click += new System.EventHandler(this.cmdPreviousClaim_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(366, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(73, 24);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(467, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 24);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // pnlClaimData
            // 
            this.pnlClaimData.AutoScroll = true;
            this.pnlClaimData.Controls.Add(this.ctlHandlingDisplay);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayPatient);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayInsurance);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayDoctor);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayGeneral);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayNotes);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplaySubscriber);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayServices);
            this.pnlClaimData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClaimData.Location = new System.Drawing.Point(0, 0);
            this.pnlClaimData.Name = "pnlClaimData";
            this.pnlClaimData.Size = new System.Drawing.Size(545, 678);
            this.pnlClaimData.TabIndex = 15;
            // 
            // lnkViewClaimChangeHistory
            // 
            this.lnkViewClaimChangeHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkViewClaimChangeHistory.AutoSize = true;
            this.lnkViewClaimChangeHistory.Location = new System.Drawing.Point(8, 11);
            this.lnkViewClaimChangeHistory.Name = "lnkViewClaimChangeHistory";
            this.lnkViewClaimChangeHistory.Size = new System.Drawing.Size(93, 13);
            this.lnkViewClaimChangeHistory.TabIndex = 87;
            this.lnkViewClaimChangeHistory.TabStop = true;
            this.lnkViewClaimChangeHistory.Text = "Change History...";
            this.lnkViewClaimChangeHistory.Visible = false;
            this.lnkViewClaimChangeHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewClaimChangeHistory_LinkClicked);
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(322, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(30, 13);
            this.label32.TabIndex = 13;
            this.label32.Text = "days";
            // 
            // nmbRevisitInterval
            // 
            this.nmbRevisitInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmbRevisitInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbRevisitInterval.Location = new System.Drawing.Point(278, 4);
            this.nmbRevisitInterval.Name = "nmbRevisitInterval";
            this.nmbRevisitInterval.Size = new System.Drawing.Size(44, 21);
            this.nmbRevisitInterval.TabIndex = 12;
            this.nmbRevisitInterval.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nmbRevisitInterval.ValueChanged += new System.EventHandler(this.nmbRevisitInterval_ValueChanged);
            this.nmbRevisitInterval.Leave += new System.EventHandler(this.nmbRevisitInterval_ValueChanged);
            // 
            // chkSetRevisitDate
            // 
            this.chkSetRevisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSetRevisitDate.AutoSize = true;
            this.chkSetRevisitDate.Checked = true;
            this.chkSetRevisitDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetRevisitDate.Location = new System.Drawing.Point(46, 8);
            this.chkSetRevisitDate.Name = "chkSetRevisitDate";
            this.chkSetRevisitDate.Size = new System.Drawing.Size(106, 17);
            this.chkSetRevisitDate.TabIndex = 15;
            this.chkSetRevisitDate.Text = "Set revisit date: ";
            this.chkSetRevisitDate.UseVisualStyleBackColor = true;
            // 
            // pnlLeftPanel
            // 
            this.pnlLeftPanel.AutoScroll = true;
            this.pnlLeftPanel.Controls.Add(this.pnlClaimData);
            this.pnlLeftPanel.Controls.Add(this.panel2);
            this.pnlLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftPanel.Name = "pnlLeftPanel";
            this.pnlLeftPanel.Size = new System.Drawing.Size(545, 714);
            this.pnlLeftPanel.TabIndex = 90;
            // 
            // pnlRightPanel
            // 
            this.pnlRightPanel.Controls.Add(this.callManager);
            this.pnlRightPanel.Controls.Add(this.panel1);
            this.pnlRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightPanel.Location = new System.Drawing.Point(545, 0);
            this.pnlRightPanel.Name = "pnlRightPanel";
            this.pnlRightPanel.Size = new System.Drawing.Size(446, 714);
            this.pnlRightPanel.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ctlRevisitDate);
            this.panel1.Controls.Add(this.chkSetRevisitDate);
            this.panel1.Controls.Add(this.nmbRevisitInterval);
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 678);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 36);
            this.panel1.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmdSave);
            this.panel2.Controls.Add(this.lnkViewClaimChangeHistory);
            this.panel2.Controls.Add(this.cmdNextClaim);
            this.panel2.Controls.Add(this.cmdPreviousClaim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 36);
            this.panel2.TabIndex = 91;
            // 
            // callManager
            // 
            this.callManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callManager.Location = new System.Drawing.Point(0, 0);
            this.callManager.Name = "callManager";
            this.callManager.Size = new System.Drawing.Size(446, 678);
            this.callManager.TabIndex = 14;
            // 
            // ctlRevisitDate
            // 
            this.ctlRevisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlRevisitDate.CurrentDate = null;
            this.ctlRevisitDate.DateSelectionVisible = true;
            this.ctlRevisitDate.DateValue = null;
            this.ctlRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlRevisitDate.Location = new System.Drawing.Point(148, 4);
            this.ctlRevisitDate.Name = "ctlRevisitDate";
            this.ctlRevisitDate.Size = new System.Drawing.Size(124, 21);
            this.ctlRevisitDate.TabIndex = 14;
            this.ctlRevisitDate.ValueChanged += new System.EventHandler(this.ctlRevisitDate_ValueChanged);
            // 
            // ctlHandlingDisplay
            // 
            this.ctlHandlingDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlHandlingDisplay.CanMaximize = false;
            this.ctlHandlingDisplay.Caption = "Handling";
            this.ctlHandlingDisplay.Controls.Add(this.label34);
            this.ctlHandlingDisplay.Controls.Add(this.ctlBatchDate);
            this.ctlHandlingDisplay.Controls.Add(this.label33);
            this.ctlHandlingDisplay.Controls.Add(this.cmbHandling);
            this.ctlHandlingDisplay.Controls.Add(this.chkInBatch);
            this.ctlHandlingDisplay.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Full;
            this.ctlHandlingDisplay.FormIndex = 7;
            this.ctlHandlingDisplay.Location = new System.Drawing.Point(6, 628);
            this.ctlHandlingDisplay.Name = "ctlHandlingDisplay";
            this.ctlHandlingDisplay.Size = new System.Drawing.Size(517, 74);
            this.ctlHandlingDisplay.TabIndex = 87;
            this.ctlHandlingDisplay.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(237, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 13);
            this.label34.TabIndex = 72;
            this.label34.Text = "Batch Date";
            // 
            // ctlBatchDate
            // 
            this.ctlBatchDate.CurrentDate = null;
            this.ctlBatchDate.DateSelectionVisible = true;
            this.ctlBatchDate.DateValue = null;
            this.ctlBatchDate.Enabled = false;
            this.ctlBatchDate.ForeColor = System.Drawing.Color.Black;
            this.ctlBatchDate.Location = new System.Drawing.Point(308, 29);
            this.ctlBatchDate.Name = "ctlBatchDate";
            this.ctlBatchDate.Size = new System.Drawing.Size(204, 21);
            this.ctlBatchDate.TabIndex = 71;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(102, 13);
            this.label33.TabIndex = 25;
            this.label33.Text = "Handling Method";
            // 
            // cmbHandling
            // 
            this.cmbHandling.FormattingEnabled = true;
            this.cmbHandling.Items.AddRange(new object[] {
            "Unclassified",
            "Paper",
            "ApexEDI",
            "ANS"});
            this.cmbHandling.Location = new System.Drawing.Point(113, 29);
            this.cmbHandling.Name = "cmbHandling";
            this.cmbHandling.Size = new System.Drawing.Size(121, 21);
            this.cmbHandling.TabIndex = 26;
            // 
            // chkInBatch
            // 
            this.chkInBatch.AutoSize = true;
            this.chkInBatch.Enabled = false;
            this.chkInBatch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInBatch.ForeColor = System.Drawing.Color.Black;
            this.chkInBatch.Location = new System.Drawing.Point(308, 52);
            this.chkInBatch.Name = "chkInBatch";
            this.chkInBatch.Size = new System.Drawing.Size(73, 17);
            this.chkInBatch.TabIndex = 27;
            this.chkInBatch.Text = "In Batch";
            this.chkInBatch.UseVisualStyleBackColor = true;
            // 
            // ctlClaimDisplayPatient
            // 
            this.ctlClaimDisplayPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayPatient.CanMaximize = true;
            this.ctlClaimDisplayPatient.Caption = "Patient";
            this.ctlClaimDisplayPatient.Controls.Add(this.ctlPatientDOB);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientState);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientCity);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientAddress2);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientName);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientZIP);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientSSN);
            this.ctlClaimDisplayPatient.Controls.Add(this.txtPatientAddress);
            this.ctlClaimDisplayPatient.Controls.Add(this.label12);
            this.ctlClaimDisplayPatient.Controls.Add(this.label10);
            this.ctlClaimDisplayPatient.Controls.Add(this.label45);
            this.ctlClaimDisplayPatient.Controls.Add(this.label47);
            this.ctlClaimDisplayPatient.Controls.Add(this.label46);
            this.ctlClaimDisplayPatient.Controls.Add(this.label48);
            this.ctlClaimDisplayPatient.Controls.Add(this.label11);
            this.ctlClaimDisplayPatient.Controls.Add(this.label7);
            this.ctlClaimDisplayPatient.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayPatient.FormIndex = 3;
            this.ctlClaimDisplayPatient.Location = new System.Drawing.Point(6, 258);
            this.ctlClaimDisplayPatient.Name = "ctlClaimDisplayPatient";
            this.ctlClaimDisplayPatient.Size = new System.Drawing.Size(517, 77);
            this.ctlClaimDisplayPatient.TabIndex = 83;
            this.ctlClaimDisplayPatient.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // ctlPatientDOB
            // 
            this.ctlPatientDOB.CurrentDate = null;
            this.ctlPatientDOB.DateSelectionVisible = true;
            this.ctlPatientDOB.DateValue = null;
            this.ctlPatientDOB.Location = new System.Drawing.Point(61, 52);
            this.ctlPatientDOB.Name = "ctlPatientDOB";
            this.ctlPatientDOB.Size = new System.Drawing.Size(173, 21);
            this.ctlPatientDOB.TabIndex = 69;
            // 
            // txtPatientState
            // 
            this.txtPatientState.Location = new System.Drawing.Point(306, 108);
            this.txtPatientState.MaxLength = 99;
            this.txtPatientState.Name = "txtPatientState";
            this.txtPatientState.Size = new System.Drawing.Size(43, 21);
            this.txtPatientState.TabIndex = 65;
            this.txtPatientState.Tag = "0";
            // 
            // txtPatientCity
            // 
            this.txtPatientCity.Location = new System.Drawing.Point(60, 107);
            this.txtPatientCity.MaxLength = 149;
            this.txtPatientCity.Name = "txtPatientCity";
            this.txtPatientCity.Size = new System.Drawing.Size(173, 21);
            this.txtPatientCity.TabIndex = 63;
            this.txtPatientCity.Tag = "0";
            // 
            // txtPatientAddress2
            // 
            this.txtPatientAddress2.Location = new System.Drawing.Point(306, 78);
            this.txtPatientAddress2.MaxLength = 254;
            this.txtPatientAddress2.Name = "txtPatientAddress2";
            this.txtPatientAddress2.Size = new System.Drawing.Size(204, 21);
            this.txtPatientAddress2.TabIndex = 61;
            this.txtPatientAddress2.Tag = "0";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(60, 26);
            this.txtPatientName.MaxLength = 254;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(173, 21);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Tag = "1";
            this.txtPatientName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtPatientZIP
            // 
            this.txtPatientZIP.Location = new System.Drawing.Point(400, 109);
            this.txtPatientZIP.MaxLength = 19;
            this.txtPatientZIP.Name = "txtPatientZIP";
            this.txtPatientZIP.Size = new System.Drawing.Size(109, 21);
            this.txtPatientZIP.TabIndex = 67;
            this.txtPatientZIP.Tag = "0";
            // 
            // txtPatientSSN
            // 
            this.txtPatientSSN.Location = new System.Drawing.Point(306, 27);
            this.txtPatientSSN.MaxLength = 254;
            this.txtPatientSSN.Name = "txtPatientSSN";
            this.txtPatientSSN.Size = new System.Drawing.Size(204, 21);
            this.txtPatientSSN.TabIndex = 3;
            this.txtPatientSSN.Tag = "1";
            this.txtPatientSSN.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(60, 80);
            this.txtPatientAddress.MaxLength = 254;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(173, 21);
            this.txtPatientAddress.TabIndex = 59;
            this.txtPatientAddress.Tag = "0";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(238, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 25);
            this.label12.TabIndex = 21;
            this.label12.Tag = "1";
            this.label12.Text = "SSN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 68;
            this.label10.Tag = "0";
            this.label10.Text = "ZIP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(238, 105);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(91, 25);
            this.label45.TabIndex = 66;
            this.label45.Tag = "0";
            this.label45.Text = "State";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(238, 76);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(244, 25);
            this.label47.TabIndex = 62;
            this.label47.Tag = "0";
            this.label47.Text = "Line 2";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(6, 104);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(230, 25);
            this.label46.TabIndex = 64;
            this.label46.Tag = "0";
            this.label46.Text = "City";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(5, 78);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(234, 25);
            this.label48.TabIndex = 60;
            this.label48.Tag = "0";
            this.label48.Text = "Address";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 25);
            this.label11.TabIndex = 19;
            this.label11.Tag = "1";
            this.label11.Text = "DOB";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 25);
            this.label7.TabIndex = 17;
            this.label7.Tag = "1";
            this.label7.Text = "Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayInsurance
            // 
            this.ctlClaimDisplayInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayInsurance.CanMaximize = true;
            this.ctlClaimDisplayInsurance.Caption = "Insurance Carrier";
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsuranceState);
            this.ctlClaimDisplayInsurance.Controls.Add(this.lnkViewCompanyContactInfo);
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsuranceAddress);
            this.ctlClaimDisplayInsurance.Controls.Add(this.cmbInsuranceCarrier);
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsuranceAddress2);
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsuranceCity);
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsuranceZIP);
            this.ctlClaimDisplayInsurance.Controls.Add(this.txtInsurancePhone);
            this.ctlClaimDisplayInsurance.Controls.Add(this.lblInsuranceCity);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label5);
            this.ctlClaimDisplayInsurance.Controls.Add(this.lnkCreateCompany);
            this.ctlClaimDisplayInsurance.Controls.Add(this.lnkEditCompany);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label21);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label31);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label41);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label40);
            this.ctlClaimDisplayInsurance.Controls.Add(this.label6);
            this.ctlClaimDisplayInsurance.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayInsurance.FormIndex = 0;
            this.ctlClaimDisplayInsurance.Location = new System.Drawing.Point(6, 3);
            this.ctlClaimDisplayInsurance.Name = "ctlClaimDisplayInsurance";
            this.ctlClaimDisplayInsurance.Size = new System.Drawing.Size(517, 76);
            this.ctlClaimDisplayInsurance.TabIndex = 80;
            this.ctlClaimDisplayInsurance.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // txtInsuranceState
            // 
            this.txtInsuranceState.Location = new System.Drawing.Point(306, 103);
            this.txtInsuranceState.Name = "txtInsuranceState";
            this.txtInsuranceState.ReadOnly = true;
            this.txtInsuranceState.Size = new System.Drawing.Size(47, 21);
            this.txtInsuranceState.TabIndex = 42;
            // 
            // lnkViewCompanyContactInfo
            // 
            this.lnkViewCompanyContactInfo.AutoSize = true;
            this.lnkViewCompanyContactInfo.Location = new System.Drawing.Point(40, 54);
            this.lnkViewCompanyContactInfo.Name = "lnkViewCompanyContactInfo";
            this.lnkViewCompanyContactInfo.Size = new System.Drawing.Size(196, 13);
            this.lnkViewCompanyContactInfo.TabIndex = 48;
            this.lnkViewCompanyContactInfo.TabStop = true;
            this.lnkViewCompanyContactInfo.Tag = "1";
            this.lnkViewCompanyContactInfo.Text = "View extended company contact info...";
            this.lnkViewCompanyContactInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewCompanyContactInfo_LinkClicked);
            // 
            // txtInsuranceAddress
            // 
            this.txtInsuranceAddress.Location = new System.Drawing.Point(64, 78);
            this.txtInsuranceAddress.Name = "txtInsuranceAddress";
            this.txtInsuranceAddress.ReadOnly = true;
            this.txtInsuranceAddress.Size = new System.Drawing.Size(173, 21);
            this.txtInsuranceAddress.TabIndex = 2;
            this.txtInsuranceAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cmbInsuranceCarrier
            // 
            this.cmbInsuranceCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsuranceCarrier.FormattingEnabled = true;
            this.cmbInsuranceCarrier.Location = new System.Drawing.Point(56, 28);
            this.cmbInsuranceCarrier.Name = "cmbInsuranceCarrier";
            this.cmbInsuranceCarrier.Size = new System.Drawing.Size(180, 21);
            this.cmbInsuranceCarrier.TabIndex = 0;
            this.cmbInsuranceCarrier.Tag = "1";
            this.cmbInsuranceCarrier.SelectedIndexChanged += new System.EventHandler(this.cmbInsuranceCarrier_SelectedIndexChanged);
            // 
            // txtInsuranceAddress2
            // 
            this.txtInsuranceAddress2.Location = new System.Drawing.Point(307, 76);
            this.txtInsuranceAddress2.Name = "txtInsuranceAddress2";
            this.txtInsuranceAddress2.ReadOnly = true;
            this.txtInsuranceAddress2.Size = new System.Drawing.Size(205, 21);
            this.txtInsuranceAddress2.TabIndex = 32;
            // 
            // txtInsuranceCity
            // 
            this.txtInsuranceCity.Location = new System.Drawing.Point(64, 102);
            this.txtInsuranceCity.Name = "txtInsuranceCity";
            this.txtInsuranceCity.ReadOnly = true;
            this.txtInsuranceCity.Size = new System.Drawing.Size(173, 21);
            this.txtInsuranceCity.TabIndex = 34;
            // 
            // txtInsuranceZIP
            // 
            this.txtInsuranceZIP.Location = new System.Drawing.Point(404, 104);
            this.txtInsuranceZIP.Name = "txtInsuranceZIP";
            this.txtInsuranceZIP.ReadOnly = true;
            this.txtInsuranceZIP.Size = new System.Drawing.Size(107, 21);
            this.txtInsuranceZIP.TabIndex = 44;
            // 
            // txtInsurancePhone
            // 
            this.txtInsurancePhone.Location = new System.Drawing.Point(306, 51);
            this.txtInsurancePhone.Name = "txtInsurancePhone";
            this.txtInsurancePhone.ReadOnly = true;
            this.txtInsurancePhone.Size = new System.Drawing.Size(207, 21);
            this.txtInsurancePhone.TabIndex = 46;
            this.txtInsurancePhone.Tag = "1";
            // 
            // lblInsuranceCity
            // 
            this.lblInsuranceCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceCity.Location = new System.Drawing.Point(6, 99);
            this.lblInsuranceCity.Name = "lblInsuranceCity";
            this.lblInsuranceCity.Size = new System.Drawing.Size(234, 25);
            this.lblInsuranceCity.TabIndex = 35;
            this.lblInsuranceCity.Text = "City";
            this.lblInsuranceCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkCreateCompany
            // 
            this.lnkCreateCompany.Location = new System.Drawing.Point(347, 31);
            this.lnkCreateCompany.Name = "lnkCreateCompany";
            this.lnkCreateCompany.Size = new System.Drawing.Size(100, 17);
            this.lnkCreateCompany.TabIndex = 1;
            this.lnkCreateCompany.TabStop = true;
            this.lnkCreateCompany.Tag = "1";
            this.lnkCreateCompany.Text = "Create Company...";
            this.lnkCreateCompany.Visible = false;
            this.lnkCreateCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateCompany_LinkClicked);
            // 
            // lnkEditCompany
            // 
            this.lnkEditCompany.AutoSize = true;
            this.lnkEditCompany.Location = new System.Drawing.Point(256, 31);
            this.lnkEditCompany.Name = "lnkEditCompany";
            this.lnkEditCompany.Size = new System.Drawing.Size(85, 13);
            this.lnkEditCompany.TabIndex = 17;
            this.lnkEditCompany.TabStop = true;
            this.lnkEditCompany.Tag = "1";
            this.lnkEditCompany.Text = "Edit Company...";
            this.lnkEditCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditCompany_LinkClicked);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(242, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(254, 25);
            this.label21.TabIndex = 33;
            this.label21.Text = "Line 2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(242, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(102, 19);
            this.label31.TabIndex = 43;
            this.label31.Text = "State";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(242, 49);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(254, 25);
            this.label41.TabIndex = 47;
            this.label41.Tag = "1";
            this.label41.Text = "Phone";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(372, 101);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(120, 25);
            this.label40.TabIndex = 45;
            this.label40.Text = "ZIP";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 16;
            this.label6.Tag = "1";
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayDoctor
            // 
            this.ctlClaimDisplayDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayDoctor.CanMaximize = true;
            this.ctlClaimDisplayDoctor.Caption = "Doctor";
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorName);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorTaxID);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorLicenseID);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorBC);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorPhone);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorFax);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorAddress2);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label14);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label13);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorAddress);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label18);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label20);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label19);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorState);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label51);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorZIP);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label17);
            this.ctlClaimDisplayDoctor.Controls.Add(this.txtDoctorCity);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label15);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label49);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label52);
            this.ctlClaimDisplayDoctor.Controls.Add(this.label50);
            this.ctlClaimDisplayDoctor.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayDoctor.FormIndex = 4;
            this.ctlClaimDisplayDoctor.Location = new System.Drawing.Point(6, 343);
            this.ctlClaimDisplayDoctor.Name = "ctlClaimDisplayDoctor";
            this.ctlClaimDisplayDoctor.Size = new System.Drawing.Size(517, 108);
            this.ctlClaimDisplayDoctor.TabIndex = 84;
            this.ctlClaimDisplayDoctor.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(61, 32);
            this.txtDoctorName.MaxLength = 254;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(172, 21);
            this.txtDoctorName.TabIndex = 0;
            this.txtDoctorName.Tag = "1";
            this.txtDoctorName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorTaxID
            // 
            this.txtDoctorTaxID.Location = new System.Drawing.Point(61, 58);
            this.txtDoctorTaxID.MaxLength = 254;
            this.txtDoctorTaxID.Name = "txtDoctorTaxID";
            this.txtDoctorTaxID.Size = new System.Drawing.Size(172, 21);
            this.txtDoctorTaxID.TabIndex = 1;
            this.txtDoctorTaxID.Tag = "1";
            this.txtDoctorTaxID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorLicenseID
            // 
            this.txtDoctorLicenseID.Location = new System.Drawing.Point(61, 84);
            this.txtDoctorLicenseID.MaxLength = 254;
            this.txtDoctorLicenseID.Name = "txtDoctorLicenseID";
            this.txtDoctorLicenseID.Size = new System.Drawing.Size(172, 21);
            this.txtDoctorLicenseID.TabIndex = 2;
            this.txtDoctorLicenseID.Tag = "1";
            this.txtDoctorLicenseID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorBC
            // 
            this.txtDoctorBC.Location = new System.Drawing.Point(307, 83);
            this.txtDoctorBC.MaxLength = 254;
            this.txtDoctorBC.Name = "txtDoctorBC";
            this.txtDoctorBC.Size = new System.Drawing.Size(205, 21);
            this.txtDoctorBC.TabIndex = 3;
            this.txtDoctorBC.Tag = "1";
            this.txtDoctorBC.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.Location = new System.Drawing.Point(307, 30);
            this.txtDoctorPhone.MaxLength = 254;
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.Size = new System.Drawing.Size(206, 21);
            this.txtDoctorPhone.TabIndex = 4;
            this.txtDoctorPhone.Tag = "1";
            this.txtDoctorPhone.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorFax
            // 
            this.txtDoctorFax.Location = new System.Drawing.Point(307, 56);
            this.txtDoctorFax.MaxLength = 254;
            this.txtDoctorFax.Name = "txtDoctorFax";
            this.txtDoctorFax.Size = new System.Drawing.Size(206, 21);
            this.txtDoctorFax.TabIndex = 5;
            this.txtDoctorFax.Tag = "1";
            this.txtDoctorFax.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtDoctorAddress2
            // 
            this.txtDoctorAddress2.Location = new System.Drawing.Point(307, 109);
            this.txtDoctorAddress2.MaxLength = 254;
            this.txtDoctorAddress2.Name = "txtDoctorAddress2";
            this.txtDoctorAddress2.Size = new System.Drawing.Size(207, 21);
            this.txtDoctorAddress2.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 25);
            this.label14.TabIndex = 19;
            this.label14.Tag = "1";
            this.label14.Text = "Tax ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 25);
            this.label13.TabIndex = 21;
            this.label13.Tag = "1";
            this.label13.Text = "Lic. ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorAddress
            // 
            this.txtDoctorAddress.Location = new System.Drawing.Point(61, 111);
            this.txtDoctorAddress.MaxLength = 254;
            this.txtDoctorAddress.Name = "txtDoctorAddress";
            this.txtDoctorAddress.Size = new System.Drawing.Size(173, 21);
            this.txtDoctorAddress.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(241, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(236, 25);
            this.label18.TabIndex = 23;
            this.label18.Tag = "1";
            this.label18.Text = "BC / BS #";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(241, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(261, 25);
            this.label20.TabIndex = 25;
            this.label20.Tag = "1";
            this.label20.Text = "Phone";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(241, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(261, 25);
            this.label19.TabIndex = 27;
            this.label19.Tag = "1";
            this.label19.Text = "Fax";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorState
            // 
            this.txtDoctorState.Location = new System.Drawing.Point(307, 138);
            this.txtDoctorState.MaxLength = 99;
            this.txtDoctorState.Name = "txtDoctorState";
            this.txtDoctorState.Size = new System.Drawing.Size(57, 21);
            this.txtDoctorState.TabIndex = 75;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(243, 107);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(263, 25);
            this.label51.TabIndex = 72;
            this.label51.Text = "Line 2";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorZIP
            // 
            this.txtDoctorZIP.Location = new System.Drawing.Point(415, 138);
            this.txtDoctorZIP.MaxLength = 19;
            this.txtDoctorZIP.Name = "txtDoctorZIP";
            this.txtDoctorZIP.Size = new System.Drawing.Size(99, 21);
            this.txtDoctorZIP.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(383, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 25);
            this.label17.TabIndex = 78;
            this.label17.Text = "ZIP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorCity
            // 
            this.txtDoctorCity.Location = new System.Drawing.Point(61, 138);
            this.txtDoctorCity.MaxLength = 149;
            this.txtDoctorCity.Name = "txtDoctorCity";
            this.txtDoctorCity.Size = new System.Drawing.Size(173, 21);
            this.txtDoctorCity.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 25);
            this.label15.TabIndex = 17;
            this.label15.Tag = "1";
            this.label15.Text = "Name";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(5, 109);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(232, 25);
            this.label49.TabIndex = 70;
            this.label49.Text = "Address";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(243, 135);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(123, 25);
            this.label52.TabIndex = 76;
            this.label52.Text = "State";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(7, 135);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 25);
            this.label50.TabIndex = 74;
            this.label50.Text = "City";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayGeneral
            // 
            this.ctlClaimDisplayGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayGeneral.CanMaximize = true;
            this.ctlClaimDisplayGeneral.Caption = "General";
            this.ctlClaimDisplayGeneral.Controls.Add(this.ctlTracerDate);
            this.ctlClaimDisplayGeneral.Controls.Add(this.ctlOnHoldDate);
            this.ctlClaimDisplayGeneral.Controls.Add(this.ctlResentDate);
            this.ctlClaimDisplayGeneral.Controls.Add(this.ctlSentDate);
            this.ctlClaimDisplayGeneral.Controls.Add(this.chkClosed);
            this.ctlClaimDisplayGeneral.Controls.Add(this.label16);
            this.ctlClaimDisplayGeneral.Controls.Add(this.label9);
            this.ctlClaimDisplayGeneral.Controls.Add(this.label8);
            this.ctlClaimDisplayGeneral.Controls.Add(this.label4);
            this.ctlClaimDisplayGeneral.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayGeneral.FormIndex = 5;
            this.ctlClaimDisplayGeneral.Location = new System.Drawing.Point(6, 454);
            this.ctlClaimDisplayGeneral.Name = "ctlClaimDisplayGeneral";
            this.ctlClaimDisplayGeneral.Size = new System.Drawing.Size(517, 82);
            this.ctlClaimDisplayGeneral.TabIndex = 86;
            this.ctlClaimDisplayGeneral.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // ctlTracerDate
            // 
            this.ctlTracerDate.CurrentDate = null;
            this.ctlTracerDate.DateSelectionVisible = true;
            this.ctlTracerDate.DateValue = null;
            this.ctlTracerDate.Location = new System.Drawing.Point(307, 56);
            this.ctlTracerDate.Name = "ctlTracerDate";
            this.ctlTracerDate.Size = new System.Drawing.Size(206, 21);
            this.ctlTracerDate.TabIndex = 73;
            // 
            // ctlOnHoldDate
            // 
            this.ctlOnHoldDate.CurrentDate = null;
            this.ctlOnHoldDate.DateSelectionVisible = true;
            this.ctlOnHoldDate.DateValue = null;
            this.ctlOnHoldDate.Location = new System.Drawing.Point(307, 31);
            this.ctlOnHoldDate.Name = "ctlOnHoldDate";
            this.ctlOnHoldDate.Size = new System.Drawing.Size(206, 21);
            this.ctlOnHoldDate.TabIndex = 72;
            // 
            // ctlResentDate
            // 
            this.ctlResentDate.CurrentDate = null;
            this.ctlResentDate.DateSelectionVisible = true;
            this.ctlResentDate.DateValue = null;
            this.ctlResentDate.Location = new System.Drawing.Point(61, 56);
            this.ctlResentDate.Name = "ctlResentDate";
            this.ctlResentDate.Size = new System.Drawing.Size(173, 21);
            this.ctlResentDate.TabIndex = 71;
            // 
            // ctlSentDate
            // 
            this.ctlSentDate.CurrentDate = null;
            this.ctlSentDate.DateSelectionVisible = true;
            this.ctlSentDate.DateValue = null;
            this.ctlSentDate.Location = new System.Drawing.Point(61, 30);
            this.ctlSentDate.Name = "ctlSentDate";
            this.ctlSentDate.Size = new System.Drawing.Size(173, 21);
            this.ctlSentDate.TabIndex = 70;
            // 
            // chkClosed
            // 
            this.chkClosed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClosed.Location = new System.Drawing.Point(439, 81);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(75, 17);
            this.chkClosed.TabIndex = 6;
            this.chkClosed.Tag = "0";
            this.chkClosed.Text = "Claim Paid";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(236, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 35;
            this.label16.Tag = "1";
            this.label16.Text = "Tracer Date";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 32;
            this.label9.Tag = "1";
            this.label9.Text = "Re-sent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 29;
            this.label8.Tag = "1";
            this.label8.Text = "On hold";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 26;
            this.label4.Tag = "1";
            this.label4.Text = "Sent";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayNotes
            // 
            this.ctlClaimDisplayNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayNotes.CanMaximize = false;
            this.ctlClaimDisplayNotes.Caption = "Notes";
            this.ctlClaimDisplayNotes.Controls.Add(this.txtNotes);
            this.ctlClaimDisplayNotes.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayNotes.FormIndex = 6;
            this.ctlClaimDisplayNotes.Location = new System.Drawing.Point(6, 542);
            this.ctlClaimDisplayNotes.Name = "ctlClaimDisplayNotes";
            this.ctlClaimDisplayNotes.Size = new System.Drawing.Size(517, 81);
            this.ctlClaimDisplayNotes.TabIndex = 85;
            this.ctlClaimDisplayNotes.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(3, 24);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(508, 55);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.Tag = "1";
            this.txtNotes.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ctlClaimDisplaySubscriber
            // 
            this.ctlClaimDisplaySubscriber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplaySubscriber.CanMaximize = true;
            this.ctlClaimDisplaySubscriber.Caption = "Subscriber";
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberName);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label27);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.ctlSubscriberDOB);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberAltID);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberID);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberGroupName);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberAddress);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberGroupNum);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberSSN);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label26);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberZIP);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label28);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberAddress2);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberState);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.txtSubscriberCity);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label25);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label24);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label23);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label44);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label22);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label29);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label35);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label43);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.label42);
            this.ctlClaimDisplaySubscriber.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplaySubscriber.FormIndex = 2;
            this.ctlClaimDisplaySubscriber.Location = new System.Drawing.Point(6, 174);
            this.ctlClaimDisplaySubscriber.Name = "ctlClaimDisplaySubscriber";
            this.ctlClaimDisplaySubscriber.Size = new System.Drawing.Size(517, 108);
            this.ctlClaimDisplaySubscriber.TabIndex = 82;
            this.ctlClaimDisplaySubscriber.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // txtSubscriberName
            // 
            this.txtSubscriberName.Location = new System.Drawing.Point(61, 33);
            this.txtSubscriberName.MaxLength = 254;
            this.txtSubscriberName.Name = "txtSubscriberName";
            this.txtSubscriberName.Size = new System.Drawing.Size(173, 21);
            this.txtSubscriberName.TabIndex = 0;
            this.txtSubscriberName.Tag = "1";
            this.txtSubscriberName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(231, 25);
            this.label27.TabIndex = 17;
            this.label27.Tag = "1";
            this.label27.Text = "Name";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlSubscriberDOB
            // 
            this.ctlSubscriberDOB.CurrentDate = null;
            this.ctlSubscriberDOB.DateSelectionVisible = true;
            this.ctlSubscriberDOB.DateValue = null;
            this.ctlSubscriberDOB.Location = new System.Drawing.Point(61, 56);
            this.ctlSubscriberDOB.Name = "ctlSubscriberDOB";
            this.ctlSubscriberDOB.Size = new System.Drawing.Size(173, 21);
            this.ctlSubscriberDOB.TabIndex = 59;
            // 
            // txtSubscriberAltID
            // 
            this.txtSubscriberAltID.Location = new System.Drawing.Point(60, 111);
            this.txtSubscriberAltID.MaxLength = 254;
            this.txtSubscriberAltID.Name = "txtSubscriberAltID";
            this.txtSubscriberAltID.Size = new System.Drawing.Size(173, 21);
            this.txtSubscriberAltID.TabIndex = 4;
            this.txtSubscriberAltID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtSubscriberID
            // 
            this.txtSubscriberID.Location = new System.Drawing.Point(61, 84);
            this.txtSubscriberID.MaxLength = 254;
            this.txtSubscriberID.Name = "txtSubscriberID";
            this.txtSubscriberID.Size = new System.Drawing.Size(173, 21);
            this.txtSubscriberID.TabIndex = 3;
            this.txtSubscriberID.Tag = "1";
            this.txtSubscriberID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtSubscriberGroupName
            // 
            this.txtSubscriberGroupName.Location = new System.Drawing.Point(307, 31);
            this.txtSubscriberGroupName.MaxLength = 254;
            this.txtSubscriberGroupName.Name = "txtSubscriberGroupName";
            this.txtSubscriberGroupName.Size = new System.Drawing.Size(204, 21);
            this.txtSubscriberGroupName.TabIndex = 6;
            this.txtSubscriberGroupName.Tag = "1";
            this.txtSubscriberGroupName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtSubscriberAddress
            // 
            this.txtSubscriberAddress.Location = new System.Drawing.Point(60, 134);
            this.txtSubscriberAddress.MaxLength = 254;
            this.txtSubscriberAddress.Name = "txtSubscriberAddress";
            this.txtSubscriberAddress.Size = new System.Drawing.Size(173, 21);
            this.txtSubscriberAddress.TabIndex = 49;
            // 
            // txtSubscriberGroupNum
            // 
            this.txtSubscriberGroupNum.Location = new System.Drawing.Point(307, 56);
            this.txtSubscriberGroupNum.MaxLength = 254;
            this.txtSubscriberGroupNum.Name = "txtSubscriberGroupNum";
            this.txtSubscriberGroupNum.Size = new System.Drawing.Size(204, 21);
            this.txtSubscriberGroupNum.TabIndex = 7;
            this.txtSubscriberGroupNum.Tag = "1";
            this.txtSubscriberGroupNum.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtSubscriberSSN
            // 
            this.txtSubscriberSSN.Location = new System.Drawing.Point(307, 83);
            this.txtSubscriberSSN.MaxLength = 254;
            this.txtSubscriberSSN.Name = "txtSubscriberSSN";
            this.txtSubscriberSSN.Size = new System.Drawing.Size(204, 21);
            this.txtSubscriberSSN.TabIndex = 5;
            this.txtSubscriberSSN.Tag = "1";
            this.txtSubscriberSSN.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(231, 25);
            this.label26.TabIndex = 19;
            this.label26.Tag = "1";
            this.label26.Text = "DOB";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberZIP
            // 
            this.txtSubscriberZIP.Location = new System.Drawing.Point(400, 160);
            this.txtSubscriberZIP.MaxLength = 19;
            this.txtSubscriberZIP.Name = "txtSubscriberZIP";
            this.txtSubscriberZIP.Size = new System.Drawing.Size(109, 21);
            this.txtSubscriberZIP.TabIndex = 57;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(368, 157);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 25);
            this.label28.TabIndex = 58;
            this.label28.Text = "ZIP";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberAddress2
            // 
            this.txtSubscriberAddress2.Location = new System.Drawing.Point(307, 132);
            this.txtSubscriberAddress2.MaxLength = 254;
            this.txtSubscriberAddress2.Name = "txtSubscriberAddress2";
            this.txtSubscriberAddress2.Size = new System.Drawing.Size(203, 21);
            this.txtSubscriberAddress2.TabIndex = 51;
            // 
            // txtSubscriberState
            // 
            this.txtSubscriberState.Location = new System.Drawing.Point(306, 159);
            this.txtSubscriberState.MaxLength = 99;
            this.txtSubscriberState.Name = "txtSubscriberState";
            this.txtSubscriberState.Size = new System.Drawing.Size(43, 21);
            this.txtSubscriberState.TabIndex = 55;
            // 
            // txtSubscriberCity
            // 
            this.txtSubscriberCity.Location = new System.Drawing.Point(60, 158);
            this.txtSubscriberCity.MaxLength = 149;
            this.txtSubscriberCity.Name = "txtSubscriberCity";
            this.txtSubscriberCity.Size = new System.Drawing.Size(173, 21);
            this.txtSubscriberCity.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 81);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(230, 25);
            this.label25.TabIndex = 21;
            this.label25.Tag = "1";
            this.label25.Text = "ID";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(231, 25);
            this.label24.TabIndex = 23;
            this.label24.Text = "Alt ID";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(239, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(265, 25);
            this.label23.TabIndex = 25;
            this.label23.Tag = "1";
            this.label23.Text = "Group Name";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(5, 132);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(234, 25);
            this.label44.TabIndex = 50;
            this.label44.Text = "Address";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(239, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(265, 25);
            this.label22.TabIndex = 27;
            this.label22.Tag = "1";
            this.label22.Text = "Group #";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(239, 81);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(260, 25);
            this.label29.TabIndex = 29;
            this.label29.Tag = "1";
            this.label29.Text = "SSN";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(238, 156);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 25);
            this.label35.TabIndex = 56;
            this.label35.Text = "State";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(238, 130);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(244, 25);
            this.label43.TabIndex = 52;
            this.label43.Text = "Line 2";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(5, 155);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(231, 25);
            this.label42.TabIndex = 54;
            this.label42.Text = "City";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayServices
            // 
            this.ctlClaimDisplayServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayServices.CanMaximize = true;
            this.ctlClaimDisplayServices.Caption = "Services";
            this.ctlClaimDisplayServices.Controls.Add(this.dgvProcedureData);
            this.ctlClaimDisplayServices.Controls.Add(this.label2);
            this.ctlClaimDisplayServices.Controls.Add(this.txtDateOfService);
            this.ctlClaimDisplayServices.Controls.Add(this.nmbClaimAmount);
            this.ctlClaimDisplayServices.Controls.Add(this.label3);
            this.ctlClaimDisplayServices.Controls.Add(this.label1);
            this.ctlClaimDisplayServices.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Full;
            this.ctlClaimDisplayServices.FormIndex = 1;
            this.ctlClaimDisplayServices.Location = new System.Drawing.Point(6, 81);
            this.ctlClaimDisplayServices.Name = "ctlClaimDisplayServices";
            this.ctlClaimDisplayServices.Size = new System.Drawing.Size(517, 131);
            this.ctlClaimDisplayServices.TabIndex = 81;
            this.ctlClaimDisplayServices.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            // 
            // dgvProcedureData
            // 
            this.dgvProcedureData.AllowUserToAddRows = false;
            this.dgvProcedureData.AllowUserToDeleteRows = false;
            this.dgvProcedureData.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcedureData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcedureData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedureData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkedProcedureDataGridViewTextBoxColumn,
            this.colProcedureDate,
            this.adaCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ToothRange,
            this.surfStringDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvProcedureData.DataSource = this.displayProcedureBindingSource;
            this.dgvProcedureData.EnableHeadersVisualStyles = false;
            this.dgvProcedureData.Location = new System.Drawing.Point(4, 54);
            this.dgvProcedureData.Name = "dgvProcedureData";
            this.dgvProcedureData.ReadOnly = true;
            this.dgvProcedureData.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcedureData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcedureData.Size = new System.Drawing.Size(513, 75);
            this.dgvProcedureData.TabIndex = 79;
            // 
            // linkedProcedureDataGridViewTextBoxColumn
            // 
            this.linkedProcedureDataGridViewTextBoxColumn.DataPropertyName = "LinkedProcedure";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedProcedureDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.linkedProcedureDataGridViewTextBoxColumn.HeaderText = "LinkedProcedure";
            this.linkedProcedureDataGridViewTextBoxColumn.Name = "linkedProcedureDataGridViewTextBoxColumn";
            this.linkedProcedureDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkedProcedureDataGridViewTextBoxColumn.Visible = false;
            // 
            // colProcedureDate
            // 
            this.colProcedureDate.DataPropertyName = "ProcedureDate";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProcedureDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProcedureDate.HeaderText = "Date";
            this.colProcedureDate.Name = "colProcedureDate";
            this.colProcedureDate.ReadOnly = true;
            this.colProcedureDate.Width = 60;
            // 
            // adaCodeDataGridViewTextBoxColumn
            // 
            this.adaCodeDataGridViewTextBoxColumn.DataPropertyName = "AdaCode";
            this.adaCodeDataGridViewTextBoxColumn.HeaderText = "ADA";
            this.adaCodeDataGridViewTextBoxColumn.Name = "adaCodeDataGridViewTextBoxColumn";
            this.adaCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.adaCodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ToothRange
            // 
            this.ToothRange.DataPropertyName = "ToothRange";
            this.ToothRange.HeaderText = "Range";
            this.ToothRange.Name = "ToothRange";
            this.ToothRange.ReadOnly = true;
            this.ToothRange.Width = 60;
            // 
            // surfStringDataGridViewTextBoxColumn
            // 
            this.surfStringDataGridViewTextBoxColumn.DataPropertyName = "SurfString";
            this.surfStringDataGridViewTextBoxColumn.FillWeight = 40F;
            this.surfStringDataGridViewTextBoxColumn.HeaderText = "Surf";
            this.surfStringDataGridViewTextBoxColumn.Name = "surfStringDataGridViewTextBoxColumn";
            this.surfStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfStringDataGridViewTextBoxColumn.Width = 45;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amt";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 50;
            // 
            // displayProcedureBindingSource
            // 
            this.displayProcedureBindingSource.DataSource = typeof(C_DentalClaimTracker.DisplayProcedure);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "DOS, Tooth Numbers, Procedures, Procedure codes, Amount";
            this.label2.Visible = false;
            // 
            // txtDateOfService
            // 
            this.txtDateOfService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateOfService.Location = new System.Drawing.Point(109, 27);
            this.txtDateOfService.Name = "txtDateOfService";
            this.txtDateOfService.ReadOnly = true;
            this.txtDateOfService.Size = new System.Drawing.Size(138, 21);
            this.txtDateOfService.TabIndex = 0;
            this.txtDateOfService.Tag = "1";
            // 
            // nmbClaimAmount
            // 
            this.nmbClaimAmount.Location = new System.Drawing.Point(439, 27);
            this.nmbClaimAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmbClaimAmount.Name = "nmbClaimAmount";
            this.nmbClaimAmount.Size = new System.Drawing.Size(77, 21);
            this.nmbClaimAmount.TabIndex = 2;
            this.nmbClaimAmount.Tag = "1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 9;
            this.label3.Tag = "1";
            this.label3.Text = "Date of Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Tag = "1";
            this.label1.Text = "Amount of Claim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmViewClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 714);
            this.Controls.Add(this.pnlRightPanel);
            this.Controls.Add(this.pnlLeftPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewClaim";
            this.Text = "View Claim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewClaim_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewClaim_FormClosing);
            this.pnlClaimData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbRevisitInterval)).EndInit();
            this.pnlLeftPanel.ResumeLayout(false);
            this.pnlRightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ctlHandlingDisplay.ResumeLayout(false);
            this.ctlHandlingDisplay.PerformLayout();
            this.ctlClaimDisplayPatient.ResumeLayout(false);
            this.ctlClaimDisplayPatient.PerformLayout();
            this.ctlClaimDisplayInsurance.ResumeLayout(false);
            this.ctlClaimDisplayInsurance.PerformLayout();
            this.ctlClaimDisplayDoctor.ResumeLayout(false);
            this.ctlClaimDisplayDoctor.PerformLayout();
            this.ctlClaimDisplayGeneral.ResumeLayout(false);
            this.ctlClaimDisplayNotes.ResumeLayout(false);
            this.ctlClaimDisplayNotes.PerformLayout();
            this.ctlClaimDisplaySubscriber.ResumeLayout(false);
            this.ctlClaimDisplaySubscriber.PerformLayout();
            this.ctlClaimDisplayServices.ResumeLayout(false);
            this.ctlClaimDisplayServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedureData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbClaimAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateOfService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbClaimAmount;
        private System.Windows.Forms.TextBox txtInsuranceAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbInsuranceCarrier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkCreateCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientSSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDoctorFax;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDoctorPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDoctorBC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDoctorLicenseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDoctorTaxID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubscriberSSN;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtSubscriberGroupNum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSubscriberGroupName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSubscriberAltID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSubscriberID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSubscriberName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chkClosed;
        private System.Windows.Forms.Button cmdNextClaim;
        private System.Windows.Forms.Button cmdPreviousClaim;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.LinkLabel lnkEditCompany;
        private CallManager callManager;
        private System.Windows.Forms.Panel pnlClaimData;
        private System.Windows.Forms.TextBox txtInsuranceAddress2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtInsuranceCity;
        private System.Windows.Forms.Label lblInsuranceCity;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtInsuranceZIP;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtInsuranceState;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtInsurancePhone;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.LinkLabel lnkViewCompanyContactInfo;
        private System.Windows.Forms.TextBox txtSubscriberZIP;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSubscriberState;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtSubscriberCity;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtSubscriberAddress2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtSubscriberAddress;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtPatientZIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatientState;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtPatientCity;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtPatientAddress2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtDoctorZIP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDoctorState;
        private System.Windows.Forms.TextBox txtDoctorCity;
        private System.Windows.Forms.TextBox txtDoctorAddress2;
        private System.Windows.Forms.TextBox txtDoctorAddress;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DataGridView dgvProcedureData;
        private System.Windows.Forms.BindingSource displayProcedureBindingSource;
        private ctlClaimDataDisplay ctlClaimDisplayInsurance;
        private ctlClaimDataDisplay ctlClaimDisplayServices;
        private ctlClaimDataDisplay ctlClaimDisplayPatient;
        private ctlClaimDataDisplay ctlClaimDisplaySubscriber;
        private ctlClaimDataDisplay ctlClaimDisplayDoctor;
        private ctlClaimDataDisplay ctlClaimDisplayNotes;
        private ctlClaimDataDisplay ctlClaimDisplayGeneral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothRangeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothRangeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel lnkViewClaimChangeHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedProcedureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcedureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn adaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToothRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nmbRevisitInterval;
        private ctlDateEntry ctlRevisitDate;
        private ctlDateEntry ctlPatientDOB;
        private ctlDateEntry ctlSubscriberDOB;
        private ctlDateEntry ctlOnHoldDate;
        private ctlDateEntry ctlResentDate;
        private ctlDateEntry ctlSentDate;
        private ctlDateEntry ctlTracerDate;
        private ctlClaimDataDisplay ctlHandlingDisplay;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbHandling;
        private System.Windows.Forms.Label label34;
        private ctlDateEntry ctlBatchDate;
        private System.Windows.Forms.CheckBox chkInBatch;
        private System.Windows.Forms.CheckBox chkSetRevisitDate;
        private System.Windows.Forms.Panel pnlLeftPanel;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}