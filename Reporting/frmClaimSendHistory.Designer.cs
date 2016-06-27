namespace C_DentalClaimTracker.Reporting
{
    partial class frmClaimSendHistory
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colProviderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProviderInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPERObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colINSObjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.pnlMatchingClaims = new System.Windows.Forms.Panel();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaimObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMatchingClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProviderID,
            this.colProviderInfo,
            this.colStartDate,
            this.colEndDate,
            this.colInsurance,
            this.Column1,
            this.Column2,
            this.colPERObject,
            this.colINSObjects,
            this.colMonth,
            this.colYear});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 53);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(948, 295);
            this.dgvMain.TabIndex = 11;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // colProviderID
            // 
            this.colProviderID.HeaderText = "Date";
            this.colProviderID.Name = "colProviderID";
            this.colProviderID.ReadOnly = true;
            this.colProviderID.Width = 90;
            // 
            // colProviderInfo
            // 
            this.colProviderInfo.HeaderText = "Count";
            this.colProviderInfo.Name = "colProviderInfo";
            this.colProviderInfo.ReadOnly = true;
            this.colProviderInfo.Width = 75;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "< 30";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Width = 75;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "30-45";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Width = 75;
            // 
            // colInsurance
            // 
            this.colInsurance.HeaderText = "46-60";
            this.colInsurance.Name = "colInsurance";
            this.colInsurance.ReadOnly = true;
            this.colInsurance.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "61-75";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "> 76";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // colPERObject
            // 
            this.colPERObject.HeaderText = "Paid";
            this.colPERObject.Name = "colPERObject";
            this.colPERObject.ReadOnly = true;
            this.colPERObject.Width = 75;
            // 
            // colINSObjects
            // 
            this.colINSObjects.HeaderText = "Unpaid";
            this.colINSObjects.Name = "colINSObjects";
            this.colINSObjects.ReadOnly = true;
            this.colINSObjects.Width = 75;
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            this.colMonth.Visible = false;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 115);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cmdSearch);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 113);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(336, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 70);
            this.label5.TabIndex = 20;
            this.label5.Text = "Type in parts of companies you want to search for. \r\n- Use \"%\" for wildcard. \r\n- " +
                "Use \",\" to separate searches. \r\n- Use \'-\' to specify NOT LIKE.\r\n- Examples: \"BCB" +
                "S\", \"%Blue%,Anthem,-%Federal%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Company Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 72);
            this.textBox1.TabIndex = 18;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.cmdSearch.Location = new System.Drawing.Point(807, 60);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(136, 50);
            this.cmdSearch.TabIndex = 17;
            this.cmdSearch.Text = "Refresh";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(14, 69);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(101, 20);
            this.dtpEnd.TabIndex = 16;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(14, 36);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(101, 20);
            this.dtpStart.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Options";
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblSearchOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(948, 53);
            this.lblSearchOptions.TabIndex = 13;
            this.lblSearchOptions.Text = "Claim Payment History";
            this.lblSearchOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMatchingClaims
            // 
            this.pnlMatchingClaims.Controls.Add(this.dgvMatches);
            this.pnlMatchingClaims.Controls.Add(this.panel2);
            this.pnlMatchingClaims.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMatchingClaims.Location = new System.Drawing.Point(0, 348);
            this.pnlMatchingClaims.Name = "pnlMatchingClaims";
            this.pnlMatchingClaims.Size = new System.Drawing.Size(948, 183);
            this.pnlMatchingClaims.TabIndex = 14;
            this.pnlMatchingClaims.Visible = false;
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientName,
            this.colDOB,
            this.colCompanyName,
            this.colAmount,
            this.colDOS,
            this.colType,
            this.colProvider,
            this.colID,
            this.colDB,
            this.colClaimObject});
            this.dgvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatches.Location = new System.Drawing.Point(0, 36);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(948, 147);
            this.dgvMatches.TabIndex = 0;
            this.dgvMatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 36);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Matching Claims";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // colDOS
            // 
            this.colDOS.HeaderText = "DOS";
            this.colDOS.Name = "colDOS";
            this.colDOS.ReadOnly = true;
            this.colDOS.Width = 110;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 120;
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            this.colProvider.Width = 120;
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
            // frmClaimSendHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 646);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlMatchingClaims);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSearchOptions);
            this.Name = "frmClaimSendHistory";
            this.Text = "Claim Payment History";
            this.Load += new System.EventHandler(this.frmClaimSendHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMatchingClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProviderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProviderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPERObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colINSObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.Panel pnlMatchingClaims;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaimObject;
    }
}