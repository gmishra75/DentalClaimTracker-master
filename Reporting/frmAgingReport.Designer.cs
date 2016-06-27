namespace C_DentalClaimTracker.Reporting
{
    partial class frmAgingReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AgingReportRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmbDate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowPredeterms = new System.Windows.Forms.CheckBox();
            this.chkShowSecondary = new System.Windows.Forms.CheckBox();
            this.chkShowPrimary = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rptvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AgingReportRowBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgingReportRowBindingSource
            // 
            this.AgingReportRowBindingSource.DataSource = typeof(C_DentalClaimTracker.Reporting.Data.AgingReportRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateReport.Image = global::C_DentalClaimTracker.Properties.Resources.application_form_edit;
            this.btnGenerateReport.Location = new System.Drawing.Point(889, 0);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(123, 60);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Regenerate Report";
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.label1);
            this.grpDate.Controls.Add(this.nmbDate);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDate.Location = new System.Drawing.Point(276, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(112, 60);
            this.grpDate.TabIndex = 9;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date Cutoff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "days+";
            // 
            // nmbDate
            // 
            this.nmbDate.Location = new System.Drawing.Point(6, 28);
            this.nmbDate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbDate.Name = "nmbDate";
            this.nmbDate.Size = new System.Drawing.Size(55, 21);
            this.nmbDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowPredeterms);
            this.groupBox1.Controls.Add(this.chkShowSecondary);
            this.groupBox1.Controls.Add(this.chkShowPrimary);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Claim Types";
            // 
            // chkShowPredeterms
            // 
            this.chkShowPredeterms.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowPredeterms.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPredeterms.Location = new System.Drawing.Point(179, 17);
            this.chkShowPredeterms.Name = "chkShowPredeterms";
            this.chkShowPredeterms.Size = new System.Drawing.Size(88, 40);
            this.chkShowPredeterms.TabIndex = 22;
            this.chkShowPredeterms.Text = "Predeterm";
            this.chkShowPredeterms.UseVisualStyleBackColor = true;
            // 
            // chkShowSecondary
            // 
            this.chkShowSecondary.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowSecondary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowSecondary.Location = new System.Drawing.Point(91, 17);
            this.chkShowSecondary.Name = "chkShowSecondary";
            this.chkShowSecondary.Size = new System.Drawing.Size(88, 40);
            this.chkShowSecondary.TabIndex = 21;
            this.chkShowSecondary.Text = "Secondary";
            this.chkShowSecondary.UseVisualStyleBackColor = true;
            // 
            // chkShowPrimary
            // 
            this.chkShowPrimary.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowPrimary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPrimary.Location = new System.Drawing.Point(3, 17);
            this.chkShowPrimary.Name = "chkShowPrimary";
            this.chkShowPrimary.Size = new System.Drawing.Size(88, 40);
            this.chkShowPrimary.TabIndex = 20;
            this.chkShowPrimary.Text = "Primary";
            this.chkShowPrimary.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 616);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(937, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rptvMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 556);
            this.panel3.TabIndex = 2;
            // 
            // rptvMain
            // 
            this.rptvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AgingReportStandard";
            reportDataSource1.Value = this.AgingReportRowBindingSource;
            this.rptvMain.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvMain.LocalReport.ReportEmbeddedResource = "C_DentalClaimTracker.Reporting.Report1.rdlc";
            this.rptvMain.Location = new System.Drawing.Point(0, 0);
            this.rptvMain.Name = "rptvMain";
            this.rptvMain.Size = new System.Drawing.Size(1012, 556);
            this.rptvMain.TabIndex = 0;
            // 
            // frmAgingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgingReport";
            this.Text = "Claim Priority Report";
            this.Load += new System.EventHandler(this.frmAgingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgingReportRowBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer rptvMain;
        private System.Windows.Forms.BindingSource AgingReportRowBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkShowPredeterms;
        private System.Windows.Forms.CheckBox chkShowSecondary;
        private System.Windows.Forms.CheckBox chkShowPrimary;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmbDate;
    }
}