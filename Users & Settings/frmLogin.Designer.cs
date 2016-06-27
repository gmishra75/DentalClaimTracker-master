namespace C_DentalClaimTracker
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAdministrative = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkOpenExclusive = new System.Windows.Forms.CheckBox();
            this.lnkAdministrativeFunctions = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.pnlAdministrative.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdLogin.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLogin.Image = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise;
            this.cmdLogin.Location = new System.Drawing.Point(69, 5);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(101, 44);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(5, 26);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(58, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "E&xit";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(6, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(165, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(6, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.cmdLogin);
            this.pnlBottom.Controls.Add(this.cmdCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 105);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(180, 55);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlAdministrative
            // 
            this.pnlAdministrative.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlAdministrative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdministrative.Controls.Add(this.label3);
            this.pnlAdministrative.Controls.Add(this.chkOpenExclusive);
            this.pnlAdministrative.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdministrative.Location = new System.Drawing.Point(0, 58);
            this.pnlAdministrative.Name = "pnlAdministrative";
            this.pnlAdministrative.Size = new System.Drawing.Size(180, 47);
            this.pnlAdministrative.TabIndex = 1;
            this.pnlAdministrative.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = global::C_DentalClaimTracker.Properties.Settings.Default.LastUpdate;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // chkOpenExclusive
            // 
            this.chkOpenExclusive.AutoSize = true;
            this.chkOpenExclusive.Location = new System.Drawing.Point(6, 9);
            this.chkOpenExclusive.Name = "chkOpenExclusive";
            this.chkOpenExclusive.Size = new System.Drawing.Size(133, 17);
            this.chkOpenExclusive.TabIndex = 1;
            this.chkOpenExclusive.Text = "Open Exclusive (&Lock)";
            this.chkOpenExclusive.UseVisualStyleBackColor = true;
            // 
            // lnkAdministrativeFunctions
            // 
            this.lnkAdministrativeFunctions.AutoSize = true;
            this.lnkAdministrativeFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkAdministrativeFunctions.ForeColor = System.Drawing.Color.White;
            this.lnkAdministrativeFunctions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnkAdministrativeFunctions.Location = new System.Drawing.Point(60, 84);
            this.lnkAdministrativeFunctions.Name = "lnkAdministrativeFunctions";
            this.lnkAdministrativeFunctions.Size = new System.Drawing.Size(111, 13);
            this.lnkAdministrativeFunctions.TabIndex = 2;
            this.lnkAdministrativeFunctions.TabStop = true;
            this.lnkAdministrativeFunctions.Text = "&Administrative Options";
            this.lnkAdministrativeFunctions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdministrativeFunctions_LinkClicked);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.gradient61238115;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtUserName);
            this.pnlMain.Controls.Add(this.lnkAdministrativeFunctions);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(180, 58);
            this.pnlMain.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(180, 160);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlAdministrative);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlAdministrative.ResumeLayout(false);
            this.pnlAdministrative.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlAdministrative;
        private System.Windows.Forms.CheckBox chkOpenExclusive;
        private System.Windows.Forms.LinkLabel lnkAdministrativeFunctions;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label3;
    }
}