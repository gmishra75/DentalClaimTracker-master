namespace C_DentalClaimTracker
{
    partial class frmUserManager
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
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdResetPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(176, 82);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(55, 17);
            this.chkIsAdmin.TabIndex = 1;
            this.chkIsAdmin.Text = "Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            this.chkIsAdmin.CheckedChanged += new System.EventHandler(this.chkIsAdmin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // cmdResetPassword
            // 
            this.cmdResetPassword.Location = new System.Drawing.Point(176, 53);
            this.cmdResetPassword.Name = "cmdResetPassword";
            this.cmdResetPassword.Size = new System.Drawing.Size(112, 23);
            this.cmdResetPassword.TabIndex = 3;
            this.cmdResetPassword.Text = "Reset Password";
            this.cmdResetPassword.UseVisualStyleBackColor = true;
            this.cmdResetPassword.Click += new System.EventHandler(this.cmdResetPassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 30);
            this.panel1.TabIndex = 18;
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(108, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Image = global::C_DentalClaimTracker.Properties.Resources.cancel;
            this.cmdRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRemove.Location = new System.Drawing.Point(12, 165);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(72, 24);
            this.cmdRemove.TabIndex = 17;
            this.cmdRemove.Text = "&Remove";
            this.cmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::C_DentalClaimTracker.Properties.Resources.add;
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAdd.Location = new System.Drawing.Point(98, 165);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(72, 24);
            this.cmdAdd.TabIndex = 16;
            this.cmdAdd.Text = " &Add";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(176, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(112, 20);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(12, 25);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(158, 134);
            this.lstUsers.TabIndex = 19;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(176, 105);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(56, 17);
            this.chkIsActive.TabIndex = 20;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 232);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmdResetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.label1);
            this.Name = "frmUserManager";
            this.Text = "User Manager";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdResetPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}