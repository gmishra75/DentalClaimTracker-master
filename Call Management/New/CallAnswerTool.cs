using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Call_Management
{
    public partial class CallAnswerTool : UserControl
    {
        int i = 0;

        public CallAnswerTool()
        {
            InitializeComponent();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (i == 0)
            {
                checkedListBox2.Items.Clear();
                checkedListBox2.Items.Add("Past Filing Limitation");
                checkedListBox2.Items.Add("Revisit Date Past Filing Limitation");
                i++;
            }
            else
            {
                pnlAnswerPanel.Visible = true;
            }
        }
    }
}
