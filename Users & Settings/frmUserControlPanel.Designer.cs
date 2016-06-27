namespace C_DentalClaimTracker
{
    partial class frmUserControlPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkPassword = new System.Windows.Forms.LinkLabel();
            this.chkShowClaimSearch = new System.Windows.Forms.CheckBox();
            this.grpWhatToLoad = new System.Windows.Forms.GroupBox();
            this.chkShowEclaims = new System.Windows.Forms.CheckBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbDefaultSearchDate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowMyClaimsFirst = new System.Windows.Forms.CheckBox();
            this.pnlOffices = new System.Windows.Forms.Panel();
            this.lblOffices = new System.Windows.Forms.Label();
            this.grpWhatToLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDefaultSearchDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlOffices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Control Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(12, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(156, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // lnkPassword
            // 
            this.lnkPassword.AutoSize = true;
            this.lnkPassword.Location = new System.Drawing.Point(14, 102);
            this.lnkPassword.Name = "lnkPassword";
            this.lnkPassword.Size = new System.Drawing.Size(102, 13);
            this.lnkPassword.TabIndex = 4;
            this.lnkPassword.TabStop = true;
            this.lnkPassword.Text = "Change Password...";
            this.lnkPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPassword_LinkClicked);
            // 
            // chkShowClaimSearch
            // 
            this.chkShowClaimSearch.AutoSize = true;
            this.chkShowClaimSearch.Location = new System.Drawing.Point(12, 19);
            this.chkShowClaimSearch.Name = "chkShowClaimSearch";
            this.chkShowClaimSearch.Size = new System.Drawing.Size(118, 17);
            this.chkShowClaimSearch.TabIndex = 5;
            this.chkShowClaimSearch.Text = "Show Claim Search";
            this.chkShowClaimSearch.UseVisualStyleBackColor = true;
            this.chkShowClaimSearch.CheckedChanged += new System.EventHandler(this.DataChanged);
            // 
            // grpWhatToLoad
            // 
            this.grpWhatToLoad.Controls.Add(this.chkShowEclaims);
            this.grpWhatToLoad.Controls.Add(this.chkShowClaimSearch);
            this.grpWhatToLoad.Location = new System.Drawing.Point(12, 127);
            this.grpWhatToLoad.Name = "grpWhatToLoad";
            this.grpWhatToLoad.Size = new System.Drawing.Size(200, 67);
            this.grpWhatToLoad.TabIndex = 6;
            this.grpWhatToLoad.TabStop = false;
            this.grpWhatToLoad.Text = "On Startup";
            // 
            // chkShowEclaims
            // 
            this.chkShowEclaims.AutoSize = true;
            this.chkShowEclaims.Location = new System.Drawing.Point(12, 42);
            this.chkShowEclaims.Name = "chkShowEclaims";
            this.chkShowEclaims.Size = new System.Drawing.Size(92, 17);
            this.chkShowEclaims.TabIndex = 6;
            this.chkShowEclaims.Text = "Show Eclaims";
            this.chkShowEclaims.UseVisualStyleBackColor = true;
            this.chkShowEclaims.CheckedChanged += new System.EventHandler(this.DataChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(159, 279);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(53, 23);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(100, 279);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(53, 23);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(70, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Default sent date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmbDefaultSearchDate
            // 
            this.nmbDefaultSearchDate.Location = new System.Drawing.Point(12, 16);
            this.nmbDefaultSearchDate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbDefaultSearchDate.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nmbDefaultSearchDate.Name = "nmbDefaultSearchDate";
            this.nmbDefaultSearchDate.Size = new System.Drawing.Size(52, 20);
            this.nmbDefaultSearchDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "days before today";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowMyClaimsFirst);
            this.groupBox1.Controls.Add(this.nmbDefaultSearchDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Form";
            // 
            // chkShowMyClaimsFirst
            // 
            this.chkShowMyClaimsFirst.AutoSize = true;
            this.chkShowMyClaimsFirst.Location = new System.Drawing.Point(12, 42);
            this.chkShowMyClaimsFirst.Name = "chkShowMyClaimsFirst";
            this.chkShowMyClaimsFirst.Size = new System.Drawing.Size(120, 17);
            this.chkShowMyClaimsFirst.TabIndex = 6;
            this.chkShowMyClaimsFirst.Text = "Show my claims first";
            this.chkShowMyClaimsFirst.UseVisualStyleBackColor = true;
            // 
            // pnlOffices
            // 
            this.pnlOffices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOffices.Controls.Add(this.lblOffices);
            this.pnlOffices.Location = new System.Drawing.Point(364, 44);
            this.pnlOffices.Name = "pnlOffices";
            this.pnlOffices.Size = new System.Drawing.Size(194, 178);
            this.pnlOffices.TabIndex = 13;
            // 
            // lblOffices
            // 
            this.lblOffices.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOffices.Location = new System.Drawing.Point(0, 0);
            this.lblOffices.Name = "lblOffices";
            this.lblOffices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOffices.Size = new System.Drawing.Size(192, 19);
            this.lblOffices.TabIndex = 0;
            this.lblOffices.Text = "Offices";
            // 
            // frmUserControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(563, 307);
            this.Controls.Add(this.pnlOffices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.grpWhatToLoad);
            this.Controls.Add(this.lnkPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserControlPanel";
            this.Text = "User Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserManagement_FormClosing);
            this.grpWhatToLoad.ResumeLayout(false);
            this.grpWhatToLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDefaultSearchDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlOffices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkPassword;
        private System.Windows.Forms.CheckBox chkShowClaimSearch;
        private System.Windows.Forms.GroupBox grpWhatToLoad;
        private System.Windows.Forms.CheckBox chkShowEclaims;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbDefaultSearchDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkShowMyClaimsFirst;
        private System.Windows.Forms.Panel pnlOffices;
        private System.Windows.Forms.Label lblOffices;
    }
}