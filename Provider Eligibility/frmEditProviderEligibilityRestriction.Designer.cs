namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmEditProviderEligibilityRestriction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbToProvider = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ctlEndDate = new C_DentalClaimTracker.ctlDateEntry();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ctlStartDate = new C_DentalClaimTracker.ctlDateEntry();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lstCompaniesInGroup = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstGroupsIncluded = new System.Windows.Forms.ListBox();
            this.cTextGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.cmbInsuranceGroups = new System.Windows.Forms.ComboBox();
            this.lnkEditGroups = new System.Windows.Forms.LinkLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rtbRestrictionSummary = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbForProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pnlForProvider = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.cTextGroups.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlForProvider.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkEnabled);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 32;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnabled.Location = new System.Drawing.Point(4, 22);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(78, 20);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(503, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.btnSave.Location = new System.Drawing.Point(601, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbToProvider
            // 
            this.cmbToProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbToProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToProvider.FormattingEnabled = true;
            this.cmbToProvider.Location = new System.Drawing.Point(0, 90);
            this.cmbToProvider.Name = "cmbToProvider";
            this.cmbToProvider.Size = new System.Drawing.Size(282, 24);
            this.cmbToProvider.TabIndex = 8;
            this.cmbToProvider.SelectedIndexChanged += new System.EventHandler(this.lstSwitchToProvider_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Substitute Provider";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ctlEndDate);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 176);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel6.Size = new System.Drawing.Size(282, 62);
            this.panel6.TabIndex = 31;
            // 
            // ctlEndDate
            // 
            this.ctlEndDate.CurrentDate = null;
            this.ctlEndDate.DateSelectionVisible = true;
            this.ctlEndDate.DateValue = null;
            this.ctlEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlEndDate.Location = new System.Drawing.Point(0, 35);
            this.ctlEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlEndDate.Name = "ctlEndDate";
            this.ctlEndDate.ReadOnly = false;
            this.ctlEndDate.Size = new System.Drawing.Size(282, 32);
            this.ctlEndDate.TabIndex = 30;
            this.ctlEndDate.ValueChanged += new System.EventHandler(this.ctlStartDate_Leave);
            this.ctlEndDate.Leave += new System.EventHandler(this.ctlStartDate_Leave);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "End Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ctlStartDate);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 114);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel7.Size = new System.Drawing.Size(282, 62);
            this.panel7.TabIndex = 32;
            // 
            // ctlStartDate
            // 
            this.ctlStartDate.CurrentDate = null;
            this.ctlStartDate.DateSelectionVisible = true;
            this.ctlStartDate.DateValue = null;
            this.ctlStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlStartDate.Location = new System.Drawing.Point(0, 35);
            this.ctlStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlStartDate.Name = "ctlStartDate";
            this.ctlStartDate.ReadOnly = false;
            this.ctlStartDate.Size = new System.Drawing.Size(282, 32);
            this.ctlStartDate.TabIndex = 26;
            this.ctlStartDate.ValueChanged += new System.EventHandler(this.ctlStartDate_Leave);
            this.ctlStartDate.Leave += new System.EventHandler(this.ctlStartDate_Leave);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Start Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lstCompaniesInGroup);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.lstGroupsIncluded);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(412, 381);
            this.panel10.TabIndex = 10;
            // 
            // lstCompaniesInGroup
            // 
            this.lstCompaniesInGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstCompaniesInGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCompaniesInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompaniesInGroup.FormattingEnabled = true;
            this.lstCompaniesInGroup.IntegralHeight = false;
            this.lstCompaniesInGroup.ItemHeight = 16;
            this.lstCompaniesInGroup.Location = new System.Drawing.Point(0, 145);
            this.lstCompaniesInGroup.Name = "lstCompaniesInGroup";
            this.lstCompaniesInGroup.Size = new System.Drawing.Size(412, 236);
            this.lstCompaniesInGroup.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(412, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Companies in these Groups";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstGroupsIncluded
            // 
            this.lstGroupsIncluded.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstGroupsIncluded.ContextMenuStrip = this.cTextGroups;
            this.lstGroupsIncluded.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstGroupsIncluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGroupsIncluded.FormattingEnabled = true;
            this.lstGroupsIncluded.IntegralHeight = false;
            this.lstGroupsIncluded.ItemHeight = 16;
            this.lstGroupsIncluded.Location = new System.Drawing.Point(0, 44);
            this.lstGroupsIncluded.Name = "lstGroupsIncluded";
            this.lstGroupsIncluded.Size = new System.Drawing.Size(412, 80);
            this.lstGroupsIncluded.TabIndex = 15;
            this.lstGroupsIncluded.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstGroupsIncluded_KeyDown);
            // 
            // cTextGroups
            // 
            this.cTextGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cTextGroups.Name = "cTextGroups";
            this.cTextGroups.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Groups Included (del to remove)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddGroup);
            this.panel2.Controls.Add(this.cmbInsuranceGroups);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 23);
            this.panel2.TabIndex = 16;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddGroup.Location = new System.Drawing.Point(337, 0);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "&Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // cmbInsuranceGroups
            // 
            this.cmbInsuranceGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbInsuranceGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsuranceGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInsuranceGroups.FormattingEnabled = true;
            this.cmbInsuranceGroups.Location = new System.Drawing.Point(0, 0);
            this.cmbInsuranceGroups.Name = "cmbInsuranceGroups";
            this.cmbInsuranceGroups.Size = new System.Drawing.Size(335, 24);
            this.cmbInsuranceGroups.TabIndex = 1;
            this.cmbInsuranceGroups.SelectedIndexChanged += new System.EventHandler(this.cmbInsuranceGroups_SelectedIndexChanged);
            // 
            // lnkEditGroups
            // 
            this.lnkEditGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditGroups.AutoSize = true;
            this.lnkEditGroups.Location = new System.Drawing.Point(349, 11);
            this.lnkEditGroups.Name = "lnkEditGroups";
            this.lnkEditGroups.Size = new System.Drawing.Size(62, 13);
            this.lnkEditGroups.TabIndex = 13;
            this.lnkEditGroups.TabStop = true;
            this.lnkEditGroups.Text = "Edit Groups";
            this.lnkEditGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditGroups_LinkClicked);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.lnkEditGroups);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(282, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(418, 419);
            this.panel8.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(412, 32);
            this.label11.TabIndex = 38;
            this.label11.Text = "Insurance Groups";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.rtbRestrictionSummary);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(700, 146);
            this.panel9.TabIndex = 39;
            // 
            // rtbRestrictionSummary
            // 
            this.rtbRestrictionSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRestrictionSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRestrictionSummary.Location = new System.Drawing.Point(3, 35);
            this.rtbRestrictionSummary.Name = "rtbRestrictionSummary";
            this.rtbRestrictionSummary.Size = new System.Drawing.Size(694, 76);
            this.rtbRestrictionSummary.TabIndex = 3;
            this.rtbRestrictionSummary.Text = "abc\n123";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Lavender;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(694, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Eligibility Restriction Details";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eligibility Restriction Summary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbForProvider
            // 
            this.cmbForProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbForProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForProvider.FormattingEnabled = true;
            this.cmbForProvider.Location = new System.Drawing.Point(0, 32);
            this.cmbForProvider.Name = "cmbForProvider";
            this.cmbForProvider.Size = new System.Drawing.Size(282, 24);
            this.cmbForProvider.TabIndex = 9;
            this.cmbForProvider.SelectedIndexChanged += new System.EventHandler(this.lstForProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base Provider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 146);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(700, 419);
            this.panel11.TabIndex = 40;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel6);
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.cmbToProvider);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.pnlForProvider);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(282, 419);
            this.panel12.TabIndex = 0;
            // 
            // pnlForProvider
            // 
            this.pnlForProvider.Controls.Add(this.cmbForProvider);
            this.pnlForProvider.Controls.Add(this.label1);
            this.pnlForProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForProvider.Location = new System.Drawing.Point(0, 0);
            this.pnlForProvider.Name = "pnlForProvider";
            this.pnlForProvider.Size = new System.Drawing.Size(282, 58);
            this.pnlForProvider.TabIndex = 10;
            // 
            // frmEditProviderEligibilityRestriction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 615);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Name = "frmEditProviderEligibilityRestriction";
            this.Text = "Add New Eligibility Restriction";
            this.Load += new System.EventHandler(this.frmEditProviderEligibilityRestriction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.cTextGroups.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnlForProvider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlDateEntry ctlStartDate;
        private ctlDateEntry ctlEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbRestrictionSummary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbToProvider;
        private System.Windows.Forms.ComboBox cmbInsuranceGroups;
        private System.Windows.Forms.ListBox lstCompaniesInGroup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.ComboBox cmbForProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkEditGroups;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel pnlForProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstGroupsIncluded;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.ContextMenuStrip cTextGroups;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}