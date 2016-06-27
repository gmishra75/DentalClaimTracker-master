namespace C_DentalClaimTracker
{
    partial class frmConfigureSchema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigureSchema));
            this.lnkRegenerateMappings = new System.Windows.Forms.LinkLabel();
            this.dgvMappings = new System.Windows.Forms.DataGridView();
            this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkedField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtSchemaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSQLDataType = new System.Windows.Forms.Panel();
            this.txtClaimDBColumn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrimary = new System.Windows.Forms.TabPage();
            this.tabSecondary = new System.Windows.Forms.TabPage();
            this.txtSQLSecondary = new System.Windows.Forms.TextBox();
            this.tabPredeterm = new System.Windows.Forms.TabPage();
            this.txtSQLPredeterm = new System.Windows.Forms.TextBox();
            this.txtDateColumn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompanyNameColumn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClaimIDColumn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAllowSavePassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tabSecPredeterm = new System.Windows.Forms.TabPage();
            this.txtSQLSecondaryPredeterm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).BeginInit();
            this.pnlSQLDataType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPrimary.SuspendLayout();
            this.tabSecondary.SuspendLayout();
            this.tabPredeterm.SuspendLayout();
            this.tabSecPredeterm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkRegenerateMappings
            // 
            this.lnkRegenerateMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRegenerateMappings.AutoSize = true;
            this.lnkRegenerateMappings.Location = new System.Drawing.Point(810, 9);
            this.lnkRegenerateMappings.Name = "lnkRegenerateMappings";
            this.lnkRegenerateMappings.Size = new System.Drawing.Size(112, 13);
            this.lnkRegenerateMappings.TabIndex = 1;
            this.lnkRegenerateMappings.TabStop = true;
            this.lnkRegenerateMappings.Text = "Regenerate Mappings";
            this.lnkRegenerateMappings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegenerateMappings_LinkClicked);
            // 
            // dgvMappings
            // 
            this.dgvMappings.AllowUserToAddRows = false;
            this.dgvMappings.AllowUserToDeleteRows = false;
            this.dgvMappings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMappings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMappings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTable,
            this.colLocal,
            this.colLinkedField,
            this.colFieldData});
            this.dgvMappings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMappings.Location = new System.Drawing.Point(12, 49);
            this.dgvMappings.MultiSelect = false;
            this.dgvMappings.Name = "dgvMappings";
            this.dgvMappings.RowHeadersVisible = false;
            this.dgvMappings.Size = new System.Drawing.Size(500, 553);
            this.dgvMappings.TabIndex = 2;
            this.dgvMappings.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMappings_CellBeginEdit);
            // 
            // colTable
            // 
            this.colTable.DataPropertyName = "TableName";
            this.colTable.HeaderText = "Local Table";
            this.colTable.Name = "colTable";
            this.colTable.Width = 125;
            // 
            // colLocal
            // 
            this.colLocal.DataPropertyName = "FieldName";
            this.colLocal.HeaderText = "Local Field";
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            this.colLocal.Width = 150;
            // 
            // colLinkedField
            // 
            this.colLinkedField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLinkedField.DataPropertyName = "LinkedField";
            this.colLinkedField.HeaderText = "Linked Field";
            this.colLinkedField.Name = "colLinkedField";
            // 
            // colFieldData
            // 
            this.colFieldData.DataPropertyName = "FieldData";
            this.colFieldData.HeaderText = "Field Data";
            this.colFieldData.Name = "colFieldData";
            this.colFieldData.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(860, 579);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(62, 23);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtSchemaName
            // 
            this.txtSchemaName.Location = new System.Drawing.Point(15, 23);
            this.txtSchemaName.Name = "txtSchemaName";
            this.txtSchemaName.Size = new System.Drawing.Size(182, 20);
            this.txtSchemaName.TabIndex = 4;
            this.txtSchemaName.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Schema Name";
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Location = new System.Drawing.Point(3, 3);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(373, 267);
            this.txtSQL.TabIndex = 6;
            this.txtSQL.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SQL Statements";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDataType
            // 
            this.cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(208, 22);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(121, 21);
            this.cmbDataType.TabIndex = 8;
            this.cmbDataType.SelectedIndexChanged += new System.EventHandler(this.cmbDataType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(205, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Type";
            // 
            // pnlSQLDataType
            // 
            this.pnlSQLDataType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSQLDataType.Controls.Add(this.txtClaimDBColumn);
            this.pnlSQLDataType.Controls.Add(this.label10);
            this.pnlSQLDataType.Controls.Add(this.tabControl1);
            this.pnlSQLDataType.Controls.Add(this.txtDateColumn);
            this.pnlSQLDataType.Controls.Add(this.label7);
            this.pnlSQLDataType.Controls.Add(this.txtCompanyNameColumn);
            this.pnlSQLDataType.Controls.Add(this.label8);
            this.pnlSQLDataType.Controls.Add(this.txtClaimIDColumn);
            this.pnlSQLDataType.Controls.Add(this.label9);
            this.pnlSQLDataType.Controls.Add(this.chkAllowSavePassword);
            this.pnlSQLDataType.Controls.Add(this.txtPassword);
            this.pnlSQLDataType.Controls.Add(this.lblPassword);
            this.pnlSQLDataType.Controls.Add(this.txtUserName);
            this.pnlSQLDataType.Controls.Add(this.label6);
            this.pnlSQLDataType.Controls.Add(this.txtDatabaseName);
            this.pnlSQLDataType.Controls.Add(this.label5);
            this.pnlSQLDataType.Controls.Add(this.txtServerName);
            this.pnlSQLDataType.Controls.Add(this.label4);
            this.pnlSQLDataType.Controls.Add(this.label2);
            this.pnlSQLDataType.Location = new System.Drawing.Point(518, 49);
            this.pnlSQLDataType.Name = "pnlSQLDataType";
            this.pnlSQLDataType.Size = new System.Drawing.Size(404, 515);
            this.pnlSQLDataType.TabIndex = 10;
            this.pnlSQLDataType.Visible = false;
            // 
            // txtClaimDBColumn
            // 
            this.txtClaimDBColumn.Location = new System.Drawing.Point(10, 66);
            this.txtClaimDBColumn.Name = "txtClaimDBColumn";
            this.txtClaimDBColumn.Size = new System.Drawing.Size(181, 20);
            this.txtClaimDBColumn.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Location = new System.Drawing.Point(7, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 36);
            this.label10.TabIndex = 24;
            this.label10.Text = "Claim DB column";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPrimary);
            this.tabControl1.Controls.Add(this.tabSecondary);
            this.tabControl1.Controls.Add(this.tabPredeterm);
            this.tabControl1.Controls.Add(this.tabSecPredeterm);
            this.tabControl1.Location = new System.Drawing.Point(7, 213);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 299);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPrimary
            // 
            this.tabPrimary.Controls.Add(this.txtSQL);
            this.tabPrimary.Location = new System.Drawing.Point(4, 22);
            this.tabPrimary.Name = "tabPrimary";
            this.tabPrimary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimary.Size = new System.Drawing.Size(379, 273);
            this.tabPrimary.TabIndex = 0;
            this.tabPrimary.Text = "Standard Claims";
            this.tabPrimary.UseVisualStyleBackColor = true;
            // 
            // tabSecondary
            // 
            this.tabSecondary.Controls.Add(this.txtSQLSecondary);
            this.tabSecondary.Location = new System.Drawing.Point(4, 22);
            this.tabSecondary.Name = "tabSecondary";
            this.tabSecondary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondary.Size = new System.Drawing.Size(379, 273);
            this.tabSecondary.TabIndex = 1;
            this.tabSecondary.Text = "Secondary Claims";
            this.tabSecondary.UseVisualStyleBackColor = true;
            // 
            // txtSQLSecondary
            // 
            this.txtSQLSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLSecondary.Location = new System.Drawing.Point(3, 3);
            this.txtSQLSecondary.Multiline = true;
            this.txtSQLSecondary.Name = "txtSQLSecondary";
            this.txtSQLSecondary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLSecondary.Size = new System.Drawing.Size(373, 267);
            this.txtSQLSecondary.TabIndex = 7;
            // 
            // tabPredeterm
            // 
            this.tabPredeterm.Controls.Add(this.txtSQLPredeterm);
            this.tabPredeterm.Location = new System.Drawing.Point(4, 22);
            this.tabPredeterm.Name = "tabPredeterm";
            this.tabPredeterm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPredeterm.Size = new System.Drawing.Size(379, 273);
            this.tabPredeterm.TabIndex = 2;
            this.tabPredeterm.Text = "Predeterm claims";
            this.tabPredeterm.UseVisualStyleBackColor = true;
            // 
            // txtSQLPredeterm
            // 
            this.txtSQLPredeterm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLPredeterm.Location = new System.Drawing.Point(3, 3);
            this.txtSQLPredeterm.Multiline = true;
            this.txtSQLPredeterm.Name = "txtSQLPredeterm";
            this.txtSQLPredeterm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLPredeterm.Size = new System.Drawing.Size(373, 267);
            this.txtSQLPredeterm.TabIndex = 7;
            // 
            // txtDateColumn
            // 
            this.txtDateColumn.Location = new System.Drawing.Point(202, 113);
            this.txtDateColumn.Name = "txtDateColumn";
            this.txtDateColumn.Size = new System.Drawing.Size(181, 20);
            this.txtDateColumn.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(199, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Date column";
            // 
            // txtCompanyNameColumn
            // 
            this.txtCompanyNameColumn.Location = new System.Drawing.Point(202, 68);
            this.txtCompanyNameColumn.Name = "txtCompanyNameColumn";
            this.txtCompanyNameColumn.Size = new System.Drawing.Size(181, 20);
            this.txtCompanyNameColumn.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(199, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insurance Company name column";
            // 
            // txtClaimIDColumn
            // 
            this.txtClaimIDColumn.Location = new System.Drawing.Point(202, 23);
            this.txtClaimIDColumn.Name = "txtClaimIDColumn";
            this.txtClaimIDColumn.Size = new System.Drawing.Size(181, 20);
            this.txtClaimIDColumn.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(199, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Claim ID column";
            // 
            // chkAllowSavePassword
            // 
            this.chkAllowSavePassword.Location = new System.Drawing.Point(314, 144);
            this.chkAllowSavePassword.Name = "chkAllowSavePassword";
            this.chkAllowSavePassword.Size = new System.Drawing.Size(76, 40);
            this.chkAllowSavePassword.TabIndex = 16;
            this.chkAllowSavePassword.Text = "Save Password";
            this.chkAllowSavePassword.UseVisualStyleBackColor = true;
            this.chkAllowSavePassword.CheckedChanged += new System.EventHandler(this.chkAllowSavePassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(106, 20);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Visible = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassword.Location = new System.Drawing.Point(199, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 36);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            this.lblPassword.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 156);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 20);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(10, 111);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(181, 20);
            this.txtDatabaseName.TabIndex = 10;
            this.txtDatabaseName.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(10, 23);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(181, 20);
            this.txtServerName.TabIndex = 8;
            this.txtServerName.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Server Name";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(793, 579);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(61, 23);
            this.cmdClose.TabIndex = 12;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tabSecPredeterm
            // 
            this.tabSecPredeterm.Controls.Add(this.txtSQLSecondaryPredeterm);
            this.tabSecPredeterm.Location = new System.Drawing.Point(4, 22);
            this.tabSecPredeterm.Name = "tabSecPredeterm";
            this.tabSecPredeterm.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecPredeterm.Size = new System.Drawing.Size(379, 273);
            this.tabSecPredeterm.TabIndex = 3;
            this.tabSecPredeterm.Text = "Secondary Predeterm";
            this.tabSecPredeterm.UseVisualStyleBackColor = true;
            // 
            // txtSQLSecondaryPredeterm
            // 
            this.txtSQLSecondaryPredeterm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQLSecondaryPredeterm.Location = new System.Drawing.Point(3, 3);
            this.txtSQLSecondaryPredeterm.Multiline = true;
            this.txtSQLSecondaryPredeterm.Name = "txtSQLSecondaryPredeterm";
            this.txtSQLSecondaryPredeterm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQLSecondaryPredeterm.Size = new System.Drawing.Size(373, 267);
            this.txtSQLSecondaryPredeterm.TabIndex = 8;
            // 
            // frmConfigureSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 614);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.pnlSQLDataType);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.txtSchemaName);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dgvMappings);
            this.Controls.Add(this.lnkRegenerateMappings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigureSchema";
            this.Text = "Configure Schema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfigureSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).EndInit();
            this.pnlSQLDataType.ResumeLayout(false);
            this.pnlSQLDataType.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPrimary.ResumeLayout(false);
            this.tabPrimary.PerformLayout();
            this.tabSecondary.ResumeLayout(false);
            this.tabSecondary.PerformLayout();
            this.tabPredeterm.ResumeLayout(false);
            this.tabPredeterm.PerformLayout();
            this.tabSecPredeterm.ResumeLayout(false);
            this.tabSecPredeterm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkRegenerateMappings;
        private System.Windows.Forms.DataGridView dgvMappings;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtSchemaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSQLDataType;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAllowSavePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkedField;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldData;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TextBox txtDateColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompanyNameColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClaimIDColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrimary;
        private System.Windows.Forms.TabPage tabSecondary;
        private System.Windows.Forms.TabPage tabPredeterm;
        private System.Windows.Forms.TextBox txtSQLSecondary;
        private System.Windows.Forms.TextBox txtSQLPredeterm;
        private System.Windows.Forms.TextBox txtClaimDBColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabSecPredeterm;
        private System.Windows.Forms.TextBox txtSQLSecondaryPredeterm;
    }
}