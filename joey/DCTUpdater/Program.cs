using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DCTUpdater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            bool checkOnlyMode = false;

            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "/c":
                    case "/check":
                        checkOnlyMode = true; // Check-Only Mode means no downloads will happen, only the check to see if a donwload is avaialble
                        // If no download is available the app will return exit code 0. If there are files available it will return 2. An error is 1.
                        break;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmUpdater updater = new frmUpdater();

            if (checkOnlyMode)
            {
                try
                {
                    if (updater.CheckForUpdates())
                        return 2; // Updates are available
                }
                catch (Exception)
                {
                    return 1; // Error
                }
            }
            else
            {
                // Run full update                
                Application.Run(updater);

                if (!updater.Success)
                    return 1; // Error
            }            

            return 0; // Success
        }
    }
}