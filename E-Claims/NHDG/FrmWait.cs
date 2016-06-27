using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NHDG.NHDGCommon {
	/// <summary>A window asking the user to wait.</summary>
	public class FrmWait : Form {
		#region Control Declarations
		/// <summary>The message to the user.</summary>
		public System.Windows.Forms.Label Message;

		private System.ComponentModel.Container components = null;
		#endregion


		/// <summary>Initializes an instance of FrmWait.</summary>
		public FrmWait() {
			InitializeComponent();
		}


		/// <summary>Releases all resources used by the component.</summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing) {
			if ((disposing) && (components != null)) {
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
			this.Message = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Message
			// 
			this.Message.Location = new System.Drawing.Point(7, 8);
			this.Message.Name = "Message";
			this.Message.Size = new System.Drawing.Size(289, 60);
			this.Message.TabIndex = 0;
			this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Message.UseMnemonic = false;
			// 
			// FrmWait
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(302, 75);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Message});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmWait";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Please Wait";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion
	}
}
