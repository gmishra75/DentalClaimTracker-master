using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DCTUpdater.Properties;
using System.Net;

namespace DCTUpdater
{
    public partial class frmUpdater : Form
    {
        delegate void CheckBoxDelegate(CheckBox chkToChange);
        delegate void UpdateProgressDelegate(string currentTask, int progress);        
                
        Color STARTEDCOLOR = Color.Orange;
        Color FINISHEDCOLOR = Color.Gray;

        BackgroundWorker WorkerThread = new BackgroundWorker();
        Exception WorkerException = null;        
        bool RunOnCompletion = false;        

        DeploymentManifest RemoteManifest = new DeploymentManifest();
        List<DeploymentFile> FileUpdateList = new List<DeploymentFile>();
        
        public frmUpdater()
        {
            InitializeComponent();

            WorkerThread.DoWork += new DoWorkEventHandler(WorkerThread_DoWork);
            WorkerThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerThread_RunWorkerCompleted);
        }

        public bool Success { get; private set; }

        void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Success)
            {
                if (FileUpdateList.Count == 0)
                {
                    MessageBox.Show(this, "No updates were necessary.", "Dental Claim Tracker Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Update downloaded successfully! Application will now restart.", "Dental Claim Tracker Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (WorkerException != null)
                {
                    MessageBox.Show(this, "An error occurred while installing the update. The error reported was\n\n" + WorkerException.Message, "Dental Claim Tracker Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(this, "An error occurred while installing the update.", "Dental Claim Tracker Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (RunOnCompletion)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath + "\\C-DentalClaimTracker.exe");
            }

            Application.Exit();
        }

        void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MarkCheckStarted(chkStepOne);
                UpdateProgress("Checking online manifest...", 5);
                if (CheckForUpdates())
                {
                    MarkCheckFinished(chkStepOne);
                    
                    MarkCheckStarted(chkStepTwo);
                    UpdateProgress("Checking online manifest...", 5);

                    DownloadUpdates();
                    MarkCheckFinished(chkStepTwo);

                    MarkCheckStarted(chkStepThree);
                    InstallUpdates();

                    UpdateProgress("Verification and cleanup...", 5);
                    CheckAndCleanup();
                    UpdateProgress("Verification and cleanup...", 5);
                    MarkCheckFinished(chkStepThree);
                }
                else
                {
                    MarkCheckFinished(chkStepOne);
                    UpdateProgress("No updates found.", 95);
                }

                Success = true;
            }
            catch (Exception ex)
            {
                WorkerException = ex;
            }
        }

        public bool CheckForUpdates()
        {
            RemoteManifest.LoadFromUrl(Settings.Default.RemoteDeploymentManifest);

            string rootDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\";
            string localFile = "";
            DeploymentFile localDF;
            foreach (DeploymentFile df in RemoteManifest.Files)
            {
                if (Path.IsPathRooted(df.FileName))
                {
                    localFile = df.FileName;
                }
                else
                {
                    localFile = Path.Combine(rootDir, df.FileName);
                }

                if (!File.Exists(localFile))
                {
                    // This file is missing from the local system, updates are needed
                    FileUpdateList.Add(df);
                }
                else
                {
                    localDF = DeploymentFile.CreateFromFile(localFile);

                    if (localDF != df)
                    {
                        // This file does not match the remote manifest, updates are needed
                        FileUpdateList.Add(df);
                    }
                }
            }

            return FileUpdateList.Count > 0; // Updates are needed if there are any files in this list
        }

        private void CheckAndCleanup()
        {
            string tempDir = Path.GetTempPath() + Application.ProductName;
            string rootDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\";
            string localFile = "";
            DeploymentFile localDF;
            foreach (DeploymentFile df in RemoteManifest.Files)
            {
                if (Path.IsPathRooted(df.FileName))
                {
                    localFile = df.FileName;
                }
                else
                {
                    localFile = Path.Combine(rootDir, df.FileName);
                }

                if (!File.Exists(localFile))
                {
                    // This file is missing from the local system, updates are needed
                    throw new Exception("One or more files did not update successfully. The server checksum values do not match the local file.");
                }
                else
                {
                    localDF = DeploymentFile.CreateFromFile(localFile);

                    if (localDF != df)
                    {
                        // This file does not match the remote manifest, updates are needed
                        throw new Exception("One or more files did not update successfully. The server checksum values do not match the local file.");
                    }
                }
            }

            Directory.Delete(tempDir, true); // Delete all temporary files
        }

        private void DownloadUpdates()
        {
            string tempFile = "";
            string remoteFile = "";
            string tempDir = Path.GetTempPath() + Application.ProductName + "\\";
            int fileCount = 0;

            foreach (DeploymentFile df in FileUpdateList)
            {
                if (Path.IsPathRooted(df.FileName))
                {
                    tempFile = Path.Combine(tempDir, Path.GetFileName(df.FileName));
                    remoteFile = Settings.Default.FTPRootUri + Path.GetFileName(tempFile);
                }
                else
                {
                    tempFile = Path.Combine(tempDir, df.FileName);
                    remoteFile = tempFile.Replace(tempDir, Settings.Default.FTPRootUri).Replace("\\", "/");
                }

                Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                fileCount++;
                UpdateProgress(String.Format("Downloading {0} of {1}...",fileCount.ToString(), FileUpdateList.Count.ToString()), 5);

                DownloadFile(tempFile, remoteFile);
            }
        }

        private void InstallUpdates()
        {
            string rootDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\";
            string backupDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\Backups\\";
            string tempFile = "";
            string localFile = "";
            string backupFile = "";
            string backupTimeStamp = DateTime.Now.ToString("MM-dd-yyyy h-mm tt");
            string tempDir = Path.GetTempPath() + Application.ProductName;
            int fileCount = 0;

            foreach (DeploymentFile df in FileUpdateList)
            {
                if (Path.IsPathRooted(df.FileName))
                {
                    tempFile = Path.Combine(tempDir, Path.GetFileName(df.FileName));
                    localFile = df.FileName;
                    backupFile = Path.Combine(backupDir, Path.GetFileNameWithoutExtension(Path.GetFileName(df.FileName)) + backupTimeStamp + Path.GetExtension(df.FileName));
                }
                else
                {
                    tempFile = Path.Combine(tempDir, df.FileName);
                    localFile = Path.Combine(rootDir, df.FileName);
                    backupFile = Path.Combine(backupDir, Path.GetFileNameWithoutExtension(Path.GetFileName(df.FileName)) + backupTimeStamp + Path.GetExtension(df.FileName));
                }

                fileCount++;
                UpdateProgress(String.Format("Installing {0} of {1}...", fileCount.ToString(), FileUpdateList.Count.ToString()), 5);

                if ((File.Exists(localFile)) && (!File.Exists(backupFile)))
                {
                    // Make a backup of this file before overwriting it                    
                    Directory.CreateDirectory(Path.GetDirectoryName(backupFile));

                    File.Copy(localFile, backupFile);                    
                }

                // Copy from Temp to Local
                Directory.CreateDirectory(Path.GetDirectoryName(localFile));
                File.Copy(tempFile, localFile, true);
            }
        }

        private void DownloadFile(string localFileName, string requestUriString)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(requestUriString);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.KeepAlive = true;
            request.UseBinary = true;
            
            request.Credentials = new NetworkCredential(Settings.Default.FTPUserName, Settings.Default.FTPPassword);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            FileStream fs = new FileStream(localFileName, FileMode.Create);
            Byte[] buffer = new byte[2047];
            int read = 1;

            while (read > 0)
            {
                read = responseStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, read);
            }
            fs.Flush();
            fs.Close();

            responseStream.Close();
            response.Close();
            request = null;
        }

        private void frmUpdater_Load(object sender, EventArgs e)
        {
            WorkerThread.RunWorkerAsync();
        }

        private void UpdateProgress(string currentTask, int progress)
        {
            if (lblCurrentTask.InvokeRequired)
            {
                UpdateProgressDelegate upd = new UpdateProgressDelegate(UpdateProgress);
                Invoke(upd, new object[] { currentTask, progress });
            }
            else
            {
                lblCurrentTask.Text = currentTask;

                if (pbarMain.Maximum >= pbarMain.Value + progress)
                    pbarMain.Value += progress;
                else
                    pbarMain.Value = pbarMain.Maximum;

                pbarMain.Maximum = 20 + (FileUpdateList.Count * 10);
            }
        }
        
        private void MarkCheckStarted(CheckBox chkToChange)
        {
            if (chkToChange.InvokeRequired)
            {
                CheckBoxDelegate cd = new CheckBoxDelegate(MarkCheckStarted);
                Invoke(cd, new object[] { chkToChange });
            }
            else
            {
                chkToChange.ForeColor = STARTEDCOLOR;
                chkToChange.Checked = false;
            }
        }

        private void MarkCheckFinished(CheckBox chkToChange)
        {
            if (chkToChange.InvokeRequired)
            {
                CheckBoxDelegate cd = new CheckBoxDelegate(MarkCheckFinished);
                Invoke(cd, new object[] { chkToChange });
            }
            else
            {
                chkToChange.ForeColor = FINISHEDCOLOR;
                chkToChange.Checked = true;
            }
        }

        private void MarkCheckIncomplete(CheckBox chkToChange)
        {
            if (chkToChange.InvokeRequired)
            {
                CheckBoxDelegate cd = new CheckBoxDelegate(MarkCheckIncomplete);
                Invoke(cd, new object[] { chkToChange });
            }
            else
            {
                chkToChange.ForeColor = ForeColor;
                chkToChange.Checked = false;
            }
        }
    }
}