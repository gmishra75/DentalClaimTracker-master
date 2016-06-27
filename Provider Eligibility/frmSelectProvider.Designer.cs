namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmSelectProvider
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
            this.txtProviderID = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenClaim = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colProviderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProviderID
            // 
            this.txtProviderID.Location = new System.Drawing.Point(13, 23);
            this.txtProviderID.Name = "txtProviderID";
            this.txtProviderID.Size = new System.Drawing.Size(100, 20);
            this.txtProviderID.TabIndex = 1;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(117, 23);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(160, 20);
            this.txtProviderName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provider Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Provider ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(306, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 46);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProviderName);
            this.panel1.Controls.Add(this.txtProviderID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 65);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOpenClaim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 55);
            this.panel2.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(227, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenClaim
            // 
            this.btnOpenClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenClaim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClaim.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.btnOpenClaim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenClaim.Location = new System.Drawing.Point(306, 5);
            this.btnOpenClaim.Name = "btnOpenClaim";
            this.btnOpenClaim.Size = new System.Drawing.Size(140, 46);
            this.btnOpenClaim.TabIndex = 3;
            this.btnOpenClaim.Text = "&Open";
            this.btnOpenClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOpenClaim.UseVisualStyleBackColor = true;
            this.btnOpenClaim.Click += new System.EventHandler(this.btnOpenClaim_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProviderID,
            this.colProviderName,
            this.colClaimObject});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 65);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(453, 281);
            this.dgvResults.TabIndex = 30;
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentDoubleClick);
            // 
            // colProviderID
            // 
            this.colProviderID.HeaderText = "ID";
            this.colProviderID.Name = "colProviderID";
            this.colProviderID.ReadOnly = true;
            // 
            // colProviderName
            // 
            this.colProviderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProviderName.HeaderText = "Name";
            this.colProviderName.Name = "colProviderName";
            this.colProviderName.ReadOnly = true;
            // 
            // colClaimObject
            // 
            this.colClaimObject.HeaderText = "claim object";
            this.colClaimObject.Name = "colClaimObject";
            this.colClaimObject.ReadOnly = true;
            this.colClaimObject.Visible = false;
            // 
            // frmSelectProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 401);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSelectProvider";
            this.Text = "Select Provider";
            this.Load += new System.EventHandler(this.frmSelectProvider_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProviderID;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnOpenClaim;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProviderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimObject;
    }
}