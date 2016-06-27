using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class ctlEligibilityRestrictionDisplay : UserControl
    {
        provider_eligibility_restrictions ProviderEligibilityRestriction { get; set;  }




        public ctlEligibilityRestrictionDisplay(provider_eligibility_restrictions per, bool canEdit)
        {
            InitializeComponent();
            
            ProviderEligibilityRestriction = per;
            pnlEditButton.Visible = canEdit;
            LoadText();
        }

        private void LoadText()
        {
            string SummaryText = @"{\rtf1\ansi For \b [FROMPROVIDER]\b0  switch to \b [TOPROVIDER]\b0 \par
starting \b [STARTDATE]\b0  [ENDDATE] \par
for Insurance Company Group \b [ICG]\b0}";

            SummaryText = SummaryText.Replace("[TOPROVIDER]", provider_eligibility_restrictions.FindClaimByProviderID(ProviderEligibilityRestriction.provider_id).DoctorName);
            SummaryText = SummaryText.Replace("[FROMPROVIDER]", provider_eligibility_restrictions.FindClaimByProviderID(ProviderEligibilityRestriction.switch_to_provider_id).DoctorName);
            SummaryText = SummaryText.Replace("[STARTDATE]", ProviderEligibilityRestriction.start_date.Value.ToShortDateString());

            if (ProviderEligibilityRestriction.end_date.HasValue)
                SummaryText = SummaryText.Replace("[ENDDATE]", string.Format(@"until \b {0}\b0 ", ProviderEligibilityRestriction.end_date.Value.ToShortDateString()));
            else
                SummaryText = SummaryText.Replace("[ENDDATE]", "");

            richTextBox1.Rtf = SummaryText;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProviderEligibilityRestriction editRestriction = new frmEditProviderEligibilityRestriction(ProviderEligibilityRestriction);

            if (editRestriction.ShowDialog() == DialogResult.OK)
            {
                ProviderEligibilityRestriction = editRestriction.FormRestriction;
                LoadText();
            }
        }
    }
}
