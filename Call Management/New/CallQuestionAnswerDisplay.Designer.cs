namespace C_DentalClaimTracker.Call_Management
{
    partial class CallQuestionAnswerDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.pnlChoiceLargeText = new System.Windows.Forms.Panel();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.pnlChoiceDate = new System.Windows.Forms.Panel();
            this.ctlDate = new C_DentalClaimTracker.ctlDateEntry();
            this.pnlChoiceYesNo = new System.Windows.Forms.Panel();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.pnlChoiceNumeric = new System.Windows.Forms.Panel();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlChoiceNormalText = new System.Windows.Forms.Panel();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.pnlChoiceSmallText = new System.Windows.Forms.Panel();
            this.txtSmall = new System.Windows.Forms.TextBox();
            this.pnlChoiceCategory = new System.Windows.Forms.Panel();
            this.pnlChoiceMultiple = new System.Windows.Forms.Panel();
            this.cmbMultipleChoice = new System.Windows.Forms.ComboBox();
            this.cmdClearAnswer = new System.Windows.Forms.Button();
            this.lblDataDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDataEntry.SuspendLayout();
            this.pnlChoiceLargeText.SuspendLayout();
            this.pnlChoiceDate.SuspendLayout();
            this.pnlChoiceYesNo.SuspendLayout();
            this.pnlChoiceNumeric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.pnlChoiceNormalText.SuspendLayout();
            this.pnlChoiceSmallText.SuspendLayout();
            this.pnlChoiceMultiple.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.Controls.Add(this.pnlChoiceLargeText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceDate);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceYesNo);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceNumeric);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceNormalText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceSmallText);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceCategory);
            this.pnlDataEntry.Controls.Add(this.pnlChoiceMultiple);
            this.pnlDataEntry.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDataEntry.Location = new System.Drawing.Point(375, 0);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(210, 32);
            this.pnlDataEntry.TabIndex = 3;
            this.pnlDataEntry.Visible = false;
            // 
            // pnlChoiceLargeText
            // 
            this.pnlChoiceLargeText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceLargeText.Controls.Add(this.txtLarge);
            this.pnlChoiceLargeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceLargeText.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceLargeText.Name = "pnlChoiceLargeText";
            this.pnlChoiceLargeText.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceLargeText.TabIndex = 6;
            this.pnlChoiceLargeText.Visible = false;
            // 
            // txtLarge
            // 
            this.txtLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLarge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarge.Location = new System.Drawing.Point(3, 3);
            this.txtLarge.MaxLength = 999;
            this.txtLarge.Multiline = true;
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.Size = new System.Drawing.Size(204, 26);
            this.txtLarge.TabIndex = 1;
            this.txtLarge.TextChanged += new System.EventHandler(this.txtLarge_TextChanged);
            // 
            // pnlChoiceDate
            // 
            this.pnlChoiceDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceDate.Controls.Add(this.ctlDate);
            this.pnlChoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceDate.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceDate.Name = "pnlChoiceDate";
            this.pnlChoiceDate.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceDate.TabIndex = 7;
            this.pnlChoiceDate.Visible = false;
            // 
            // ctlDate
            // 
            this.ctlDate.CurrentDate = null;
            this.ctlDate.DateSelectionVisible = true;
            this.ctlDate.DateValue = null;
            this.ctlDate.Location = new System.Drawing.Point(3, 6);
            this.ctlDate.Name = "ctlDate";
            this.ctlDate.Size = new System.Drawing.Size(168, 21);
            this.ctlDate.TabIndex = 0;
            this.ctlDate.ValueChanged += new System.EventHandler(this.ctlDate_ValueChanged);
            // 
            // pnlChoiceYesNo
            // 
            this.pnlChoiceYesNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceYesNo.Controls.Add(this.radNo);
            this.pnlChoiceYesNo.Controls.Add(this.radYes);
            this.pnlChoiceYesNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceYesNo.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceYesNo.Name = "pnlChoiceYesNo";
            this.pnlChoiceYesNo.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceYesNo.TabIndex = 2;
            this.pnlChoiceYesNo.Visible = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(55, 8);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(3, 8);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // pnlChoiceNumeric
            // 
            this.pnlChoiceNumeric.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceNumeric.Controls.Add(this.numNumber);
            this.pnlChoiceNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceNumeric.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceNumeric.Name = "pnlChoiceNumeric";
            this.pnlChoiceNumeric.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceNumeric.TabIndex = 8;
            this.pnlChoiceNumeric.Visible = false;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(3, 6);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(77, 20);
            this.numNumber.TabIndex = 0;
            this.numNumber.ValueChanged += new System.EventHandler(this.numNumber_ValueChanged);
            // 
            // pnlChoiceNormalText
            // 
            this.pnlChoiceNormalText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceNormalText.Controls.Add(this.txtNormal);
            this.pnlChoiceNormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceNormalText.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceNormalText.Name = "pnlChoiceNormalText";
            this.pnlChoiceNormalText.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceNormalText.TabIndex = 4;
            this.pnlChoiceNormalText.Visible = false;
            // 
            // txtNormal
            // 
            this.txtNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNormal.Location = new System.Drawing.Point(3, 6);
            this.txtNormal.MaxLength = 250;
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(204, 20);
            this.txtNormal.TabIndex = 0;
            this.txtNormal.TextChanged += new System.EventHandler(this.txtNormal_TextChanged);
            // 
            // pnlChoiceSmallText
            // 
            this.pnlChoiceSmallText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceSmallText.Controls.Add(this.txtSmall);
            this.pnlChoiceSmallText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceSmallText.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceSmallText.Name = "pnlChoiceSmallText";
            this.pnlChoiceSmallText.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceSmallText.TabIndex = 5;
            this.pnlChoiceSmallText.Visible = false;
            // 
            // txtSmall
            // 
            this.txtSmall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSmall.Location = new System.Drawing.Point(3, 6);
            this.txtSmall.MaxLength = 250;
            this.txtSmall.Name = "txtSmall";
            this.txtSmall.Size = new System.Drawing.Size(204, 20);
            this.txtSmall.TabIndex = 1;
            this.txtSmall.TextChanged += new System.EventHandler(this.txtSmall_TextChanged);
            // 
            // pnlChoiceCategory
            // 
            this.pnlChoiceCategory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceCategory.Name = "pnlChoiceCategory";
            this.pnlChoiceCategory.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceCategory.TabIndex = 1;
            this.pnlChoiceCategory.Visible = false;
            // 
            // pnlChoiceMultiple
            // 
            this.pnlChoiceMultiple.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlChoiceMultiple.Controls.Add(this.cmbMultipleChoice);
            this.pnlChoiceMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChoiceMultiple.Location = new System.Drawing.Point(0, 0);
            this.pnlChoiceMultiple.Name = "pnlChoiceMultiple";
            this.pnlChoiceMultiple.Size = new System.Drawing.Size(210, 32);
            this.pnlChoiceMultiple.TabIndex = 3;
            this.pnlChoiceMultiple.Visible = false;
            // 
            // cmbMultipleChoice
            // 
            this.cmbMultipleChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMultipleChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMultipleChoice.FormattingEnabled = true;
            this.cmbMultipleChoice.Location = new System.Drawing.Point(3, 6);
            this.cmbMultipleChoice.Name = "cmbMultipleChoice";
            this.cmbMultipleChoice.Size = new System.Drawing.Size(204, 21);
            this.cmbMultipleChoice.TabIndex = 8;
            this.cmbMultipleChoice.SelectedIndexChanged += new System.EventHandler(this.cmbMultipleChoice_SelectedIndexChanged);
            // 
            // cmdClearAnswer
            // 
            this.cmdClearAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearAnswer.Location = new System.Drawing.Point(325, 3);
            this.cmdClearAnswer.Name = "cmdClearAnswer";
            this.cmdClearAnswer.Size = new System.Drawing.Size(47, 27);
            this.cmdClearAnswer.TabIndex = 9;
            this.cmdClearAnswer.Text = "Clear";
            this.cmdClearAnswer.UseVisualStyleBackColor = true;
            this.cmdClearAnswer.Click += new System.EventHandler(this.cmdClearAnswer_Click);
            // 
            // lblDataDescription
            // 
            this.lblDataDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDataDescription.Name = "lblDataDescription";
            this.lblDataDescription.Size = new System.Drawing.Size(375, 32);
            this.lblDataDescription.TabIndex = 0;
            this.lblDataDescription.Text = "Question Text here";
            this.lblDataDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClearAnswer);
            this.panel1.Controls.Add(this.lblDataDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 32);
            this.panel1.TabIndex = 10;
            // 
            // CallQuestionAnswerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDataEntry);
            this.Name = "CallQuestionAnswerDisplay";
            this.Size = new System.Drawing.Size(585, 32);
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlChoiceLargeText.ResumeLayout(false);
            this.pnlChoiceLargeText.PerformLayout();
            this.pnlChoiceDate.ResumeLayout(false);
            this.pnlChoiceYesNo.ResumeLayout(false);
            this.pnlChoiceYesNo.PerformLayout();
            this.pnlChoiceNumeric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.pnlChoiceNormalText.ResumeLayout(false);
            this.pnlChoiceNormalText.PerformLayout();
            this.pnlChoiceSmallText.ResumeLayout(false);
            this.pnlChoiceSmallText.PerformLayout();
            this.pnlChoiceMultiple.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Button cmdClearAnswer;
        private System.Windows.Forms.Panel pnlChoiceDate;
        private ctlDateEntry ctlDate;
        private System.Windows.Forms.Panel pnlChoiceYesNo;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Panel pnlChoiceNumeric;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.Panel pnlChoiceNormalText;
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Panel pnlChoiceSmallText;
        private System.Windows.Forms.TextBox txtSmall;
        private System.Windows.Forms.Panel pnlChoiceCategory;
        private System.Windows.Forms.Panel pnlChoiceMultiple;
        private System.Windows.Forms.ComboBox cmbMultipleChoice;
        private System.Windows.Forms.Label lblDataDescription;
        private System.Windows.Forms.Panel pnlChoiceLargeText;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.Panel panel1;

    }
}
