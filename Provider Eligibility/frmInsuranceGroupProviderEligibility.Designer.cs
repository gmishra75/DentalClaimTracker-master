namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmInsuranceGroupProviderEligibility
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
            this.lnkShowPrimary = new System.Windows.Forms.LinkLabel();
            this.txtPrimaryProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkShowPrimary
            // 
            this.lnkShowPrimary.AutoSize = true;
            this.lnkShowPrimary.Location = new System.Drawing.Point(12, 9);
            this.lnkShowPrimary.Name = "lnkShowPrimary";
            this.lnkShowPrimary.Size = new System.Drawing.Size(125, 13);
            this.lnkShowPrimary.TabIndex = 0;
            this.lnkShowPrimary.TabStop = true;
            this.lnkShowPrimary.Text = "Select Primary Provider...";
            this.lnkShowPrimary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtPrimaryProvider
            // 
            this.txtPrimaryProvider.Location = new System.Drawing.Point(15, 25);
            this.txtPrimaryProvider.Name = "txtPrimaryProvider";
            this.txtPrimaryProvider.Size = new System.Drawing.Size(191, 20);
            this.txtPrimaryProvider.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "If a provider lacks certification for a given group, the primary provider\'s certi" +
                "fication covers other providers.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 35);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddRule);
            this.panel2.Controls.Add(this.lnkShowPrimary);
            this.panel2.Controls.Add(this.txtPrimaryProvider);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 51);
            this.panel2.TabIndex = 4;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupName,
            this.colGroupDesc,
            this.colFilters,
            this.colGroupObject});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 51);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(711, 235);
            this.dgvMain.TabIndex = 5;
            // 
            // colGroupName
            // 
            this.colGroupName.HeaderText = "Name";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            this.colGroupName.Width = 110;
            // 
            // colGroupDesc
            // 
            this.colGroupDesc.HeaderText = "Description";
            this.colGroupDesc.Name = "colGroupDesc";
            this.colGroupDesc.ReadOnly = true;
            this.colGroupDesc.Width = 200;
            // 
            // colFilters
            // 
            this.colFilters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilters.HeaderText = "Filters";
            this.colFilters.Name = "colFilters";
            this.colFilters.ReadOnly = true;
            // 
            // colGroupObject
            // 
            this.colGroupObject.HeaderText = "INS";
            this.colGroupObject.Name = "colGroupObject";
            this.colGroupObject.ReadOnly = true;
            this.colGroupObject.Visible = false;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Enabled = false;
            this.btnAddRule.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_add;
            this.btnAddRule.Location = new System.Drawing.Point(573, 6);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(126, 39);
            this.btnAddRule.TabIndex = 11;
            this.btnAddRule.Text = "&Add Exception";
            this.btnAddRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClose.Location = new System.Drawing.Point(609, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(102, 35);
            this.cmdClose.TabIndex = 13;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmInsuranceGroupProviderEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 321);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInsuranceGroupProviderEligibility";
            this.Text = "IG: Provider Eligibility";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkShowPrimary;
        private System.Windows.Forms.TextBox txtPrimaryProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupObject;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button cmdClose;
    }
}