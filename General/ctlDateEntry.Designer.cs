namespace C_DentalClaimTracker
{
    partial class ctlDateEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlDateEntry));
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Location = new System.Drawing.Point(0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(69, 20);
            this.txtDate.TabIndex = 39;
            this.txtDate.Tag = "1";
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "d";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(72, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(10, 20);
            this.dtpDate.TabIndex = 42;
            this.dtpDate.TabStop = false;
            this.dtpDate.Tag = "1";
            this.dtpDate.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.Location = new System.Drawing.Point(69, 0);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(21, 21);
            this.btnDate.TabIndex = 40;
            this.btnDate.Tag = "1";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // ctlDateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.dtpDate);
            this.Name = "ctlDateEntry";
            this.Size = new System.Drawing.Size(90, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
