namespace C_DentalClaimTracker.Call_Management
{
    partial class ConditionClassificationHandler
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.lblCategoryMarker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(292, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Claim Condition";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.AutoScroll = true;
            this.pnlAnswers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnswers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAnswers.Location = new System.Drawing.Point(0, 73);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlAnswers.Size = new System.Drawing.Size(292, 74);
            this.pnlAnswers.TabIndex = 1;
            // 
            // lblCategoryMarker
            // 
            this.lblCategoryMarker.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCategoryMarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoryMarker.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoryMarker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryMarker.ForeColor = System.Drawing.Color.White;
            this.lblCategoryMarker.Location = new System.Drawing.Point(0, 39);
            this.lblCategoryMarker.Name = "lblCategoryMarker";
            this.lblCategoryMarker.Size = new System.Drawing.Size(292, 34);
            this.lblCategoryMarker.TabIndex = 2;
            this.lblCategoryMarker.Text = "Category Marker";
            this.lblCategoryMarker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoryMarker.Visible = false;
            // 
            // StatusClassificationHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAnswers);
            this.Controls.Add(this.lblCategoryMarker);
            this.Controls.Add(this.lblTitle);
            this.Name = "StatusClassificationHandler";
            this.Size = new System.Drawing.Size(292, 147);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Label lblCategoryMarker;
    }
}
