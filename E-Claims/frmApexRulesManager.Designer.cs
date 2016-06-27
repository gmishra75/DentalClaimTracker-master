namespace C_DentalClaimTracker.E_Claims
{
    partial class frmApexRulesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApexRulesManager));
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colRuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuleText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProviderInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSecondary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPredeterm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuleObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblSearchOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(823, 56);
            this.lblSearchOptions.TabIndex = 11;
            this.lblSearchOptions.Text = "Apex Rules Manager";
            this.lblSearchOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleID,
            this.colRuleText,
            this.colProviderInfo,
            this.colEndDate,
            this.colSecondary,
            this.colPredeterm,
            this.colInsurance,
            this.colRuleObject});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 56);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(823, 395);
            this.dgvMain.TabIndex = 13;
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            this.dgvMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentDoubleClick);
            this.dgvMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMain_KeyDown);
            // 
            // colRuleID
            // 
            this.colRuleID.HeaderText = "Name";
            this.colRuleID.Name = "colRuleID";
            this.colRuleID.ReadOnly = true;
            // 
            // colRuleText
            // 
            this.colRuleText.HeaderText = "Text";
            this.colRuleText.Name = "colRuleText";
            this.colRuleText.ReadOnly = true;
            this.colRuleText.Width = 120;
            // 
            // colProviderInfo
            // 
            this.colProviderInfo.HeaderText = "Procedure Codes";
            this.colProviderInfo.Name = "colProviderInfo";
            this.colProviderInfo.ReadOnly = true;
            this.colProviderInfo.Width = 200;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "PRM";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEndDate.Width = 40;
            // 
            // colSecondary
            // 
            this.colSecondary.HeaderText = "SEC";
            this.colSecondary.Name = "colSecondary";
            this.colSecondary.ReadOnly = true;
            this.colSecondary.Width = 40;
            // 
            // colPredeterm
            // 
            this.colPredeterm.HeaderText = "PRE";
            this.colPredeterm.Name = "colPredeterm";
            this.colPredeterm.ReadOnly = true;
            this.colPredeterm.Width = 40;
            // 
            // colInsurance
            // 
            this.colInsurance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInsurance.HeaderText = "Insurance Company List";
            this.colInsurance.Name = "colInsurance";
            this.colInsurance.ReadOnly = true;
            // 
            // colRuleObject
            // 
            this.colRuleObject.HeaderText = "Rule Object";
            this.colRuleObject.Name = "colRuleObject";
            this.colRuleObject.ReadOnly = true;
            this.colRuleObject.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 91);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 89);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 69);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reminders";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_add;
            this.btnAddRule.Location = new System.Drawing.Point(685, 9);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(126, 39);
            this.btnAddRule.TabIndex = 12;
            this.btnAddRule.Text = "&Add Rule";
            this.btnAddRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // frmApexRulesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.lblSearchOptions);
            this.Name = "frmApexRulesManager";
            this.Text = "Apex Rules Manager";
            this.Load += new System.EventHandler(this.frmApexRulesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProviderInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSecondary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPredeterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleObject;
    }
}