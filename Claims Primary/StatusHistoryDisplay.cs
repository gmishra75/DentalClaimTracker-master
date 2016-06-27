using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class StatusHistoryDisplay : UserControl
    {
        public StatusHistoryDisplay()
        {
            InitializeComponent();
        }

        public int RowCount
        { get { return dgvMain.Rows.Count; } }
        
        public void SetToClaim(claim toUse, bool showAsIs)
        {
            dgvMain.Rows.Clear();
            foreach (claim_status_history csh in toUse.GetClaimHistory(showAsIs))
            {
                string dateString = "";
                if (csh.date_of_change != null)
                {
                    dateString = csh.date_of_change.Value.ToShortDateString() + " " + csh.date_of_change.Value.ToShortTimeString();
                }
                dgvMain.Rows.Add(new object[] { csh.LinkedUser.username, 
                    dateString, 
                    csh.CreateChangeText() } );
            }
        }
    }
}
