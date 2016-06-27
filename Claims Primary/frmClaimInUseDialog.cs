using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmClaimInUseDialog : Form
    {
        public enum ClaimInUseChoice
        {
            OpenReadOnly,
            DoNotOpen,
            OpenAnyway
        }

        public ClaimInUseChoice UserChoice = ClaimInUseChoice.DoNotOpen;

        public frmClaimInUseDialog(string userList)
        {
            InitializeComponent();
            lblMainText.Text = lblMainText.Text.Replace("userList", userList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserChoice = ClaimInUseChoice.OpenAnyway;
            Close();
        }

        private void cmdDoNotOpen_Click(object sender, EventArgs e)
        {
            UserChoice = ClaimInUseChoice.DoNotOpen;
            Close();
        }

        private void cmdOpenReadOnly_Click(object sender, EventArgs e)
        {
            UserChoice = ClaimInUseChoice.OpenReadOnly;
            Close();
        }
    }
}