using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHDG.EClaims;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.AppSettings;
using log4net;

namespace eClaims
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

            // Set things up.
            Globals.Settings = (EClaimsSettings)Utilities.DeserializeFromFile(typeof(EClaimsSettings), SettingsManager.Instance.Settings["EClaims"].ConfigurationFile);
            log4net.Config.DOMConfigurator.ConfigureAndWatch(new System.IO.FileInfo(SettingsManager.Instance.Settings["EClaims"].LogConfigurationFile));
            Globals.Logger = LogManager.GetLogger("EClaims");

            // Say hello.
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Globals.Logger.Info("Application starting: v" + v.ToString() +
                                ", Windows v" + System.Environment.OSVersion.Version.ToString() +
                                ", .NET v" + System.Environment.Version.ToString());

            // Run the application.
            try
            {
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a fatal problem -- application closing.", "EClaims");
                Globals.Logger.Fatal("There was a fatal problem -- application closing.", ex);
            }

            // Make sure the database has been closed.
            if (Globals.Database != null)
            {
                if (Globals.Database.State != System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        Globals.Logger.Debug("Closing database connection...");
                        Globals.Database.Close();
                        Globals.Logger.Debug("Database closed.");
                    }
                    catch (Exception ex)
                    {
                        Globals.Logger.Error("Could not close database.", ex);
                    }
                }
            }

            // All done.
            Globals.Logger.Info("Application exiting.");
        }
    }
}