using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHDG.EClaims;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.AppSettings;
using log4net;
using C_DentalClaimTracker.General;

namespace C_DentalClaimTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            // Set things up.
            // Globals.Settings = (EClaimsSettings)Utilities.DeserializeFromFile(typeof(EClaimsSettings), SettingsManager.Instance.Settings["EClaims"].ConfigurationFile);
            // log4net.Config.DOMConfigurator.ConfigureAndWatch(new System.IO.FileInfo(SettingsManager.Instance.Settings["EClaims"].LogConfigurationFile));

            // Run the application.
            try
            {
                Application.Run(frmStartScreenWPFContainer.Instance());
            }
            catch (Exception ex)
            {
                LoggingHelper.Log("Unhandled exception occurred somewhere in the application.", LogSeverity.Error, ex, false);
                MessageBox.Show("There was an unhandled problem in the application. Please report the following error to an administrator. You may need to restart Claim Tracker\n\n" + ex.Message, 
                    "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    if (ActiveUser.UserObject != null)
                    {
                        ActiveUser.LogAction(ActiveUser.ActionTypes.Logout);
                        ActiveUser.UserObject.Logout();
                        ActiveUser.UserObject = null;
                    }
                }
                catch { }
            }
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            try
            {
                if (ActiveUser.UserObject != null)
                {
                    ActiveUser.LogAction(ActiveUser.ActionTypes.Logout);
                    ActiveUser.UserObject.Logout();
                    ActiveUser.UserObject = null;
                }
            }
            catch { }

            try
            {
                if (Properties.Settings.Default.OpenedExclusive)
                {
                    system_options.SetImportFlag(false);
                    Properties.Settings.Default.OpenedExclusive = false;

                }
            }
            catch { }
        }
    }
}