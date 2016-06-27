using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmChangePassword : Form
    {
        user _formUser;
        public frmChangePassword(user formUser)
        {
            InitializeComponent();
            _formUser = formUser;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (_formUser.VerifyPassword(txtOldPassword.Text))
            {
                if (txtNewPassword1.Text == txtNewPassword2.Text)
                {
                    _formUser.password = _formUser.Hash(txtNewPassword1.Text);
                    _formUser.Save();

                    MessageBox.Show(this, "Your new password is now saved. You can use it the next time you login.", "New password");
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "Your passwords do not match.", "Passwords don't match");
                }
            }
            else
                MessageBox.Show(this, "Your old password is incorrect.", "Old password wrong");
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}