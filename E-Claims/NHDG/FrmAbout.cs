using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NHDG.NHDGCommon {
	/// <summary>A generic "About" window.</summary>
	public class FrmAbout : Form {
		#region Control Declarations
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCLR;
		private System.Windows.Forms.Label lblWindows;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCLRVersion;
		private System.Windows.Forms.Label lblWindowsVersion;
		private System.Windows.Forms.Label lblNotes;
		private System.Windows.Forms.Label lblNHDGVersion;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.Container components = null;
		#endregion


		/// <summary>Constructor.</summary>
		public FrmAbout() {
			InitializeComponent();
			StartEventProcessing();

			Version tmp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			this.lblNHDGVersion.Text = "v" + tmp.Major.ToString() +
									   "." + tmp.Minor.ToString() +
									   "." + tmp.Build.ToString();
			this.lblCLRVersion.Text = "v" + System.Environment.Version.Major.ToString() +
									  "." + System.Environment.Version.Minor.ToString() +
									  "." + System.Environment.Version.Build.ToString();
			this.lblWindowsVersion.Text = "v" + System.Environment.OSVersion.Version.Major.ToString() +
										  "." + System.Environment.OSVersion.Version.Minor.ToString() +
										  "." + System.Environment.OSVersion.Version.Build.ToString();
		}


		/// <summary>Customize the information in the window.</summary>
		/// <param name="name">Name of the application.</param>
		/// <param name="version">Application version.</param>
		/// <remarks>This should be called before showing the form.</remarks>
		public void SetFields(string name, Version version) { SetFields(name, version, string.Empty); }
		/// <summary>Customize the information in the window.</summary>
		/// <param name="name">Name of the application.</param>
		/// <param name="version">Application version.</param>
		/// <param name="notes">Special notes to display in the window.</param>
		/// <remarks>This should be called before showing the form.</remarks>
		public void SetFields(string name, Version version, string notes) {
			this.Text = "About " + name;
			this.lblName.Text = name;
			this.lblVersion.Text = "v" + version.Major.ToString() +
								   "." + version.Minor.ToString() +
								   "." + version.Build.ToString();
			this.lblNotes.Text = notes;
		}


		/// <summary>Releases all resources used by the component.</summary>
		protected override void Dispose(bool disposing) {
			if ((disposing) && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#region Events
		/// <summary>Hook into the events.</summary>
		private void StartEventProcessing() {
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
		}


		/// <summary>Close the about window.</summary>
		/// <param name="sender">The button that triggered the event.</param>
		/// <param name="e">The arguments passed by the event.</param>
		private void btnOK_Click(object sender, System.EventArgs e) {
			this.Close();
		}
		#endregion


		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.btnOK = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCLR = new System.Windows.Forms.Label();
			this.lblWindows = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblNotes = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblCLRVersion = new System.Windows.Forms.Label();
			this.lblWindowsVersion = new System.Windows.Forms.Label();
			this.lblNHDGVersion = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(92, 200);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "&OK";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(16, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(116, 16);
			this.lblName.TabIndex = 1;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblName.UseMnemonic = false;
			// 
			// lblCLR
			// 
			this.lblCLR.Location = new System.Drawing.Point(16, 56);
			this.lblCLR.Name = "lblCLR";
			this.lblCLR.Size = new System.Drawing.Size(116, 16);
			this.lblCLR.TabIndex = 2;
			this.lblCLR.Text = ".NET CLR";
			this.lblCLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCLR.UseMnemonic = false;
			// 
			// lblWindows
			// 
			this.lblWindows.Location = new System.Drawing.Point(16, 76);
			this.lblWindows.Name = "lblWindows";
			this.lblWindows.Size = new System.Drawing.Size(116, 16);
			this.lblWindows.TabIndex = 3;
			this.lblWindows.Text = "Windows";
			this.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblWindows.UseMnemonic = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.lblNotes});
			this.groupBox1.Location = new System.Drawing.Point(12, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(236, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// lblNotes
			// 
			this.lblNotes.Location = new System.Drawing.Point(4, 12);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(228, 84);
			this.lblNotes.TabIndex = 0;
			this.lblNotes.UseMnemonic = false;
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(132, 16);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(116, 16);
			this.lblVersion.TabIndex = 5;
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblVersion.UseMnemonic = false;
			// 
			// lblCLRVersion
			// 
			this.lblCLRVersion.Location = new System.Drawing.Point(132, 56);
			this.lblCLRVersion.Name = "lblCLRVersion";
			this.lblCLRVersion.Size = new System.Drawing.Size(116, 16);
			this.lblCLRVersion.TabIndex = 6;
			this.lblCLRVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCLRVersion.UseMnemonic = false;
			// 
			// lblWindowsVersion
			// 
			this.lblWindowsVersion.Location = new System.Drawing.Point(132, 76);
			this.lblWindowsVersion.Name = "lblWindowsVersion";
			this.lblWindowsVersion.Size = new System.Drawing.Size(116, 16);
			this.lblWindowsVersion.TabIndex = 7;
			this.lblWindowsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblWindowsVersion.UseMnemonic = false;
			// 
			// lblNHDGVersion
			// 
			this.lblNHDGVersion.Location = new System.Drawing.Point(132, 36);
			this.lblNHDGVersion.Name = "lblNHDGVersion";
			this.lblNHDGVersion.Size = new System.Drawing.Size(116, 16);
			this.lblNHDGVersion.TabIndex = 9;
			this.lblNHDGVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNHDGVersion.UseMnemonic = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "NHDG Common";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.UseMnemonic = false;
			// 
			// FrmAbout
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(262, 227);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblNHDGVersion,
																		  this.label1,
																		  this.lblWindowsVersion,
																		  this.lblCLRVersion,
																		  this.lblVersion,
																		  this.groupBox1,
																		  this.lblWindows,
																		  this.lblCLR,
																		  this.lblName,
																		  this.btnOK});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
