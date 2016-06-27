namespace C_DentalClaimTracker.E_Claims.Mercury
{
    partial class frmEligibility
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
            this.lnkFullImport = new System.Windows.Forms.LinkLabel();
            this.dtpImportFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkUncheckAll = new System.Windows.Forms.LinkLabel();
            this.lnkCheckAll = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheckEligibility = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmbMaxResults = new System.Windows.Forms.NumericUpDown();
            this.lblMaxResults = new System.Windows.Forms.Label();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnRejected = new System.Windows.Forms.Button();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnUnverified = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblSearching = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAdvanced.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxResults)).BeginInit();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkFullImport
            // 
            this.lnkFullImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkFullImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFullImport.Location = new System.Drawing.Point(2, 2);
            this.lnkFullImport.Name = "lnkFullImport";
            this.lnkFullImport.Padding = new System.Windows.Forms.Padding(2);
            this.lnkFullImport.Size = new System.Drawing.Size(117, 22);
            this.lnkFullImport.TabIndex = 1;
            this.lnkFullImport.TabStop = true;
            this.lnkFullImport.Text = "Full Import";
            this.lnkFullImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFullImport_LinkClicked);
            // 
            // dtpImportFromDate
            // 
            this.dtpImportFromDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpImportFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImportFromDate.Location = new System.Drawing.Point(2, 42);
            this.dtpImportFromDate.Name = "dtpImportFromDate";
            this.dtpImportFromDate.Size = new System.Drawing.Size(117, 20);
            this.dtpImportFromDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnCheckEligibility);
            this.panel3.Controls.Add(this.btnAdvanced);
            this.panel3.Controls.Add(this.pnlAdvanced);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 429);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(941, 73);
            this.panel3.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.LightYellow;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Image = global::C_DentalClaimTracker.Properties.Resources.cancel1;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(313, 3);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(260, 67);
            this.lblError.TabIndex = 64;
            this.lblError.Text = "Could not connect to Dentrix to update appointments.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkUncheckAll);
            this.panel2.Controls.Add(this.lnkCheckAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(202, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 67);
            this.panel2.TabIndex = 65;
            // 
            // lnkUncheckAll
            // 
            this.lnkUncheckAll.AutoSize = true;
            this.lnkUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUncheckAll.Location = new System.Drawing.Point(6, 27);
            this.lnkUncheckAll.Name = "lnkUncheckAll";
            this.lnkUncheckAll.Size = new System.Drawing.Size(79, 16);
            this.lnkUncheckAll.TabIndex = 1;
            this.lnkUncheckAll.TabStop = true;
            this.lnkUncheckAll.Text = "Uncheck All";
            this.lnkUncheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUncheckAll_LinkClicked);
            // 
            // lnkCheckAll
            // 
            this.lnkCheckAll.AutoSize = true;
            this.lnkCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCheckAll.Location = new System.Drawing.Point(6, 5);
            this.lnkCheckAll.Name = "lnkCheckAll";
            this.lnkCheckAll.Size = new System.Drawing.Size(64, 16);
            this.lnkCheckAll.TabIndex = 0;
            this.lnkCheckAll.TabStop = true;
            this.lnkCheckAll.Text = "Check All";
            this.lnkCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckAll_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(726, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckEligibility
            // 
            this.btnCheckEligibility.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckEligibility.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEligibility.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.btnCheckEligibility.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckEligibility.Location = new System.Drawing.Point(805, 3);
            this.btnCheckEligibility.Name = "btnCheckEligibility";
            this.btnCheckEligibility.Size = new System.Drawing.Size(133, 67);
            this.btnCheckEligibility.TabIndex = 11;
            this.btnCheckEligibility.Text = "Send Out";
            this.btnCheckEligibility.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckEligibility.UseVisualStyleBackColor = true;
            this.btnCheckEligibility.Click += new System.EventHandler(this.btnCheckEligibility_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdvanced.Location = new System.Drawing.Point(126, 3);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(76, 67);
            this.btnAdvanced.TabIndex = 6;
            this.btnAdvanced.Text = "Advanced\r\n\r\n>>";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdvanced.Controls.Add(this.dtpImportFromDate);
            this.pnlAdvanced.Controls.Add(this.label1);
            this.pnlAdvanced.Controls.Add(this.lnkFullImport);
            this.pnlAdvanced.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdvanced.Location = new System.Drawing.Point(3, 3);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Padding = new System.Windows.Forms.Padding(2);
            this.pnlAdvanced.Size = new System.Drawing.Size(123, 67);
            this.pnlAdvanced.TabIndex = 4;
            this.pnlAdvanced.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Appointments after";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.btnUpcoming);
            this.pnlTop.Controls.Add(this.btnTomorrow);
            this.pnlTop.Controls.Add(this.btnRejected);
            this.pnlTop.Controls.Add(this.btnSent);
            this.pnlTop.Controls.Add(this.btnUnverified);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlTop.Size = new System.Drawing.Size(941, 53);
            this.pnlTop.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nmbMaxResults);
            this.panel1.Controls.Add(this.lblMaxResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(851, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 50);
            this.panel1.TabIndex = 20;
            // 
            // nmbMaxResults
            // 
            this.nmbMaxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmbMaxResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbMaxResults.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbMaxResults.Location = new System.Drawing.Point(0, 25);
            this.nmbMaxResults.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmbMaxResults.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbMaxResults.Name = "nmbMaxResults";
            this.nmbMaxResults.Size = new System.Drawing.Size(85, 23);
            this.nmbMaxResults.TabIndex = 1;
            this.nmbMaxResults.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblMaxResults
            // 
            this.lblMaxResults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMaxResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxResults.Location = new System.Drawing.Point(0, 0);
            this.lblMaxResults.Name = "lblMaxResults";
            this.lblMaxResults.Size = new System.Drawing.Size(85, 25);
            this.lblMaxResults.TabIndex = 61;
            this.lblMaxResults.Text = "Max Results";
            this.lblMaxResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaxResults.Click += new System.EventHandler(this.lblMaxResults_Click);
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpcoming.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpcoming.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_gear;
            this.btnUpcoming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcoming.Location = new System.Drawing.Point(635, 3);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(158, 50);
            this.btnUpcoming.TabIndex = 18;
            this.btnUpcoming.Text = "All Upcoming";
            this.btnUpcoming.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpcoming.UseVisualStyleBackColor = true;
            this.btnUpcoming.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTomorrow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomorrow.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_code;
            this.btnTomorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomorrow.Location = new System.Drawing.Point(477, 3);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(158, 50);
            this.btnTomorrow.TabIndex = 17;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnRejected
            // 
            this.btnRejected.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRejected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejected.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_code_red;
            this.btnRejected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRejected.Location = new System.Drawing.Point(319, 3);
            this.btnRejected.Name = "btnRejected";
            this.btnRejected.Size = new System.Drawing.Size(158, 50);
            this.btnRejected.TabIndex = 21;
            this.btnRejected.Text = "Rejected";
            this.btnRejected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRejected.UseVisualStyleBackColor = true;
            this.btnRejected.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnSent
            // 
            this.btnSent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_go;
            this.btnSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSent.Location = new System.Drawing.Point(161, 3);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(158, 50);
            this.btnSent.TabIndex = 22;
            this.btnSent.Text = "Sent";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnUnverified
            // 
            this.btnUnverified.BackColor = System.Drawing.Color.Thistle;
            this.btnUnverified.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUnverified.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnverified.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnverified.Image = global::C_DentalClaimTracker.Properties.Resources.page_white_magnify;
            this.btnUnverified.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnverified.Location = new System.Drawing.Point(3, 3);
            this.btnUnverified.Name = "btnUnverified";
            this.btnUnverified.Size = new System.Drawing.Size(158, 50);
            this.btnUnverified.TabIndex = 19;
            this.btnUnverified.Text = "Unsent";
            this.btnUnverified.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnverified.UseVisualStyleBackColor = false;
            this.btnUnverified.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.AutoScroll = true;
            this.pnlResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(0, 144);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Padding = new System.Windows.Forms.Padding(1);
            this.pnlResults.Size = new System.Drawing.Size(941, 285);
            this.pnlResults.TabIndex = 10;
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.Thistle;
            this.pnlLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoading.Controls.Add(this.lblSearching);
            this.pnlLoading.Controls.Add(this.pictureBox1);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoading.Location = new System.Drawing.Point(0, 53);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(941, 91);
            this.pnlLoading.TabIndex = 65;
            this.pnlLoading.Visible = false;
            // 
            // lblSearching
            // 
            this.lblSearching.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearching.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearching.Location = new System.Drawing.Point(53, 0);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(489, 89);
            this.lblSearching.TabIndex = 63;
            this.lblSearching.Text = "Updating Eligibility, Please Wait...";
            this.lblSearching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.arrow_rotate_clockwise2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 89);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // frmEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 502);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel3);
            this.Name = "frmEligibility";
            this.Text = "Eligibility Information";
            this.Load += new System.EventHandler(this.frmEligibility_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxResults)).EndInit();
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkFullImport;
        private System.Windows.Forms.DateTimePicker dtpImportFromDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.NumericUpDown nmbMaxResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaxResults;
        private System.Windows.Forms.Button btnUpcoming;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button btnUnverified;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckEligibility;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnRejected;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lnkUncheckAll;
        private System.Windows.Forms.LinkLabel lnkCheckAll;
        private System.Windows.Forms.Button btnSent;
    }
}