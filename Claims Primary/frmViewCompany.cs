using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmViewCompany : Form
    {
        private EditModes _editMode;
        private company _formCompany;
        private company_contact_info _formContactInfo;

        public frmViewCompany(EditModes editMode)
        {
            InitializeComponent();
            _editMode = editMode;
            _formCompany = new company();
            _formContactInfo = new company_contact_info();
        }

        /// <summary>
        /// Note that form is automatically treated as a dialog
        /// </summary>
        /// <param name="activeCompany"></param>
        public frmViewCompany(company activeCompany, company_contact_info activeInfo)
        {
            InitializeComponent();
            _editMode = EditModes.Edit;
            _formCompany = activeCompany;
            _formContactInfo = activeInfo;
            txtName.Text = _formCompany.name;

            txtPhone.Text = activeInfo.phone_Object.FormattedPhone;
            txtAddress.Text = activeInfo.address;
            txtAddress2.Text = activeInfo.address2;
            txtCity.Text = activeInfo.city;
            txtState.Text = activeInfo.state;
            txtZip.Text = activeInfo.zip;


        }

        public company FormCompany
        {
            get { return _formCompany; }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            _formCompany.name = txtName.Text;
            _formCompany.updated_on = DateTime.Now;

            _formContactInfo.phone_Object = new PhoneObject(txtPhone.Text);
            _formContactInfo.address = txtAddress.Text;
            _formContactInfo.address2 = txtAddress2.Text;
            _formContactInfo.city = txtCity.Text;
            _formContactInfo.state = txtState.Text;
            _formContactInfo.zip = txtZip.Text;


            if (ValidateForm())
            {
                DialogResult = DialogResult.OK;
                _formCompany.Save();
                _formContactInfo.Save();
                if (_editMode != EditModes.AddNew)
                {
                    Close();
                }
                
            }

        }

        private bool ValidateForm()
        {
            if (!_formCompany.IsUnique())
            {
                MessageBox.Show(this, "The company name you entered is in use.", "Name in use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show(this, "Please enter a company name.", "No Company name", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void frmViewCompany_Load(object sender, EventArgs e)
        {

        }
    }
}