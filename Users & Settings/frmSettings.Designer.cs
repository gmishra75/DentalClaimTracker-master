namespace C_DentalClaimTracker
{
    partial class frmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtEclaimsSaveFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpPredetermLimitDate = new System.Windows.Forms.DateTimePicker();
            this.chkLimitPredetermOnSearch = new System.Windows.Forms.CheckBox();
            this.nmbMaxClaimsInBatch = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmbMaxClaims = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbResendRevisit = new System.Windows.Forms.NumericUpDown();
            this.chkResendRevisit = new System.Windows.Forms.CheckBox();
            this.chkResendStatus = new System.Windows.Forms.CheckBox();
            this.cmbResendStatus = new System.Windows.Forms.ComboBox();
            this.chkEclaimsShowSecondaryAmounts = new System.Windows.Forms.CheckBox();
            this.lblLocalComputerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkStatusOnApexResend = new System.Windows.Forms.CheckBox();
            this.cmbStatusOnApexResend = new System.Windows.Forms.ComboBox();
            this.chkStatusOnApex = new System.Windows.Forms.CheckBox();
            this.cmbStatusOnApex = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nmbApexRevisitDate = new System.Windows.Forms.NumericUpDown();
            this.chkApexRevisitDate = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQNF4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQNB4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQNF3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQNB3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQNF2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQNB2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQNF1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQNB1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkOpenConfig = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLocalName = new System.Windows.Forms.TextBox();
            this.txtApexConfigLocation = new System.Windows.Forms.TextBox();
            this.chkUseAdvancedVideo = new System.Windows.Forms.CheckBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkOverrideProviderByState = new System.Windows.Forms.CheckBox();
            this.cmbOverrideStateProviderID = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOverrideStateState = new System.Windows.Forms.TextBox();
            this.cmbOverrideStateNewProviderID = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbOverrideStateInsurance = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxClaimsInBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxClaims)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbResendRevisit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbApexRevisitDate)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(544, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 34);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(477, 13);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(61, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtEclaimsSaveFolder
            // 
            this.txtEclaimsSaveFolder.Location = new System.Drawing.Point(7, 101);
            this.txtEclaimsSaveFolder.Name = "txtEclaimsSaveFolder";
            this.txtEclaimsSaveFolder.Size = new System.Drawing.Size(300, 20);
            this.txtEclaimsSaveFolder.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eclaims Save Folder (include closing \\)";
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(245, 22);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(61, 23);
            this.cmdTest.TabIndex = 8;
            this.cmdTest.Text = "&Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max number of claims to display on multiple claim screen (use a smaller number fo" +
    "r slower computers)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nmbMaxClaimsInBatch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nmbMaxClaims);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 117);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpPredetermLimitDate);
            this.panel2.Controls.Add(this.chkLimitPredetermOnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 28);
            this.panel2.TabIndex = 13;
            // 
            // dtpPredetermLimitDate
            // 
            this.dtpPredetermLimitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPredetermLimitDate.Location = new System.Drawing.Point(188, 0);
            this.dtpPredetermLimitDate.Name = "dtpPredetermLimitDate";
            this.dtpPredetermLimitDate.Size = new System.Drawing.Size(106, 20);
            this.dtpPredetermLimitDate.TabIndex = 1;
            this.dtpPredetermLimitDate.Value = new System.DateTime(2010, 1, 1, 15, 55, 0, 0);
            // 
            // chkLimitPredetermOnSearch
            // 
            this.chkLimitPredetermOnSearch.AutoSize = true;
            this.chkLimitPredetermOnSearch.Location = new System.Drawing.Point(3, 3);
            this.chkLimitPredetermOnSearch.Name = "chkLimitPredetermOnSearch";
            this.chkLimitPredetermOnSearch.Size = new System.Drawing.Size(164, 17);
            this.chkLimitPredetermOnSearch.TabIndex = 0;
            this.chkLimitPredetermOnSearch.Text = "Hide Predeterms before date:";
            this.chkLimitPredetermOnSearch.UseVisualStyleBackColor = true;
            // 
            // nmbMaxClaimsInBatch
            // 
            this.nmbMaxClaimsInBatch.Location = new System.Drawing.Point(215, 63);
            this.nmbMaxClaimsInBatch.Name = "nmbMaxClaimsInBatch";
            this.nmbMaxClaimsInBatch.Size = new System.Drawing.Size(78, 20);
            this.nmbMaxClaimsInBatch.TabIndex = 12;
            this.nmbMaxClaimsInBatch.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(0, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max number of claims allowed in a batch";
            // 
            // nmbMaxClaims
            // 
            this.nmbMaxClaims.Location = new System.Drawing.Point(215, 20);
            this.nmbMaxClaims.Name = "nmbMaxClaims";
            this.nmbMaxClaims.Size = new System.Drawing.Size(78, 20);
            this.nmbMaxClaims.TabIndex = 10;
            this.nmbMaxClaims.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apex Config Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmbResendRevisit);
            this.groupBox1.Controls.Add(this.chkResendRevisit);
            this.groupBox1.Controls.Add(this.chkResendStatus);
            this.groupBox1.Controls.Add(this.cmbResendStatus);
            this.groupBox1.Location = new System.Drawing.Point(7, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resend button behavior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "days from resend date";
            // 
            // nmbResendRevisit
            // 
            this.nmbResendRevisit.Enabled = false;
            this.nmbResendRevisit.Location = new System.Drawing.Point(106, 44);
            this.nmbResendRevisit.Name = "nmbResendRevisit";
            this.nmbResendRevisit.Size = new System.Drawing.Size(62, 20);
            this.nmbResendRevisit.TabIndex = 17;
            // 
            // chkResendRevisit
            // 
            this.chkResendRevisit.AutoSize = true;
            this.chkResendRevisit.Location = new System.Drawing.Point(4, 47);
            this.chkResendRevisit.Name = "chkResendRevisit";
            this.chkResendRevisit.Size = new System.Drawing.Size(93, 17);
            this.chkResendRevisit.TabIndex = 16;
            this.chkResendRevisit.Text = "Set Revisit To";
            this.chkResendRevisit.UseVisualStyleBackColor = true;
            this.chkResendRevisit.CheckedChanged += new System.EventHandler(this.chkResendRevisit_CheckedChanged);
            // 
            // chkResendStatus
            // 
            this.chkResendStatus.AutoSize = true;
            this.chkResendStatus.Location = new System.Drawing.Point(4, 19);
            this.chkResendStatus.Name = "chkResendStatus";
            this.chkResendStatus.Size = new System.Drawing.Size(91, 17);
            this.chkResendStatus.TabIndex = 15;
            this.chkResendStatus.Text = "Set Status To";
            this.chkResendStatus.UseVisualStyleBackColor = true;
            this.chkResendStatus.CheckedChanged += new System.EventHandler(this.chkResendStatus_CheckedChanged);
            // 
            // cmbResendStatus
            // 
            this.cmbResendStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResendStatus.Enabled = false;
            this.cmbResendStatus.FormattingEnabled = true;
            this.cmbResendStatus.Location = new System.Drawing.Point(106, 17);
            this.cmbResendStatus.Name = "cmbResendStatus";
            this.cmbResendStatus.Size = new System.Drawing.Size(188, 21);
            this.cmbResendStatus.TabIndex = 14;
            // 
            // chkEclaimsShowSecondaryAmounts
            // 
            this.chkEclaimsShowSecondaryAmounts.Checked = true;
            this.chkEclaimsShowSecondaryAmounts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEclaimsShowSecondaryAmounts.Location = new System.Drawing.Point(7, 565);
            this.chkEclaimsShowSecondaryAmounts.Name = "chkEclaimsShowSecondaryAmounts";
            this.chkEclaimsShowSecondaryAmounts.Size = new System.Drawing.Size(310, 43);
            this.chkEclaimsShowSecondaryAmounts.TabIndex = 15;
            this.chkEclaimsShowSecondaryAmounts.Text = "Eclaims - Show Adjudication Date, Primary Pay Amount, and Patient Responsible Amo" +
    "unt on Secondary Claims";
            this.chkEclaimsShowSecondaryAmounts.UseVisualStyleBackColor = true;
            // 
            // lblLocalComputerName
            // 
            this.lblLocalComputerName.AutoSize = true;
            this.lblLocalComputerName.Location = new System.Drawing.Point(4, 163);
            this.lblLocalComputerName.Name = "lblLocalComputerName";
            this.lblLocalComputerName.Size = new System.Drawing.Size(112, 13);
            this.lblLocalComputerName.TabIndex = 17;
            this.lblLocalComputerName.Text = "Local Computer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStatusOnApexResend);
            this.groupBox2.Controls.Add(this.cmbStatusOnApexResend);
            this.groupBox2.Controls.Add(this.chkStatusOnApex);
            this.groupBox2.Controls.Add(this.cmbStatusOnApex);
            this.groupBox2.Location = new System.Drawing.Point(8, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status for claims sent through Apex";
            // 
            // chkStatusOnApexResend
            // 
            this.chkStatusOnApexResend.AutoSize = true;
            this.chkStatusOnApexResend.Location = new System.Drawing.Point(5, 46);
            this.chkStatusOnApexResend.Name = "chkStatusOnApexResend";
            this.chkStatusOnApexResend.Size = new System.Drawing.Size(80, 17);
            this.chkStatusOnApexResend.TabIndex = 17;
            this.chkStatusOnApexResend.Text = "On Resend";
            this.chkStatusOnApexResend.UseVisualStyleBackColor = true;
            this.chkStatusOnApexResend.CheckedChanged += new System.EventHandler(this.chkStatusOnApexResend_CheckedChanged);
            // 
            // cmbStatusOnApexResend
            // 
            this.cmbStatusOnApexResend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOnApexResend.Enabled = false;
            this.cmbStatusOnApexResend.FormattingEnabled = true;
            this.cmbStatusOnApexResend.Location = new System.Drawing.Point(106, 44);
            this.cmbStatusOnApexResend.Name = "cmbStatusOnApexResend";
            this.cmbStatusOnApexResend.Size = new System.Drawing.Size(188, 21);
            this.cmbStatusOnApexResend.TabIndex = 16;
            // 
            // chkStatusOnApex
            // 
            this.chkStatusOnApex.AutoSize = true;
            this.chkStatusOnApex.Location = new System.Drawing.Point(4, 19);
            this.chkStatusOnApex.Name = "chkStatusOnApex";
            this.chkStatusOnApex.Size = new System.Drawing.Size(90, 17);
            this.chkStatusOnApex.TabIndex = 15;
            this.chkStatusOnApex.Text = "On First Send";
            this.chkStatusOnApex.UseVisualStyleBackColor = true;
            this.chkStatusOnApex.CheckedChanged += new System.EventHandler(this.chkStatusOnApex_CheckedChanged);
            // 
            // cmbStatusOnApex
            // 
            this.cmbStatusOnApex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOnApex.Enabled = false;
            this.cmbStatusOnApex.FormattingEnabled = true;
            this.cmbStatusOnApex.Location = new System.Drawing.Point(106, 17);
            this.cmbStatusOnApex.Name = "cmbStatusOnApex";
            this.cmbStatusOnApex.Size = new System.Drawing.Size(188, 21);
            this.cmbStatusOnApex.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "days from send date";
            // 
            // nmbApexRevisitDate
            // 
            this.nmbApexRevisitDate.Location = new System.Drawing.Point(108, 16);
            this.nmbApexRevisitDate.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmbApexRevisitDate.Name = "nmbApexRevisitDate";
            this.nmbApexRevisitDate.Size = new System.Drawing.Size(62, 20);
            this.nmbApexRevisitDate.TabIndex = 20;
            // 
            // chkApexRevisitDate
            // 
            this.chkApexRevisitDate.AutoSize = true;
            this.chkApexRevisitDate.Location = new System.Drawing.Point(6, 19);
            this.chkApexRevisitDate.Name = "chkApexRevisitDate";
            this.chkApexRevisitDate.Size = new System.Drawing.Size(93, 17);
            this.chkApexRevisitDate.TabIndex = 19;
            this.chkApexRevisitDate.Text = "Set Revisit To";
            this.chkApexRevisitDate.UseVisualStyleBackColor = true;
            this.chkApexRevisitDate.CheckedChanged += new System.EventHandler(this.chkApexRevisitDate_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Controls.Add(this.cmdCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 634);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 39);
            this.panel3.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQNF4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtQNB4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtQNF3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtQNB3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtQNF2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtQNB2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtQNF1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQNB1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(313, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 487);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick Note Entry";
            // 
            // txtQNF4
            // 
            this.txtQNF4.Location = new System.Drawing.Point(9, 406);
            this.txtQNF4.MaxLength = 500;
            this.txtQNF4.Multiline = true;
            this.txtQNF4.Name = "txtQNF4";
            this.txtQNF4.Size = new System.Drawing.Size(285, 71);
            this.txtQNF4.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Quick Note 4 Full Text";
            // 
            // txtQNB4
            // 
            this.txtQNB4.Location = new System.Drawing.Point(140, 363);
            this.txtQNB4.MaxLength = 10;
            this.txtQNB4.Name = "txtQNB4";
            this.txtQNB4.Size = new System.Drawing.Size(73, 20);
            this.txtQNB4.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Quick Note 4 Button Text";
            // 
            // txtQNF3
            // 
            this.txtQNF3.Location = new System.Drawing.Point(9, 287);
            this.txtQNF3.MaxLength = 500;
            this.txtQNF3.Multiline = true;
            this.txtQNF3.Name = "txtQNF3";
            this.txtQNF3.Size = new System.Drawing.Size(285, 71);
            this.txtQNF3.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Quick Note 3 Full Text";
            // 
            // txtQNB3
            // 
            this.txtQNB3.Location = new System.Drawing.Point(140, 244);
            this.txtQNB3.MaxLength = 10;
            this.txtQNB3.Name = "txtQNB3";
            this.txtQNB3.Size = new System.Drawing.Size(73, 20);
            this.txtQNB3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Quick Note 3 Button Text";
            // 
            // txtQNF2
            // 
            this.txtQNF2.Location = new System.Drawing.Point(9, 171);
            this.txtQNF2.MaxLength = 500;
            this.txtQNF2.Multiline = true;
            this.txtQNF2.Name = "txtQNF2";
            this.txtQNF2.Size = new System.Drawing.Size(285, 71);
            this.txtQNF2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quick Note 2 Full Text";
            // 
            // txtQNB2
            // 
            this.txtQNB2.Location = new System.Drawing.Point(140, 128);
            this.txtQNB2.MaxLength = 10;
            this.txtQNB2.Name = "txtQNB2";
            this.txtQNB2.Size = new System.Drawing.Size(73, 20);
            this.txtQNB2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Quick Note 2 Button Text";
            // 
            // txtQNF1
            // 
            this.txtQNF1.Location = new System.Drawing.Point(9, 55);
            this.txtQNF1.MaxLength = 500;
            this.txtQNF1.Multiline = true;
            this.txtQNF1.Name = "txtQNF1";
            this.txtQNF1.Size = new System.Drawing.Size(285, 71);
            this.txtQNF1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quick Note 1 Full Text";
            // 
            // txtQNB1
            // 
            this.txtQNB1.Location = new System.Drawing.Point(140, 12);
            this.txtQNB1.MaxLength = 10;
            this.txtQNB1.Name = "txtQNB1";
            this.txtQNB1.Size = new System.Drawing.Size(73, 20);
            this.txtQNB1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quick Note 1 Button Text";
            // 
            // lnkOpenConfig
            // 
            this.lnkOpenConfig.AutoSize = true;
            this.lnkOpenConfig.Location = new System.Drawing.Point(146, 8);
            this.lnkOpenConfig.Name = "lnkOpenConfig";
            this.lnkOpenConfig.Size = new System.Drawing.Size(94, 13);
            this.lnkOpenConfig.TabIndex = 21;
            this.lnkOpenConfig.TabStop = true;
            this.lnkOpenConfig.Text = "Open Config File...";
            this.lnkOpenConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenConfig_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkApexRevisitDate);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.nmbApexRevisitDate);
            this.groupBox4.Location = new System.Drawing.Point(7, 369);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 45);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Revisit date on first send";
            // 
            // txtLocalName
            // 
            this.txtLocalName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::C_DentalClaimTracker.Properties.Settings.Default, "LocalComputerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLocalName.Location = new System.Drawing.Point(7, 179);
            this.txtLocalName.Name = "txtLocalName";
            this.txtLocalName.Size = new System.Drawing.Size(300, 20);
            this.txtLocalName.TabIndex = 16;
            this.txtLocalName.Text = global::C_DentalClaimTracker.Properties.Settings.Default.LocalComputerName;
            // 
            // txtApexConfigLocation
            // 
            this.txtApexConfigLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::C_DentalClaimTracker.Properties.Settings.Default, "ApexEDIConfigLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtApexConfigLocation.Location = new System.Drawing.Point(7, 139);
            this.txtApexConfigLocation.Name = "txtApexConfigLocation";
            this.txtApexConfigLocation.Size = new System.Drawing.Size(300, 20);
            this.txtApexConfigLocation.TabIndex = 11;
            this.txtApexConfigLocation.Text = global::C_DentalClaimTracker.Properties.Settings.Default.ApexEDIConfigLocation;
            // 
            // chkUseAdvancedVideo
            // 
            this.chkUseAdvancedVideo.AutoSize = true;
            this.chkUseAdvancedVideo.Checked = global::C_DentalClaimTracker.Properties.Settings.Default.UseAdvancedVideo;
            this.chkUseAdvancedVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseAdvancedVideo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::C_DentalClaimTracker.Properties.Settings.Default, "UseAdvancedVideo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseAdvancedVideo.Location = new System.Drawing.Point(11, 542);
            this.chkUseAdvancedVideo.Name = "chkUseAdvancedVideo";
            this.chkUseAdvancedVideo.Size = new System.Drawing.Size(127, 17);
            this.chkUseAdvancedVideo.TabIndex = 3;
            this.chkUseAdvancedVideo.Text = "Use Advanced Video";
            this.chkUseAdvancedVideo.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Enabled = false;
            this.txtServerName.Location = new System.Drawing.Point(7, 24);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(233, 20);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.Text = global::C_DentalClaimTracker.Properties.Settings.Default.ServerNameSQL;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::C_DentalClaimTracker.Properties.Settings.Default, "DatabaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDatabaseName.Enabled = false;
            this.txtDatabaseName.Location = new System.Drawing.Point(7, 62);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(233, 20);
            this.txtDatabaseName.TabIndex = 23;
            this.txtDatabaseName.Text = global::C_DentalClaimTracker.Properties.Settings.Default.DatabaseName;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Database Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbOverrideStateInsurance);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.cmbOverrideStateNewProviderID);
            this.groupBox5.Controls.Add(this.txtOverrideStateState);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.cmbOverrideStateProviderID);
            this.groupBox5.Controls.Add(this.chkOverrideProviderByState);
            this.groupBox5.Location = new System.Drawing.Point(313, 515);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 101);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Overwrite Provider by State";
            // 
            // chkOverrideProviderByState
            // 
            this.chkOverrideProviderByState.AutoSize = true;
            this.chkOverrideProviderByState.Location = new System.Drawing.Point(6, 19);
            this.chkOverrideProviderByState.Name = "chkOverrideProviderByState";
            this.chkOverrideProviderByState.Size = new System.Drawing.Size(108, 17);
            this.chkOverrideProviderByState.TabIndex = 19;
            this.chkOverrideProviderByState.Text = "Override Provider";
            this.chkOverrideProviderByState.UseVisualStyleBackColor = true;
            // 
            // cmbOverrideStateProviderID
            // 
            this.cmbOverrideStateProviderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverrideStateProviderID.FormattingEnabled = true;
            this.cmbOverrideStateProviderID.Location = new System.Drawing.Point(118, 17);
            this.cmbOverrideStateProviderID.Name = "cmbOverrideStateProviderID";
            this.cmbOverrideStateProviderID.Size = new System.Drawing.Size(167, 21);
            this.cmbOverrideStateProviderID.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "for Insurance";
            // 
            // txtOverrideStateState
            // 
            this.txtOverrideStateState.Location = new System.Drawing.Point(62, 74);
            this.txtOverrideStateState.MaxLength = 10;
            this.txtOverrideStateState.Name = "txtOverrideStateState";
            this.txtOverrideStateState.Size = new System.Drawing.Size(45, 20);
            this.txtOverrideStateState.TabIndex = 23;
            // 
            // cmbOverrideStateNewProviderID
            // 
            this.cmbOverrideStateNewProviderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverrideStateNewProviderID.FormattingEnabled = true;
            this.cmbOverrideStateNewProviderID.Location = new System.Drawing.Point(140, 74);
            this.cmbOverrideStateNewProviderID.Name = "cmbOverrideStateNewProviderID";
            this.cmbOverrideStateNewProviderID.Size = new System.Drawing.Size(145, 21);
            this.cmbOverrideStateNewProviderID.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(110, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "use";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "and State";
            // 
            // cmbOverrideStateInsurance
            // 
            this.cmbOverrideStateInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverrideStateInsurance.FormattingEnabled = true;
            this.cmbOverrideStateInsurance.Location = new System.Drawing.Point(78, 47);
            this.cmbOverrideStateInsurance.Name = "cmbOverrideStateInsurance";
            this.cmbOverrideStateInsurance.Size = new System.Drawing.Size(207, 21);
            this.cmbOverrideStateInsurance.TabIndex = 27;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(622, 673);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lnkOpenConfig);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLocalName);
            this.Controls.Add(this.chkEclaimsShowSecondaryAmounts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApexConfigLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.txtEclaimsSaveFolder);
            this.Controls.Add(this.chkUseAdvancedVideo);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblLocalComputerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxClaimsInBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxClaims)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbResendRevisit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbApexRevisitDate)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkUseAdvancedVideo;
        private System.Windows.Forms.TextBox txtEclaimsSaveFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmbMaxClaims;
        private System.Windows.Forms.TextBox txtApexConfigLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbResendStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbResendRevisit;
        private System.Windows.Forms.CheckBox chkResendRevisit;
        private System.Windows.Forms.CheckBox chkResendStatus;
        private System.Windows.Forms.CheckBox chkEclaimsShowSecondaryAmounts;
        private System.Windows.Forms.TextBox txtLocalName;
        private System.Windows.Forms.Label lblLocalComputerName;
        private System.Windows.Forms.NumericUpDown nmbMaxClaimsInBatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpPredetermLimitDate;
        private System.Windows.Forms.CheckBox chkLimitPredetermOnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkStatusOnApex;
        private System.Windows.Forms.ComboBox cmbStatusOnApex;
        private System.Windows.Forms.CheckBox chkStatusOnApexResend;
        private System.Windows.Forms.ComboBox cmbStatusOnApexResend;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQNB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQNF1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQNF4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQNB4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQNF3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQNB3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQNF2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQNB2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lnkOpenConfig;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nmbApexRevisitDate;
        private System.Windows.Forms.CheckBox chkApexRevisitDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbOverrideStateInsurance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbOverrideStateNewProviderID;
        private System.Windows.Forms.TextBox txtOverrideStateState;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbOverrideStateProviderID;
        private System.Windows.Forms.CheckBox chkOverrideProviderByState;
    }
}