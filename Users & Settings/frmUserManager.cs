using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmUserManager : Form
    {
        user selectedUser = null;

        public frmUserManager()
        {
            InitializeComponent();

            RefreshUserList();
        }

        private void RefreshUserList()
        {
            user u = new user();

            foreach (DataRow aRow in u.GetAllData("username").Rows)
            {
                u = new user();
                u.Load(aRow);

                lstUsers.Items.Add(u);
            }

            if (lstUsers.Items.Count > 0)
                lstUsers.SelectedIndex = 0;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.username = "Enter name here...";
            u.is_active = true;
            u.is_admin = false;
            
            u["logged_in"] = 0;
            u["viewing_claim_id"] = 0;
            u.password = "";
            u["open_search_form"] = 0;
            u["open_eclaims_form"] = 0;
            u.Save();

            u.UserData.PopulateDefaults(u.id);
            

            lstUsers.Items.Add(u);
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                if (SelectedUserOKToRemove())
                {
                    selectedUser.Delete();

                    int i = lstUsers.SelectedIndex;

                    lstUsers.Items.Remove(lstUsers.SelectedItem);

                    if (i < lstUsers.Items.Count - 1)
                        lstUsers.SelectedIndex = i;
                    else if (lstUsers.Items.Count > 0)
                        lstUsers.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(this, "Delete cancelled.");
                }
            }
        }

        private bool SelectedUserOKToRemove()
        {
            if (MessageBox.Show(this, "Are you sure you want to remove this user? Currently the system is not set up to " +
                "automatically verify that this user is not in use. If this user is no longer employed, it's better to " +
                "deactivate the employee by unchecking the 'Active' checkbox to the right. If you remove a user with claim information " +
                "you may cause system problems. Only continue if you are sure this user has no linked information.\n\nDelete user?", "Delete User?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex > -1)
            {
                selectedUser = (user)lstUsers.SelectedItem;

                txtUserName.Text = selectedUser.username;

                chkIsActive.Checked = selectedUser.is_active;
                chkIsAdmin.Checked = selectedUser.is_admin;

            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text != selectedUser.username)
            {
                selectedUser.username = txtUserName.Text;
                selectedUser.Save();

                int i = lstUsers.SelectedIndex;
                lstUsers.Items.Remove(lstUsers.SelectedItem);

                lstUsers.Items.Insert(i, selectedUser);
                lstUsers.SelectedIndex = i;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdResetPassword_Click(object sender, EventArgs e)
        {
            selectedUser.password = "";
            selectedUser.Save();
        }

        private void chkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            selectedUser.is_admin = chkIsAdmin.Checked;
            selectedUser.Save();
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            selectedUser.is_active = chkIsActive.Checked;
            selectedUser.Save();
        }
    }
}