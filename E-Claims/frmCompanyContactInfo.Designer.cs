namespace C_DentalClaimTracker
{
    partial class frmCompanyContactInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdUseSelectedAddress = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colInsuranceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(813, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Viewing Extended Contact Information For:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdUseSelectedAddress);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 29);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdUseSelectedAddress
            // 
            this.cmdUseSelectedAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUseSelectedAddress.Location = new System.Drawing.Point(3, 3);
            this.cmdUseSelectedAddress.Name = "cmdUseSelectedAddress";
            this.cmdUseSelectedAddress.Size = new System.Drawing.Size(143, 23);
            this.cmdUseSelectedAddress.TabIndex = 1;
            this.cmdUseSelectedAddress.Text = "&Use Selected Address";
            this.cmdUseSelectedAddress.UseVisualStyleBackColor = true;
            this.cmdUseSelectedAddress.Click += new System.EventHandler(this.cmdUseSelectedAddress_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(735, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(66, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "&OK";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInsuranceCompany,
            this.colPatientName,
            this.colPatientDOB,
            this.colInvoiceAmount,
            this.colGroupNum,
            this.colUpdate,
            this.colClaimObject});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.Location = new System.Drawing.Point(0, 35);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(813, 311);
            this.dgvResults.TabIndex = 62;
            this.dgvResults.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvResults_Paint);
            // 
            // colInsuranceCompany
            // 
            this.colInsuranceCompany.DataPropertyName = "phone";
            this.colInsuranceCompany.HeaderText = "Phone";
            this.colInsuranceCompany.Name = "colInsuranceCompany";
            this.colInsuranceCompany.ReadOnly = true;
            this.colInsuranceCompany.Width = 120;
            // 
            // colPatientName
            // 
            this.colPatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPatientName.DataPropertyName = "address";
            this.colPatientName.HeaderText = "Address";
            this.colPatientName.MinimumWidth = 100;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            // 
            // colPatientDOB
            // 
            this.colPatientDOB.DataPropertyName = "address2";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colPatientDOB.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPatientDOB.HeaderText = "Address Line 2";
            this.colPatientDOB.Name = "colPatientDOB";
            this.colPatientDOB.ReadOnly = true;
            this.colPatientDOB.Width = 150;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.DataPropertyName = "city";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colInvoiceAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvoiceAmount.HeaderText = "City";
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.ReadOnly = true;
            // 
            // colGroupNum
            // 
            this.colGroupNum.DataPropertyName = "state";
            this.colGroupNum.HeaderText = "State";
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.ReadOnly = true;
            this.colGroupNum.Width = 50;
            // 
            // colUpdate
            // 
            this.colUpdate.DataPropertyName = "zip";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.colUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUpdate.HeaderText = "Zip";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Width = 60;
            // 
            // colClaimObject
            // 
            this.colClaimObject.DataPropertyName = "ContactInfo";
            this.colClaimObject.HeaderText = "data";
            this.colClaimObject.Name = "colClaimObject";
            this.colClaimObject.Visible = false;
            this.colClaimObject.Width = 5;
            // 
            // frmCompanyContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 375);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCompanyContactInfo";
            this.Text = "Company Contact Info";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsuranceCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimObject;
        private System.Windows.Forms.Button cmdUseSelectedAddress;
    }
}