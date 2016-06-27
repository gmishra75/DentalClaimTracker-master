namespace C_DentalClaimTracker
{
    partial class ctlUnusualPaymentRule
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
            this.cmdDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperatorDropDown = new System.Windows.Forms.ComboBox();
            this.nmbAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAmountTypeDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdDelete.Image = global::C_DentalClaimTracker.Properties.Resources.bullet_delete;
            this.cmdDelete.Location = new System.Drawing.Point(500, 0);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(29, 25);
            this.cmdDelete.TabIndex = 0;
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProcessCode.Location = new System.Drawing.Point(76, 0);
            this.txtProcessCode.MaxLength = 45;
            this.txtProcessCode.Multiline = true;
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Size = new System.Drawing.Size(94, 25);
            this.txtProcessCode.TabIndex = 2;
            this.txtProcessCode.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(170, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "paid at";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOperatorDropDown
            // 
            this.cmbOperatorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperatorDropDown.FormattingEnabled = true;
            this.cmbOperatorDropDown.Location = new System.Drawing.Point(215, 2);
            this.cmbOperatorDropDown.Name = "cmbOperatorDropDown";
            this.cmbOperatorDropDown.Size = new System.Drawing.Size(94, 21);
            this.cmbOperatorDropDown.TabIndex = 5;
            this.cmbOperatorDropDown.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // nmbAmount
            // 
            this.nmbAmount.DecimalPlaces = 2;
            this.nmbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbAmount.Location = new System.Drawing.Point(309, 2);
            this.nmbAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmbAmount.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nmbAmount.Name = "nmbAmount";
            this.nmbAmount.Size = new System.Drawing.Size(90, 22);
            this.nmbAmount.TabIndex = 6;
            this.nmbAmount.ValueChanged += new System.EventHandler(this.NumberValueChanged);
            this.nmbAmount.Leave += new System.EventHandler(this.NumberValueChanged);
            // 
            // cmbAmountTypeDropdown
            // 
            this.cmbAmountTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmountTypeDropdown.FormattingEnabled = true;
            this.cmbAmountTypeDropdown.Location = new System.Drawing.Point(399, 2);
            this.cmbAmountTypeDropdown.Name = "cmbAmountTypeDropdown";
            this.cmbAmountTypeDropdown.Size = new System.Drawing.Size(94, 21);
            this.cmbAmountTypeDropdown.TabIndex = 7;
            this.cmbAmountTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // ctlUnusualPaymentRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmbAmountTypeDropdown);
            this.Controls.Add(this.nmbAmount);
            this.Controls.Add(this.cmbOperatorDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcessCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDelete);
            this.Name = "ctlUnusualPaymentRule";
            this.Size = new System.Drawing.Size(529, 25);
            this.Load += new System.EventHandler(this.ctlUnusualPaymentRule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcessCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperatorDropDown;
        private System.Windows.Forms.NumericUpDown nmbAmount;
        private System.Windows.Forms.ComboBox cmbAmountTypeDropdown;
    }
}
