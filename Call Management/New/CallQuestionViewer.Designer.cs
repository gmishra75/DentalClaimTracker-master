namespace C_DentalClaimTracker.Call_Management
{
    partial class CallQuestionViewer
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCategoryInfo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.AutoScroll = true;
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 36);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(928, 327);
            this.pnlControls.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.lblCategoryInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlTop.Size = new System.Drawing.Size(928, 36);
            this.pnlTop.TabIndex = 1;
            // 
            // lblCategoryInfo
            // 
            this.lblCategoryInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryInfo.Location = new System.Drawing.Point(3, 0);
            this.lblCategoryInfo.Name = "lblCategoryInfo";
            this.lblCategoryInfo.Size = new System.Drawing.Size(925, 36);
            this.lblCategoryInfo.TabIndex = 0;
            this.lblCategoryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CallQuestionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlTop);
            this.Name = "CallQuestionViewer";
            this.Size = new System.Drawing.Size(928, 363);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCategoryInfo;
    }
}
