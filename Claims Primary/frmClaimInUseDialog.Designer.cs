namespace C_DentalClaimTracker
{
    partial class frmClaimInUseDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaimInUseDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainText = new System.Windows.Forms.Label();
            this.cmdOpenReadOnly = new System.Windows.Forms.Button();
            this.cmdDoNotOpen = new System.Windows.Forms.Button();
            this.cmdOpenAnyway = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdOpenAnyway);
            this.panel1.Controls.Add(this.cmdDoNotOpen);
            this.panel1.Controls.Add(this.cmdOpenReadOnly);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 30);
            this.panel1.TabIndex = 0;
            // 
            // lblMainText
            // 
            this.lblMainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainText.Location = new System.Drawing.Point(0, 0);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(404, 177);
            this.lblMainText.TabIndex = 1;
            this.lblMainText.Text = resources.GetString("lblMainText.Text");
            this.lblMainText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdOpenReadOnly
            // 
            this.cmdOpenReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOpenReadOnly.Location = new System.Drawing.Point(190, 3);
            this.cmdOpenReadOnly.Name = "cmdOpenReadOnly";
            this.cmdOpenReadOnly.Size = new System.Drawing.Size(99, 23);
            this.cmdOpenReadOnly.TabIndex = 0;
            this.cmdOpenReadOnly.Text = "&Read Only";
            this.cmdOpenReadOnly.UseVisualStyleBackColor = true;
            this.cmdOpenReadOnly.Click += new System.EventHandler(this.cmdOpenReadOnly_Click);
            // 
            // cmdDoNotOpen
            // 
            this.cmdDoNotOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDoNotOpen.Location = new System.Drawing.Point(295, 3);
            this.cmdDoNotOpen.Name = "cmdDoNotOpen";
            this.cmdDoNotOpen.Size = new System.Drawing.Size(99, 23);
            this.cmdDoNotOpen.TabIndex = 1;
            this.cmdDoNotOpen.Text = "Do &Not Open";
            this.cmdDoNotOpen.UseVisualStyleBackColor = true;
            this.cmdDoNotOpen.Click += new System.EventHandler(this.cmdDoNotOpen_Click);
            // 
            // cmdOpenAnyway
            // 
            this.cmdOpenAnyway.Location = new System.Drawing.Point(12, 3);
            this.cmdOpenAnyway.Name = "cmdOpenAnyway";
            this.cmdOpenAnyway.Size = new System.Drawing.Size(99, 23);
            this.cmdOpenAnyway.TabIndex = 2;
            this.cmdOpenAnyway.Text = "&Open Anyway";
            this.cmdOpenAnyway.UseVisualStyleBackColor = true;
            this.cmdOpenAnyway.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmClaimInUseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.lblMainText);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmClaimInUseDialog";
            this.Text = "Claim In Use";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.Button cmdOpenAnyway;
        private System.Windows.Forms.Button cmdDoNotOpen;
        private System.Windows.Forms.Button cmdOpenReadOnly;
    }
}