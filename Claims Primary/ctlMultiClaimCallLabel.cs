using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class ctlMultiClaimCallLabel : UserControl
    {
        private string _companyName = "";
        private string _groupName = "";
        List<PhoneObject> _phoneNumberList = new List<PhoneObject>();
        List<string> _phoneNumbersString = new List<string>();

        public ctlMultiClaimCallLabel()
        {
            InitializeComponent();
        }

        public string Company_Name
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                lblCompanyName.Text = Company_Name;
            }
        }
        public string GroupName
        {
            get { return _groupName; }
            set
            {
                _groupName = value;
                SetGroupNameText();
            }
        }

        
        public List<PhoneObject> PhoneNumberList
        {
            get { return _phoneNumberList; }
        }

        /// <summary>
        /// Adds a phone to the phone list if it's unique
        /// </summary>
        /// <param name="toAdd"></param>
        /// <returns></returns>
        public bool TryAddPhone(string toAdd)
        {
            if (_phoneNumbersString.Contains(toAdd))
                return false;
            else
            {
                _phoneNumbersString.Add(toAdd);
                _phoneNumberList.Add(new PhoneObject(toAdd));
                SetGroupNameText();
                return true;
            }
        }

        private void SetGroupNameText()
        {
            lblGroupNamePhone.Text = GroupName;
            if (PhoneNumberList.Count == 1)
            {
                lblGroupNamePhone.Text += " - " + PhoneNumberList[0].FormattedPhone;
            }
            else
            {
                string groupPhoneText = "";
                foreach (PhoneObject aPhone in PhoneNumberList)
                {
                    if (groupPhoneText == "")
                        groupPhoneText += ", ";

                    groupPhoneText += aPhone.FormattedPhone;
                }

                groupPhoneText = " - (" + groupPhoneText + ")";

                lblGroupNamePhone.Text += groupPhoneText;
            }
            
        }

    }
}
