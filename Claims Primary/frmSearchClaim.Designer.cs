namespace C_DentalClaimTracker
{
    partial class frmSearchClaim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchClaim));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCompanyDropdown = new System.Windows.Forms.ComboBox();
            this.bsCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtGroupNum = new System.Windows.Forms.TextBox();
            this.grpAllBin = new System.Windows.Forms.GroupBox();
            this.chkOpenClaimsOnly = new System.Windows.Forms.CheckBox();
            this.txtClaimAmount = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowPredeterms = new System.Windows.Forms.CheckBox();
            this.chkShowSecondary = new System.Windows.Forms.CheckBox();
            this.chkShowPrimary = new System.Windows.Forms.CheckBox();
            this.txtGroupPlan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProviderID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ctlPatientDOB = new C_DentalClaimTracker.ctlDateEntry();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpLastSent = new C_DentalClaimTracker.ctlDateEntry();
            this.chkLastSent = new System.Windows.Forms.CheckBox();
            this.dtpRevisitDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkRevisitDate = new System.Windows.Forms.CheckBox();
            this.dtpCreateDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkCreateDate = new System.Windows.Forms.CheckBox();
            this.ctlLastUpdateDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkLastUpdateEnabled = new System.Windows.Forms.CheckBox();
            this.cmbDateFilterType = new System.Windows.Forms.ComboBox();
            this.ctlTracerDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkTracerDateEnabled = new System.Windows.Forms.CheckBox();
            this.ctlOnHoldDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkHoldDateEnabled = new System.Windows.Forms.CheckBox();
            this.ctlResentDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkResentDateEnabled = new System.Windows.Forms.CheckBox();
            this.ctlSentDate = new C_DentalClaimTracker.ctlDateEntry();
            this.chkSentDateEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbClinic = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cmdPrintAll = new System.Windows.Forms.Button();
            this.cmdPrintList = new System.Windows.Forms.Button();
            this.grpCheckedClaims = new System.Windows.Forms.GroupBox();
            this.lnkUncheckAll = new System.Windows.Forms.LinkLabel();
            this.lnkCheckAll = new System.Windows.Forms.LinkLabel();
            this.btnSetToCustomAddress = new System.Windows.Forms.Button();
            this.cmdSetStatus = new System.Windows.Forms.Button();
            this.cmdCheckedStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdResend = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdOpenClaim = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkNEANumOnly = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSearchTime = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.lblSearching = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldate_of_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colclaimIDnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldbnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOSRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTextResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsResults = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.ctlNotes = new C_DentalClaimTracker.NotesGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmdUnsubmittedBin = new System.Windows.Forms.Button();
            this.cmdResolveBin = new System.Windows.Forms.Button();
            this.cmdAllBin = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmbMaxResults = new System.Windows.Forms.NumericUpDown();
            this.lblMaxResults = new System.Windows.Forms.Label();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ctxtProviderList = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanies)).BeginInit();
            this.grpAllBin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.grpCheckedClaims.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.cTextResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).BeginInit();
            this.pnlNotes.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxResults)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrier Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient DOB";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Claim Amount";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Group #";
            // 
            // cmbCompanyDropdown
            // 
            this.cmbCompanyDropdown.DataSource = this.bsCompanies;
            this.cmbCompanyDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompanyDropdown.FormattingEnabled = true;
            this.cmbCompanyDropdown.Location = new System.Drawing.Point(6, 37);
            this.cmbCompanyDropdown.Name = "cmbCompanyDropdown";
            this.cmbCompanyDropdown.Size = new System.Drawing.Size(159, 22);
            this.cmbCompanyDropdown.TabIndex = 0;
            this.cmbCompanyDropdown.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCompanyDropdown_DrawItem);
            // 
            // bsCompanies
            // 
            this.bsCompanies.DataSource = typeof(C_DentalClaimTracker.Claims_Primary.InsuranceCompanyGroups);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(6, 72);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(160, 21);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtGroupNum
            // 
            this.txtGroupNum.Location = new System.Drawing.Point(173, 73);
            this.txtGroupNum.Name = "txtGroupNum";
            this.txtGroupNum.Size = new System.Drawing.Size(100, 21);
            this.txtGroupNum.TabIndex = 3;
            // 
            // grpAllBin
            // 
            this.grpAllBin.Controls.Add(this.chkOpenClaimsOnly);
            this.grpAllBin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAllBin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAllBin.Location = new System.Drawing.Point(0, 43);
            this.grpAllBin.Name = "grpAllBin";
            this.grpAllBin.Size = new System.Drawing.Size(141, 41);
            this.grpAllBin.TabIndex = 6;
            this.grpAllBin.TabStop = false;
            this.grpAllBin.Text = "All Bin Options";
            // 
            // chkOpenClaimsOnly
            // 
            this.chkOpenClaimsOnly.AutoSize = true;
            this.chkOpenClaimsOnly.Checked = true;
            this.chkOpenClaimsOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenClaimsOnly.Location = new System.Drawing.Point(6, 17);
            this.chkOpenClaimsOnly.Name = "chkOpenClaimsOnly";
            this.chkOpenClaimsOnly.Size = new System.Drawing.Size(101, 17);
            this.chkOpenClaimsOnly.TabIndex = 19;
            this.chkOpenClaimsOnly.Text = "Hide paid claims";
            this.chkOpenClaimsOnly.UseVisualStyleBackColor = true;
            // 
            // txtClaimAmount
            // 
            this.txtClaimAmount.Location = new System.Drawing.Point(107, 111);
            this.txtClaimAmount.Name = "txtClaimAmount";
            this.txtClaimAmount.Size = new System.Drawing.Size(88, 21);
            this.txtClaimAmount.TabIndex = 5;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(484, -1);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(73, 32);
            this.cmdClose.TabIndex = 10;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowPredeterms);
            this.groupBox1.Controls.Add(this.chkShowSecondary);
            this.groupBox1.Controls.Add(this.chkShowPrimary);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(293, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Claim Types";
            // 
            // chkShowPredeterms
            // 
            this.chkShowPredeterms.AutoSize = true;
            this.chkShowPredeterms.Checked = true;
            this.chkShowPredeterms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowPredeterms.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPredeterms.Location = new System.Drawing.Point(5, 66);
            this.chkShowPredeterms.Name = "chkShowPredeterms";
            this.chkShowPredeterms.Size = new System.Drawing.Size(87, 17);
            this.chkShowPredeterms.TabIndex = 22;
            this.chkShowPredeterms.Text = "Predeterm";
            this.chkShowPredeterms.UseVisualStyleBackColor = true;
            // 
            // chkShowSecondary
            // 
            this.chkShowSecondary.AutoSize = true;
            this.chkShowSecondary.Checked = true;
            this.chkShowSecondary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSecondary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowSecondary.Location = new System.Drawing.Point(5, 43);
            this.chkShowSecondary.Name = "chkShowSecondary";
            this.chkShowSecondary.Size = new System.Drawing.Size(86, 17);
            this.chkShowSecondary.TabIndex = 21;
            this.chkShowSecondary.Text = "Secondary";
            this.chkShowSecondary.UseVisualStyleBackColor = true;
            // 
            // chkShowPrimary
            // 
            this.chkShowPrimary.AutoSize = true;
            this.chkShowPrimary.Checked = true;
            this.chkShowPrimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowPrimary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPrimary.Location = new System.Drawing.Point(6, 20);
            this.chkShowPrimary.Name = "chkShowPrimary";
            this.chkShowPrimary.Size = new System.Drawing.Size(71, 17);
            this.chkShowPrimary.TabIndex = 20;
            this.chkShowPrimary.Text = "Primary";
            this.chkShowPrimary.UseVisualStyleBackColor = true;
            // 
            // txtGroupPlan
            // 
            this.txtGroupPlan.Location = new System.Drawing.Point(173, 38);
            this.txtGroupPlan.Name = "txtGroupPlan";
            this.txtGroupPlan.Size = new System.Drawing.Size(100, 21);
            this.txtGroupPlan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Group Name";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Contains",
            "Starts With",
            "Exact"});
            this.cmbSearchType.Location = new System.Drawing.Point(191, 0);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(83, 21);
            this.cmbSearchType.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBatchNumber);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbProviderID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbSearchType);
            this.groupBox3.Controls.Add(this.ctlPatientDOB);
            this.groupBox3.Controls.Add(this.txtGroupPlan);
            this.groupBox3.Controls.Add(this.cmbCompanyDropdown);
            this.groupBox3.Controls.Add(this.txtPatientName);
            this.groupBox3.Controls.Add(this.txtClaimAmount);
            this.groupBox3.Controls.Add(this.txtGroupNum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 145);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Criteria";
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.Location = new System.Drawing.Point(201, 111);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(73, 21);
            this.txtBatchNumber.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Batch no";
            // 
            // cmbProviderID
            // 
            this.cmbProviderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviderID.FormattingEnabled = true;
            this.cmbProviderID.Location = new System.Drawing.Point(294, 109);
            this.cmbProviderID.Name = "cmbProviderID";
            this.cmbProviderID.Size = new System.Drawing.Size(90, 21);
            this.cmbProviderID.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(296, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Provider ID";
            // 
            // ctlPatientDOB
            // 
            this.ctlPatientDOB.CurrentDate = null;
            this.ctlPatientDOB.DateSelectionVisible = true;
            this.ctlPatientDOB.DateValue = null;
            this.ctlPatientDOB.Location = new System.Drawing.Point(6, 109);
            this.ctlPatientDOB.Name = "ctlPatientDOB";
            this.ctlPatientDOB.ReadOnly = false;
            this.ctlPatientDOB.Size = new System.Drawing.Size(95, 21);
            this.ctlPatientDOB.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpLastSent);
            this.groupBox4.Controls.Add(this.chkLastSent);
            this.groupBox4.Controls.Add(this.dtpRevisitDate);
            this.groupBox4.Controls.Add(this.chkRevisitDate);
            this.groupBox4.Controls.Add(this.dtpCreateDate);
            this.groupBox4.Controls.Add(this.chkCreateDate);
            this.groupBox4.Controls.Add(this.ctlLastUpdateDate);
            this.groupBox4.Controls.Add(this.chkLastUpdateEnabled);
            this.groupBox4.Controls.Add(this.cmbDateFilterType);
            this.groupBox4.Controls.Add(this.ctlTracerDate);
            this.groupBox4.Controls.Add(this.chkTracerDateEnabled);
            this.groupBox4.Controls.Add(this.ctlOnHoldDate);
            this.groupBox4.Controls.Add(this.chkHoldDateEnabled);
            this.groupBox4.Controls.Add(this.ctlResentDate);
            this.groupBox4.Controls.Add(this.chkResentDateEnabled);
            this.groupBox4.Controls.Add(this.ctlSentDate);
            this.groupBox4.Controls.Add(this.chkSentDateEnabled);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(390, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 145);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date Filtering";
            // 
            // dtpLastSent
            // 
            this.dtpLastSent.CurrentDate = null;
            this.dtpLastSent.DateSelectionVisible = true;
            this.dtpLastSent.DateValue = null;
            this.dtpLastSent.Location = new System.Drawing.Point(198, 111);
            this.dtpLastSent.Name = "dtpLastSent";
            this.dtpLastSent.ReadOnly = false;
            this.dtpLastSent.Size = new System.Drawing.Size(90, 21);
            this.dtpLastSent.TabIndex = 40;
            // 
            // chkLastSent
            // 
            this.chkLastSent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLastSent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLastSent.Location = new System.Drawing.Point(199, 96);
            this.chkLastSent.Name = "chkLastSent";
            this.chkLastSent.Size = new System.Drawing.Size(89, 17);
            this.chkLastSent.TabIndex = 39;
            this.chkLastSent.Text = "Last Sent";
            this.chkLastSent.UseVisualStyleBackColor = true;
            // 
            // dtpRevisitDate
            // 
            this.dtpRevisitDate.CurrentDate = null;
            this.dtpRevisitDate.DateSelectionVisible = true;
            this.dtpRevisitDate.DateValue = null;
            this.dtpRevisitDate.Location = new System.Drawing.Point(102, 112);
            this.dtpRevisitDate.Name = "dtpRevisitDate";
            this.dtpRevisitDate.ReadOnly = false;
            this.dtpRevisitDate.Size = new System.Drawing.Size(90, 21);
            this.dtpRevisitDate.TabIndex = 38;
            // 
            // chkRevisitDate
            // 
            this.chkRevisitDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRevisitDate.Location = new System.Drawing.Point(103, 97);
            this.chkRevisitDate.Name = "chkRevisitDate";
            this.chkRevisitDate.Size = new System.Drawing.Size(89, 17);
            this.chkRevisitDate.TabIndex = 37;
            this.chkRevisitDate.Text = "Revisit";
            this.chkRevisitDate.UseVisualStyleBackColor = true;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CurrentDate = null;
            this.dtpCreateDate.DateSelectionVisible = true;
            this.dtpCreateDate.DateValue = null;
            this.dtpCreateDate.Location = new System.Drawing.Point(6, 112);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.ReadOnly = false;
            this.dtpCreateDate.Size = new System.Drawing.Size(90, 21);
            this.dtpCreateDate.TabIndex = 36;
            // 
            // chkCreateDate
            // 
            this.chkCreateDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCreateDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreateDate.Location = new System.Drawing.Point(6, 97);
            this.chkCreateDate.Name = "chkCreateDate";
            this.chkCreateDate.Size = new System.Drawing.Size(90, 17);
            this.chkCreateDate.TabIndex = 35;
            this.chkCreateDate.Text = "Created";
            this.chkCreateDate.UseVisualStyleBackColor = true;
            // 
            // ctlLastUpdateDate
            // 
            this.ctlLastUpdateDate.CurrentDate = null;
            this.ctlLastUpdateDate.DateSelectionVisible = true;
            this.ctlLastUpdateDate.DateValue = null;
            this.ctlLastUpdateDate.Location = new System.Drawing.Point(198, 37);
            this.ctlLastUpdateDate.Name = "ctlLastUpdateDate";
            this.ctlLastUpdateDate.ReadOnly = false;
            this.ctlLastUpdateDate.Size = new System.Drawing.Size(90, 21);
            this.ctlLastUpdateDate.TabIndex = 34;
            // 
            // chkLastUpdateEnabled
            // 
            this.chkLastUpdateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLastUpdateEnabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLastUpdateEnabled.Location = new System.Drawing.Point(199, 22);
            this.chkLastUpdateEnabled.Name = "chkLastUpdateEnabled";
            this.chkLastUpdateEnabled.Size = new System.Drawing.Size(89, 17);
            this.chkLastUpdateEnabled.TabIndex = 33;
            this.chkLastUpdateEnabled.Text = "Updated";
            this.chkLastUpdateEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbDateFilterType
            // 
            this.cmbDateFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFilterType.FormattingEnabled = true;
            this.cmbDateFilterType.Items.AddRange(new object[] {
            "Before",
            "After",
            "Exact"});
            this.cmbDateFilterType.Location = new System.Drawing.Point(194, 0);
            this.cmbDateFilterType.Name = "cmbDateFilterType";
            this.cmbDateFilterType.Size = new System.Drawing.Size(94, 21);
            this.cmbDateFilterType.TabIndex = 32;
            // 
            // ctlTracerDate
            // 
            this.ctlTracerDate.CurrentDate = null;
            this.ctlTracerDate.DateSelectionVisible = true;
            this.ctlTracerDate.DateValue = null;
            this.ctlTracerDate.Location = new System.Drawing.Point(103, 75);
            this.ctlTracerDate.Name = "ctlTracerDate";
            this.ctlTracerDate.ReadOnly = false;
            this.ctlTracerDate.Size = new System.Drawing.Size(90, 21);
            this.ctlTracerDate.TabIndex = 31;
            // 
            // chkTracerDateEnabled
            // 
            this.chkTracerDateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTracerDateEnabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTracerDateEnabled.Location = new System.Drawing.Point(103, 60);
            this.chkTracerDateEnabled.Name = "chkTracerDateEnabled";
            this.chkTracerDateEnabled.Size = new System.Drawing.Size(89, 17);
            this.chkTracerDateEnabled.TabIndex = 30;
            this.chkTracerDateEnabled.Text = "Tracer";
            this.chkTracerDateEnabled.UseVisualStyleBackColor = true;
            // 
            // ctlOnHoldDate
            // 
            this.ctlOnHoldDate.CurrentDate = null;
            this.ctlOnHoldDate.DateSelectionVisible = true;
            this.ctlOnHoldDate.DateValue = null;
            this.ctlOnHoldDate.Location = new System.Drawing.Point(102, 38);
            this.ctlOnHoldDate.Name = "ctlOnHoldDate";
            this.ctlOnHoldDate.ReadOnly = false;
            this.ctlOnHoldDate.Size = new System.Drawing.Size(90, 21);
            this.ctlOnHoldDate.TabIndex = 29;
            // 
            // chkHoldDateEnabled
            // 
            this.chkHoldDateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHoldDateEnabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoldDateEnabled.Location = new System.Drawing.Point(103, 23);
            this.chkHoldDateEnabled.Name = "chkHoldDateEnabled";
            this.chkHoldDateEnabled.Size = new System.Drawing.Size(89, 17);
            this.chkHoldDateEnabled.TabIndex = 28;
            this.chkHoldDateEnabled.Text = "On Hold";
            this.chkHoldDateEnabled.UseVisualStyleBackColor = true;
            // 
            // ctlResentDate
            // 
            this.ctlResentDate.CurrentDate = null;
            this.ctlResentDate.DateSelectionVisible = true;
            this.ctlResentDate.DateValue = null;
            this.ctlResentDate.Location = new System.Drawing.Point(6, 75);
            this.ctlResentDate.Name = "ctlResentDate";
            this.ctlResentDate.ReadOnly = false;
            this.ctlResentDate.Size = new System.Drawing.Size(90, 21);
            this.ctlResentDate.TabIndex = 27;
            // 
            // chkResentDateEnabled
            // 
            this.chkResentDateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkResentDateEnabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResentDateEnabled.Location = new System.Drawing.Point(6, 60);
            this.chkResentDateEnabled.Name = "chkResentDateEnabled";
            this.chkResentDateEnabled.Size = new System.Drawing.Size(90, 17);
            this.chkResentDateEnabled.TabIndex = 26;
            this.chkResentDateEnabled.Text = "Resent";
            this.chkResentDateEnabled.UseVisualStyleBackColor = true;
            // 
            // ctlSentDate
            // 
            this.ctlSentDate.CurrentDate = null;
            this.ctlSentDate.DateSelectionVisible = true;
            this.ctlSentDate.DateValue = null;
            this.ctlSentDate.Location = new System.Drawing.Point(6, 38);
            this.ctlSentDate.Name = "ctlSentDate";
            this.ctlSentDate.ReadOnly = false;
            this.ctlSentDate.Size = new System.Drawing.Size(90, 21);
            this.ctlSentDate.TabIndex = 25;
            this.ctlSentDate.ValueChanged += new System.EventHandler(this.ctlSentDate_ValueChanged);
            // 
            // chkSentDateEnabled
            // 
            this.chkSentDateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSentDateEnabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSentDateEnabled.Location = new System.Drawing.Point(6, 23);
            this.chkSentDateEnabled.Name = "chkSentDateEnabled";
            this.chkSentDateEnabled.Size = new System.Drawing.Size(90, 17);
            this.chkSentDateEnabled.TabIndex = 18;
            this.chkSentDateEnabled.Text = "Sent ";
            this.chkSentDateEnabled.UseVisualStyleBackColor = true;
            this.chkSentDateEnabled.CheckedChanged += new System.EventHandler(this.chkSentDateEnabled_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbClinic);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 43);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clinic";
            // 
            // cmbClinic
            // 
            this.cmbClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinic.FormattingEnabled = true;
            this.cmbClinic.Location = new System.Drawing.Point(6, 15);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Size = new System.Drawing.Size(145, 21);
            this.cmbClinic.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox14);
            this.panel1.Controls.Add(this.grpCheckedClaims);
            this.panel1.Controls.Add(this.cmdOpenClaim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1040, 62);
            this.panel1.TabIndex = 28;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cmdPrintAll);
            this.groupBox14.Controls.Add(this.cmdPrintList);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox14.Location = new System.Drawing.Point(622, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(203, 54);
            this.groupBox14.TabIndex = 36;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Print List";
            // 
            // cmdPrintAll
            // 
            this.cmdPrintAll.Image = global::C_DentalClaimTracker.Properties.Resources.printer;
            this.cmdPrintAll.Location = new System.Drawing.Point(102, 18);
            this.cmdPrintAll.Name = "cmdPrintAll";
            this.cmdPrintAll.Size = new System.Drawing.Size(90, 25);
            this.cmdPrintAll.TabIndex = 35;
            this.cmdPrintAll.Text = "All";
            this.cmdPrintAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdPrintAll, "Print the selected claims from the list");
            this.cmdPrintAll.UseVisualStyleBackColor = true;
            this.cmdPrintAll.Click += new System.EventHandler(this.cmdPrintAll_Click);
            // 
            // cmdPrintList
            // 
            this.cmdPrintList.Image = global::C_DentalClaimTracker.Properties.Resources.printer;
            this.cmdPrintList.Location = new System.Drawing.Point(6, 18);
            this.cmdPrintList.Name = "cmdPrintList";
            this.cmdPrintList.Size = new System.Drawing.Size(90, 25);
            this.cmdPrintList.TabIndex = 34;
            this.cmdPrintList.Text = "Selected";
            this.cmdPrintList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdPrintList, "Print the selected claims from the list");
            this.cmdPrintList.UseVisualStyleBackColor = true;
            this.cmdPrintList.Click += new System.EventHandler(this.cmdPrintList_Click);
            // 
            // grpCheckedClaims
            // 
            this.grpCheckedClaims.Controls.Add(this.lnkUncheckAll);
            this.grpCheckedClaims.Controls.Add(this.lnkCheckAll);
            this.grpCheckedClaims.Controls.Add(this.btnSetToCustomAddress);
            this.grpCheckedClaims.Controls.Add(this.cmdSetStatus);
            this.grpCheckedClaims.Controls.Add(this.cmdCheckedStatus);
            this.grpCheckedClaims.Controls.Add(this.label8);
            this.grpCheckedClaims.Controls.Add(this.cmdResend);
            this.grpCheckedClaims.Controls.Add(this.cmdPrint);
            this.grpCheckedClaims.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCheckedClaims.Location = new System.Drawing.Point(3, 3);
            this.grpCheckedClaims.Name = "grpCheckedClaims";
            this.grpCheckedClaims.Size = new System.Drawing.Size(619, 54);
            this.grpCheckedClaims.TabIndex = 11;
            this.grpCheckedClaims.TabStop = false;
            this.grpCheckedClaims.Text = "Checked Claims";
            // 
            // lnkUncheckAll
            // 
            this.lnkUncheckAll.AutoSize = true;
            this.lnkUncheckAll.Location = new System.Drawing.Point(151, 0);
            this.lnkUncheckAll.Name = "lnkUncheckAll";
            this.lnkUncheckAll.Size = new System.Drawing.Size(61, 13);
            this.lnkUncheckAll.TabIndex = 36;
            this.lnkUncheckAll.TabStop = true;
            this.lnkUncheckAll.Text = "Uncheck All";
            this.lnkUncheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUncheckAll_LinkClicked);
            // 
            // lnkCheckAll
            // 
            this.lnkCheckAll.AutoSize = true;
            this.lnkCheckAll.Location = new System.Drawing.Point(95, 0);
            this.lnkCheckAll.Name = "lnkCheckAll";
            this.lnkCheckAll.Size = new System.Drawing.Size(50, 13);
            this.lnkCheckAll.TabIndex = 35;
            this.lnkCheckAll.TabStop = true;
            this.lnkCheckAll.Text = "Check All";
            this.lnkCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckAll_LinkClicked);
            // 
            // btnSetToCustomAddress
            // 
            this.btnSetToCustomAddress.Image = global::C_DentalClaimTracker.Properties.Resources.css_go;
            this.btnSetToCustomAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetToCustomAddress.Location = new System.Drawing.Point(183, 20);
            this.btnSetToCustomAddress.Name = "btnSetToCustomAddress";
            this.btnSetToCustomAddress.Size = new System.Drawing.Size(118, 31);
            this.btnSetToCustomAddress.TabIndex = 34;
            this.btnSetToCustomAddress.Text = "Override Provider";
            this.btnSetToCustomAddress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetToCustomAddress.UseVisualStyleBackColor = true;
            this.btnSetToCustomAddress.Click += new System.EventHandler(this.btnSetToCustomAddress_Click);
            // 
            // cmdSetStatus
            // 
            this.cmdSetStatus.Enabled = false;
            this.cmdSetStatus.Location = new System.Drawing.Point(560, 19);
            this.cmdSetStatus.Name = "cmdSetStatus";
            this.cmdSetStatus.Size = new System.Drawing.Size(53, 31);
            this.cmdSetStatus.TabIndex = 4;
            this.cmdSetStatus.Text = "Set";
            this.cmdSetStatus.UseVisualStyleBackColor = true;
            this.cmdSetStatus.Click += new System.EventHandler(this.CheckedItemsButton_Click);
            // 
            // cmdCheckedStatus
            // 
            this.cmdCheckedStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdCheckedStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheckedStatus.FormattingEnabled = true;
            this.cmdCheckedStatus.Location = new System.Drawing.Point(380, 21);
            this.cmdCheckedStatus.Name = "cmdCheckedStatus";
            this.cmdCheckedStatus.Size = new System.Drawing.Size(175, 27);
            this.cmdCheckedStatus.TabIndex = 3;
            this.cmdCheckedStatus.SelectedIndexChanged += new System.EventHandler(this.cmdCheckedStatus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Set Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdResend
            // 
            this.cmdResend.Image = global::C_DentalClaimTracker.Properties.Resources.computer_go1;
            this.cmdResend.Location = new System.Drawing.Point(94, 20);
            this.cmdResend.Name = "cmdResend";
            this.cmdResend.Size = new System.Drawing.Size(83, 31);
            this.cmdResend.TabIndex = 1;
            this.cmdResend.Text = "&Resend";
            this.cmdResend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdResend.UseVisualStyleBackColor = true;
            this.cmdResend.Click += new System.EventHandler(this.CheckedItemsButton_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = global::C_DentalClaimTracker.Properties.Resources.printer;
            this.cmdPrint.Location = new System.Drawing.Point(5, 20);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(83, 31);
            this.cmdPrint.TabIndex = 0;
            this.cmdPrint.Text = "&Print";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.CheckedItemsButton_Click);
            // 
            // cmdOpenClaim
            // 
            this.cmdOpenClaim.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdOpenClaim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpenClaim.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.cmdOpenClaim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOpenClaim.Location = new System.Drawing.Point(895, 3);
            this.cmdOpenClaim.Name = "cmdOpenClaim";
            this.cmdOpenClaim.Size = new System.Drawing.Size(140, 54);
            this.cmdOpenClaim.TabIndex = 2;
            this.cmdOpenClaim.Text = "&Open";
            this.cmdOpenClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdOpenClaim.UseVisualStyleBackColor = true;
            this.cmdOpenClaim.Click += new System.EventHandler(this.cmdOpenClaim_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel7);
            this.pnlTop.Controls.Add(this.panel3);
            this.pnlTop.Controls.Add(this.groupBox4);
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Controls.Add(this.groupBox3);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1040, 145);
            this.pnlTop.TabIndex = 29;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grpAllBin);
            this.panel7.Controls.Add(this.cmdSearch);
            this.panel7.Controls.Add(this.groupBox7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(842, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 145);
            this.panel7.TabIndex = 31;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSearch.Location = new System.Drawing.Point(0, 90);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(141, 55);
            this.cmdSearch.TabIndex = 8;
            this.cmdSearch.Text = "&Search";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkNEANumOnly);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(141, 43);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Special Options";
            // 
            // chkNEANumOnly
            // 
            this.chkNEANumOnly.AutoSize = true;
            this.chkNEANumOnly.Location = new System.Drawing.Point(6, 18);
            this.chkNEANumOnly.Name = "chkNEANumOnly";
            this.chkNEANumOnly.Size = new System.Drawing.Size(105, 17);
            this.chkNEANumOnly.TabIndex = 19;
            this.chkNEANumOnly.Text = "Only with NEA #";
            this.chkNEANumOnly.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(685, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 145);
            this.panel3.TabIndex = 30;
            // 
            // lblSearchTime
            // 
            this.lblSearchTime.Location = new System.Drawing.Point(0, 12);
            this.lblSearchTime.Name = "lblSearchTime";
            this.lblSearchTime.Size = new System.Drawing.Size(157, 19);
            this.lblSearchTime.TabIndex = 64;
            this.lblSearchTime.Text = "Search time: 0 ms";
            this.lblSearchTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbStatus);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 41);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hide others\' claims",
            "My claims only",
            "Show all claims"});
            this.cmbStatus.Location = new System.Drawing.Point(6, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(145, 21);
            this.cmbStatus.TabIndex = 34;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // pnlResults
            // 
            this.pnlResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.spltMain);
            this.pnlResults.Controls.Add(this.panel4);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(0, 145);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Padding = new System.Windows.Forms.Padding(1);
            this.pnlResults.Size = new System.Drawing.Size(1040, 321);
            this.pnlResults.TabIndex = 9;
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltMain.Location = new System.Drawing.Point(1, 44);
            this.spltMain.Name = "spltMain";
            this.spltMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.lblSearching);
            this.spltMain.Panel1.Controls.Add(this.dgvResults);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.pnlNotes);
            this.spltMain.Panel2Collapsed = true;
            this.spltMain.Size = new System.Drawing.Size(1036, 274);
            this.spltMain.SplitterDistance = 219;
            this.spltMain.TabIndex = 64;
            // 
            // lblSearching
            // 
            this.lblSearching.BackColor = System.Drawing.Color.LightYellow;
            this.lblSearching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearching.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearching.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise2;
            this.lblSearching.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearching.Location = new System.Drawing.Point(2, 22);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(137, 54);
            this.lblSearching.TabIndex = 61;
            this.lblSearching.Text = "Searching...";
            this.lblSearching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearching.Visible = false;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.PatientName,
            this.PatientDOB,
            this.colCarrier,
            this.Amount,
            this.coldate_of_service,
            this.colType,
            this.colRevisitDate,
            this.colAssn,
            this.colProvider,
            this.colStatus,
            this.Column1,
            this.colLastEdit,
            this.colclaimIDnum,
            this.coldbnum,
            this.colClaimObject,
            this.colDOSRange});
            this.dgvResults.ContextMenuStrip = this.cTextResults;
            this.dgvResults.DataSource = this.bsResults;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1036, 274);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            this.dgvResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResults_CellFormatting);
            this.dgvResults.SelectionChanged += new System.EventHandler(this.dgvResults_SelectionChanged);
            this.dgvResults.DoubleClick += new System.EventHandler(this.dgvResults_DoubleClick);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "X";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 20;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "Name";
            this.PatientName.HeaderText = "Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 119;
            // 
            // PatientDOB
            // 
            this.PatientDOB.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.PatientDOB.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDOB.HeaderText = "Patient DOB";
            this.PatientDOB.Name = "PatientDOB";
            this.PatientDOB.ReadOnly = true;
            // 
            // colCarrier
            // 
            this.colCarrier.DataPropertyName = "Carrier";
            this.colCarrier.HeaderText = "Carrier";
            this.colCarrier.Name = "colCarrier";
            this.colCarrier.ReadOnly = true;
            this.colCarrier.Width = 172;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Amt";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 50;
            // 
            // coldate_of_service
            // 
            this.coldate_of_service.DataPropertyName = "DateOfService";
            this.coldate_of_service.HeaderText = "DOS";
            this.coldate_of_service.Name = "coldate_of_service";
            this.coldate_of_service.ReadOnly = true;
            this.coldate_of_service.Width = 70;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 50;
            // 
            // colRevisitDate
            // 
            this.colRevisitDate.DataPropertyName = "RevisitDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colRevisitDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRevisitDate.HeaderText = "Revisit";
            this.colRevisitDate.Name = "colRevisitDate";
            this.colRevisitDate.ReadOnly = true;
            this.colRevisitDate.Width = 70;
            // 
            // colAssn
            // 
            this.colAssn.DataPropertyName = "AssignTo";
            this.colAssn.HeaderText = "Assn To";
            this.colAssn.Name = "colAssn";
            this.colAssn.Visible = false;
            this.colAssn.Width = 80;
            // 
            // colProvider
            // 
            this.colProvider.DataPropertyName = "Provider";
            this.colProvider.HeaderText = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LastSendDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Last Sent";
            this.Column1.Name = "Column1";
            this.Column1.Width = 82;
            // 
            // colLastEdit
            // 
            this.colLastEdit.DataPropertyName = "LastEdit";
            this.colLastEdit.HeaderText = "Last Edit";
            this.colLastEdit.Name = "colLastEdit";
            this.colLastEdit.ReadOnly = true;
            this.colLastEdit.Width = 125;
            // 
            // colclaimIDnum
            // 
            this.colclaimIDnum.DataPropertyName = "SystemID1";
            this.colclaimIDnum.HeaderText = "SystemID1";
            this.colclaimIDnum.Name = "colclaimIDnum";
            this.colclaimIDnum.Visible = false;
            // 
            // coldbnum
            // 
            this.coldbnum.DataPropertyName = "SystemID2";
            this.coldbnum.HeaderText = "SystemID2";
            this.coldbnum.Name = "coldbnum";
            this.coldbnum.Visible = false;
            // 
            // colClaimObject
            // 
            this.colClaimObject.DataPropertyName = "ClaimObject";
            this.colClaimObject.HeaderText = "ClaimObject";
            this.colClaimObject.Name = "colClaimObject";
            this.colClaimObject.Visible = false;
            // 
            // colDOSRange
            // 
            this.colDOSRange.DataPropertyName = "DateOfServiceRange";
            this.colDOSRange.HeaderText = "SecondDateOfService";
            this.colDOSRange.Name = "colDOSRange";
            this.colDOSRange.Visible = false;
            // 
            // cTextResults
            // 
            this.cTextResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem});
            this.cTextResults.Name = "cTextResults";
            this.cTextResults.Size = new System.Drawing.Size(138, 48);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkAllToolStripMenuItem.Text = "&Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.uncheckAllToolStripMenuItem.Text = "&Uncheck All";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // bsResults
            // 
            this.bsResults.DataSource = typeof(C_DentalClaimTracker.Claims_Primary.SearchResults.MainSearchSearchResultList);
            // 
            // pnlNotes
            // 
            this.pnlNotes.Controls.Add(this.ctlNotes);
            this.pnlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotes.Location = new System.Drawing.Point(0, 0);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(150, 46);
            this.pnlNotes.TabIndex = 64;
            // 
            // ctlNotes
            // 
            this.ctlNotes.CurrentCall = null;
            this.ctlNotes.CurrentClaim = null;
            this.ctlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlNotes.Location = new System.Drawing.Point(0, 0);
            this.ctlNotes.Mode = C_DentalClaimTracker.NotesGrid.NotesGridMode.GridView;
            this.ctlNotes.Name = "ctlNotes";
            this.ctlNotes.ReadOnly = true;
            this.ctlNotes.Size = new System.Drawing.Size(150, 46);
            this.ctlNotes.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 43);
            this.panel4.TabIndex = 62;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.cmdUnsubmittedBin);
            this.panel6.Controls.Add(this.cmdResolveBin);
            this.panel6.Controls.Add(this.cmdAllBin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 43);
            this.panel6.TabIndex = 63;
            // 
            // cmdUnsubmittedBin
            // 
            this.cmdUnsubmittedBin.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUnsubmittedBin.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdUnsubmittedBin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnsubmittedBin.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_code;
            this.cmdUnsubmittedBin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUnsubmittedBin.Location = new System.Drawing.Point(326, 0);
            this.cmdUnsubmittedBin.Name = "cmdUnsubmittedBin";
            this.cmdUnsubmittedBin.Size = new System.Drawing.Size(163, 39);
            this.cmdUnsubmittedBin.TabIndex = 11;
            this.cmdUnsubmittedBin.Text = "Unsubmitted";
            this.cmdUnsubmittedBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdUnsubmittedBin, "Claims that have not yet been started");
            this.cmdUnsubmittedBin.UseVisualStyleBackColor = true;
            this.cmdUnsubmittedBin.Click += new System.EventHandler(this.cmdBin_Clicked);
            // 
            // cmdResolveBin
            // 
            this.cmdResolveBin.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdResolveBin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResolveBin.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_code_red;
            this.cmdResolveBin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdResolveBin.Location = new System.Drawing.Point(163, 0);
            this.cmdResolveBin.Name = "cmdResolveBin";
            this.cmdResolveBin.Size = new System.Drawing.Size(163, 39);
            this.cmdResolveBin.TabIndex = 14;
            this.cmdResolveBin.Text = "Resolve";
            this.cmdResolveBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdResolveBin, "Claims in need of a revisit");
            this.cmdResolveBin.Click += new System.EventHandler(this.cmdBin_Clicked);
            // 
            // cmdAllBin
            // 
            this.cmdAllBin.BackColor = System.Drawing.Color.LightYellow;
            this.cmdAllBin.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAllBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAllBin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAllBin.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_magnify;
            this.cmdAllBin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAllBin.Location = new System.Drawing.Point(0, 0);
            this.cmdAllBin.Name = "cmdAllBin";
            this.cmdAllBin.Size = new System.Drawing.Size(163, 39);
            this.cmdAllBin.TabIndex = 15;
            this.cmdAllBin.Text = "All";
            this.cmdAllBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdAllBin, "All claims - use the \'Unpaid Claims Only\' checkbox to toggle viewing of paid clai" +
        "ms");
            this.cmdAllBin.UseVisualStyleBackColor = true;
            this.cmdAllBin.Click += new System.EventHandler(this.cmdBin_Clicked);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.nmbMaxResults);
            this.panel5.Controls.Add(this.lblMaxResults);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(954, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 43);
            this.panel5.TabIndex = 62;
            // 
            // nmbMaxResults
            // 
            this.nmbMaxResults.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::C_DentalClaimTracker.Properties.Settings.Default, "SearchFormsMaxResults", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nmbMaxResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nmbMaxResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbMaxResults.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbMaxResults.Location = new System.Drawing.Point(0, 18);
            this.nmbMaxResults.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbMaxResults.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbMaxResults.Name = "nmbMaxResults";
            this.nmbMaxResults.Size = new System.Drawing.Size(80, 23);
            this.nmbMaxResults.TabIndex = 1;
            this.nmbMaxResults.Value = global::C_DentalClaimTracker.Properties.Settings.Default.SearchFormsMaxResults;
            // 
            // lblMaxResults
            // 
            this.lblMaxResults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMaxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxResults.Location = new System.Drawing.Point(0, 0);
            this.lblMaxResults.Name = "lblMaxResults";
            this.lblMaxResults.Size = new System.Drawing.Size(80, 41);
            this.lblMaxResults.TabIndex = 60;
            this.lblMaxResults.Text = "Max Results";
            this.lblMaxResults.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ttipMain.SetToolTip(this.lblMaxResults, "The maximum number of results to display.");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSearchTime);
            this.panel2.Controls.Add(this.cmdClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 32);
            this.panel2.TabIndex = 33;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ctxtProviderList
            // 
            this.ctxtProviderList.Name = "ctxtProviderList";
            this.ctxtProviderList.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSearchClaim
            // 
            this.AcceptButton = this.cmdSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(1040, 560);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchClaim";
            this.Text = "Search for Claims";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchClaim_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchClaim_Load);
            this.Shown += new System.EventHandler(this.frmSearchClaim_Shown);
            this.Leave += new System.EventHandler(this.frmSearchClaim_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanies)).EndInit();
            this.grpAllBin.ResumeLayout(false);
            this.grpAllBin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.grpCheckedClaims.ResumeLayout(false);
            this.grpCheckedClaims.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.pnlResults.ResumeLayout(false);
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.cTextResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).EndInit();
            this.pnlNotes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxResults)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdOpenClaim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCompanyDropdown;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtGroupNum;
        private System.Windows.Forms.GroupBox grpAllBin;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.NumericUpDown nmbMaxResults;
        private System.Windows.Forms.Label lblMaxResults;
        private System.Windows.Forms.TextBox txtClaimAmount;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGroupPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOpenClaimsOnly;
        private ctlDateEntry ctlPatientDOB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private ctlDateEntry ctlOnHoldDate;
        private System.Windows.Forms.CheckBox chkHoldDateEnabled;
        private ctlDateEntry ctlResentDate;
        private System.Windows.Forms.CheckBox chkResentDateEnabled;
        private ctlDateEntry ctlSentDate;
        private System.Windows.Forms.CheckBox chkSentDateEnabled;
        private ctlDateEntry ctlTracerDate;
        private System.Windows.Forms.CheckBox chkTracerDateEnabled;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.ComboBox cmbDateFilterType;
        private System.Windows.Forms.CheckBox chkShowPredeterms;
        private System.Windows.Forms.CheckBox chkShowSecondary;
        private System.Windows.Forms.CheckBox chkShowPrimary;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbClinic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblSearching;
        private ctlDateEntry ctlLastUpdateDate;
        private System.Windows.Forms.CheckBox chkLastUpdateEnabled;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cmdUnsubmittedBin;
        private System.Windows.Forms.Button cmdAllBin;
        private System.Windows.Forms.Button cmdResolveBin;
        private System.Windows.Forms.GroupBox grpCheckedClaims;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdResend;
        private System.Windows.Forms.ComboBox cmdCheckedStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdSetStatus;
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.Panel pnlNotes;
        private NotesGrid ctlNotes;
        private System.Windows.Forms.ComboBox cmbProviderID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkNEANumOnly;
        private System.Windows.Forms.BindingSource bsResults;
        private System.Windows.Forms.Button btnSetToCustomAddress;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.BindingSource bsCompanies;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button cmdPrintAll;
        private System.Windows.Forms.Button cmdPrintList;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.LinkLabel lnkUncheckAll;
        private System.Windows.Forms.LinkLabel lnkCheckAll;
        private System.Windows.Forms.ContextMenuStrip cTextResults;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtProviderList;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldate_of_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colclaimIDnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldbnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOSRange;
        private ctlDateEntry dtpLastSent;
        private System.Windows.Forms.CheckBox chkLastSent;
        private ctlDateEntry dtpRevisitDate;
        private System.Windows.Forms.CheckBox chkRevisitDate;
        private ctlDateEntry dtpCreateDate;
        private System.Windows.Forms.CheckBox chkCreateDate;
        private System.Windows.Forms.Label lblSearchTime;
    }
}

