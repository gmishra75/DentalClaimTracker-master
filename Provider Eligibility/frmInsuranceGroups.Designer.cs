namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmInsuranceGroups
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditRequirement = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvMain.ContextMenuStrip = this.ctxMenu;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 56);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(760, 444);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            this.dgvMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMain_KeyDown);
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
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
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditRequirement});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(95, 26);
            // 
            // mnuEditRequirement
            // 
            this.mnuEditRequirement.Name = "mnuEditRequirement";
            this.mnuEditRequirement.Size = new System.Drawing.Size(94, 22);
            this.mnuEditRequirement.Text = "&Edit";
            this.mnuEditRequirement.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 43);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 41);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "- Double-click on a group to edit it";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reminders";
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblSearchOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(760, 56);
            this.lblSearchOptions.TabIndex = 5;
            this.lblSearchOptions.Text = "Insurance Groups";
            this.lblSearchOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_add;
            this.btnAddRule.Location = new System.Drawing.Point(622, 9);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(126, 39);
            this.btnAddRule.TabIndex = 10;
            this.btnAddRule.Text = "&Add Group";
            this.btnAddRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClose.Location = new System.Drawing.Point(656, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(102, 41);
            this.cmdClose.TabIndex = 12;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmInsuranceGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 543);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSearchOptions);
            this.Name = "frmInsuranceGroups";
            this.Text = "Insurance Groups";
            this.Load += new System.EventHandler(this.frmProviderEligibilityRestrictions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRequirement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupObject;
        private System.Windows.Forms.Button cmdClose;
    }
}