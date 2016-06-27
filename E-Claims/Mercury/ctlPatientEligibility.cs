using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    public partial class ctlPatientEligibility : UserControl
    {
        private eligibility_data _eligibilityData;
        private Color COLOR_VALID = Color.MediumSeaGreen;
        private Color COLOR_INVALID = Color.DarkRed;
        private Color COLOR_UNCHECKED = DefaultBackColor;
        private Color COLOR_SENT = Color.LightSteelBlue;
        bool isSent;

        public eligibility_data EligibilityData
        {
            get
            {
                return _eligibilityData;
            }
            set
            {
                _eligibilityData = value;
                LoadData(value);
            }
        }

        public bool CheckState
        {
            get { return chkCheckState.Checked; }
            set { chkCheckState.Checked = value; }
        }

        public ctlPatientEligibility(eligibility_data ed)
        {
            InitializeComponent();
            EligibilityData = ed;

            isSent = false;

            if (ed.last_check.HasValue)
                if (ed.last_check.Value.Year > 1900)
                    isSent = true;

            CheckState = !isSent;
        }

        private void LoadData(eligibility_data ed)
        {
            lblPatientName.Text = ed.patient_name;
            lblDescription.Text = ed.procedure_info;
            lblTime.Text = string.Format("{0}\n{1} min", ed.appt_date.ToString("H:mm"), ed.appt_length.ToString());

            if (isSent)
            {
                if (ed.last_status == (int) frmEligibility.Eligibility_Status.Verified)
                {
                    lblStatus.Text = "Valid";
                    lblStatus.BackColor = COLOR_VALID;
                }
                else if (ed.last_status == (int)frmEligibility.Eligibility_Status.Rejected)
                {
                    lblStatus.Text = "Invalid";
                    lblStatus.BackColor = COLOR_INVALID;
                }
                else
                {
                    lblStatus.Text = "Sent";
                    lblStatus.BackColor = COLOR_SENT;
                }
            }
            else
            {
                lblStatus.Text = "Unsent";
                lblStatus.BackColor = COLOR_UNCHECKED;
            }

        }
    }
}
