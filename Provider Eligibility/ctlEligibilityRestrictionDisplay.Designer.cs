namespace C_DentalClaimTracker.Provider_Eligibility
{
    partial class ctlEligibilityRestrictionDisplay
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlEditButton = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlEditButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 53);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "abc\n123\ndef";
            // 
            // pnlEditButton
            // 
            this.pnlEditButton.Controls.Add(this.btnEdit);
            this.pnlEditButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEditButton.Location = new System.Drawing.Point(498, 0);
            this.pnlEditButton.Name = "pnlEditButton";
            this.pnlEditButton.Size = new System.Drawing.Size(106, 53);
            this.pnlEditButton.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::C_DentalClaimTracker.Properties.Resources.comment_edit1;
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 48);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ctlEligibilityRestrictionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlEditButton);
            this.Name = "ctlEligibilityRestrictionDisplay";
            this.Size = new System.Drawing.Size(604, 53);
            this.pnlEditButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlEditButton;
        private System.Windows.Forms.Button btnEdit;
    }
}
