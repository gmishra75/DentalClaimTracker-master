namespace C_DentalClaimTracker.Reporting
{
    partial class frmCodePaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodePaymentHistory));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumClaims = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsuranceCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMatchingClaims = new System.Windows.Forms.Panel();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeductable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMatchingClaims = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlPatientInformation = new System.Windows.Forms.Panel();
            this.radSimilar = new System.Windows.Forms.RadioButton();
            this.radExact = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlInsuranceCompanies = new System.Windows.Forms.Panel();
            this.clbInsurance = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlInsuranceGroups = new System.Windows.Forms.Panel();
            this.clbInsuranceGroups = new System.Windows.Forms.CheckedListBox();
            this.lnkClearInsurance = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.clbProviders = new System.Windows.Forms.CheckedListBox();
            this.lnkUncheckAll = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcedureCode = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDateDuration = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmbMaxMatches = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblResultsSummary = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.imgSearchMode = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnInsurance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlMatchingClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlPatientInformation.SuspendLayout();
            this.pnlInsuranceCompanies.SuspendLayout();
            this.pnlInsuranceGroups.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxMatches)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentAmount,
            this.colPercent,
            this.colNumClaims,
            this.colProcCode,
            this.colDateCriteria,
            this.colInsuranceCriteria,
            this.colAmountActual});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 285);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1014, 208);
            this.dgvMain.TabIndex = 15;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.HeaderText = "Payment Amount";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            this.colPaymentAmount.Width = 150;
            // 
            // colPercent
            // 
            this.colPercent.HeaderText = "Percent";
            this.colPercent.Name = "colPercent";
            this.colPercent.ReadOnly = true;
            // 
            // colNumClaims
            // 
            this.colNumClaims.HeaderText = "Number";
            this.colNumClaims.Name = "colNumClaims";
            this.colNumClaims.ReadOnly = true;
            // 
            // colProcCode
            // 
            this.colProcCode.HeaderText = "Proc Code";
            this.colProcCode.Name = "colProcCode";
            this.colProcCode.ReadOnly = true;
            // 
            // colDateCriteria
            // 
            this.colDateCriteria.HeaderText = "date Criteria";
            this.colDateCriteria.Name = "colDateCriteria";
            this.colDateCriteria.ReadOnly = true;
            this.colDateCriteria.Visible = false;
            // 
            // colInsuranceCriteria
            // 
            this.colInsuranceCriteria.HeaderText = "Insurance Criteria";
            this.colInsuranceCriteria.Name = "colInsuranceCriteria";
            this.colInsuranceCriteria.ReadOnly = true;
            this.colInsuranceCriteria.Visible = false;
            // 
            // colAmountActual
            // 
            this.colAmountActual.HeaderText = "Actual Amount";
            this.colAmountActual.Name = "colAmountActual";
            this.colAmountActual.ReadOnly = true;
            this.colAmountActual.Visible = false;
            // 
            // pnlMatchingClaims
            // 
            this.pnlMatchingClaims.Controls.Add(this.dgvMatches);
            this.pnlMatchingClaims.Controls.Add(this.panel2);
            this.pnlMatchingClaims.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMatchingClaims.Location = new System.Drawing.Point(0, 493);
            this.pnlMatchingClaims.Name = "pnlMatchingClaims";
            this.pnlMatchingClaims.Size = new System.Drawing.Size(1014, 183);
            this.pnlMatchingClaims.TabIndex = 18;
            this.pnlMatchingClaims.Visible = false;
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientName,
            this.colDOB,
            this.colCompanyName,
            this.colAmount,
            this.colDeductable,
            this.colDOS,
            this.colType,
            this.colProvider,
            this.colGroupName,
            this.colGroupNo,
            this.colID,
            this.colDB,
            this.colClaimObject});
            this.dgvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatches.Location = new System.Drawing.Point(0, 36);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(1014, 147);
            this.dgvMatches.TabIndex = 0;
            this.dgvMatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellDoubleClick);
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "Name";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 125;
            // 
            // colDOB
            // 
            this.colDOB.HeaderText = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            this.colDOB.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompanyName.HeaderText = "Carrier";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // colDeductable
            // 
            this.colDeductable.HeaderText = "Deductable";
            this.colDeductable.Name = "colDeductable";
            this.colDeductable.ReadOnly = true;
            // 
            // colDOS
            // 
            this.colDOS.HeaderText = "DOS";
            this.colDOS.Name = "colDOS";
            this.colDOS.ReadOnly = true;
            this.colDOS.Width = 75;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            this.colProvider.Width = 90;
            // 
            // colGroupName
            // 
            this.colGroupName.HeaderText = "Group Name";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            // 
            // colGroupNo
            // 
            this.colGroupNo.HeaderText = "Group No";
            this.colGroupNo.Name = "colGroupNo";
            this.colGroupNo.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "Dentrix ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colDB
            // 
            this.colDB.HeaderText = "Dentrix DB";
            this.colDB.Name = "colDB";
            this.colDB.ReadOnly = true;
            this.colDB.Visible = false;
            // 
            // colClaimObject
            // 
            this.colClaimObject.HeaderText = "Claim";
            this.colClaimObject.Name = "colClaimObject";
            this.colClaimObject.ReadOnly = true;
            this.colClaimObject.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.lblMatchingClaims);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 36);
            this.panel2.TabIndex = 1;
            // 
            // lblMatchingClaims
            // 
            this.lblMatchingClaims.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMatchingClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchingClaims.ForeColor = System.Drawing.Color.White;
            this.lblMatchingClaims.Location = new System.Drawing.Point(0, 0);
            this.lblMatchingClaims.Name = "lblMatchingClaims";
            this.lblMatchingClaims.Size = new System.Drawing.Size(361, 36);
            this.lblMatchingClaims.TabIndex = 0;
            this.lblMatchingClaims.Text = "Matching Claims";
            this.lblMatchingClaims.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 206);
            this.panel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pnlPatientInformation);
            this.panel1.Controls.Add(this.pnlInsuranceCompanies);
            this.panel1.Controls.Add(this.pnlInsuranceGroups);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 204);
            this.panel1.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmdSearch);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(895, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel7.Size = new System.Drawing.Size(146, 204);
            this.panel7.TabIndex = 28;
            // 
            // pnlPatientInformation
            // 
            this.pnlPatientInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatientInformation.Controls.Add(this.radSimilar);
            this.pnlPatientInformation.Controls.Add(this.radExact);
            this.pnlPatientInformation.Controls.Add(this.label10);
            this.pnlPatientInformation.Controls.Add(this.txtPatientName);
            this.pnlPatientInformation.Controls.Add(this.label9);
            this.pnlPatientInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientInformation.Location = new System.Drawing.Point(714, 0);
            this.pnlPatientInformation.Name = "pnlPatientInformation";
            this.pnlPatientInformation.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlPatientInformation.Size = new System.Drawing.Size(181, 204);
            this.pnlPatientInformation.TabIndex = 27;
            this.pnlPatientInformation.Visible = false;
            // 
            // radSimilar
            // 
            this.radSimilar.AutoSize = true;
            this.radSimilar.Location = new System.Drawing.Point(59, 74);
            this.radSimilar.Name = "radSimilar";
            this.radSimilar.Size = new System.Drawing.Size(55, 17);
            this.radSimilar.TabIndex = 18;
            this.radSimilar.Text = "Similar";
            this.radSimilar.UseVisualStyleBackColor = true;
            // 
            // radExact
            // 
            this.radExact.AutoSize = true;
            this.radExact.Checked = true;
            this.radExact.Location = new System.Drawing.Point(59, 51);
            this.radExact.Name = "radExact";
            this.radExact.Size = new System.Drawing.Size(52, 17);
            this.radExact.TabIndex = 17;
            this.radExact.TabStop = true;
            this.radExact.Text = "Exact";
            this.radExact.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(59, 23);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(117, 22);
            this.txtPatientName.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Patient Information";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInsuranceCompanies
            // 
            this.pnlInsuranceCompanies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInsuranceCompanies.Controls.Add(this.clbInsurance);
            this.pnlInsuranceCompanies.Controls.Add(this.label7);
            this.pnlInsuranceCompanies.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInsuranceCompanies.Location = new System.Drawing.Point(533, 0);
            this.pnlInsuranceCompanies.Name = "pnlInsuranceCompanies";
            this.pnlInsuranceCompanies.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlInsuranceCompanies.Size = new System.Drawing.Size(181, 204);
            this.pnlInsuranceCompanies.TabIndex = 22;
            // 
            // clbInsurance
            // 
            this.clbInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbInsurance.CheckOnClick = true;
            this.clbInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbInsurance.FormattingEnabled = true;
            this.clbInsurance.Location = new System.Drawing.Point(3, 20);
            this.clbInsurance.Name = "clbInsurance";
            this.clbInsurance.Size = new System.Drawing.Size(173, 182);
            this.clbInsurance.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Insurance Companies";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInsuranceGroups
            // 
            this.pnlInsuranceGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInsuranceGroups.Controls.Add(this.clbInsuranceGroups);
            this.pnlInsuranceGroups.Controls.Add(this.lnkClearInsurance);
            this.pnlInsuranceGroups.Controls.Add(this.label1);
            this.pnlInsuranceGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInsuranceGroups.Location = new System.Drawing.Point(352, 0);
            this.pnlInsuranceGroups.Name = "pnlInsuranceGroups";
            this.pnlInsuranceGroups.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlInsuranceGroups.Size = new System.Drawing.Size(181, 204);
            this.pnlInsuranceGroups.TabIndex = 24;
            // 
            // clbInsuranceGroups
            // 
            this.clbInsuranceGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbInsuranceGroups.CheckOnClick = true;
            this.clbInsuranceGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbInsuranceGroups.FormattingEnabled = true;
            this.clbInsuranceGroups.Location = new System.Drawing.Point(3, 20);
            this.clbInsuranceGroups.Name = "clbInsuranceGroups";
            this.clbInsuranceGroups.Size = new System.Drawing.Size(173, 164);
            this.clbInsuranceGroups.TabIndex = 11;
            // 
            // lnkClearInsurance
            // 
            this.lnkClearInsurance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkClearInsurance.Location = new System.Drawing.Point(3, 184);
            this.lnkClearInsurance.Name = "lnkClearInsurance";
            this.lnkClearInsurance.Size = new System.Drawing.Size(173, 18);
            this.lnkClearInsurance.TabIndex = 26;
            this.lnkClearInsurance.TabStop = true;
            this.lnkClearInsurance.Text = "Clear all Insurance Selections";
            this.lnkClearInsurance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearInsurance_LinkClicked);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Insurance Groups";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.clbProviders);
            this.panel14.Controls.Add(this.lnkUncheckAll);
            this.panel14.Controls.Add(this.label13);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(171, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel14.Size = new System.Drawing.Size(181, 204);
            this.panel14.TabIndex = 29;
            // 
            // clbProviders
            // 
            this.clbProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbProviders.FormattingEnabled = true;
            this.clbProviders.Location = new System.Drawing.Point(3, 20);
            this.clbProviders.Name = "clbProviders";
            this.clbProviders.Size = new System.Drawing.Size(173, 164);
            this.clbProviders.TabIndex = 11;
            // 
            // lnkUncheckAll
            // 
            this.lnkUncheckAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkUncheckAll.Location = new System.Drawing.Point(3, 184);
            this.lnkUncheckAll.Name = "lnkUncheckAll";
            this.lnkUncheckAll.Size = new System.Drawing.Size(173, 18);
            this.lnkUncheckAll.TabIndex = 27;
            this.lnkUncheckAll.TabStop = true;
            this.lnkUncheckAll.Text = "Clear All Providers";
            this.lnkUncheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUncheckAll_LinkClicked);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Providers";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 204);
            this.panel4.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.txtProcedureCode);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 102);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(169, 49);
            this.panel12.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Code";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Procedure Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProcedureCode
            // 
            this.txtProcedureCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcedureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedureCode.Location = new System.Drawing.Point(56, 23);
            this.txtProcedureCode.Name = "txtProcedureCode";
            this.txtProcedureCode.Size = new System.Drawing.Size(101, 22);
            this.txtProcedureCode.TabIndex = 11;
            this.txtProcedureCode.TextChanged += new System.EventHandler(this.txtProcedureCode_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.cmbDateDuration);
            this.panel11.Controls.Add(this.dtpEnd);
            this.panel11.Controls.Add(this.dtpStart);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(169, 79);
            this.panel11.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start";
            // 
            // cmbDateDuration
            // 
            this.cmbDateDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateDuration.FormattingEnabled = true;
            this.cmbDateDuration.Items.AddRange(new object[] {
            "1 month",
            "3 months",
            "6 months",
            "12 months",
            "Custom"});
            this.cmbDateDuration.Location = new System.Drawing.Point(56, 30);
            this.cmbDateDuration.Name = "cmbDateDuration";
            this.cmbDateDuration.Size = new System.Drawing.Size(101, 21);
            this.cmbDateDuration.TabIndex = 14;
            this.cmbDateDuration.SelectedIndexChanged += new System.EventHandler(this.cmbDateDuration_SelectedIndexChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(56, 57);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(101, 20);
            this.dtpEnd.TabIndex = 16;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(56, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(101, 20);
            this.dtpStart.TabIndex = 15;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "End";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date Range";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.nmbMaxMatches);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(866, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel10.Size = new System.Drawing.Size(148, 36);
            this.panel10.TabIndex = 25;
            // 
            // nmbMaxMatches
            // 
            this.nmbMaxMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmbMaxMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmbMaxMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbMaxMatches.Location = new System.Drawing.Point(94, 7);
            this.nmbMaxMatches.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbMaxMatches.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbMaxMatches.Name = "nmbMaxMatches";
            this.nmbMaxMatches.Size = new System.Drawing.Size(51, 22);
            this.nmbMaxMatches.TabIndex = 11;
            this.nmbMaxMatches.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max Results";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.panel8.Controls.Add(this.btnClose);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 676);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1014, 35);
            this.panel8.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(921, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.panel9.Controls.Add(this.lblResultsSummary);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 249);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1014, 36);
            this.panel9.TabIndex = 20;
            // 
            // lblResultsSummary
            // 
            this.lblResultsSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblResultsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsSummary.ForeColor = System.Drawing.Color.White;
            this.lblResultsSummary.Location = new System.Drawing.Point(0, 0);
            this.lblResultsSummary.Name = "lblResultsSummary";
            this.lblResultsSummary.Size = new System.Drawing.Size(316, 36);
            this.lblResultsSummary.TabIndex = 0;
            this.lblResultsSummary.Text = "Results Summary";
            this.lblResultsSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(181)))), ((int)(((byte)(222)))));
            this.panel6.Controls.Add(this.btnPatient);
            this.panel6.Controls.Add(this.btnInsurance);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(235, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 41);
            this.panel6.TabIndex = 26;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // imgSearchMode
            // 
            this.imgSearchMode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSearchMode.ImageStream")));
            this.imgSearchMode.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSearchMode.Images.SetKeyName(0, "bullet_purple.png");
            this.imgSearchMode.Images.SetKeyName(1, "bullet_white.png");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblSearchOptions);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1014, 43);
            this.panel5.TabIndex = 29;
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.ForeColor = System.Drawing.Color.White;
            this.lblSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(235, 41);
            this.lblSearchOptions.TabIndex = 18;
            this.lblSearchOptions.Text = "Code Payment History";
            this.lblSearchOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSearch.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.cmdSearch.Location = new System.Drawing.Point(6, 150);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(136, 50);
            this.cmdSearch.TabIndex = 17;
            this.cmdSearch.Text = "&Search";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.White;
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatient.ImageIndex = 1;
            this.btnPatient.ImageList = this.imgSearchMode;
            this.btnPatient.Location = new System.Drawing.Point(136, 0);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(136, 41);
            this.btnPatient.TabIndex = 19;
            this.btnPatient.Text = "By Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnInformation_Click_1);
            // 
            // btnInsurance
            // 
            this.btnInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(155)))), ((int)(((byte)(108)))));
            this.btnInsurance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsurance.ForeColor = System.Drawing.Color.Black;
            this.btnInsurance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsurance.ImageIndex = 0;
            this.btnInsurance.ImageList = this.imgSearchMode;
            this.btnInsurance.Location = new System.Drawing.Point(0, 0);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(136, 41);
            this.btnInsurance.TabIndex = 18;
            this.btnInsurance.Text = "By Insurance";
            this.btnInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsurance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsurance.UseVisualStyleBackColor = false;
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // frmCodePaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pnlMatchingClaims);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Name = "frmCodePaymentHistory";
            this.Text = "Code Payment History";
            this.Load += new System.EventHandler(this.frmCodePaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlMatchingClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlPatientInformation.ResumeLayout(false);
            this.pnlPatientInformation.PerformLayout();
            this.pnlInsuranceCompanies.ResumeLayout(false);
            this.pnlInsuranceGroups.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxMatches)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlMatchingClaims;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMatchingClaims;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProcedureCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlInsuranceGroups;
        private System.Windows.Forms.CheckedListBox clbInsuranceGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInsuranceCompanies;
        private System.Windows.Forms.CheckedListBox clbInsurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblResultsSummary;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmbMaxMatches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkClearInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimObject;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDateDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumClaims;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsuranceCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountActual;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlPatientInformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ImageList imgSearchMode;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.CheckedListBox clbProviders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel lnkUncheckAll;
        private System.Windows.Forms.RadioButton radSimilar;
        private System.Windows.Forms.RadioButton radExact;
    }
}