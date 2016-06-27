namespace C_DentalClaimTracker
{
    partial class frmViewActionLog
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chkShowLogins = new System.Windows.Forms.CheckBox();
            this.chkSearchDateRange = new System.Windows.Forms.CheckBox();
            this.grpDateRange = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlShowCall = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCallInfo = new System.Windows.Forms.Label();
            this.cmdHideShowCall = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlCallDisplay = new C_DentalClaimTracker.CallDisplay();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop.SuspendLayout();
            this.grpDateRange.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlShowCall.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.chkShowLogins);
            this.pnlTop.Controls.Add(this.chkSearchDateRange);
            this.pnlTop.Controls.Add(this.grpDateRange);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cmbUsers);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(771, 46);
            this.pnlTop.TabIndex = 0;
            // 
            // chkShowLogins
            // 
            this.chkShowLogins.AutoSize = true;
            this.chkShowLogins.Location = new System.Drawing.Point(478, 19);
            this.chkShowLogins.Name = "chkShowLogins";
            this.chkShowLogins.Size = new System.Drawing.Size(87, 17);
            this.chkShowLogins.TabIndex = 5;
            this.chkShowLogins.Text = "Show Logins";
            this.chkShowLogins.UseVisualStyleBackColor = true;
            this.chkShowLogins.CheckedChanged += new System.EventHandler(this.chkShowLogins_CheckedChanged);
            // 
            // chkSearchDateRange
            // 
            this.chkSearchDateRange.AutoSize = true;
            this.chkSearchDateRange.Checked = true;
            this.chkSearchDateRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearchDateRange.Location = new System.Drawing.Point(247, 3);
            this.chkSearchDateRange.Name = "chkSearchDateRange";
            this.chkSearchDateRange.Size = new System.Drawing.Size(15, 14);
            this.chkSearchDateRange.TabIndex = 4;
            this.chkSearchDateRange.UseVisualStyleBackColor = true;
            this.chkSearchDateRange.CheckedChanged += new System.EventHandler(this.chkSearchDateRange_CheckedChanged);
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.dtpEndDate);
            this.grpDateRange.Controls.Add(this.label3);
            this.grpDateRange.Controls.Add(this.dtpStartDate);
            this.grpDateRange.Controls.Add(this.label2);
            this.grpDateRange.Location = new System.Drawing.Point(178, 3);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.Size = new System.Drawing.Size(294, 40);
            this.grpDateRange.TabIndex = 2;
            this.grpDateRange.TabStop = false;
            this.grpDateRange.Text = "Date Range";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(180, 14);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(106, 20);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(42, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(106, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(3, 19);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(169, 21);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.pnlShowCall);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(771, 306);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.colDate,
            this.colAction,
            this.colNotes,
            this.colClaim});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(771, 206);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // pnlShowCall
            // 
            this.pnlShowCall.Controls.Add(this.ctlCallDisplay);
            this.pnlShowCall.Controls.Add(this.panel2);
            this.pnlShowCall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowCall.Location = new System.Drawing.Point(0, 206);
            this.pnlShowCall.Name = "pnlShowCall";
            this.pnlShowCall.Size = new System.Drawing.Size(771, 100);
            this.pnlShowCall.TabIndex = 1;
            this.pnlShowCall.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCallInfo);
            this.panel2.Controls.Add(this.cmdHideShowCall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 31);
            this.panel2.TabIndex = 3;
            // 
            // lblCallInfo
            // 
            this.lblCallInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCallInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCallInfo.Name = "lblCallInfo";
            this.lblCallInfo.Size = new System.Drawing.Size(746, 31);
            this.lblCallInfo.TabIndex = 1;
            // 
            // cmdHideShowCall
            // 
            this.cmdHideShowCall.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdHideShowCall.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_delete;
            this.cmdHideShowCall.Location = new System.Drawing.Point(746, 0);
            this.cmdHideShowCall.Name = "cmdHideShowCall";
            this.cmdHideShowCall.Size = new System.Drawing.Size(25, 31);
            this.cmdHideShowCall.TabIndex = 0;
            this.cmdHideShowCall.UseVisualStyleBackColor = true;
            this.cmdHideShowCall.Click += new System.EventHandler(this.cmdHideShowCall_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 352);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(771, 33);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlCallDisplay
            // 
            this.ctlCallDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlCallDisplay.Location = new System.Drawing.Point(0, 31);
            this.ctlCallDisplay.Name = "ctlCallDisplay";
            this.ctlCallDisplay.Size = new System.Drawing.Size(771, 69);
            this.ctlCallDisplay.TabIndex = 2;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 75;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 115;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colClaim
            // 
            this.colClaim.HeaderText = "View";
            this.colClaim.Name = "colClaim";
            this.colClaim.ReadOnly = true;
            this.colClaim.Text = "";
            this.colClaim.Width = 80;
            // 
            // frmViewActionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 385);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmViewActionLog";
            this.Text = "User Action Log";
            this.Load += new System.EventHandler(this.frmViewActionLog_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlShowCall.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.GroupBox grpDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkSearchDateRange;
        private System.Windows.Forms.CheckBox chkShowLogins;
        private System.Windows.Forms.Panel pnlShowCall;
        private System.Windows.Forms.Panel panel2;
        private CallDisplay ctlCallDisplay;
        private System.Windows.Forms.Button cmdHideShowCall;
        private System.Windows.Forms.Label lblCallInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewButtonColumn colClaim;
    }
}