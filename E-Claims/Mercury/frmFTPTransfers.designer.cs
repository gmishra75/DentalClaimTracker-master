namespace C_DentalClaimTracker.E_Claims.Mercury
{
    partial class frmFTPTransfers
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
            this.pbarMain = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBottomBar = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbarMain
            // 
            this.pbarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbarMain.Location = new System.Drawing.Point(0, 47);
            this.pbarMain.Margin = new System.Windows.Forms.Padding(4);
            this.pbarMain.Name = "pbarMain";
            this.pbarMain.Size = new System.Drawing.Size(407, 62);
            this.pbarMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 47);
            this.panel1.TabIndex = 3;
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(84, 0);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Size = new System.Drawing.Size(323, 47);
            this.lblMain.TabIndex = 3;
            this.lblMain.Text = "Sending file 1/1...";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBottomBar
            // 
            this.txtBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBottomBar.Location = new System.Drawing.Point(0, 142);
            this.txtBottomBar.Name = "txtBottomBar";
            this.txtBottomBar.Size = new System.Drawing.Size(407, 178);
            this.txtBottomBar.TabIndex = 7;
            this.txtBottomBar.Text = "";
            // 
            // frmFTPTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 320);
            this.Controls.Add(this.txtBottomBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbarMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFTPTransfers";
            this.Text = "Mercury File Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDownloadFile_FormClosing);
            this.Load += new System.EventHandler(this.frmFTPTransfers_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbarMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtBottomBar;
    }
}