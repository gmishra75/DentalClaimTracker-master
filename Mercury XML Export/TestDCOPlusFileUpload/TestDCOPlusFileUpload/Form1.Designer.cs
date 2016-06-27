namespace TestDCOPlusFileUpload
{
    partial class Form1
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
            this.dlgPickFile = new System.Windows.Forms.OpenFileDialog();
            this.Upload = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.LinkLabel();
            this.FileToUpload = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dlgPickFile
            // 
            this.dlgPickFile.FileName = "openFileDialog1";
            // 
            // Upload
            // 
            this.Upload.Enabled = false;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upload.Location = new System.Drawing.Point(279, 81);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "&Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ChooseFile.AutoSize = true;
            this.ChooseFile.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ChooseFile.Location = new System.Drawing.Point(16, 39);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(62, 13);
            this.ChooseFile.TabIndex = 2;
            this.ChooseFile.TabStop = true;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ChooseFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChooseFile_LinkClicked);
            // 
            // FileToUpload
            // 
            this.FileToUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileToUpload.Location = new System.Drawing.Point(19, 13);
            this.FileToUpload.Name = "FileToUpload";
            this.FileToUpload.ReadOnly = true;
            this.FileToUpload.Size = new System.Drawing.Size(335, 20);
            this.FileToUpload.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 116);
            this.Controls.Add(this.FileToUpload);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.Upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DCO Plus - File Upload Test Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgPickFile;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.LinkLabel ChooseFile;
        private System.Windows.Forms.TextBox FileToUpload;
    }
}

