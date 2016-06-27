using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace C_DentalClaimTracker
{
    partial class frmAboutBox : Form
    {
        public frmAboutBox()
        {
            InitializeComponent();
        }

        private void lnkCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twinsparks.com/");
        }

        private void frmAboutBox_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
