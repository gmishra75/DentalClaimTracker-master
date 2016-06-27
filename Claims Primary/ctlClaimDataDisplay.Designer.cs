namespace C_DentalClaimTracker
{
    partial class ctlClaimDataDisplay
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
            this.components = new System.ComponentModel.Container();
            this.ttipMain = new System.Windows.Forms.ToolTip(this.components);
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.cmdGrow = new System.Windows.Forms.Button();
            this.cmdMaximize = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.bullet_arrow_down;
            this.cmdMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdMinimize.Location = new System.Drawing.Point(438, 0);
            this.cmdMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(25, 26);
            this.cmdMinimize.TabIndex = 23;
            this.ttipMain.SetToolTip(this.cmdMinimize, "Minimize this section");
            this.cmdMinimize.UseVisualStyleBackColor = false;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdGrow
            // 
            this.cmdGrow.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.bullet_arrow_up;
            this.cmdGrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdGrow.Location = new System.Drawing.Point(463, 0);
            this.cmdGrow.Name = "cmdGrow";
            this.cmdGrow.Size = new System.Drawing.Size(25, 26);
            this.cmdGrow.TabIndex = 24;
            this.ttipMain.SetToolTip(this.cmdGrow, "Show all information in this section");
            this.cmdGrow.UseVisualStyleBackColor = false;
            this.cmdGrow.Click += new System.EventHandler(this.cmdGrow_Click);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.bullet_arrow_top;
            this.cmdMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdMaximize.Location = new System.Drawing.Point(488, 0);
            this.cmdMaximize.Name = "cmdMaximize";
            this.cmdMaximize.Size = new System.Drawing.Size(25, 26);
            this.cmdMaximize.TabIndex = 22;
            this.ttipMain.SetToolTip(this.cmdMaximize, "Show all information in this section");
            this.cmdMaximize.UseVisualStyleBackColor = false;
            this.cmdMaximize.Click += new System.EventHandler(this.cmdMaximize_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.cmdMinimize);
            this.pnlTop.Controls.Add(this.cmdGrow);
            this.pnlTop.Controls.Add(this.cmdMaximize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(515, 28);
            this.pnlTop.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 26);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Insurance Carrier";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlClaimDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlTop);
            this.Name = "ctlClaimDataDisplay";
            this.Size = new System.Drawing.Size(515, 148);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctlClaimDataDisplay_Paint);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdMinimize;
        private System.Windows.Forms.ToolTip ttipMain;
        private System.Windows.Forms.Button cmdMaximize;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button cmdGrow;
    }
}
