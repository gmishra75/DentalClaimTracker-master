namespace C_DentalClaimTracker.Call_Management
{
    partial class CallAnswerTool
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
            this.spltTopBottom = new System.Windows.Forms.SplitContainer();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAnswerPanel = new System.Windows.Forms.Panel();
            this.ctlDateEntry1 = new C_DentalClaimTracker.ctlDateEntry();
            this.ctlDateEntry2 = new C_DentalClaimTracker.ctlDateEntry();
            this.spltTopBottom.Panel1.SuspendLayout();
            this.spltTopBottom.Panel2.SuspendLayout();
            this.spltTopBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAnswerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltTopBottom
            // 
            this.spltTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltTopBottom.Location = new System.Drawing.Point(0, 0);
            this.spltTopBottom.Name = "spltTopBottom";
            this.spltTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltTopBottom.Panel1
            // 
            this.spltTopBottom.Panel1.Controls.Add(this.checkedListBox2);
            this.spltTopBottom.Panel1.Controls.Add(this.label1);
            this.spltTopBottom.Panel1.Controls.Add(this.panel2);
            // 
            // spltTopBottom.Panel2
            // 
            this.spltTopBottom.Panel2.Controls.Add(this.pnlAnswerPanel);
            this.spltTopBottom.Size = new System.Drawing.Size(795, 471);
            this.spltTopBottom.SplitterDistance = 111;
            this.spltTopBottom.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Paid",
            "In Process",
            "Being Processed",
            "Being Held",
            "Rejected",
            "Never Received"});
            this.checkedListBox2.Location = new System.Drawing.Point(0, 23);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(595, 88);
            this.checkedListBox2.TabIndex = 3;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Claim Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(595, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 111);
            this.panel2.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Verify Doctor Info",
            "Verify Patient Info",
            "Verify Subscriber Info",
            "Annual Benefits"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 86);
            this.checkedListBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Verification";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(16, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(764, 62);
            this.panel5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 60);
            this.label8.TabIndex = 1;
            this.label8.Text = "Appeal Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ctlDateEntry2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(16, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 30);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Revisit Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ctlDateEntry1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(15, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 30);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Resubmit Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(795, 27);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 33);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(398, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 60);
            this.textBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = ">> Never Received";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(215, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = ">> Never Received > Past Filing Limitation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(-1, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(795, 27);
            this.label7.TabIndex = 5;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAnswerPanel
            // 
            this.pnlAnswerPanel.Controls.Add(this.label10);
            this.pnlAnswerPanel.Controls.Add(this.label4);
            this.pnlAnswerPanel.Controls.Add(this.label3);
            this.pnlAnswerPanel.Controls.Add(this.label7);
            this.pnlAnswerPanel.Controls.Add(this.panel3);
            this.pnlAnswerPanel.Controls.Add(this.panel4);
            this.pnlAnswerPanel.Controls.Add(this.panel5);
            this.pnlAnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnswerPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlAnswerPanel.Name = "pnlAnswerPanel";
            this.pnlAnswerPanel.Size = new System.Drawing.Size(795, 356);
            this.pnlAnswerPanel.TabIndex = 7;
            this.pnlAnswerPanel.Visible = false;
            // 
            // ctlDateEntry1
            // 
            this.ctlDateEntry1.CurrentDate = null;
            this.ctlDateEntry1.DateSelectionVisible = true;
            this.ctlDateEntry1.DateValue = null;
            this.ctlDateEntry1.Location = new System.Drawing.Point(653, 3);
            this.ctlDateEntry1.Name = "ctlDateEntry1";
            this.ctlDateEntry1.Size = new System.Drawing.Size(106, 21);
            this.ctlDateEntry1.TabIndex = 2;
            // 
            // ctlDateEntry2
            // 
            this.ctlDateEntry2.CurrentDate = null;
            this.ctlDateEntry2.DateSelectionVisible = true;
            this.ctlDateEntry2.DateValue = null;
            this.ctlDateEntry2.Location = new System.Drawing.Point(653, 3);
            this.ctlDateEntry2.Name = "ctlDateEntry2";
            this.ctlDateEntry2.Size = new System.Drawing.Size(106, 21);
            this.ctlDateEntry2.TabIndex = 3;
            // 
            // CallAnswerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spltTopBottom);
            this.Name = "CallAnswerTool";
            this.Size = new System.Drawing.Size(795, 471);
            this.spltTopBottom.Panel1.ResumeLayout(false);
            this.spltTopBottom.Panel2.ResumeLayout(false);
            this.spltTopBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlAnswerPanel.ResumeLayout(false);
            this.pnlAnswerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltTopBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private ctlDateEntry ctlDateEntry1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private ctlDateEntry ctlDateEntry2;
        private System.Windows.Forms.Panel pnlAnswerPanel;
    }
}
