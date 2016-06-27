namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class frmAddUnitTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOS = new System.Windows.Forms.DateTimePicker();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAddTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 28);
            this.panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTest.Location = new System.Drawing.Point(115, 0);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(75, 28);
            this.btnAddTest.TabIndex = 0;
            this.btnAddTest.Text = "&Add";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtProvider
            // 
            this.txtProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvider.Location = new System.Drawing.Point(0, 23);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(190, 24);
            this.txtProvider.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insurance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDOS
            // 
            this.dtpDOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOS.Location = new System.Drawing.Point(0, 114);
            this.dtpDOS.Name = "dtpDOS";
            this.dtpDOS.Size = new System.Drawing.Size(190, 20);
            this.dtpDOS.TabIndex = 6;
            // 
            // lblErrorText
            // 
            this.lblErrorText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblErrorText.Location = new System.Drawing.Point(0, 134);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(190, 35);
            this.lblErrorText.TabIndex = 7;
            this.lblErrorText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(0, 70);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(190, 21);
            this.cmbInsurance.TabIndex = 3;
            // 
            // frmAddUnitTest
            // 
            this.AcceptButton = this.btnAddTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(190, 203);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.dtpDOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbInsurance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUnitTest";
            this.Text = "Add Unit Test";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpDOS;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.ComboBox cmbInsurance;
    }
}