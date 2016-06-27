namespace C_DentalClaimTracker
{
    partial class frmClaimManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaimManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.cmdPaper = new System.Windows.Forms.Button();
            this.pnlCloseClaim = new System.Windows.Forms.Panel();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.cmdApex = new System.Windows.Forms.Button();
            this.pnlViewLinkedClaim = new System.Windows.Forms.Panel();
            this.lnkViewLinkedClaim = new System.Windows.Forms.LinkLabel();
            this.pnlOwnerInfo = new System.Windows.Forms.Panel();
            this.lblCurrentOwner = new System.Windows.Forms.Label();
            this.cmdCurrentOwner = new System.Windows.Forms.Button();
            this.pnlResendButton = new System.Windows.Forms.Panel();
            this.cmdResendClaim = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdMainPrintClaim = new System.Windows.Forms.Button();
            this.spltTopBottom = new System.Windows.Forms.SplitContainer();
            this.spltLeftRight = new System.Windows.Forms.SplitContainer();
            this.pnlDisplayPanel = new System.Windows.Forms.Panel();
            this.tbcNavigator = new System.Windows.Forms.TabControl();
            this.tabClaimInfo = new System.Windows.Forms.TabPage();
            this.pnlLeftPanel = new System.Windows.Forms.Panel();
            this.pnlClaimData = new System.Windows.Forms.Panel();
            this.ctlHandlingDisplay = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dgvHandlingHistory = new System.Windows.Forms.DataGridView();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandlingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbHandling = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cmbOverrideProvider = new System.Windows.Forms.ComboBox();
            this.chkUseApexDefaults = new System.Windows.Forms.CheckBox();
            this.grpApexOptions = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cmbApexStandardOption = new System.Windows.Forms.ComboBox();
            this.txtApexCustomText = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayGeneral = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOnHoldDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTracerDate = new System.Windows.Forms.TextBox();
            this.lblClaimPaid = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDentrixClaimID = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txtDentrixClaimDB = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSentDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResentDate = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtClinic = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayNotes = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.ctlClaimDisplayDoctor = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDoctorTaxID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDoctorLicenseID = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtDoctorAddress = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtDoctorCity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDoctorPhone = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDoctorNPI = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDoctorBC = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtDoctorAddress2 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtDoctorState = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDoctorZIP = new System.Windows.Forms.TextBox();
            this.ctlClaimDisplayPatient = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPatientSSN = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtPatientAddress2 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtPatientState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatientZIP = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatientDOB = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtPatientCity = new System.Windows.Forms.TextBox();
            this.ctlClaimDisplaySubscriber = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSubscriberGroupName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSubscriberGroupNum = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSubscriberSSN = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtSubscriberAddress2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtSubscriberState = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSubscriberZIP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSubscriberName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSubscriberDOB = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSubscriberID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSubscriberAltID = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtSubscriberAddress = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtSubscriberCity = new System.Windows.Forms.TextBox();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAmountOfClaim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDateOfService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlClaimDisplayInsurance = new C_DentalClaimTracker.ctlClaimDataDisplay();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.txtInsurancePhone = new System.Windows.Forms.TextBox();
            this.lnkViewCompanyContactInfo = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtInsuranceAddress2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtInsuranceState = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtInsuranceZIP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInsuranceName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsuranceAddress = new System.Windows.Forms.TextBox();
            this.lblInsuranceCity = new System.Windows.Forms.Label();
            this.txtInsuranceCity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lnkViewClaimChangeHistory = new System.Windows.Forms.LinkLabel();
            this.cmdNextClaim = new System.Windows.Forms.Button();
            this.cmdPreviousClaim = new System.Windows.Forms.Button();
            this.tabPastCalls = new System.Windows.Forms.TabPage();
            this.pnlRightPanel = new System.Windows.Forms.Panel();
            this.pnlPastStatus = new System.Windows.Forms.Panel();
            this.ctlPastCalls = new C_DentalClaimTracker.Claims_Primary.MultiCallDisplay();
            this.callManager = new C_DentalClaimTracker.CallManager();
            this.tabRelatedClaims = new System.Windows.Forms.TabPage();
            this.pnlRelatedClaims = new System.Windows.Forms.Panel();
            this.dgvClaimsForSubscriber = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label63 = new System.Windows.Forms.Label();
            this.tabSearchClaims = new System.Windows.Forms.TabPage();
            this.pnlClaimsFromSearch = new System.Windows.Forms.Panel();
            this.dgvNextClaimDisplay = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuickSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClearSearch = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.cmbQuickSearch = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdSearchClaims = new System.Windows.Forms.Button();
            this.cmdRelatedClaims = new System.Windows.Forms.Button();
            this.cmdWorkHistory = new System.Windows.Forms.Button();
            this.cmdClaimInfo = new System.Windows.Forms.Button();
            this.spltRightSide = new System.Windows.Forms.SplitContainer();
            this.pnlCallStatusHolder = new System.Windows.Forms.Panel();
            this.chkTalkedWithPerson = new System.Windows.Forms.CheckBox();
            this.tbcNewCallData = new System.Windows.Forms.TabControl();
            this.tbpCallPage = new System.Windows.Forms.TabPage();
            this.spltRightSideTopBottom = new System.Windows.Forms.SplitContainer();
            this.ctlStatusHandler = new C_DentalClaimTracker.Call_Management.ConditionClassificationHandler();
            this.mainQuestionViewer = new C_DentalClaimTracker.Call_Management.CallQuestionViewer();
            this.pnlNewCallTopPanel = new System.Windows.Forms.Panel();
            this.ctlDataVerification = new C_DentalClaimTracker.Call_Management.DataVerificationHandler();
            this.lnkReclassify = new System.Windows.Forms.LinkLabel();
            this.txtNEA_Number = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.pnlStatusRevisit = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dtpNewRevisitDate = new C_DentalClaimTracker.ctlDateEntry();
            this.label60 = new System.Windows.Forms.Label();
            this.lblRevisitCurrent = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.lblStatusCurrent = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.callNotes = new C_DentalClaimTracker.NotesGrid();
            this.pnlCallControls = new System.Windows.Forms.Panel();
            this.lblHoldTime = new System.Windows.Forms.Label();
            this.lblCallTime = new System.Windows.Forms.Label();
            this.cmdStartHold = new System.Windows.Forms.Button();
            this.cmdEndCall = new System.Windows.Forms.Button();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.ctxUserList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlTopPanel.SuspendLayout();
            this.pnlCloseClaim.SuspendLayout();
            this.pnlViewLinkedClaim.SuspendLayout();
            this.pnlOwnerInfo.SuspendLayout();
            this.pnlResendButton.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTopBottom)).BeginInit();
            this.spltTopBottom.Panel1.SuspendLayout();
            this.spltTopBottom.Panel2.SuspendLayout();
            this.spltTopBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltLeftRight)).BeginInit();
            this.spltLeftRight.Panel1.SuspendLayout();
            this.spltLeftRight.Panel2.SuspendLayout();
            this.spltLeftRight.SuspendLayout();
            this.tbcNavigator.SuspendLayout();
            this.tabClaimInfo.SuspendLayout();
            this.pnlLeftPanel.SuspendLayout();
            this.pnlClaimData.SuspendLayout();
            this.ctlHandlingDisplay.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandlingHistory)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel17.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.grpApexOptions.SuspendLayout();
            this.ctlClaimDisplayGeneral.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.ctlClaimDisplayNotes.SuspendLayout();
            this.ctlClaimDisplayDoctor.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.ctlClaimDisplayPatient.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.ctlClaimDisplaySubscriber.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ctlClaimDisplayServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedureData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayProcedureBindingSource)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.ctlClaimDisplayInsurance.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPastCalls.SuspendLayout();
            this.pnlRightPanel.SuspendLayout();
            this.pnlPastStatus.SuspendLayout();
            this.tabRelatedClaims.SuspendLayout();
            this.pnlRelatedClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaimsForSubscriber)).BeginInit();
            this.tabSearchClaims.SuspendLayout();
            this.pnlClaimsFromSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextClaimDisplay)).BeginInit();
            this.pnlQuickSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltRightSide)).BeginInit();
            this.spltRightSide.Panel1.SuspendLayout();
            this.spltRightSide.Panel2.SuspendLayout();
            this.spltRightSide.SuspendLayout();
            this.pnlCallStatusHolder.SuspendLayout();
            this.tbcNewCallData.SuspendLayout();
            this.tbpCallPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltRightSideTopBottom)).BeginInit();
            this.spltRightSideTopBottom.Panel1.SuspendLayout();
            this.spltRightSideTopBottom.Panel2.SuspendLayout();
            this.spltRightSideTopBottom.SuspendLayout();
            this.pnlNewCallTopPanel.SuspendLayout();
            this.pnlStatusRevisit.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.pnlCallControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopPanel.Controls.Add(this.cmdPaper);
            this.pnlTopPanel.Controls.Add(this.pnlCloseClaim);
            this.pnlTopPanel.Controls.Add(this.cmdApex);
            this.pnlTopPanel.Controls.Add(this.pnlViewLinkedClaim);
            this.pnlTopPanel.Controls.Add(this.pnlOwnerInfo);
            this.pnlTopPanel.Controls.Add(this.pnlResendButton);
            this.pnlTopPanel.Controls.Add(this.panel3);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(1148, 32);
            this.pnlTopPanel.TabIndex = 90;
            // 
            // cmdPaper
            // 
            this.cmdPaper.Image = global::C_DentalClaimTracker.Properties.Resources.layers1;
            this.cmdPaper.Location = new System.Drawing.Point(667, 4);
            this.cmdPaper.Name = "cmdPaper";
            this.cmdPaper.Size = new System.Drawing.Size(67, 23);
            this.cmdPaper.TabIndex = 27;
            this.cmdPaper.Text = "Pape&r";
            this.cmdPaper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdPaper, "Paper");
            this.cmdPaper.UseVisualStyleBackColor = true;
            this.cmdPaper.Click += new System.EventHandler(this.cmdPaper_Click);
            // 
            // pnlCloseClaim
            // 
            this.pnlCloseClaim.Controls.Add(this.btnMarkPaid);
            this.pnlCloseClaim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCloseClaim.Location = new System.Drawing.Point(504, 0);
            this.pnlCloseClaim.Name = "pnlCloseClaim";
            this.pnlCloseClaim.Size = new System.Drawing.Size(84, 28);
            this.pnlCloseClaim.TabIndex = 30;
            this.pnlCloseClaim.Visible = false;
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMarkPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMarkPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkPaid.Location = new System.Drawing.Point(0, 0);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(84, 28);
            this.btnMarkPaid.TabIndex = 17;
            this.btnMarkPaid.Text = "Mark Paid";
            this.btnMarkPaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // cmdApex
            // 
            this.cmdApex.Image = global::C_DentalClaimTracker.Properties.Resources.monitor_go1;
            this.cmdApex.Location = new System.Drawing.Point(594, 3);
            this.cmdApex.Name = "cmdApex";
            this.cmdApex.Size = new System.Drawing.Size(67, 23);
            this.cmdApex.TabIndex = 26;
            this.cmdApex.Text = "&Apex";
            this.cmdApex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdApex, "Apex");
            this.cmdApex.UseVisualStyleBackColor = true;
            this.cmdApex.Click += new System.EventHandler(this.cmdApex_Click);
            // 
            // pnlViewLinkedClaim
            // 
            this.pnlViewLinkedClaim.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlViewLinkedClaim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewLinkedClaim.Controls.Add(this.lnkViewLinkedClaim);
            this.pnlViewLinkedClaim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlViewLinkedClaim.Location = new System.Drawing.Point(360, 0);
            this.pnlViewLinkedClaim.Name = "pnlViewLinkedClaim";
            this.pnlViewLinkedClaim.Size = new System.Drawing.Size(144, 28);
            this.pnlViewLinkedClaim.TabIndex = 28;
            // 
            // lnkViewLinkedClaim
            // 
            this.lnkViewLinkedClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkViewLinkedClaim.Location = new System.Drawing.Point(0, 0);
            this.lnkViewLinkedClaim.Name = "lnkViewLinkedClaim";
            this.lnkViewLinkedClaim.Size = new System.Drawing.Size(142, 26);
            this.lnkViewLinkedClaim.TabIndex = 17;
            this.lnkViewLinkedClaim.TabStop = true;
            this.lnkViewLinkedClaim.Text = "View Primary Claim";
            this.lnkViewLinkedClaim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkViewLinkedClaim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewLinkedClaim_LinkClicked);
            // 
            // pnlOwnerInfo
            // 
            this.pnlOwnerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOwnerInfo.Controls.Add(this.lblCurrentOwner);
            this.pnlOwnerInfo.Controls.Add(this.cmdCurrentOwner);
            this.pnlOwnerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOwnerInfo.Location = new System.Drawing.Point(180, 0);
            this.pnlOwnerInfo.Name = "pnlOwnerInfo";
            this.pnlOwnerInfo.Size = new System.Drawing.Size(180, 28);
            this.pnlOwnerInfo.TabIndex = 27;
            // 
            // lblCurrentOwner
            // 
            this.lblCurrentOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentOwner.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOwner.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentOwner.Name = "lblCurrentOwner";
            this.lblCurrentOwner.Size = new System.Drawing.Size(107, 26);
            this.lblCurrentOwner.TabIndex = 21;
            this.lblCurrentOwner.Text = "Owner: Kathleen";
            this.lblCurrentOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCurrentOwner
            // 
            this.cmdCurrentOwner.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdCurrentOwner.Image = global::C_DentalClaimTracker.Properties.Resources.tag_blue_add1;
            this.cmdCurrentOwner.Location = new System.Drawing.Point(107, 0);
            this.cmdCurrentOwner.Name = "cmdCurrentOwner";
            this.cmdCurrentOwner.Size = new System.Drawing.Size(71, 26);
            this.cmdCurrentOwner.TabIndex = 19;
            this.cmdCurrentOwner.Text = "Assign";
            this.cmdCurrentOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdCurrentOwner.UseVisualStyleBackColor = true;
            this.cmdCurrentOwner.Click += new System.EventHandler(this.cmdCurrentOwner_Click);
            // 
            // pnlResendButton
            // 
            this.pnlResendButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResendButton.Controls.Add(this.cmdResendClaim);
            this.pnlResendButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResendButton.Location = new System.Drawing.Point(90, 0);
            this.pnlResendButton.Name = "pnlResendButton";
            this.pnlResendButton.Size = new System.Drawing.Size(90, 28);
            this.pnlResendButton.TabIndex = 29;
            // 
            // cmdResendClaim
            // 
            this.cmdResendClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdResendClaim.Image = ((System.Drawing.Image)(resources.GetObject("cmdResendClaim.Image")));
            this.cmdResendClaim.Location = new System.Drawing.Point(0, 0);
            this.cmdResendClaim.Name = "cmdResendClaim";
            this.cmdResendClaim.Size = new System.Drawing.Size(88, 26);
            this.cmdResendClaim.TabIndex = 16;
            this.cmdResendClaim.Text = "&Resend";
            this.cmdResendClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdResendClaim, "Resend Via EDI");
            this.cmdResendClaim.UseVisualStyleBackColor = true;
            this.cmdResendClaim.Click += new System.EventHandler(this.cmdResendClaim_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmdMainPrintClaim);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 28);
            this.panel3.TabIndex = 26;
            // 
            // cmdMainPrintClaim
            // 
            this.cmdMainPrintClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdMainPrintClaim.Image = ((System.Drawing.Image)(resources.GetObject("cmdMainPrintClaim.Image")));
            this.cmdMainPrintClaim.Location = new System.Drawing.Point(0, 0);
            this.cmdMainPrintClaim.Name = "cmdMainPrintClaim";
            this.cmdMainPrintClaim.Size = new System.Drawing.Size(88, 26);
            this.cmdMainPrintClaim.TabIndex = 16;
            this.cmdMainPrintClaim.Text = "Print";
            this.cmdMainPrintClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdMainPrintClaim.UseVisualStyleBackColor = true;
            this.cmdMainPrintClaim.Click += new System.EventHandler(this.cmdMainPrintClaim_Click);
            // 
            // spltTopBottom
            // 
            this.spltTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltTopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltTopBottom.Location = new System.Drawing.Point(0, 0);
            this.spltTopBottom.Name = "spltTopBottom";
            this.spltTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltTopBottom.Panel1
            // 
            this.spltTopBottom.Panel1.Controls.Add(this.pnlTopPanel);
            this.spltTopBottom.Panel1MinSize = 1;
            // 
            // spltTopBottom.Panel2
            // 
            this.spltTopBottom.Panel2.Controls.Add(this.spltLeftRight);
            this.spltTopBottom.Size = new System.Drawing.Size(1148, 714);
            this.spltTopBottom.SplitterDistance = 32;
            this.spltTopBottom.TabIndex = 91;
            this.spltTopBottom.DoubleClick += new System.EventHandler(this.splitContainer2_DoubleClick);
            // 
            // spltLeftRight
            // 
            this.spltLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltLeftRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltLeftRight.Location = new System.Drawing.Point(0, 0);
            this.spltLeftRight.Name = "spltLeftRight";
            // 
            // spltLeftRight.Panel1
            // 
            this.spltLeftRight.Panel1.Controls.Add(this.pnlDisplayPanel);
            this.spltLeftRight.Panel1.Controls.Add(this.tbcNavigator);
            this.spltLeftRight.Panel1.Controls.Add(this.panel4);
            // 
            // spltLeftRight.Panel2
            // 
            this.spltLeftRight.Panel2.Controls.Add(this.spltRightSide);
            this.spltLeftRight.Size = new System.Drawing.Size(1148, 678);
            this.spltLeftRight.SplitterDistance = 564;
            this.spltLeftRight.TabIndex = 17;
            this.spltLeftRight.DoubleClick += new System.EventHandler(this.spltLeftRight_DoubleClick);
            // 
            // pnlDisplayPanel
            // 
            this.pnlDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayPanel.Location = new System.Drawing.Point(0, 43);
            this.pnlDisplayPanel.Name = "pnlDisplayPanel";
            this.pnlDisplayPanel.Size = new System.Drawing.Size(564, 29);
            this.pnlDisplayPanel.TabIndex = 64;
            // 
            // tbcNavigator
            // 
            this.tbcNavigator.Controls.Add(this.tabClaimInfo);
            this.tbcNavigator.Controls.Add(this.tabPastCalls);
            this.tbcNavigator.Controls.Add(this.tabRelatedClaims);
            this.tbcNavigator.Controls.Add(this.tabSearchClaims);
            this.tbcNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcNavigator.Location = new System.Drawing.Point(0, 72);
            this.tbcNavigator.Name = "tbcNavigator";
            this.tbcNavigator.SelectedIndex = 0;
            this.tbcNavigator.Size = new System.Drawing.Size(564, 606);
            this.tbcNavigator.TabIndex = 15;
            this.tbcNavigator.Visible = false;
            this.tbcNavigator.SelectedIndexChanged += new System.EventHandler(this.tbcNavigator_SelectedIndexChanged);
            // 
            // tabClaimInfo
            // 
            this.tabClaimInfo.Controls.Add(this.pnlLeftPanel);
            this.tabClaimInfo.Location = new System.Drawing.Point(4, 22);
            this.tabClaimInfo.Name = "tabClaimInfo";
            this.tabClaimInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabClaimInfo.Size = new System.Drawing.Size(556, 580);
            this.tabClaimInfo.TabIndex = 0;
            this.tabClaimInfo.Text = "Claim Info";
            this.tabClaimInfo.UseVisualStyleBackColor = true;
            // 
            // pnlLeftPanel
            // 
            this.pnlLeftPanel.AutoScroll = true;
            this.pnlLeftPanel.Controls.Add(this.pnlClaimData);
            this.pnlLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftPanel.Name = "pnlLeftPanel";
            this.pnlLeftPanel.Size = new System.Drawing.Size(550, 574);
            this.pnlLeftPanel.TabIndex = 90;
            // 
            // pnlClaimData
            // 
            this.pnlClaimData.AutoScroll = true;
            this.pnlClaimData.Controls.Add(this.ctlHandlingDisplay);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayGeneral);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayNotes);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayDoctor);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayPatient);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplaySubscriber);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayServices);
            this.pnlClaimData.Controls.Add(this.ctlClaimDisplayInsurance);
            this.pnlClaimData.Controls.Add(this.panel2);
            this.pnlClaimData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClaimData.Location = new System.Drawing.Point(0, 0);
            this.pnlClaimData.Name = "pnlClaimData";
            this.pnlClaimData.Size = new System.Drawing.Size(550, 574);
            this.pnlClaimData.TabIndex = 15;
            // 
            // ctlHandlingDisplay
            // 
            this.ctlHandlingDisplay.BackColorCaption = System.Drawing.Color.DarkSeaGreen;
            this.ctlHandlingDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlHandlingDisplay.CanMaximize = false;
            this.ctlHandlingDisplay.Caption = "Handling";
            this.ctlHandlingDisplay.Controls.Add(this.panel18);
            this.ctlHandlingDisplay.Controls.Add(this.panel17);
            this.ctlHandlingDisplay.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Full;
            this.ctlHandlingDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlHandlingDisplay.FormIndex = 7;
            this.ctlHandlingDisplay.Location = new System.Drawing.Point(0, 590);
            this.ctlHandlingDisplay.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlHandlingDisplay.Name = "ctlHandlingDisplay";
            this.ctlHandlingDisplay.Size = new System.Drawing.Size(531, 211);
            this.ctlHandlingDisplay.TabIndex = 87;
            this.ctlHandlingDisplay.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlHandlingDisplay.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dgvHandlingHistory);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(240, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(289, 209);
            this.panel18.TabIndex = 83;
            this.panel18.Tag = "0";
            // 
            // dgvHandlingHistory
            // 
            this.dgvHandlingHistory.AllowUserToAddRows = false;
            this.dgvHandlingHistory.AllowUserToDeleteRows = false;
            this.dgvHandlingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHandlingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBatchNo,
            this.colHandlingMethod,
            this.colSendDate});
            this.dgvHandlingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHandlingHistory.Location = new System.Drawing.Point(0, 21);
            this.dgvHandlingHistory.Name = "dgvHandlingHistory";
            this.dgvHandlingHistory.RowHeadersVisible = false;
            this.dgvHandlingHistory.Size = new System.Drawing.Size(289, 188);
            this.dgvHandlingHistory.TabIndex = 73;
            // 
            // colBatchNo
            // 
            this.colBatchNo.HeaderText = "Batch #";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Width = 80;
            // 
            // colHandlingMethod
            // 
            this.colHandlingMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHandlingMethod.HeaderText = "Handling";
            this.colHandlingMethod.Name = "colHandlingMethod";
            // 
            // colSendDate
            // 
            this.colSendDate.HeaderText = "Sent Date";
            this.colSendDate.Name = "colSendDate";
            this.colSendDate.Width = 110;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label54);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(289, 21);
            this.panel20.TabIndex = 75;
            this.panel20.Tag = "1";
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(0, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(289, 21);
            this.label54.TabIndex = 25;
            this.label54.Tag = "0";
            this.label54.Text = "Batch History";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.flowLayoutPanel11);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(240, 209);
            this.panel17.TabIndex = 82;
            this.panel17.Tag = "0";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label33);
            this.flowLayoutPanel11.Controls.Add(this.cmbHandling);
            this.flowLayoutPanel11.Controls.Add(this.label56);
            this.flowLayoutPanel11.Controls.Add(this.cmbOverrideProvider);
            this.flowLayoutPanel11.Controls.Add(this.chkUseApexDefaults);
            this.flowLayoutPanel11.Controls.Add(this.grpApexOptions);
            this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(240, 209);
            this.flowLayoutPanel11.TabIndex = 3;
            this.flowLayoutPanel11.Tag = "0";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 25);
            this.label33.TabIndex = 25;
            this.label33.Text = "Default Handling";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHandling
            // 
            this.cmbHandling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandling.FormattingEnabled = true;
            this.cmbHandling.Items.AddRange(new object[] {
            "Unclassified",
            "Paper",
            "ApexEDI"});
            this.cmbHandling.Location = new System.Drawing.Point(113, 3);
            this.cmbHandling.Name = "cmbHandling";
            this.cmbHandling.Size = new System.Drawing.Size(123, 21);
            this.cmbHandling.TabIndex = 26;
            this.cmbHandling.Tag = "0";
            this.cmbHandling.SelectedIndexChanged += new System.EventHandler(this.cmbHandling_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(3, 27);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(104, 25);
            this.label56.TabIndex = 79;
            this.label56.Text = "Override Prov";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOverrideProvider
            // 
            this.cmbOverrideProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverrideProvider.FormattingEnabled = true;
            this.cmbOverrideProvider.Location = new System.Drawing.Point(113, 30);
            this.cmbOverrideProvider.Name = "cmbOverrideProvider";
            this.cmbOverrideProvider.Size = new System.Drawing.Size(123, 21);
            this.cmbOverrideProvider.TabIndex = 80;
            this.cmbOverrideProvider.Tag = "0";
            // 
            // chkUseApexDefaults
            // 
            this.chkUseApexDefaults.AutoSize = true;
            this.chkUseApexDefaults.Checked = true;
            this.chkUseApexDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseApexDefaults.Location = new System.Drawing.Point(3, 57);
            this.chkUseApexDefaults.Name = "chkUseApexDefaults";
            this.chkUseApexDefaults.Size = new System.Drawing.Size(192, 17);
            this.chkUseApexDefaults.TabIndex = 78;
            this.chkUseApexDefaults.Tag = "0";
            this.chkUseApexDefaults.Text = "Append Apex System Default Text";
            this.chkUseApexDefaults.UseVisualStyleBackColor = true;
            this.chkUseApexDefaults.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // grpApexOptions
            // 
            this.grpApexOptions.Controls.Add(this.label34);
            this.grpApexOptions.Controls.Add(this.cmbApexStandardOption);
            this.grpApexOptions.Controls.Add(this.txtApexCustomText);
            this.grpApexOptions.Controls.Add(this.label39);
            this.grpApexOptions.Enabled = false;
            this.grpApexOptions.Location = new System.Drawing.Point(3, 80);
            this.grpApexOptions.Name = "grpApexOptions";
            this.grpApexOptions.Size = new System.Drawing.Size(233, 97);
            this.grpApexOptions.TabIndex = 75;
            this.grpApexOptions.TabStop = false;
            this.grpApexOptions.Tag = "1";
            this.grpApexOptions.Text = "Apex Text";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 13);
            this.label34.TabIndex = 80;
            this.label34.Text = "Standard Option";
            // 
            // cmbApexStandardOption
            // 
            this.cmbApexStandardOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApexStandardOption.FormattingEnabled = true;
            this.cmbApexStandardOption.Items.AddRange(new object[] {
            "Select an option..."});
            this.cmbApexStandardOption.Location = new System.Drawing.Point(7, 33);
            this.cmbApexStandardOption.Name = "cmbApexStandardOption";
            this.cmbApexStandardOption.Size = new System.Drawing.Size(163, 21);
            this.cmbApexStandardOption.TabIndex = 79;
            this.cmbApexStandardOption.SelectedIndexChanged += new System.EventHandler(this.cmbApexStandardOption_SelectedIndexChanged);
            // 
            // txtApexCustomText
            // 
            this.txtApexCustomText.Location = new System.Drawing.Point(7, 73);
            this.txtApexCustomText.MaxLength = 45;
            this.txtApexCustomText.Name = "txtApexCustomText";
            this.txtApexCustomText.Size = new System.Drawing.Size(220, 21);
            this.txtApexCustomText.TabIndex = 78;
            this.txtApexCustomText.Leave += new System.EventHandler(this.Save_Claim);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(4, 57);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(198, 13);
            this.label39.TabIndex = 76;
            this.label39.Text = "Custom Text (max 45 characters)";
            // 
            // ctlClaimDisplayGeneral
            // 
            this.ctlClaimDisplayGeneral.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayGeneral.CanMaximize = true;
            this.ctlClaimDisplayGeneral.Caption = "General";
            this.ctlClaimDisplayGeneral.Controls.Add(this.flowLayoutPanel9);
            this.ctlClaimDisplayGeneral.Controls.Add(this.panel15);
            this.ctlClaimDisplayGeneral.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayGeneral.FormIndex = 5;
            this.ctlClaimDisplayGeneral.Location = new System.Drawing.Point(0, 483);
            this.ctlClaimDisplayGeneral.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayGeneral.Name = "ctlClaimDisplayGeneral";
            this.ctlClaimDisplayGeneral.Size = new System.Drawing.Size(531, 107);
            this.ctlClaimDisplayGeneral.TabIndex = 86;
            this.ctlClaimDisplayGeneral.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayGeneral.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label8);
            this.flowLayoutPanel9.Controls.Add(this.txtOnHoldDate);
            this.flowLayoutPanel9.Controls.Add(this.label16);
            this.flowLayoutPanel9.Controls.Add(this.txtTracerDate);
            this.flowLayoutPanel9.Controls.Add(this.lblClaimPaid);
            this.flowLayoutPanel9.Controls.Add(this.label38);
            this.flowLayoutPanel9.Controls.Add(this.txtDentrixClaimID);
            this.flowLayoutPanel9.Controls.Add(this.label62);
            this.flowLayoutPanel9.Controls.Add(this.txtDentrixClaimDB);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(239, 28);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(290, 77);
            this.flowLayoutPanel9.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 29;
            this.label8.Tag = "1";
            this.label8.Text = "On hold";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOnHoldDate
            // 
            this.txtOnHoldDate.BackColor = System.Drawing.Color.White;
            this.txtOnHoldDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOnHoldDate.Location = new System.Drawing.Point(76, 3);
            this.txtOnHoldDate.MaxLength = 254;
            this.txtOnHoldDate.Name = "txtOnHoldDate";
            this.txtOnHoldDate.ReadOnly = true;
            this.txtOnHoldDate.Size = new System.Drawing.Size(210, 21);
            this.txtOnHoldDate.TabIndex = 83;
            this.txtOnHoldDate.Tag = "1";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 25);
            this.label16.TabIndex = 35;
            this.label16.Tag = "1";
            this.label16.Text = "Tracer";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTracerDate
            // 
            this.txtTracerDate.BackColor = System.Drawing.Color.White;
            this.txtTracerDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTracerDate.Location = new System.Drawing.Point(76, 30);
            this.txtTracerDate.MaxLength = 254;
            this.txtTracerDate.Name = "txtTracerDate";
            this.txtTracerDate.ReadOnly = true;
            this.txtTracerDate.Size = new System.Drawing.Size(210, 21);
            this.txtTracerDate.TabIndex = 84;
            this.txtTracerDate.Tag = "1";
            // 
            // lblClaimPaid
            // 
            this.lblClaimPaid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimPaid.Location = new System.Drawing.Point(3, 54);
            this.lblClaimPaid.Name = "lblClaimPaid";
            this.lblClaimPaid.Size = new System.Drawing.Size(283, 23);
            this.lblClaimPaid.TabIndex = 80;
            this.lblClaimPaid.Tag = "1";
            this.lblClaimPaid.Text = "Not Paid";
            this.lblClaimPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 77);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 25);
            this.label38.TabIndex = 85;
            this.label38.Tag = "0";
            this.label38.Text = "DentrixID";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDentrixClaimID
            // 
            this.txtDentrixClaimID.BackColor = System.Drawing.Color.White;
            this.txtDentrixClaimID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDentrixClaimID.Location = new System.Drawing.Point(76, 80);
            this.txtDentrixClaimID.MaxLength = 254;
            this.txtDentrixClaimID.Name = "txtDentrixClaimID";
            this.txtDentrixClaimID.ReadOnly = true;
            this.txtDentrixClaimID.Size = new System.Drawing.Size(64, 21);
            this.txtDentrixClaimID.TabIndex = 83;
            this.txtDentrixClaimID.Tag = "0";
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(146, 77);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(67, 25);
            this.label62.TabIndex = 86;
            this.label62.Tag = "0";
            this.label62.Text = "DentrixDB";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDentrixClaimDB
            // 
            this.txtDentrixClaimDB.BackColor = System.Drawing.Color.White;
            this.txtDentrixClaimDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDentrixClaimDB.Location = new System.Drawing.Point(219, 80);
            this.txtDentrixClaimDB.MaxLength = 254;
            this.txtDentrixClaimDB.Name = "txtDentrixClaimDB";
            this.txtDentrixClaimDB.ReadOnly = true;
            this.txtDentrixClaimDB.Size = new System.Drawing.Size(64, 21);
            this.txtDentrixClaimDB.TabIndex = 87;
            this.txtDentrixClaimDB.Tag = "0";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.flowLayoutPanel10);
            this.panel15.Controls.Add(this.label37);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 28);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(239, 77);
            this.panel15.TabIndex = 85;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label4);
            this.flowLayoutPanel10.Controls.Add(this.txtSentDate);
            this.flowLayoutPanel10.Controls.Add(this.label9);
            this.flowLayoutPanel10.Controls.Add(this.txtResentDate);
            this.flowLayoutPanel10.Controls.Add(this.label30);
            this.flowLayoutPanel10.Controls.Add(this.txtClinic);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(240, 77);
            this.flowLayoutPanel10.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 26;
            this.label4.Tag = "1";
            this.label4.Text = "Sent";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSentDate
            // 
            this.txtSentDate.BackColor = System.Drawing.Color.White;
            this.txtSentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSentDate.Location = new System.Drawing.Point(67, 3);
            this.txtSentDate.MaxLength = 254;
            this.txtSentDate.Name = "txtSentDate";
            this.txtSentDate.ReadOnly = true;
            this.txtSentDate.Size = new System.Drawing.Size(170, 21);
            this.txtSentDate.TabIndex = 81;
            this.txtSentDate.Tag = "1";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 32;
            this.label9.Tag = "1";
            this.label9.Text = "Re-sent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResentDate
            // 
            this.txtResentDate.BackColor = System.Drawing.Color.White;
            this.txtResentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResentDate.Location = new System.Drawing.Point(67, 30);
            this.txtResentDate.MaxLength = 254;
            this.txtResentDate.Name = "txtResentDate";
            this.txtResentDate.ReadOnly = true;
            this.txtResentDate.Size = new System.Drawing.Size(170, 21);
            this.txtResentDate.TabIndex = 82;
            this.txtResentDate.Tag = "1";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 25);
            this.label30.TabIndex = 75;
            this.label30.Tag = "1";
            this.label30.Text = "Clinic";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClinic
            // 
            this.txtClinic.BackColor = System.Drawing.Color.White;
            this.txtClinic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClinic.Location = new System.Drawing.Point(67, 57);
            this.txtClinic.MaxLength = 254;
            this.txtClinic.Name = "txtClinic";
            this.txtClinic.ReadOnly = true;
            this.txtClinic.Size = new System.Drawing.Size(170, 21);
            this.txtClinic.TabIndex = 74;
            this.txtClinic.Tag = "1";
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(0, 73);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 25);
            this.label37.TabIndex = 77;
            this.label37.Tag = "0";
            this.label37.Text = "Dentrix ClaimID";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayNotes
            // 
            this.ctlClaimDisplayNotes.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayNotes.CanMaximize = false;
            this.ctlClaimDisplayNotes.Caption = "Dentrix Notes";
            this.ctlClaimDisplayNotes.Controls.Add(this.txtNotes);
            this.ctlClaimDisplayNotes.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayNotes.FormIndex = 6;
            this.ctlClaimDisplayNotes.Location = new System.Drawing.Point(0, 453);
            this.ctlClaimDisplayNotes.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayNotes.Name = "ctlClaimDisplayNotes";
            this.ctlClaimDisplayNotes.Size = new System.Drawing.Size(531, 30);
            this.ctlClaimDisplayNotes.TabIndex = 85;
            this.ctlClaimDisplayNotes.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayNotes.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.Location = new System.Drawing.Point(0, 28);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(529, 0);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.Tag = "1";
            this.txtNotes.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ctlClaimDisplayDoctor
            // 
            this.ctlClaimDisplayDoctor.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayDoctor.CanMaximize = true;
            this.ctlClaimDisplayDoctor.Caption = "Doctor";
            this.ctlClaimDisplayDoctor.Controls.Add(this.flowLayoutPanel8);
            this.ctlClaimDisplayDoctor.Controls.Add(this.flowLayoutPanel7);
            this.ctlClaimDisplayDoctor.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayDoctor.FormIndex = 4;
            this.ctlClaimDisplayDoctor.Location = new System.Drawing.Point(0, 344);
            this.ctlClaimDisplayDoctor.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayDoctor.Name = "ctlClaimDisplayDoctor";
            this.ctlClaimDisplayDoctor.Size = new System.Drawing.Size(531, 109);
            this.ctlClaimDisplayDoctor.TabIndex = 84;
            this.ctlClaimDisplayDoctor.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayDoctor.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label15);
            this.flowLayoutPanel8.Controls.Add(this.txtDoctorName);
            this.flowLayoutPanel8.Controls.Add(this.label14);
            this.flowLayoutPanel8.Controls.Add(this.txtDoctorTaxID);
            this.flowLayoutPanel8.Controls.Add(this.label13);
            this.flowLayoutPanel8.Controls.Add(this.txtDoctorLicenseID);
            this.flowLayoutPanel8.Controls.Add(this.label49);
            this.flowLayoutPanel8.Controls.Add(this.txtDoctorAddress);
            this.flowLayoutPanel8.Controls.Add(this.label50);
            this.flowLayoutPanel8.Controls.Add(this.txtDoctorCity);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(240, 79);
            this.flowLayoutPanel8.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 25);
            this.label15.TabIndex = 17;
            this.label15.Tag = "1";
            this.label15.Text = "Name";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BackColor = System.Drawing.Color.White;
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorName.Location = new System.Drawing.Point(67, 3);
            this.txtDoctorName.MaxLength = 254;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(170, 21);
            this.txtDoctorName.TabIndex = 0;
            this.txtDoctorName.Tag = "1";
            this.txtDoctorName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 19;
            this.label14.Tag = "1";
            this.label14.Text = "Tax ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorTaxID
            // 
            this.txtDoctorTaxID.BackColor = System.Drawing.Color.White;
            this.txtDoctorTaxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorTaxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorTaxID.Location = new System.Drawing.Point(67, 30);
            this.txtDoctorTaxID.MaxLength = 254;
            this.txtDoctorTaxID.Name = "txtDoctorTaxID";
            this.txtDoctorTaxID.ReadOnly = true;
            this.txtDoctorTaxID.Size = new System.Drawing.Size(170, 21);
            this.txtDoctorTaxID.TabIndex = 1;
            this.txtDoctorTaxID.Tag = "1";
            this.txtDoctorTaxID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 21;
            this.label13.Tag = "1";
            this.label13.Text = "Lic. ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorLicenseID
            // 
            this.txtDoctorLicenseID.BackColor = System.Drawing.Color.White;
            this.txtDoctorLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorLicenseID.Location = new System.Drawing.Point(67, 57);
            this.txtDoctorLicenseID.MaxLength = 254;
            this.txtDoctorLicenseID.Name = "txtDoctorLicenseID";
            this.txtDoctorLicenseID.ReadOnly = true;
            this.txtDoctorLicenseID.Size = new System.Drawing.Size(170, 21);
            this.txtDoctorLicenseID.TabIndex = 2;
            this.txtDoctorLicenseID.Tag = "1";
            this.txtDoctorLicenseID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(3, 81);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 25);
            this.label49.TabIndex = 70;
            this.label49.Text = "Address";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorAddress
            // 
            this.txtDoctorAddress.BackColor = System.Drawing.Color.White;
            this.txtDoctorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorAddress.Location = new System.Drawing.Point(67, 84);
            this.txtDoctorAddress.MaxLength = 254;
            this.txtDoctorAddress.Name = "txtDoctorAddress";
            this.txtDoctorAddress.ReadOnly = true;
            this.txtDoctorAddress.Size = new System.Drawing.Size(170, 21);
            this.txtDoctorAddress.TabIndex = 69;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(3, 108);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(58, 25);
            this.label50.TabIndex = 74;
            this.label50.Text = "City";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorCity
            // 
            this.txtDoctorCity.BackColor = System.Drawing.Color.White;
            this.txtDoctorCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorCity.Location = new System.Drawing.Point(67, 111);
            this.txtDoctorCity.MaxLength = 149;
            this.txtDoctorCity.Name = "txtDoctorCity";
            this.txtDoctorCity.ReadOnly = true;
            this.txtDoctorCity.Size = new System.Drawing.Size(170, 21);
            this.txtDoctorCity.TabIndex = 73;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label20);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorPhone);
            this.flowLayoutPanel7.Controls.Add(this.label19);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorNPI);
            this.flowLayoutPanel7.Controls.Add(this.label18);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorBC);
            this.flowLayoutPanel7.Controls.Add(this.label51);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorAddress2);
            this.flowLayoutPanel7.Controls.Add(this.label52);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorState);
            this.flowLayoutPanel7.Controls.Add(this.label17);
            this.flowLayoutPanel7.Controls.Add(this.txtDoctorZIP);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(240, 28);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(289, 79);
            this.flowLayoutPanel7.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 25);
            this.label20.TabIndex = 25;
            this.label20.Tag = "1";
            this.label20.Text = "Phone";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.BackColor = System.Drawing.Color.White;
            this.txtDoctorPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorPhone.Location = new System.Drawing.Point(76, 3);
            this.txtDoctorPhone.MaxLength = 254;
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.ReadOnly = true;
            this.txtDoctorPhone.Size = new System.Drawing.Size(210, 21);
            this.txtDoctorPhone.TabIndex = 4;
            this.txtDoctorPhone.Tag = "1";
            this.txtDoctorPhone.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 25);
            this.label19.TabIndex = 27;
            this.label19.Tag = "1";
            this.label19.Text = "Fax";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorNPI
            // 
            this.txtDoctorNPI.BackColor = System.Drawing.Color.White;
            this.txtDoctorNPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorNPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorNPI.Location = new System.Drawing.Point(76, 30);
            this.txtDoctorNPI.MaxLength = 254;
            this.txtDoctorNPI.Name = "txtDoctorNPI";
            this.txtDoctorNPI.ReadOnly = true;
            this.txtDoctorNPI.Size = new System.Drawing.Size(210, 21);
            this.txtDoctorNPI.TabIndex = 5;
            this.txtDoctorNPI.Tag = "1";
            this.txtDoctorNPI.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 25);
            this.label18.TabIndex = 23;
            this.label18.Tag = "1";
            this.label18.Text = "BC/BS #";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorBC
            // 
            this.txtDoctorBC.BackColor = System.Drawing.Color.White;
            this.txtDoctorBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorBC.Location = new System.Drawing.Point(76, 57);
            this.txtDoctorBC.MaxLength = 254;
            this.txtDoctorBC.Name = "txtDoctorBC";
            this.txtDoctorBC.ReadOnly = true;
            this.txtDoctorBC.Size = new System.Drawing.Size(210, 21);
            this.txtDoctorBC.TabIndex = 3;
            this.txtDoctorBC.Tag = "1";
            this.txtDoctorBC.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(3, 81);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 25);
            this.label51.TabIndex = 72;
            this.label51.Text = "Line 2";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorAddress2
            // 
            this.txtDoctorAddress2.BackColor = System.Drawing.Color.White;
            this.txtDoctorAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorAddress2.Location = new System.Drawing.Point(76, 84);
            this.txtDoctorAddress2.MaxLength = 254;
            this.txtDoctorAddress2.Name = "txtDoctorAddress2";
            this.txtDoctorAddress2.ReadOnly = true;
            this.txtDoctorAddress2.Size = new System.Drawing.Size(210, 21);
            this.txtDoctorAddress2.TabIndex = 71;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(3, 108);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(67, 25);
            this.label52.TabIndex = 76;
            this.label52.Text = "State";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorState
            // 
            this.txtDoctorState.BackColor = System.Drawing.Color.White;
            this.txtDoctorState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorState.Location = new System.Drawing.Point(76, 111);
            this.txtDoctorState.MaxLength = 99;
            this.txtDoctorState.Name = "txtDoctorState";
            this.txtDoctorState.ReadOnly = true;
            this.txtDoctorState.Size = new System.Drawing.Size(45, 21);
            this.txtDoctorState.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(127, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 25);
            this.label17.TabIndex = 78;
            this.label17.Text = "ZIP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorZIP
            // 
            this.txtDoctorZIP.BackColor = System.Drawing.Color.White;
            this.txtDoctorZIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorZIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorZIP.Location = new System.Drawing.Point(168, 111);
            this.txtDoctorZIP.MaxLength = 19;
            this.txtDoctorZIP.Name = "txtDoctorZIP";
            this.txtDoctorZIP.ReadOnly = true;
            this.txtDoctorZIP.Size = new System.Drawing.Size(100, 21);
            this.txtDoctorZIP.TabIndex = 77;
            // 
            // ctlClaimDisplayPatient
            // 
            this.ctlClaimDisplayPatient.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayPatient.CanMaximize = true;
            this.ctlClaimDisplayPatient.Caption = "Patient";
            this.ctlClaimDisplayPatient.Controls.Add(this.flowLayoutPanel3);
            this.ctlClaimDisplayPatient.Controls.Add(this.panel10);
            this.ctlClaimDisplayPatient.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayPatient.FormIndex = 3;
            this.ctlClaimDisplayPatient.Location = new System.Drawing.Point(0, 289);
            this.ctlClaimDisplayPatient.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayPatient.Name = "ctlClaimDisplayPatient";
            this.ctlClaimDisplayPatient.Size = new System.Drawing.Size(531, 55);
            this.ctlClaimDisplayPatient.TabIndex = 83;
            this.ctlClaimDisplayPatient.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayPatient.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.txtPatientSSN);
            this.flowLayoutPanel3.Controls.Add(this.label58);
            this.flowLayoutPanel3.Controls.Add(this.label47);
            this.flowLayoutPanel3.Controls.Add(this.txtPatientAddress2);
            this.flowLayoutPanel3.Controls.Add(this.label45);
            this.flowLayoutPanel3.Controls.Add(this.txtPatientState);
            this.flowLayoutPanel3.Controls.Add(this.label10);
            this.flowLayoutPanel3.Controls.Add(this.txtPatientZIP);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(240, 28);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(289, 25);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 21;
            this.label12.Tag = "1";
            this.label12.Text = "SSN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientSSN
            // 
            this.txtPatientSSN.BackColor = System.Drawing.Color.White;
            this.txtPatientSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientSSN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientSSN.Location = new System.Drawing.Point(76, 3);
            this.txtPatientSSN.MaxLength = 254;
            this.txtPatientSSN.Name = "txtPatientSSN";
            this.txtPatientSSN.ReadOnly = true;
            this.txtPatientSSN.Size = new System.Drawing.Size(210, 21);
            this.txtPatientSSN.TabIndex = 3;
            this.txtPatientSSN.Tag = "1";
            this.txtPatientSSN.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label58
            // 
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(3, 27);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(283, 25);
            this.label58.TabIndex = 63;
            this.label58.Tag = "0";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(3, 52);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 25);
            this.label47.TabIndex = 62;
            this.label47.Tag = "0";
            this.label47.Text = "Line 2";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientAddress2
            // 
            this.txtPatientAddress2.BackColor = System.Drawing.Color.White;
            this.txtPatientAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientAddress2.Location = new System.Drawing.Point(76, 55);
            this.txtPatientAddress2.MaxLength = 254;
            this.txtPatientAddress2.Name = "txtPatientAddress2";
            this.txtPatientAddress2.ReadOnly = true;
            this.txtPatientAddress2.Size = new System.Drawing.Size(210, 21);
            this.txtPatientAddress2.TabIndex = 61;
            this.txtPatientAddress2.Tag = "0";
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(3, 79);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(67, 25);
            this.label45.TabIndex = 66;
            this.label45.Tag = "0";
            this.label45.Text = "State";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientState
            // 
            this.txtPatientState.BackColor = System.Drawing.Color.White;
            this.txtPatientState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientState.Location = new System.Drawing.Point(76, 82);
            this.txtPatientState.MaxLength = 99;
            this.txtPatientState.Name = "txtPatientState";
            this.txtPatientState.ReadOnly = true;
            this.txtPatientState.Size = new System.Drawing.Size(45, 21);
            this.txtPatientState.TabIndex = 65;
            this.txtPatientState.Tag = "0";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 25);
            this.label10.TabIndex = 68;
            this.label10.Tag = "0";
            this.label10.Text = "ZIP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientZIP
            // 
            this.txtPatientZIP.BackColor = System.Drawing.Color.White;
            this.txtPatientZIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientZIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientZIP.Location = new System.Drawing.Point(168, 82);
            this.txtPatientZIP.MaxLength = 19;
            this.txtPatientZIP.Name = "txtPatientZIP";
            this.txtPatientZIP.ReadOnly = true;
            this.txtPatientZIP.Size = new System.Drawing.Size(100, 21);
            this.txtPatientZIP.TabIndex = 67;
            this.txtPatientZIP.Tag = "0";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.flowLayoutPanel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 28);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 25);
            this.panel10.TabIndex = 70;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.txtPatientName);
            this.flowLayoutPanel4.Controls.Add(this.label11);
            this.flowLayoutPanel4.Controls.Add(this.txtPatientDOB);
            this.flowLayoutPanel4.Controls.Add(this.label48);
            this.flowLayoutPanel4.Controls.Add(this.txtPatientAddress);
            this.flowLayoutPanel4.Controls.Add(this.label46);
            this.flowLayoutPanel4.Controls.Add(this.txtPatientCity);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(240, 25);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 17;
            this.label7.Tag = "1";
            this.label7.Text = "Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.Location = new System.Drawing.Point(67, 3);
            this.txtPatientName.MaxLength = 254;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(170, 21);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Tag = "1";
            this.txtPatientName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 19;
            this.label11.Tag = "1";
            this.label11.Text = "DOB";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientDOB
            // 
            this.txtPatientDOB.BackColor = System.Drawing.Color.White;
            this.txtPatientDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientDOB.Location = new System.Drawing.Point(67, 30);
            this.txtPatientDOB.MaxLength = 254;
            this.txtPatientDOB.Name = "txtPatientDOB";
            this.txtPatientDOB.ReadOnly = true;
            this.txtPatientDOB.Size = new System.Drawing.Size(170, 21);
            this.txtPatientDOB.TabIndex = 69;
            this.txtPatientDOB.Tag = "1";
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(3, 54);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(58, 25);
            this.label48.TabIndex = 60;
            this.label48.Tag = "0";
            this.label48.Text = "Address";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.BackColor = System.Drawing.Color.White;
            this.txtPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientAddress.Location = new System.Drawing.Point(67, 57);
            this.txtPatientAddress.MaxLength = 254;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.ReadOnly = true;
            this.txtPatientAddress.Size = new System.Drawing.Size(170, 21);
            this.txtPatientAddress.TabIndex = 59;
            this.txtPatientAddress.Tag = "0";
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 81);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(58, 25);
            this.label46.TabIndex = 64;
            this.label46.Tag = "0";
            this.label46.Text = "City";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientCity
            // 
            this.txtPatientCity.BackColor = System.Drawing.Color.White;
            this.txtPatientCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientCity.Location = new System.Drawing.Point(67, 84);
            this.txtPatientCity.MaxLength = 149;
            this.txtPatientCity.Name = "txtPatientCity";
            this.txtPatientCity.ReadOnly = true;
            this.txtPatientCity.Size = new System.Drawing.Size(170, 21);
            this.txtPatientCity.TabIndex = 63;
            this.txtPatientCity.Tag = "0";
            // 
            // ctlClaimDisplaySubscriber
            // 
            this.ctlClaimDisplaySubscriber.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplaySubscriber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplaySubscriber.CanMaximize = true;
            this.ctlClaimDisplaySubscriber.Caption = "Subscriber";
            this.ctlClaimDisplaySubscriber.Controls.Add(this.flowLayoutPanel2);
            this.ctlClaimDisplaySubscriber.Controls.Add(this.flowLayoutPanel1);
            this.ctlClaimDisplaySubscriber.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplaySubscriber.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplaySubscriber.FormIndex = 2;
            this.ctlClaimDisplaySubscriber.Location = new System.Drawing.Point(0, 153);
            this.ctlClaimDisplaySubscriber.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplaySubscriber.Name = "ctlClaimDisplaySubscriber";
            this.ctlClaimDisplaySubscriber.Size = new System.Drawing.Size(531, 136);
            this.ctlClaimDisplaySubscriber.TabIndex = 82;
            this.ctlClaimDisplaySubscriber.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplaySubscriber.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label23);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberGroupName);
            this.flowLayoutPanel2.Controls.Add(this.label22);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberGroupNum);
            this.flowLayoutPanel2.Controls.Add(this.label29);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberSSN);
            this.flowLayoutPanel2.Controls.Add(this.label61);
            this.flowLayoutPanel2.Controls.Add(this.label43);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberAddress2);
            this.flowLayoutPanel2.Controls.Add(this.label35);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberState);
            this.flowLayoutPanel2.Controls.Add(this.label28);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriberZIP);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(240, 28);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(289, 106);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 25);
            this.label23.TabIndex = 25;
            this.label23.Tag = "1";
            this.label23.Text = "Group Name";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberGroupName
            // 
            this.txtSubscriberGroupName.BackColor = System.Drawing.Color.White;
            this.txtSubscriberGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberGroupName.Location = new System.Drawing.Point(76, 3);
            this.txtSubscriberGroupName.MaxLength = 254;
            this.txtSubscriberGroupName.Name = "txtSubscriberGroupName";
            this.txtSubscriberGroupName.ReadOnly = true;
            this.txtSubscriberGroupName.Size = new System.Drawing.Size(210, 21);
            this.txtSubscriberGroupName.TabIndex = 6;
            this.txtSubscriberGroupName.Tag = "1";
            this.txtSubscriberGroupName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 25);
            this.label22.TabIndex = 27;
            this.label22.Tag = "1";
            this.label22.Text = "Group #";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberGroupNum
            // 
            this.txtSubscriberGroupNum.BackColor = System.Drawing.Color.White;
            this.txtSubscriberGroupNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberGroupNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberGroupNum.Location = new System.Drawing.Point(76, 30);
            this.txtSubscriberGroupNum.MaxLength = 254;
            this.txtSubscriberGroupNum.Name = "txtSubscriberGroupNum";
            this.txtSubscriberGroupNum.ReadOnly = true;
            this.txtSubscriberGroupNum.Size = new System.Drawing.Size(210, 21);
            this.txtSubscriberGroupNum.TabIndex = 7;
            this.txtSubscriberGroupNum.Tag = "1";
            this.txtSubscriberGroupNum.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 54);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 25);
            this.label29.TabIndex = 29;
            this.label29.Tag = "1";
            this.label29.Text = "SSN";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberSSN
            // 
            this.txtSubscriberSSN.BackColor = System.Drawing.Color.White;
            this.txtSubscriberSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberSSN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberSSN.Location = new System.Drawing.Point(76, 57);
            this.txtSubscriberSSN.MaxLength = 254;
            this.txtSubscriberSSN.Name = "txtSubscriberSSN";
            this.txtSubscriberSSN.ReadOnly = true;
            this.txtSubscriberSSN.Size = new System.Drawing.Size(210, 21);
            this.txtSubscriberSSN.TabIndex = 5;
            this.txtSubscriberSSN.Tag = "1";
            this.txtSubscriberSSN.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(3, 81);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(283, 25);
            this.label61.TabIndex = 64;
            this.label61.Tag = "0";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(3, 106);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(67, 25);
            this.label43.TabIndex = 52;
            this.label43.Text = "Line 2";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberAddress2
            // 
            this.txtSubscriberAddress2.BackColor = System.Drawing.Color.White;
            this.txtSubscriberAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberAddress2.Location = new System.Drawing.Point(76, 109);
            this.txtSubscriberAddress2.MaxLength = 254;
            this.txtSubscriberAddress2.Name = "txtSubscriberAddress2";
            this.txtSubscriberAddress2.ReadOnly = true;
            this.txtSubscriberAddress2.Size = new System.Drawing.Size(210, 21);
            this.txtSubscriberAddress2.TabIndex = 51;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 133);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 25);
            this.label35.TabIndex = 56;
            this.label35.Text = "State";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberState
            // 
            this.txtSubscriberState.BackColor = System.Drawing.Color.White;
            this.txtSubscriberState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberState.Location = new System.Drawing.Point(75, 136);
            this.txtSubscriberState.MaxLength = 99;
            this.txtSubscriberState.Name = "txtSubscriberState";
            this.txtSubscriberState.ReadOnly = true;
            this.txtSubscriberState.Size = new System.Drawing.Size(45, 21);
            this.txtSubscriberState.TabIndex = 55;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(126, 133);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 25);
            this.label28.TabIndex = 58;
            this.label28.Text = "ZIP";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberZIP
            // 
            this.txtSubscriberZIP.BackColor = System.Drawing.Color.White;
            this.txtSubscriberZIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberZIP.Location = new System.Drawing.Point(167, 136);
            this.txtSubscriberZIP.MaxLength = 19;
            this.txtSubscriberZIP.Name = "txtSubscriberZIP";
            this.txtSubscriberZIP.ReadOnly = true;
            this.txtSubscriberZIP.Size = new System.Drawing.Size(100, 21);
            this.txtSubscriberZIP.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label27);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberName);
            this.flowLayoutPanel1.Controls.Add(this.label26);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberDOB);
            this.flowLayoutPanel1.Controls.Add(this.label25);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberID);
            this.flowLayoutPanel1.Controls.Add(this.label24);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberAltID);
            this.flowLayoutPanel1.Controls.Add(this.label44);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberAddress);
            this.flowLayoutPanel1.Controls.Add(this.label42);
            this.flowLayoutPanel1.Controls.Add(this.txtSubscriberCity);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 106);
            this.flowLayoutPanel1.TabIndex = 59;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 25);
            this.label27.TabIndex = 17;
            this.label27.Tag = "1";
            this.label27.Text = "Name";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberName
            // 
            this.txtSubscriberName.BackColor = System.Drawing.Color.White;
            this.txtSubscriberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberName.Location = new System.Drawing.Point(67, 3);
            this.txtSubscriberName.MaxLength = 254;
            this.txtSubscriberName.Name = "txtSubscriberName";
            this.txtSubscriberName.ReadOnly = true;
            this.txtSubscriberName.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberName.TabIndex = 0;
            this.txtSubscriberName.Tag = "1";
            this.txtSubscriberName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 25);
            this.label26.TabIndex = 19;
            this.label26.Tag = "1";
            this.label26.Text = "DOB";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberDOB
            // 
            this.txtSubscriberDOB.BackColor = System.Drawing.Color.White;
            this.txtSubscriberDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberDOB.Location = new System.Drawing.Point(67, 30);
            this.txtSubscriberDOB.MaxLength = 254;
            this.txtSubscriberDOB.Name = "txtSubscriberDOB";
            this.txtSubscriberDOB.ReadOnly = true;
            this.txtSubscriberDOB.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberDOB.TabIndex = 59;
            this.txtSubscriberDOB.Tag = "1";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 25);
            this.label25.TabIndex = 21;
            this.label25.Tag = "1";
            this.label25.Text = "Chart#";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberID
            // 
            this.txtSubscriberID.BackColor = System.Drawing.Color.White;
            this.txtSubscriberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberID.Location = new System.Drawing.Point(67, 57);
            this.txtSubscriberID.MaxLength = 254;
            this.txtSubscriberID.Name = "txtSubscriberID";
            this.txtSubscriberID.ReadOnly = true;
            this.txtSubscriberID.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberID.TabIndex = 3;
            this.txtSubscriberID.Tag = "1";
            this.txtSubscriberID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 81);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 25);
            this.label24.TabIndex = 23;
            this.label24.Tag = "1";
            this.label24.Text = "Ins ID";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberAltID
            // 
            this.txtSubscriberAltID.BackColor = System.Drawing.Color.White;
            this.txtSubscriberAltID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscriberAltID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberAltID.Location = new System.Drawing.Point(67, 84);
            this.txtSubscriberAltID.MaxLength = 254;
            this.txtSubscriberAltID.Name = "txtSubscriberAltID";
            this.txtSubscriberAltID.ReadOnly = true;
            this.txtSubscriberAltID.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberAltID.TabIndex = 4;
            this.txtSubscriberAltID.Tag = "1";
            this.txtSubscriberAltID.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(3, 108);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 25);
            this.label44.TabIndex = 50;
            this.label44.Text = "Address";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberAddress
            // 
            this.txtSubscriberAddress.BackColor = System.Drawing.Color.White;
            this.txtSubscriberAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberAddress.Location = new System.Drawing.Point(67, 111);
            this.txtSubscriberAddress.MaxLength = 254;
            this.txtSubscriberAddress.Name = "txtSubscriberAddress";
            this.txtSubscriberAddress.ReadOnly = true;
            this.txtSubscriberAddress.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberAddress.TabIndex = 49;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(3, 135);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 25);
            this.label42.TabIndex = 54;
            this.label42.Text = "City";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubscriberCity
            // 
            this.txtSubscriberCity.BackColor = System.Drawing.Color.White;
            this.txtSubscriberCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubscriberCity.Location = new System.Drawing.Point(67, 138);
            this.txtSubscriberCity.MaxLength = 149;
            this.txtSubscriberCity.Name = "txtSubscriberCity";
            this.txtSubscriberCity.ReadOnly = true;
            this.txtSubscriberCity.Size = new System.Drawing.Size(170, 21);
            this.txtSubscriberCity.TabIndex = 53;
            // 
            // ctlClaimDisplayServices
            // 
            this.ctlClaimDisplayServices.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayServices.CanMaximize = false;
            this.ctlClaimDisplayServices.Caption = "Services";
            this.ctlClaimDisplayServices.Controls.Add(this.dgvProcedureData);
            this.ctlClaimDisplayServices.Controls.Add(this.panel12);
            this.ctlClaimDisplayServices.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayServices.FormIndex = 1;
            this.ctlClaimDisplayServices.Location = new System.Drawing.Point(0, 73);
            this.ctlClaimDisplayServices.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayServices.Name = "ctlClaimDisplayServices";
            this.ctlClaimDisplayServices.Size = new System.Drawing.Size(531, 80);
            this.ctlClaimDisplayServices.TabIndex = 81;
            this.ctlClaimDisplayServices.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayServices.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
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
            this.dgvProcedureData.Location = new System.Drawing.Point(0, 52);
            this.dgvProcedureData.Name = "dgvProcedureData";
            this.dgvProcedureData.ReadOnly = true;
            this.dgvProcedureData.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcedureData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcedureData.Size = new System.Drawing.Size(529, 26);
            this.dgvProcedureData.TabIndex = 79;
            this.dgvProcedureData.Tag = "1";
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
            // panel12
            // 
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.panel6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 28);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(529, 24);
            this.panel12.TabIndex = 83;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtAmountOfClaim);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(240, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 24);
            this.panel7.TabIndex = 83;
            // 
            // txtAmountOfClaim
            // 
            this.txtAmountOfClaim.BackColor = System.Drawing.Color.White;
            this.txtAmountOfClaim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOfClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmountOfClaim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfClaim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountOfClaim.Location = new System.Drawing.Point(138, 0);
            this.txtAmountOfClaim.Multiline = true;
            this.txtAmountOfClaim.Name = "txtAmountOfClaim";
            this.txtAmountOfClaim.ReadOnly = true;
            this.txtAmountOfClaim.Size = new System.Drawing.Size(151, 24);
            this.txtAmountOfClaim.TabIndex = 80;
            this.txtAmountOfClaim.Tag = "1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 6;
            this.label1.Tag = "1";
            this.label1.Text = "Amount of Claim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDateOfService);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 24);
            this.panel6.TabIndex = 82;
            // 
            // txtDateOfService
            // 
            this.txtDateOfService.BackColor = System.Drawing.Color.White;
            this.txtDateOfService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateOfService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateOfService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOfService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDateOfService.Location = new System.Drawing.Point(100, 0);
            this.txtDateOfService.Multiline = true;
            this.txtDateOfService.Name = "txtDateOfService";
            this.txtDateOfService.ReadOnly = true;
            this.txtDateOfService.Size = new System.Drawing.Size(140, 24);
            this.txtDateOfService.TabIndex = 0;
            this.txtDateOfService.Tag = "1";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 9;
            this.label3.Tag = "1";
            this.label3.Text = "Date of Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlClaimDisplayInsurance
            // 
            this.ctlClaimDisplayInsurance.BackColorCaption = System.Drawing.Color.SteelBlue;
            this.ctlClaimDisplayInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlClaimDisplayInsurance.CanMaximize = true;
            this.ctlClaimDisplayInsurance.Caption = "Insurance Carrier";
            this.ctlClaimDisplayInsurance.Controls.Add(this.flowLayoutPanel5);
            this.ctlClaimDisplayInsurance.Controls.Add(this.flowLayoutPanel6);
            this.ctlClaimDisplayInsurance.DisplayMode = C_DentalClaimTracker.ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
            this.ctlClaimDisplayInsurance.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlClaimDisplayInsurance.FormIndex = 0;
            this.ctlClaimDisplayInsurance.Location = new System.Drawing.Point(0, 0);
            this.ctlClaimDisplayInsurance.MaximumSize = new System.Drawing.Size(531, 2000);
            this.ctlClaimDisplayInsurance.Name = "ctlClaimDisplayInsurance";
            this.ctlClaimDisplayInsurance.Size = new System.Drawing.Size(531, 73);
            this.ctlClaimDisplayInsurance.TabIndex = 80;
            this.ctlClaimDisplayInsurance.Resized += new System.EventHandler(this.ctlClaimDisplayData_Resized);
            this.ctlClaimDisplayInsurance.Load += new System.EventHandler(this.ctlClaimDisplayInsurance_Load);
            this.ctlClaimDisplayInsurance.Enter += new System.EventHandler(this.ctlClaimDataDisplay_Enter);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label41);
            this.flowLayoutPanel5.Controls.Add(this.txtInsurancePhone);
            this.flowLayoutPanel5.Controls.Add(this.lnkViewCompanyContactInfo);
            this.flowLayoutPanel5.Controls.Add(this.label21);
            this.flowLayoutPanel5.Controls.Add(this.txtInsuranceAddress2);
            this.flowLayoutPanel5.Controls.Add(this.label31);
            this.flowLayoutPanel5.Controls.Add(this.txtInsuranceState);
            this.flowLayoutPanel5.Controls.Add(this.label40);
            this.flowLayoutPanel5.Controls.Add(this.txtInsuranceZIP);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(240, 28);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(289, 43);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(3, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(67, 25);
            this.label41.TabIndex = 47;
            this.label41.Tag = "1";
            this.label41.Text = "Phone";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsurancePhone
            // 
            this.txtInsurancePhone.BackColor = System.Drawing.Color.White;
            this.txtInsurancePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsurancePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsurancePhone.Location = new System.Drawing.Point(76, 3);
            this.txtInsurancePhone.Name = "txtInsurancePhone";
            this.txtInsurancePhone.ReadOnly = true;
            this.txtInsurancePhone.Size = new System.Drawing.Size(210, 21);
            this.txtInsurancePhone.TabIndex = 46;
            this.txtInsurancePhone.Tag = "1";
            // 
            // lnkViewCompanyContactInfo
            // 
            this.lnkViewCompanyContactInfo.Location = new System.Drawing.Point(3, 27);
            this.lnkViewCompanyContactInfo.Name = "lnkViewCompanyContactInfo";
            this.lnkViewCompanyContactInfo.Size = new System.Drawing.Size(284, 16);
            this.lnkViewCompanyContactInfo.TabIndex = 48;
            this.lnkViewCompanyContactInfo.TabStop = true;
            this.lnkViewCompanyContactInfo.Tag = "1";
            this.lnkViewCompanyContactInfo.Text = "View extended company contact info...";
            this.lnkViewCompanyContactInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkViewCompanyContactInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewCompanyContactInfo_LinkClicked);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 25);
            this.label21.TabIndex = 33;
            this.label21.Text = "Line 2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceAddress2
            // 
            this.txtInsuranceAddress2.BackColor = System.Drawing.Color.White;
            this.txtInsuranceAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceAddress2.Location = new System.Drawing.Point(76, 46);
            this.txtInsuranceAddress2.Name = "txtInsuranceAddress2";
            this.txtInsuranceAddress2.ReadOnly = true;
            this.txtInsuranceAddress2.Size = new System.Drawing.Size(210, 21);
            this.txtInsuranceAddress2.TabIndex = 32;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 25);
            this.label31.TabIndex = 43;
            this.label31.Text = "State";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceState
            // 
            this.txtInsuranceState.BackColor = System.Drawing.Color.White;
            this.txtInsuranceState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceState.Location = new System.Drawing.Point(76, 73);
            this.txtInsuranceState.Name = "txtInsuranceState";
            this.txtInsuranceState.ReadOnly = true;
            this.txtInsuranceState.Size = new System.Drawing.Size(45, 21);
            this.txtInsuranceState.TabIndex = 42;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(127, 70);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 25);
            this.label40.TabIndex = 45;
            this.label40.Text = "ZIP";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceZIP
            // 
            this.txtInsuranceZIP.BackColor = System.Drawing.Color.White;
            this.txtInsuranceZIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceZIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceZIP.Location = new System.Drawing.Point(168, 73);
            this.txtInsuranceZIP.Name = "txtInsuranceZIP";
            this.txtInsuranceZIP.ReadOnly = true;
            this.txtInsuranceZIP.Size = new System.Drawing.Size(100, 21);
            this.txtInsuranceZIP.TabIndex = 44;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.txtInsuranceName);
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.txtInsuranceAddress);
            this.flowLayoutPanel6.Controls.Add(this.lblInsuranceCity);
            this.flowLayoutPanel6.Controls.Add(this.txtInsuranceCity);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(240, 43);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 16;
            this.label6.Tag = "1";
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.BackColor = System.Drawing.Color.White;
            this.txtInsuranceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceName.Location = new System.Drawing.Point(67, 3);
            this.txtInsuranceName.Multiline = true;
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.ReadOnly = true;
            this.txtInsuranceName.Size = new System.Drawing.Size(170, 38);
            this.txtInsuranceName.TabIndex = 49;
            this.txtInsuranceName.Tag = "1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceAddress
            // 
            this.txtInsuranceAddress.BackColor = System.Drawing.Color.White;
            this.txtInsuranceAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceAddress.Location = new System.Drawing.Point(67, 47);
            this.txtInsuranceAddress.Name = "txtInsuranceAddress";
            this.txtInsuranceAddress.ReadOnly = true;
            this.txtInsuranceAddress.Size = new System.Drawing.Size(170, 21);
            this.txtInsuranceAddress.TabIndex = 2;
            this.txtInsuranceAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblInsuranceCity
            // 
            this.lblInsuranceCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceCity.Location = new System.Drawing.Point(3, 71);
            this.lblInsuranceCity.Name = "lblInsuranceCity";
            this.lblInsuranceCity.Size = new System.Drawing.Size(58, 25);
            this.lblInsuranceCity.TabIndex = 35;
            this.lblInsuranceCity.Text = "City";
            this.lblInsuranceCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsuranceCity
            // 
            this.txtInsuranceCity.BackColor = System.Drawing.Color.White;
            this.txtInsuranceCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsuranceCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInsuranceCity.Location = new System.Drawing.Point(67, 74);
            this.txtInsuranceCity.Name = "txtInsuranceCity";
            this.txtInsuranceCity.ReadOnly = true;
            this.txtInsuranceCity.Size = new System.Drawing.Size(170, 21);
            this.txtInsuranceCity.TabIndex = 34;
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
            this.panel2.Location = new System.Drawing.Point(0, 801);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 33);
            this.panel2.TabIndex = 91;
            this.panel2.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(447, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 24);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lnkViewClaimChangeHistory
            // 
            this.lnkViewClaimChangeHistory.AutoSize = true;
            this.lnkViewClaimChangeHistory.Location = new System.Drawing.Point(6, 8);
            this.lnkViewClaimChangeHistory.Name = "lnkViewClaimChangeHistory";
            this.lnkViewClaimChangeHistory.Size = new System.Drawing.Size(93, 13);
            this.lnkViewClaimChangeHistory.TabIndex = 87;
            this.lnkViewClaimChangeHistory.TabStop = true;
            this.lnkViewClaimChangeHistory.Text = "Change History...";
            this.lnkViewClaimChangeHistory.Visible = false;
            this.lnkViewClaimChangeHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewClaimChangeHistory_LinkClicked);
            // 
            // cmdNextClaim
            // 
            this.cmdNextClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNextClaim.Location = new System.Drawing.Point(182, 4);
            this.cmdNextClaim.Name = "cmdNextClaim";
            this.cmdNextClaim.Size = new System.Drawing.Size(73, 24);
            this.cmdNextClaim.TabIndex = 9;
            this.cmdNextClaim.Text = "Claim &>>";
            this.cmdNextClaim.UseVisualStyleBackColor = true;
            this.cmdNextClaim.Visible = false;
            // 
            // cmdPreviousClaim
            // 
            this.cmdPreviousClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPreviousClaim.Location = new System.Drawing.Point(168, 4);
            this.cmdPreviousClaim.Name = "cmdPreviousClaim";
            this.cmdPreviousClaim.Size = new System.Drawing.Size(73, 24);
            this.cmdPreviousClaim.TabIndex = 8;
            this.cmdPreviousClaim.Text = "&<< Claim";
            this.cmdPreviousClaim.UseVisualStyleBackColor = true;
            this.cmdPreviousClaim.Visible = false;
            // 
            // tabPastCalls
            // 
            this.tabPastCalls.Controls.Add(this.pnlRightPanel);
            this.tabPastCalls.Controls.Add(this.callManager);
            this.tabPastCalls.Location = new System.Drawing.Point(4, 22);
            this.tabPastCalls.Name = "tabPastCalls";
            this.tabPastCalls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPastCalls.Size = new System.Drawing.Size(556, 580);
            this.tabPastCalls.TabIndex = 1;
            this.tabPastCalls.Text = "Work History";
            this.tabPastCalls.UseVisualStyleBackColor = true;
            // 
            // pnlRightPanel
            // 
            this.pnlRightPanel.Controls.Add(this.pnlPastStatus);
            this.pnlRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlRightPanel.Name = "pnlRightPanel";
            this.pnlRightPanel.Size = new System.Drawing.Size(550, 418);
            this.pnlRightPanel.TabIndex = 91;
            // 
            // pnlPastStatus
            // 
            this.pnlPastStatus.Controls.Add(this.ctlPastCalls);
            this.pnlPastStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPastStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlPastStatus.Name = "pnlPastStatus";
            this.pnlPastStatus.Size = new System.Drawing.Size(550, 418);
            this.pnlPastStatus.TabIndex = 3;
            // 
            // ctlPastCalls
            // 
            this.ctlPastCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPastCalls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPastCalls.Location = new System.Drawing.Point(0, 0);
            this.ctlPastCalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlPastCalls.Name = "ctlPastCalls";
            this.ctlPastCalls.Size = new System.Drawing.Size(550, 418);
            this.ctlPastCalls.TabIndex = 0;
            // 
            // callManager
            // 
            this.callManager.CallControlsVisible = false;
            this.callManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.callManager.Location = new System.Drawing.Point(3, 421);
            this.callManager.Name = "callManager";
            this.callManager.NotesPanelVisible = false;
            this.callManager.Size = new System.Drawing.Size(550, 156);
            this.callManager.TabIndex = 92;
            this.callManager.Visible = false;
            // 
            // tabRelatedClaims
            // 
            this.tabRelatedClaims.Controls.Add(this.pnlRelatedClaims);
            this.tabRelatedClaims.Location = new System.Drawing.Point(4, 22);
            this.tabRelatedClaims.Name = "tabRelatedClaims";
            this.tabRelatedClaims.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatedClaims.Size = new System.Drawing.Size(556, 580);
            this.tabRelatedClaims.TabIndex = 2;
            this.tabRelatedClaims.Text = "Related";
            this.tabRelatedClaims.UseVisualStyleBackColor = true;
            // 
            // pnlRelatedClaims
            // 
            this.pnlRelatedClaims.Controls.Add(this.dgvClaimsForSubscriber);
            this.pnlRelatedClaims.Controls.Add(this.label63);
            this.pnlRelatedClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRelatedClaims.Location = new System.Drawing.Point(3, 3);
            this.pnlRelatedClaims.Name = "pnlRelatedClaims";
            this.pnlRelatedClaims.Size = new System.Drawing.Size(550, 574);
            this.pnlRelatedClaims.TabIndex = 19;
            // 
            // dgvClaimsForSubscriber
            // 
            this.dgvClaimsForSubscriber.AllowUserToAddRows = false;
            this.dgvClaimsForSubscriber.AllowUserToDeleteRows = false;
            this.dgvClaimsForSubscriber.AllowUserToResizeColumns = false;
            this.dgvClaimsForSubscriber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClaimsForSubscriber.ColumnHeadersVisible = false;
            this.dgvClaimsForSubscriber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClaimsForSubscriber.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClaimsForSubscriber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClaimsForSubscriber.Location = new System.Drawing.Point(0, 22);
            this.dgvClaimsForSubscriber.MultiSelect = false;
            this.dgvClaimsForSubscriber.Name = "dgvClaimsForSubscriber";
            this.dgvClaimsForSubscriber.ReadOnly = true;
            this.dgvClaimsForSubscriber.RowHeadersVisible = false;
            this.dgvClaimsForSubscriber.RowTemplate.Height = 35;
            this.dgvClaimsForSubscriber.Size = new System.Drawing.Size(550, 552);
            this.dgvClaimsForSubscriber.TabIndex = 1;
            this.dgvClaimsForSubscriber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClaimsForSubscriber_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "colClaimInfo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label63.Dock = System.Windows.Forms.DockStyle.Top;
            this.label63.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(0, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(550, 22);
            this.label63.TabIndex = 0;
            this.label63.Text = "Recent or Active Claims for this Subscriber";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSearchClaims
            // 
            this.tabSearchClaims.Controls.Add(this.pnlClaimsFromSearch);
            this.tabSearchClaims.Location = new System.Drawing.Point(4, 22);
            this.tabSearchClaims.Name = "tabSearchClaims";
            this.tabSearchClaims.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchClaims.Size = new System.Drawing.Size(556, 580);
            this.tabSearchClaims.TabIndex = 3;
            this.tabSearchClaims.Text = "Search";
            this.tabSearchClaims.UseVisualStyleBackColor = true;
            // 
            // pnlClaimsFromSearch
            // 
            this.pnlClaimsFromSearch.Controls.Add(this.dgvNextClaimDisplay);
            this.pnlClaimsFromSearch.Controls.Add(this.pnlQuickSearch);
            this.pnlClaimsFromSearch.Controls.Add(this.label32);
            this.pnlClaimsFromSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClaimsFromSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlClaimsFromSearch.Name = "pnlClaimsFromSearch";
            this.pnlClaimsFromSearch.Size = new System.Drawing.Size(550, 574);
            this.pnlClaimsFromSearch.TabIndex = 18;
            // 
            // dgvNextClaimDisplay
            // 
            this.dgvNextClaimDisplay.AllowUserToAddRows = false;
            this.dgvNextClaimDisplay.AllowUserToDeleteRows = false;
            this.dgvNextClaimDisplay.AllowUserToResizeColumns = false;
            this.dgvNextClaimDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextClaimDisplay.ColumnHeadersVisible = false;
            this.dgvNextClaimDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colClaim});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNextClaimDisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNextClaimDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNextClaimDisplay.Location = new System.Drawing.Point(0, 22);
            this.dgvNextClaimDisplay.MultiSelect = false;
            this.dgvNextClaimDisplay.Name = "dgvNextClaimDisplay";
            this.dgvNextClaimDisplay.ReadOnly = true;
            this.dgvNextClaimDisplay.RowHeadersVisible = false;
            this.dgvNextClaimDisplay.RowTemplate.Height = 35;
            this.dgvNextClaimDisplay.Size = new System.Drawing.Size(550, 459);
            this.dgvNextClaimDisplay.TabIndex = 1;
            this.dgvNextClaimDisplay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNextClaimDisplay_CellContentDoubleClick);
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colClaim
            // 
            this.colClaim.HeaderText = "colClaimInfo";
            this.colClaim.Name = "colClaim";
            this.colClaim.ReadOnly = true;
            this.colClaim.Visible = false;
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Controls.Add(this.panel1);
            this.pnlQuickSearch.Controls.Add(this.txtQuickSearch);
            this.pnlQuickSearch.Controls.Add(this.cmbQuickSearch);
            this.pnlQuickSearch.Controls.Add(this.label36);
            this.pnlQuickSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlQuickSearch.Location = new System.Drawing.Point(0, 481);
            this.pnlQuickSearch.Name = "pnlQuickSearch";
            this.pnlQuickSearch.Size = new System.Drawing.Size(550, 93);
            this.pnlQuickSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClearSearch);
            this.panel1.Controls.Add(this.cmdSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 27);
            this.panel1.TabIndex = 4;
            // 
            // cmdClearSearch
            // 
            this.cmdClearSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdClearSearch.Location = new System.Drawing.Point(0, 0);
            this.cmdClearSearch.Name = "cmdClearSearch";
            this.cmdClearSearch.Size = new System.Drawing.Size(60, 27);
            this.cmdClearSearch.TabIndex = 1;
            this.cmdClearSearch.Text = "&Clear";
            this.cmdClearSearch.UseVisualStyleBackColor = true;
            this.cmdClearSearch.Click += new System.EventHandler(this.cmdClearSearch_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSearch.Location = new System.Drawing.Point(490, 0);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(60, 27);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuickSearch.Location = new System.Drawing.Point(0, 43);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(550, 21);
            this.txtQuickSearch.TabIndex = 3;
            this.txtQuickSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuickSearch_KeyDown);
            // 
            // cmbQuickSearch
            // 
            this.cmbQuickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbQuickSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuickSearch.FormattingEnabled = true;
            this.cmbQuickSearch.Items.AddRange(new object[] {
            "Patient Name",
            "Patient SSN",
            "Insurance Company"});
            this.cmbQuickSearch.Location = new System.Drawing.Point(0, 22);
            this.cmbQuickSearch.Name = "cmbQuickSearch";
            this.cmbQuickSearch.Size = new System.Drawing.Size(550, 21);
            this.cmbQuickSearch.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Dock = System.Windows.Forms.DockStyle.Top;
            this.label36.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(550, 22);
            this.label36.TabIndex = 1;
            this.label36.Text = "Quick Search";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(550, 22);
            this.label32.TabIndex = 0;
            this.label32.Text = "Claims from last search";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 43);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cmdSearchClaims);
            this.panel5.Controls.Add(this.cmdRelatedClaims);
            this.panel5.Controls.Add(this.cmdWorkHistory);
            this.panel5.Controls.Add(this.cmdClaimInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(562, 43);
            this.panel5.TabIndex = 63;
            // 
            // cmdSearchClaims
            // 
            this.cmdSearchClaims.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSearchClaims.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdSearchClaims.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearchClaims.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_magnify;
            this.cmdSearchClaims.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSearchClaims.Location = new System.Drawing.Point(390, 0);
            this.cmdSearchClaims.Name = "cmdSearchClaims";
            this.cmdSearchClaims.Size = new System.Drawing.Size(130, 39);
            this.cmdSearchClaims.TabIndex = 65;
            this.cmdSearchClaims.Text = "Search Claims";
            this.cmdSearchClaims.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdSearchClaims, "Show search results from your last search and perform simple searches");
            this.cmdSearchClaims.UseVisualStyleBackColor = true;
            this.cmdSearchClaims.Click += new System.EventHandler(this.cmdSearchClaims_Click);
            // 
            // cmdRelatedClaims
            // 
            this.cmdRelatedClaims.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRelatedClaims.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdRelatedClaims.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelatedClaims.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_copy;
            this.cmdRelatedClaims.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRelatedClaims.Location = new System.Drawing.Point(260, 0);
            this.cmdRelatedClaims.Name = "cmdRelatedClaims";
            this.cmdRelatedClaims.Size = new System.Drawing.Size(130, 39);
            this.cmdRelatedClaims.TabIndex = 11;
            this.cmdRelatedClaims.Text = "Related Claims";
            this.cmdRelatedClaims.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdRelatedClaims, "Recent claims with the same subscriber");
            this.cmdRelatedClaims.UseVisualStyleBackColor = true;
            this.cmdRelatedClaims.Click += new System.EventHandler(this.cmdRelatedClaims_Click);
            // 
            // cmdWorkHistory
            // 
            this.cmdWorkHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdWorkHistory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWorkHistory.Image = global::C_DentalClaimTracker.Properties.Resources.paste_plain;
            this.cmdWorkHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdWorkHistory.Location = new System.Drawing.Point(130, 0);
            this.cmdWorkHistory.Name = "cmdWorkHistory";
            this.cmdWorkHistory.Size = new System.Drawing.Size(130, 39);
            this.cmdWorkHistory.TabIndex = 14;
            this.cmdWorkHistory.Text = "Work History";
            this.cmdWorkHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdWorkHistory, "All work done to a claim");
            this.cmdWorkHistory.Click += new System.EventHandler(this.cmdWorkHistory_Click);
            // 
            // cmdClaimInfo
            // 
            this.cmdClaimInfo.BackColor = System.Drawing.Color.LightYellow;
            this.cmdClaimInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdClaimInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClaimInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClaimInfo.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.cmdClaimInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClaimInfo.Location = new System.Drawing.Point(0, 0);
            this.cmdClaimInfo.Name = "cmdClaimInfo";
            this.cmdClaimInfo.Size = new System.Drawing.Size(130, 39);
            this.cmdClaimInfo.TabIndex = 15;
            this.cmdClaimInfo.Text = "Claim Info";
            this.cmdClaimInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdClaimInfo, "Primary Claim Info");
            this.cmdClaimInfo.UseVisualStyleBackColor = true;
            this.cmdClaimInfo.Click += new System.EventHandler(this.cmdClaimInfo_Click);
            // 
            // spltRightSide
            // 
            this.spltRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltRightSide.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltRightSide.Location = new System.Drawing.Point(0, 0);
            this.spltRightSide.Name = "spltRightSide";
            this.spltRightSide.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltRightSide.Panel1
            // 
            this.spltRightSide.Panel1.Controls.Add(this.pnlCallStatusHolder);
            this.spltRightSide.Panel1.Controls.Add(this.pnlStatusRevisit);
            // 
            // spltRightSide.Panel2
            // 
            this.spltRightSide.Panel2.Controls.Add(this.callNotes);
            this.spltRightSide.Panel2.Controls.Add(this.pnlCallControls);
            this.spltRightSide.Size = new System.Drawing.Size(580, 678);
            this.spltRightSide.SplitterDistance = 500;
            this.spltRightSide.TabIndex = 93;
            this.spltRightSide.DoubleClick += new System.EventHandler(this.spltRightSide_DoubleClick);
            // 
            // pnlCallStatusHolder
            // 
            this.pnlCallStatusHolder.Controls.Add(this.chkTalkedWithPerson);
            this.pnlCallStatusHolder.Controls.Add(this.tbcNewCallData);
            this.pnlCallStatusHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCallStatusHolder.Location = new System.Drawing.Point(0, 50);
            this.pnlCallStatusHolder.Name = "pnlCallStatusHolder";
            this.pnlCallStatusHolder.Size = new System.Drawing.Size(580, 450);
            this.pnlCallStatusHolder.TabIndex = 18;
            // 
            // chkTalkedWithPerson
            // 
            this.chkTalkedWithPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTalkedWithPerson.AutoSize = true;
            this.chkTalkedWithPerson.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTalkedWithPerson.Checked = true;
            this.chkTalkedWithPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTalkedWithPerson.Location = new System.Drawing.Point(472, 3);
            this.chkTalkedWithPerson.Name = "chkTalkedWithPerson";
            this.chkTalkedWithPerson.Size = new System.Drawing.Size(106, 17);
            this.chkTalkedWithPerson.TabIndex = 17;
            this.chkTalkedWithPerson.Text = "Talked to person";
            this.ttipMain.SetToolTip(this.chkTalkedWithPerson, "Uncheck this box if on this call you only talked to machines");
            this.chkTalkedWithPerson.UseVisualStyleBackColor = true;
            this.chkTalkedWithPerson.Visible = false;
            // 
            // tbcNewCallData
            // 
            this.tbcNewCallData.Controls.Add(this.tbpCallPage);
            this.tbcNewCallData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcNewCallData.Location = new System.Drawing.Point(0, 0);
            this.tbcNewCallData.Name = "tbcNewCallData";
            this.tbcNewCallData.SelectedIndex = 0;
            this.tbcNewCallData.Size = new System.Drawing.Size(580, 450);
            this.tbcNewCallData.TabIndex = 16;
            // 
            // tbpCallPage
            // 
            this.tbpCallPage.Controls.Add(this.spltRightSideTopBottom);
            this.tbpCallPage.Location = new System.Drawing.Point(4, 22);
            this.tbpCallPage.Name = "tbpCallPage";
            this.tbpCallPage.Size = new System.Drawing.Size(572, 424);
            this.tbpCallPage.TabIndex = 2;
            this.tbpCallPage.Text = "Select a claim status...";
            this.tbpCallPage.UseVisualStyleBackColor = true;
            // 
            // spltRightSideTopBottom
            // 
            this.spltRightSideTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltRightSideTopBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltRightSideTopBottom.Location = new System.Drawing.Point(0, 0);
            this.spltRightSideTopBottom.Name = "spltRightSideTopBottom";
            this.spltRightSideTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltRightSideTopBottom.Panel1
            // 
            this.spltRightSideTopBottom.Panel1.Controls.Add(this.ctlStatusHandler);
            this.spltRightSideTopBottom.Panel1.Controls.Add(this.mainQuestionViewer);
            this.spltRightSideTopBottom.Panel1.Controls.Add(this.pnlNewCallTopPanel);
            // 
            // spltRightSideTopBottom.Panel2
            // 
            this.spltRightSideTopBottom.Panel2.Controls.Add(this.txtNEA_Number);
            this.spltRightSideTopBottom.Panel2.Controls.Add(this.label53);
            this.spltRightSideTopBottom.Panel2MinSize = 0;
            this.spltRightSideTopBottom.Size = new System.Drawing.Size(572, 424);
            this.spltRightSideTopBottom.SplitterDistance = 395;
            this.spltRightSideTopBottom.TabIndex = 5;
            // 
            // ctlStatusHandler
            // 
            this.ctlStatusHandler.AutoScroll = true;
            this.ctlStatusHandler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctlStatusHandler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlStatusHandler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlStatusHandler.Location = new System.Drawing.Point(0, 17);
            this.ctlStatusHandler.Name = "ctlStatusHandler";
            this.ctlStatusHandler.Size = new System.Drawing.Size(572, 378);
            this.ctlStatusHandler.TabIndex = 0;
            this.ctlStatusHandler.Visible = false;
            this.ctlStatusHandler.AllChoicesMade += new System.EventHandler(this.ctlStatusHandler_AllChoicesMade);
            this.ctlStatusHandler.Load += new System.EventHandler(this.ctlStatusHandler_Load);
            // 
            // mainQuestionViewer
            // 
            this.mainQuestionViewer.AutoScroll = true;
            this.mainQuestionViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainQuestionViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainQuestionViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainQuestionViewer.Location = new System.Drawing.Point(0, 17);
            this.mainQuestionViewer.Name = "mainQuestionViewer";
            this.mainQuestionViewer.Size = new System.Drawing.Size(572, 378);
            this.mainQuestionViewer.TabIndex = 1;
            this.mainQuestionViewer.ThinMode = false;
            this.mainQuestionViewer.Visible = false;
            this.mainQuestionViewer.QuestionAnswered += new System.EventHandler<C_DentalClaimTracker.Call_Management.QuestionAnsweredEventArgs>(this.Viewer_QuestionAnswered);
            this.mainQuestionViewer.QuestionCleared += new System.EventHandler(this.Viewer_QuestionCleared);
            this.mainQuestionViewer.Load += new System.EventHandler(this.mainQuestionViewer_Load);
            // 
            // pnlNewCallTopPanel
            // 
            this.pnlNewCallTopPanel.Controls.Add(this.ctlDataVerification);
            this.pnlNewCallTopPanel.Controls.Add(this.lnkReclassify);
            this.pnlNewCallTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewCallTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlNewCallTopPanel.Name = "pnlNewCallTopPanel";
            this.pnlNewCallTopPanel.Size = new System.Drawing.Size(572, 17);
            this.pnlNewCallTopPanel.TabIndex = 2;
            this.pnlNewCallTopPanel.Visible = false;
            // 
            // ctlDataVerification
            // 
            this.ctlDataVerification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataVerification.Location = new System.Drawing.Point(104, 0);
            this.ctlDataVerification.Name = "ctlDataVerification";
            this.ctlDataVerification.Size = new System.Drawing.Size(468, 17);
            this.ctlDataVerification.TabIndex = 1;
            this.ctlDataVerification.ItemCheckChanged += new System.EventHandler<C_DentalClaimTracker.Call_Management.DataVerificationCheckChangeEventArgs>(this.ctlDataVerification_ItemCheckChanged);
            // 
            // lnkReclassify
            // 
            this.lnkReclassify.AutoSize = true;
            this.lnkReclassify.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkReclassify.Location = new System.Drawing.Point(0, 0);
            this.lnkReclassify.Name = "lnkReclassify";
            this.lnkReclassify.Size = new System.Drawing.Size(104, 13);
            this.lnkReclassify.TabIndex = 0;
            this.lnkReclassify.TabStop = true;
            this.lnkReclassify.Text = "Change Condition...";
            this.lnkReclassify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReclassify_LinkClicked);
            // 
            // txtNEA_Number
            // 
            this.txtNEA_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNEA_Number.Location = new System.Drawing.Point(88, 0);
            this.txtNEA_Number.MaxLength = 40;
            this.txtNEA_Number.Name = "txtNEA_Number";
            this.txtNEA_Number.Size = new System.Drawing.Size(484, 21);
            this.txtNEA_Number.TabIndex = 80;
            this.txtNEA_Number.Tag = "1";
            this.txtNEA_Number.TextChanged += new System.EventHandler(this.Save_Claim);
            // 
            // label53
            // 
            this.label53.Dock = System.Windows.Forms.DockStyle.Left;
            this.label53.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(0, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(88, 25);
            this.label53.TabIndex = 79;
            this.label53.Text = "NEA Number";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatusRevisit
            // 
            this.pnlStatusRevisit.Controls.Add(this.panel23);
            this.pnlStatusRevisit.Controls.Add(this.panel22);
            this.pnlStatusRevisit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusRevisit.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusRevisit.Name = "pnlStatusRevisit";
            this.pnlStatusRevisit.Size = new System.Drawing.Size(580, 50);
            this.pnlStatusRevisit.TabIndex = 19;
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.dtpNewRevisitDate);
            this.panel23.Controls.Add(this.label60);
            this.panel23.Controls.Add(this.lblRevisitCurrent);
            this.panel23.Controls.Add(this.label57);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 24);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(580, 24);
            this.panel23.TabIndex = 1;
            // 
            // dtpNewRevisitDate
            // 
            this.dtpNewRevisitDate.CurrentDate = null;
            this.dtpNewRevisitDate.DateSelectionVisible = true;
            this.dtpNewRevisitDate.DateValue = null;
            this.dtpNewRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNewRevisitDate.Location = new System.Drawing.Point(220, 0);
            this.dtpNewRevisitDate.Name = "dtpNewRevisitDate";
            this.dtpNewRevisitDate.ReadOnly = false;
            this.dtpNewRevisitDate.Size = new System.Drawing.Size(121, 21);
            this.dtpNewRevisitDate.TabIndex = 27;
            // 
            // label60
            // 
            this.label60.Dock = System.Windows.Forms.DockStyle.Left;
            this.label60.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(181, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(39, 22);
            this.label60.TabIndex = 4;
            this.label60.Text = "New";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRevisitCurrent
            // 
            this.lblRevisitCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRevisitCurrent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevisitCurrent.Location = new System.Drawing.Point(55, 0);
            this.lblRevisitCurrent.Name = "lblRevisitCurrent";
            this.lblRevisitCurrent.Size = new System.Drawing.Size(126, 22);
            this.lblRevisitCurrent.TabIndex = 3;
            this.lblRevisitCurrent.Text = "Current";
            this.lblRevisitCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label57.Dock = System.Windows.Forms.DockStyle.Left;
            this.label57.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(0, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(55, 22);
            this.label57.TabIndex = 2;
            this.label57.Text = "Revisit:";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Controls.Add(this.cmbNewStatus);
            this.panel22.Controls.Add(this.label59);
            this.panel22.Controls.Add(this.lblStatusCurrent);
            this.panel22.Controls.Add(this.label55);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(580, 24);
            this.panel22.TabIndex = 0;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Location = new System.Drawing.Point(220, 0);
            this.cmbNewStatus.MaximumSize = new System.Drawing.Size(125, 0);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbNewStatus.TabIndex = 3;
            // 
            // label59
            // 
            this.label59.Dock = System.Windows.Forms.DockStyle.Left;
            this.label59.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(181, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(39, 22);
            this.label59.TabIndex = 2;
            this.label59.Text = "New";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusCurrent
            // 
            this.lblStatusCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusCurrent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCurrent.Location = new System.Drawing.Point(55, 0);
            this.lblStatusCurrent.Name = "lblStatusCurrent";
            this.lblStatusCurrent.Size = new System.Drawing.Size(126, 22);
            this.lblStatusCurrent.TabIndex = 1;
            this.lblStatusCurrent.Text = "Current";
            this.lblStatusCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label55.Dock = System.Windows.Forms.DockStyle.Left;
            this.label55.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(0, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 22);
            this.label55.TabIndex = 0;
            this.label55.Text = "Status:";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // callNotes
            // 
            this.callNotes.CurrentCall = null;
            this.callNotes.CurrentClaim = null;
            this.callNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callNotes.Location = new System.Drawing.Point(0, 33);
            this.callNotes.Mode = C_DentalClaimTracker.NotesGrid.NotesGridMode.GridView;
            this.callNotes.Name = "callNotes";
            this.callNotes.ReadOnly = false;
            this.callNotes.Size = new System.Drawing.Size(580, 141);
            this.callNotes.TabIndex = 17;
            this.callNotes.NewNotes += new System.EventHandler(this.callNotes_NewNotes);
            this.callNotes.Load += new System.EventHandler(this.callNotes_Load);
            // 
            // pnlCallControls
            // 
            this.pnlCallControls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCallControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCallControls.Controls.Add(this.lblHoldTime);
            this.pnlCallControls.Controls.Add(this.lblCallTime);
            this.pnlCallControls.Controls.Add(this.cmdStartHold);
            this.pnlCallControls.Controls.Add(this.cmdEndCall);
            this.pnlCallControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCallControls.Location = new System.Drawing.Point(0, 0);
            this.pnlCallControls.Name = "pnlCallControls";
            this.pnlCallControls.Size = new System.Drawing.Size(580, 33);
            this.pnlCallControls.TabIndex = 92;
            this.pnlCallControls.Visible = false;
            // 
            // lblHoldTime
            // 
            this.lblHoldTime.AutoSize = true;
            this.lblHoldTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoldTime.Location = new System.Drawing.Point(80, 9);
            this.lblHoldTime.Name = "lblHoldTime";
            this.lblHoldTime.Size = new System.Drawing.Size(100, 15);
            this.lblHoldTime.TabIndex = 13;
            this.lblHoldTime.Text = "Hold Time: 0:00:00";
            // 
            // lblCallTime
            // 
            this.lblCallTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallTime.AutoSize = true;
            this.lblCallTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCallTime.Location = new System.Drawing.Point(397, 9);
            this.lblCallTime.Name = "lblCallTime";
            this.lblCallTime.Size = new System.Drawing.Size(96, 15);
            this.lblCallTime.TabIndex = 12;
            this.lblCallTime.Text = "Call Time: 0:00:00";
            this.lblCallTime.Visible = false;
            // 
            // cmdStartHold
            // 
            this.cmdStartHold.Location = new System.Drawing.Point(2, 4);
            this.cmdStartHold.Name = "cmdStartHold";
            this.cmdStartHold.Size = new System.Drawing.Size(75, 23);
            this.cmdStartHold.TabIndex = 11;
            this.cmdStartHold.Text = "On &Hold";
            this.cmdStartHold.UseVisualStyleBackColor = true;
            this.cmdStartHold.Click += new System.EventHandler(this.cmdStartHold_Click);
            // 
            // cmdEndCall
            // 
            this.cmdEndCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEndCall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEndCall.Image = ((System.Drawing.Image)(resources.GetObject("cmdEndCall.Image")));
            this.cmdEndCall.Location = new System.Drawing.Point(494, 4);
            this.cmdEndCall.Name = "cmdEndCall";
            this.cmdEndCall.Size = new System.Drawing.Size(81, 24);
            this.cmdEndCall.TabIndex = 10;
            this.cmdEndCall.Text = " &End Call";
            this.cmdEndCall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEndCall.UseVisualStyleBackColor = true;
            this.cmdEndCall.Visible = false;
            this.cmdEndCall.Click += new System.EventHandler(this.cmdEndCall_Click);
            // 
            // ctxUserList
            // 
            this.ctxUserList.Name = "ctxUserList";
            this.ctxUserList.Size = new System.Drawing.Size(61, 4);
            // 
            // frmClaimManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 714);
            this.Controls.Add(this.spltTopBottom);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "frmClaimManager";
            this.Text = "Claim Manager";
            this.Activated += new System.EventHandler(this.frmClaimManager_Activated);
            this.Deactivate += new System.EventHandler(this.frmClaimManager_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewClaim_FormClosing);
            this.Load += new System.EventHandler(this.frmViewClaim_Load);
            this.Shown += new System.EventHandler(this.frmClaimManager_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmClaimManager_KeyPress);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlCloseClaim.ResumeLayout(false);
            this.pnlViewLinkedClaim.ResumeLayout(false);
            this.pnlOwnerInfo.ResumeLayout(false);
            this.pnlResendButton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.spltTopBottom.Panel1.ResumeLayout(false);
            this.spltTopBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltTopBottom)).EndInit();
            this.spltTopBottom.ResumeLayout(false);
            this.spltLeftRight.Panel1.ResumeLayout(false);
            this.spltLeftRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltLeftRight)).EndInit();
            this.spltLeftRight.ResumeLayout(false);
            this.tbcNavigator.ResumeLayout(false);
            this.tabClaimInfo.ResumeLayout(false);
            this.pnlLeftPanel.ResumeLayout(false);
            this.pnlClaimData.ResumeLayout(false);
            this.ctlHandlingDisplay.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandlingHistory)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.grpApexOptions.ResumeLayout(false);
            this.grpApexOptions.PerformLayout();
            this.ctlClaimDisplayGeneral.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.ctlClaimDisplayNotes.ResumeLayout(false);
            this.ctlClaimDisplayNotes.PerformLayout();
            this.ctlClaimDisplayDoctor.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ctlClaimDisplayPatient.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ctlClaimDisplaySubscriber.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ctlClaimDisplayServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedureData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayProcedureBindingSource)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ctlClaimDisplayInsurance.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPastCalls.ResumeLayout(false);
            this.pnlRightPanel.ResumeLayout(false);
            this.pnlPastStatus.ResumeLayout(false);
            this.tabRelatedClaims.ResumeLayout(false);
            this.pnlRelatedClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaimsForSubscriber)).EndInit();
            this.tabSearchClaims.ResumeLayout(false);
            this.pnlClaimsFromSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextClaimDisplay)).EndInit();
            this.pnlQuickSearch.ResumeLayout(false);
            this.pnlQuickSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.spltRightSide.Panel1.ResumeLayout(false);
            this.spltRightSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltRightSide)).EndInit();
            this.spltRightSide.ResumeLayout(false);
            this.pnlCallStatusHolder.ResumeLayout(false);
            this.pnlCallStatusHolder.PerformLayout();
            this.tbcNewCallData.ResumeLayout(false);
            this.tbpCallPage.ResumeLayout(false);
            this.spltRightSideTopBottom.Panel1.ResumeLayout(false);
            this.spltRightSideTopBottom.Panel2.ResumeLayout(false);
            this.spltRightSideTopBottom.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltRightSideTopBottom)).EndInit();
            this.spltRightSideTopBottom.ResumeLayout(false);
            this.pnlNewCallTopPanel.ResumeLayout(false);
            this.pnlNewCallTopPanel.PerformLayout();
            this.pnlStatusRevisit.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.pnlCallControls.ResumeLayout(false);
            this.pnlCallControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsuranceAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientSSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDoctorNPI;
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
        private System.Windows.Forms.Button cmdNextClaim;
        private System.Windows.Forms.Button cmdPreviousClaim;
        private System.Windows.Forms.Button cmdSave;
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
        private ctlClaimDataDisplay ctlHandlingDisplay;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbHandling;
        private System.Windows.Forms.Panel pnlLeftPanel;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.TabControl tbcNavigator;
        private System.Windows.Forms.TabPage tabClaimInfo;
        private System.Windows.Forms.TabPage tabPastCalls;
        private C_DentalClaimTracker.Call_Management.ConditionClassificationHandler ctlStatusHandler;
        private C_DentalClaimTracker.Call_Management.CallQuestionViewer mainQuestionViewer;
        private System.Windows.Forms.Panel pnlNewCallTopPanel;
        private System.Windows.Forms.LinkLabel lnkReclassify;
        private C_DentalClaimTracker.Call_Management.DataVerificationHandler ctlDataVerification;
        private System.Windows.Forms.SplitContainer spltLeftRight;
        private System.Windows.Forms.TabControl tbcNewCallData;
        private System.Windows.Forms.TabPage tbpCallPage;
        private System.Windows.Forms.SplitContainer spltTopBottom;
        private NotesGrid callNotes;
        private System.Windows.Forms.Panel pnlCallControls;
        private System.Windows.Forms.Button cmdEndCall;
        private System.Windows.Forms.Button cmdStartHold;
        private System.Windows.Forms.Label lblHoldTime;
        private System.Windows.Forms.Label lblCallTime;
        private CallManager callManager;
        private System.Windows.Forms.Button cmdMainPrintClaim;
        private System.Windows.Forms.SplitContainer spltRightSide;
        private System.Windows.Forms.Panel pnlPastStatus;
        private System.Windows.Forms.LinkLabel lnkViewLinkedClaim;
        private System.Windows.Forms.TextBox txtClinic;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button cmdCurrentOwner;
        private System.Windows.Forms.Label lblCurrentOwner;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Button cmdApex;
        private System.Windows.Forms.Button cmdPaper;
        private System.Windows.Forms.SplitContainer spltRightSideTopBottom;
        private System.Windows.Forms.Panel pnlClaimsFromSearch;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgvNextClaimDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaim;
        private System.Windows.Forms.Panel pnlQuickSearch;
        private System.Windows.Forms.ComboBox cmbQuickSearch;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClearSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.CheckBox chkTalkedWithPerson;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlViewLinkedClaim;
        private System.Windows.Forms.Panel pnlOwnerInfo;
        private System.Windows.Forms.Panel pnlResendButton;
        private System.Windows.Forms.Button cmdResendClaim;
        private System.Windows.Forms.DataGridView dgvHandlingHistory;
        private System.Windows.Forms.ContextMenuStrip ctxUserList;
        private System.Windows.Forms.GroupBox grpApexOptions;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.CheckBox chkUseApexDefaults;
        private System.Windows.Forms.TextBox txtApexCustomText;
        private System.Windows.Forms.ComboBox cmbApexStandardOption;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtNEA_Number;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lblClaimPaid;
        private System.Windows.Forms.TextBox txtInsuranceName;
        private System.Windows.Forms.TextBox txtPatientDOB;
        private System.Windows.Forms.TextBox txtSubscriberDOB;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtAmountOfClaim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDateOfService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtResentDate;
        private System.Windows.Forms.TextBox txtSentDate;
        private System.Windows.Forms.TextBox txtTracerDate;
        private System.Windows.Forms.TextBox txtOnHoldDate;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandlingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendDate;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label54;
        private Claims_Primary.MultiCallDisplay ctlPastCalls;
        private System.Windows.Forms.Panel pnlCallStatusHolder;
        private System.Windows.Forms.Panel pnlStatusRevisit;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label lblRevisitCurrent;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label lblStatusCurrent;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private ctlDateEntry dtpNewRevisitDate;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Panel pnlCloseClaim;
        private System.Windows.Forms.Button btnMarkPaid;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox cmbOverrideProvider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtDentrixClaimID;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox txtDentrixClaimDB;
        private System.Windows.Forms.Panel pnlDisplayPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cmdSearchClaims;
        private System.Windows.Forms.Button cmdRelatedClaims;
        private System.Windows.Forms.Button cmdWorkHistory;
        private System.Windows.Forms.Button cmdClaimInfo;
        private System.Windows.Forms.TabPage tabRelatedClaims;
        private System.Windows.Forms.TabPage tabSearchClaims;
        private System.Windows.Forms.Panel pnlRelatedClaims;
        private System.Windows.Forms.DataGridView dgvClaimsForSubscriber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label63;
    }
}