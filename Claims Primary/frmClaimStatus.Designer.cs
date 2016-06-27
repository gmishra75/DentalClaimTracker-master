namespace C_DentalClaimTracker
{
    partial class frmClaimStatus
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
            this.cmdAccept = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAsIs = new System.Windows.Forms.Button();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlRevisitDate = new C_DentalClaimTracker.ctlDateEntry();
            this.lblLasRevisitDate = new System.Windows.Forms.Label();
            this.chkSetRevisitDate = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.nmbRevisitInterval = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLastStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRevisitInterval)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAccept
            // 
            this.cmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAccept.Image = global::C_DentalClaimTracker.Properties.Resources.accept;
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(274, 169);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(94, 43);
            this.cmdAccept.TabIndex = 34;
            this.cmdAccept.Text = "   &Accept";
            this.cmdAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdAccept, "Apply the selected changes and close the form");
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancel.Image = global::C_DentalClaimTracker.Properties.Resources.cancel;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(2, 188);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(69, 24);
            this.cmdCancel.TabIndex = 35;
            this.cmdCancel.Text = " &Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdCancel, "Return to the claim without making any changes");
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAsIs
            // 
            this.cmdAsIs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAsIs.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_green1;
            this.cmdAsIs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAsIs.Location = new System.Drawing.Point(77, 188);
            this.cmdAsIs.Name = "cmdAsIs";
            this.cmdAsIs.Size = new System.Drawing.Size(69, 24);
            this.cmdAsIs.TabIndex = 36;
            this.cmdAsIs.Text = " &As is";
            this.cmdAsIs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAsIs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttipMain.SetToolTip(this.cmdAsIs, "Close the claim without making any changes");
            this.cmdAsIs.UseVisualStyleBackColor = false;
            this.cmdAsIs.Click += new System.EventHandler(this.cmdAsIs_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.cmdAccept);
            this.panel5.Controls.Add(this.cmdAsIs);
            this.panel5.Controls.Add(this.cmdCancel);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 217);
            this.panel5.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ctlRevisitDate);
            this.panel1.Controls.Add(this.lblLasRevisitDate);
            this.panel1.Controls.Add(this.chkSetRevisitDate);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.nmbRevisitInterval);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 51);
            this.panel1.TabIndex = 41;
            // 
            // ctlRevisitDate
            // 
            this.ctlRevisitDate.CurrentDate = null;
            this.ctlRevisitDate.DateSelectionVisible = true;
            this.ctlRevisitDate.DateValue = null;
            this.ctlRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlRevisitDate.Location = new System.Drawing.Point(4, 23);
            this.ctlRevisitDate.Name = "ctlRevisitDate";
            this.ctlRevisitDate.ReadOnly = false;
            this.ctlRevisitDate.Size = new System.Drawing.Size(100, 21);
            this.ctlRevisitDate.TabIndex = 26;
            this.ctlRevisitDate.ValueChanged += new System.EventHandler(this.ctlRevisitDate_ValueChanged);
            // 
            // lblLasRevisitDate
            // 
            this.lblLasRevisitDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLasRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLasRevisitDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLasRevisitDate.Location = new System.Drawing.Point(192, 0);
            this.lblLasRevisitDate.Margin = new System.Windows.Forms.Padding(3);
            this.lblLasRevisitDate.Name = "lblLasRevisitDate";
            this.lblLasRevisitDate.Size = new System.Drawing.Size(182, 49);
            this.lblLasRevisitDate.TabIndex = 33;
            this.lblLasRevisitDate.Text = "Revisit Date not set";
            // 
            // chkSetRevisitDate
            // 
            this.chkSetRevisitDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkSetRevisitDate.Checked = true;
            this.chkSetRevisitDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetRevisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSetRevisitDate.Location = new System.Drawing.Point(2, 1);
            this.chkSetRevisitDate.Name = "chkSetRevisitDate";
            this.chkSetRevisitDate.Size = new System.Drawing.Size(118, 21);
            this.chkSetRevisitDate.TabIndex = 32;
            this.chkSetRevisitDate.Text = "Set revisit date";
            this.chkSetRevisitDate.UseVisualStyleBackColor = false;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(151, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(30, 21);
            this.label32.TabIndex = 25;
            this.label32.Text = "days";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmbRevisitInterval
            // 
            this.nmbRevisitInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbRevisitInterval.Location = new System.Drawing.Point(105, 23);
            this.nmbRevisitInterval.Name = "nmbRevisitInterval";
            this.nmbRevisitInterval.Size = new System.Drawing.Size(44, 21);
            this.nmbRevisitInterval.TabIndex = 24;
            this.nmbRevisitInterval.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nmbRevisitInterval.ValueChanged += new System.EventHandler(this.nmbRevisitInterval_ValueChanged);
            this.nmbRevisitInterval.Leave += new System.EventHandler(this.nmbRevisitInterval_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblLastStatus);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 54);
            this.panel2.TabIndex = 37;
            // 
            // lblLastStatus
            // 
            this.lblLastStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLastStatus.Location = new System.Drawing.Point(194, 0);
            this.lblLastStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblLastStatus.Name = "lblLastStatus";
            this.lblLastStatus.Size = new System.Drawing.Size(182, 54);
            this.lblLastStatus.TabIndex = 30;
            this.lblLastStatus.Text = "Last status was \'Waiting for Insurance\' set by Aaron on 4/17/2010";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(4, 22);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbStatus.TabIndex = 28;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(0, 3);
            this.label39.Margin = new System.Windows.Forms.Padding(3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(166, 21);
            this.label39.TabIndex = 29;
            this.label39.Text = "Status";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 57);
            this.panel4.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(112)))), ((int)(((byte)(140)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 55);
            this.label1.TabIndex = 29;
            this.label1.Text = "Set status and revisit date for the claim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmClaimStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 217);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClaimStatus";
            this.Text = "Set Claim Status";
            this.Load += new System.EventHandler(this.frmClaimStatus_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbRevisitInterval)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAsIs;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLasRevisitDate;
        private System.Windows.Forms.CheckBox chkSetRevisitDate;
        private ctlDateEntry ctlRevisitDate;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nmbRevisitInterval;
    }
}