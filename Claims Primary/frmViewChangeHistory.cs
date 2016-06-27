using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmViewChangeHistory : Form
    {
        public frmViewChangeHistory(claim claimToView)
        {
            InitializeComponent();

            foreach(claim_change_log ccl in claimToView.LinkedChanges)
            {
                ListViewItem toAdd = new ListViewItem(ccl.change_date.GetValueOrDefault(DateTime.Now).ToShortDateString());

                toAdd.SubItems.Add(GenerateText(ccl));

                lvChangeHistory.Items.Add(toAdd);
            }
        }

        private string GenerateText(claim_change_log ccl)
        {
            string toReturn = ccl.field_info;
            toReturn += " changed from " + ccl.old_data;
            toReturn += " to " + ccl.new_data;

            return toReturn;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}