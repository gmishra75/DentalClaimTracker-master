using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_DentalClaimTracker.General
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class frmLoginWPF : UserControl
    {
        public event Action LoginSuccess;
        public event Action RequestEditDBSettings;
        public event Action RequestExit;

        public frmLoginWPF()
        {
            InitializeComponent();

            txtUserName.Text = C_DentalClaimTracker.Properties.Settings.Default.LastUserName;            
            txtUserName.SelectAll();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (system_options.ImportFlag)
                {
                    if (MessageBox.Show("The system is currently locked by an administrator. It is recommended that you " +
                        "wait until this update is complete before logging in to the system.\n\nWould you like to wait until " +
                        "this update is complete?", "Update in progress", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                        return;
                }

                user currentUser = ValidateLogin();
                if (currentUser != null)
                {
                    ActiveUser.UserObject = currentUser;
                    if (chkOpenExclusive.IsChecked.GetValueOrDefault(false))
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

                                if (MessageBox.Show("The following users are currently logged in to the system.\n\n" + userList + "\nIf you continue, they might " +
                                    "have problems with any claims they currently have open. Would you like to continue anyway?", "Continue with import?",
                                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                                {
                                    return;
                                }
                            }
                            system_options.SetImportFlag(true);
                        }
                        else
                            MessageBox.Show("You cannot open the program exclusively if you are not an administrator.");
                    }


                    ActiveUser.UserObject.Login();
                    if (chkOpenExclusive.IsChecked.GetValueOrDefault(false))
                    {
                        ActiveUser.LogAction(ActiveUser.ActionTypes.Login, "Exclusive");
                    }
                    else
                        ActiveUser.LogAction(ActiveUser.ActionTypes.Login);

                    C_DentalClaimTracker.Properties.Settings.Default.LastUserName = ActiveUser.UserObject.username;
                    C_DentalClaimTracker.Properties.Settings.Default.Save();

                    if (LoginSuccess != null)
                        LoginSuccess();

                    mdiMain.Instance().HideAdminMenu();
                }
                else
                {
                    LoggingHelper.Log("An invalid login was detected. User name: " + txtUserName.Text, LogSeverity.Information);
                    MessageBox.Show("Incorrect login.", "Incorrect login");
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

                if (MessageBox.Show("There was an error connecting to the server to validate login information. Would you like to edit " +
                    "the current server settings?\n\nError:" + errorInfo, "No database connection", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
                {
                    if (RequestEditDBSettings != null)
                        RequestEditDBSettings();
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
            System.Data.DataTable matches = u.Search("SELECT * FROM USERS WHERE username = '" + txtUserName.Text.Trim() + "' AND password = '" +
                u.Hash(txtPassword.Password.Trim()) + "'");

            if (matches.Rows.Count > 0)
            {
                u.Load(matches.Rows[0]);
                return u;
            }
            else
                return null;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (RequestExit != null)
                RequestExit();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            frmAboutBox fa = new frmAboutBox();
            fa.Show();
        }
    }


}
