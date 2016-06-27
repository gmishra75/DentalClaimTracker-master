using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmCompanyContactInfo : Form
    {
        public int newOrderID;
        private int _defaultOrderID;

        public frmCompanyContactInfo(company formCompany, int defaultOrderID)
        {
            _defaultOrderID = defaultOrderID;
            InitializeComponent();

            List<company_contact_info> allContactInfo = formCompany.GetLinkedAddresses();
            List<CompanyContactInfoDisplay> allDisplayInfo = new List<CompanyContactInfoDisplay>();

            foreach (company_contact_info anInfo in allContactInfo)
            {
                allDisplayInfo.Add(new CompanyContactInfoDisplay(anInfo));
            }

            dgvResults.DataSource = allDisplayInfo;

            lblTitle.Text = "Viewing Extended Contact Information For: " + formCompany.name;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdUseSelectedAddress_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                newOrderID = ((CompanyContactInfoDisplay)dgvResults.SelectedRows[0].DataBoundItem).ContactInfo.order_id;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, "Please select an address from the list above.");
            }
        }

        private void dgvResults_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvResults.Rows)
            {
                if (((CompanyContactInfoDisplay)aRow.DataBoundItem).ContactInfo.order_id == _defaultOrderID)
                {

                    DataGridViewCellStyle dgvcs = new DataGridViewCellStyle();
                    dgvcs.BackColor = Color.LightYellow;
                    aRow.DefaultCellStyle = dgvcs;
                    break;
                }
            }
        }
    }

    class CompanyContactInfoDisplay
    {
        private string _phone;
        private string _address;
        private string _address2;
        private string _city;
        private string _state;
        private string _zip;
        private company_contact_info _contactInfo;

        public CompanyContactInfoDisplay(company_contact_info toDisplay)
        {
            _contactInfo = toDisplay;
            Phone = toDisplay.phone_Object.FormattedPhone;
            Address = toDisplay.address;
            Address2 = toDisplay.address2;
            City = toDisplay.city;
            State = toDisplay.state;
            Zip = toDisplay.zip;
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public company_contact_info ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }

    }
}