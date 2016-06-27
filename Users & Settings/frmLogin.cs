using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmLogin : Form
    {
        int _formDefaultHeight;

        public frmLogin()
        {
            InitializeComponent();
            _formDefaultHeight = Height;
            AutoResizeForm(false);
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (system_options.ImportFlag)
                {
                    if (MessageBox.Show(this, "The system is currently locked by an administrator. It is recommended that you " +
                        "wait until this update is complete before logging in to the system.\n\nWould you like to wait until " +
                        "this update is complete?", "Update in progress", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                        return;
                }

                user currentUser = ValidateLogin();
                if (currentUser != null)
                {
                    ActiveUser.UserObject = currentUser;
                    if (chkOpenExclusive.Checked)
                    {
                        if (currentUser.is_admin)
                        {
                            if (ActiveUser.UserObject.LoggedInUsers.Count > 0)
                            {
                                string userList = string.Empty;
                                foreach (user aUser in ActiveUser.UserObject.LoggedInUsers)
                                {
                                    if (aUser.id != ActiveUser.UserObject.id)
                                        userList += aUser.username + "\n";
                                }

                                if (MessageBox.Show(this, "The following users are currently logged in to the system.\n\n" + userList + "\nIf you continue, they might " +
                                    "have problems with any claims they currently have open. Would you like to continue anyway?", "Continue with import?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                {
                                    return;
                                }
                            }
                            system_options.SetImportFlag(true);
                        }
                        else
                            MessageBox.Show(this, "You cannot open the program exclusively if you are not an administrator.");
                    }


                    DialogResult = DialogResult.OK;


                    ActiveUser.UserObject.Login();
                    if (chkOpenExclusive.Checked)
                    {
                        ActiveUser.LogAction(ActiveUser.ActionTypes.Login, "Exclusive");
                    }
                    else
                        ActiveUser.LogAction(ActiveUser.ActionTypes.Login);

                    C_DentalClaimTracker.Properties.Settings.Default.LastUserName = ActiveUser.UserObject.username;
                    C_DentalClaimTracker.Properties.Settings.Default.Save();

                    Close();

                    mdiMain.Instance().HideAdminMenu();
                }
                else
                {
                    LoggingHelper.Log("An invalid login was detected. User name: " + txtUserName.Text, LogSeverity.Information);
                    MessageBox.Show(this, "Incorrect login.", "Incorrect login");
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log(err);
                string errorInfo = err.Message;

                Exception inner = err.InnerException;
                while (inner != null)
                {
                    errorInfo += "\n\n" + inner.Message;
                    inner = inner.InnerException;
                }

                if (MessageBox.Show(this, "There was an error connecting to the server to validate login information. Would you like to edit " +
                    "the current server settings?\n\nError:" + errorInfo, "No database connection", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    frmSettings toShow = new frmSettings(true);
                    toShow.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Retrieves a user with information matching the current login info on the form. If no user
        /// is found, returns null.
        /// </summary>
        /// <returns></returns>
        private user ValidateLogin()
        {
            user u = new user();
            DataTable matches = u.Search("SELECT * FROM USERS WHERE username = '" + txtUserName.Text.Trim() + "' AND password = '" +
                u.Hash(txtPassword.Text.Trim()) + "'");

            if (matches.Rows.Count > 0)
            {
                u.Load(matches.Rows[0]);
                return u;
            }
            else
                return null;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = C_DentalClaimTracker.Properties.Settings.Default.LastUserName;
        }

        private void lnkAdministrativeFunctions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAdministrative.Visible = !pnlAdministrative.Visible;
            AutoResizeForm(true);
        }

        private void AutoResizeForm(bool Delay)
        {
            int newHeight = _formDefaultHeight;
            if (pnlAdministrative.Visible)
            {
                newHeight += pnlAdministrative.Height;
            }

            if (newHeight != Height)
            {
                if (Delay)
                {
                    int targetHeight = pnlAdministrative.Height;
                    if (pnlAdministrative.Visible)
                    {
                        pnlAdministrative.Height = 0;
                        int increment = System.Convert.ToInt32(targetHeight * .33333);
                        for (decimal i = 1; i < 3; i++)
                        {
                            pnlAdministrative.Height = System.Convert.ToInt32((i / 3) * targetHeight);
                            Height += increment;
                            // System.Threading.Thread.Sleep(50);
                        }

                        pnlAdministrative.Height = targetHeight;

                    }
                    else
                    {

                        /*
                        int increment = System.Convert.ToInt32(.1 * targetHeight);
                        for (decimal i = 5; i > 0; i--)
                        {
                            pnlAdministrative.Height = System.Convert.ToInt32((i / 5) * targetHeight);
                            Height -= increment;
                            System.Threading.Thread.Sleep(20);
                        }
                        */
                        pnlAdministrative.Visible = false;
                        

                    }

                    pnlAdministrative.Height = targetHeight;
                }

                
                Height = newHeight;
            }
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
                txtPassword.Focus();
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            CommonFunctions.OpenDirectory(Application.StartupPath);
        }
    }
}