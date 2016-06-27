namespace DCTUpdater
{
    partial class frmMain
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
            this.cmdOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOpenFolder
            // 
            this.cmdOpenFolder.Location = new System.Drawing.Point(12, 12);
            this.cmdOpenFolder.Name = "cmdOpenFolder";
            this.cmdOpenFolder.Size = new System.Drawing.Size(122, 74);
            this.cmdOpenFolder.TabIndex = 0;
            this.cmdOpenFolder.Text = "Create Local Test ";
            this.cmdOpenFolder.UseVisualStyleBackColor = true;
            this.cmdOpenFolder.Click += new System.EventHandler(this.cmdOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "This creates the deployment manifest to be used for project updates. Upload the D" +
    "eploymentManifest.XML along with the project .exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Live Deployment (\"C:\\Program Files...\")";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOpenFolder);
            this.Name = "Form1";
            this.Text = "Build Deployment Manifest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

