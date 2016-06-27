using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Threading;


using C_DentalClaimTracker.OMPropel;
using System.Security.Cryptography;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    public partial class frmFTPTransfers : Form
    {
        delegate void EmptyDelegate();
        delegate void UpdateLabelDelegate(string newText, bool append);
        delegate void UpdateProgressBarDelegate(int newValue);
        int uploadAttempts = 0;
        public List<string> dataToUpload { get; set; }
        System.Timers.Timer formTimer = new System.Timers.Timer(1000);
        int currentUploadIndex = 0;
        string errorText = "";
        List<string> errorFiles1 = new List<string>(); // the first part of the ID of a claim that had problems uploading
        List<string> errorFiles2 = new List<string>(); // the econd part of the ID for a claim that had problems uploading
        decimal increment;
        decimal progress;

        public event EventHandler RequestDownloadCompleted;
        public event EventHandler FullDownloadCompleted;
        public event EventHandler RequestUploadCompleted;
        public event EventHandler DownloadCancelled;
        public event EventHandler UploadCancelled;
        public event EventHandler FullUploadCompleted;
        public delegate void ErrorEventHandler(List<string> id1, List<string> id2);
        public event ErrorEventHandler UploadErrors;
        UpdateLabelDelegate updateMainLabel;
        UpdateProgressBarDelegate updateProgressBar;
        UpdateLabelDelegate updateBottomBar;
        EmptyDelegate uploadFiles;
        const string BOTTOMBARDOWNLOADTEXT = "Use 'Retry Download' if there is a problem with the download.";
        const string BOTTOMBARUPLOADTEXT = "Uploading puts the file on the internet so it's accessible to other computers.";
        public bool CloseOnComplete { get; set; }
        private bool uploadComplete = false;
        public bool HideOnClose { get; set; }
        public bool _claimMode;

        public frmFTPTransfers(bool hideForm = true, bool claimMode = true)
        {
            StandardInitialization();
            HideOnClose = hideForm;
            _claimMode = claimMode;
        }

        public frmFTPTransfers(string filesFolder, bool claimMode = true)
        {
            StandardInitialization();
            _claimMode = claimMode;
        }

        public frmFTPTransfers(List<string> uploadData, bool claimMode = true)
        {
            StandardInitialization();
            dataToUpload = uploadData;
            _claimMode = claimMode;
        }

        private void StandardInitialization()
        {
            InitializeComponent();
            updateMainLabel = new UpdateLabelDelegate(UpdateMainLabel);
            updateProgressBar = new UpdateProgressBarDelegate(UpdateProgressBar);
            updateBottomBar = new UpdateLabelDelegate(UpdateBottomBar);
            uploadFiles = new EmptyDelegate(StartFileUploadThreadSafe);
            CloseOnComplete = true;
            formTimer.AutoReset = false;
            formTimer.Elapsed += formTimer_Elapsed;
        } 

        public void ResetForm(string Message = "")
        {
            UpdateProgressBar(0);
            if (Message != "")
                UpdateMainLabel(Message, false);
        }

        public void UpdateMainLabel(string newText, bool append)
        {
            if (lblMain.InvokeRequired)
                Invoke(updateMainLabel, newText, append);
            else
                if (append)
                    lblMain.Text += newText;
                else
                    lblMain.Text = newText;
        }

        private void UpdateProgressBar(int newValue)
        {
            if (pbarMain.InvokeRequired)
                Invoke(updateProgressBar, newValue);
            else
            {
                if (newValue >= 0 && newValue <= 100)
                    pbarMain.Value = newValue;
            }
        }

        public void UpdateBottomBar(string newText, bool append)
        {
            if (txtBottomBar.InvokeRequired)
                Invoke(updateBottomBar, newText, append);
            else
                if (append)
                    txtBottomBar.Text += newText;
                else
                    txtBottomBar.Text = newText;
        }

        private void frmDownloadFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!uploadComplete)
                {
                    e.Cancel = true;
                    UpdateBottomBar("Please wait for the upload to finish before closing this form.", false);
                }
            }

            if (HideOnClose && !e.Cancel)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFTPTransfers_Load(object sender, EventArgs e)
        {
            
        }

        public void StartFileUpload()
        {
            try
            {
                pbarMain.Value = 0;
                increment = 100 / dataToUpload.Count;
                progress = 0;
                currentUploadIndex = 0;
                if (_claimMode)
                    UpdateBottomBar("Claims are being sent to Mercury for processing.", false);
                else
                    UpdateBottomBar("Eligibility Data is being sent to Mercury for processing.", false);
                UploadCurrentFile();
                
            }
            catch (Exception err)
            {
                LoggingHelper.Log("An error occurred uploading claims to Mercury. " + err.Message, LogSeverity.Error);
            }
        }

        private void UploadCurrentFile()
        {
            if (progress < 100)
                updateProgressBar(Convert.ToInt32(progress));
            else
                updateProgressBar(100);

            ThreadStart ts = new ThreadStart(StartFileUploadThreadSafe);
            Thread t = new Thread(ts);

            t.Start();
        }

        private void StartFileUploadThreadSafe()
        {
            uploadAttempts++;
            string aFile = dataToUpload[currentUploadIndex];
            if (_claimMode)
                UpdateMainLabel(string.Format("Sending claim {0} of {1}.\nAttempt {2} of 3.", (currentUploadIndex + 1), dataToUpload.Count, uploadAttempts), false);
            else
                UpdateMainLabel("Sending Eligibility Data For Processing.", false);

            bool success;

            try
            {
                success = UploadData(aFile);
            }
            catch (Exception err)
            {
                success = false;
                errorText += err.Message;
            }
            

            if (success)
            {
                if (_claimMode)
                    UpdateBottomBar("\nClaim " + (currentUploadIndex + 1) + " sent successfully.", true);
                else
                    UpdateBottomBar("\nEligibility Data Processed Successfully.", true);
                progress += increment;
                currentUploadIndex++;
                uploadAttempts = 0;
            }
            else
            {
                if (uploadAttempts < 3)
                    formTimer.Start();
                else
                {
                    // Put this claim in the 'Mercury Errors Batch'
                    try
                    {
                        if (aFile.Contains("-"))
                        {
                            errorFiles1.Add(aFile.Substring(0, aFile.IndexOf("-")));
                            errorFiles2.Add(aFile.Substring(aFile.IndexOf("-") + 1));
                        }
                        else
                            LoggingHelper.Log("Invalid file name when exporting Mercury claims.", LogSeverity.Error);
                    }
                    catch
                    {
                        LoggingHelper.Log("Invalid file name when exporting Mercury claims.", LogSeverity.Error);
                    }

                    string newErrorText;

                    if (_claimMode)
                        newErrorText = "An error occurred uploading claim " + (currentUploadIndex + 1) + ". ";
                    else
                        newErrorText = "An error occurred uploading Eligibility Data.";

                    errorText += newErrorText;
                    UpdateBottomBar("\n" + newErrorText, true);

                    progress += increment;
                    currentUploadIndex++;
                    uploadAttempts = 0;
                    
                    success = true;
                }
            }

            if (currentUploadIndex == dataToUpload.Count)
                AllFilesUploaded();
            else if (success)
                UploadCurrentFile();
        }

        private void AllFilesUploaded()
        {
            updateProgressBar(100);
            uploadComplete = true;

            if (errorText == "")
            {
                if (FullUploadCompleted != null)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() => FullUploadCompleted(this, new EventArgs())));
                    }
                    else
                        FullUploadCompleted(this, new EventArgs());
                }

                UpdateBottomBar("Files sent successfully.", true);
                if (this.InvokeRequired)
                    this.Invoke((Action)this.Close);
                else
                    Close();
            }
            else
            {
                LoggingHelper.Log("An error occurred uploading files to Mercury." + errorText, LogSeverity.Error);
                if (_claimMode)
                    UpdateBottomBar("\nAn error occurred sending files to Mercury. Any files with problems have been added to the daily error batch. They may need to be resent.", true);
                else
                    UpdateBottomBar("\nAn error occurred sending files to Mercury. The status for these files will not be changed.", true);
                if (UploadErrors != null)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() => UploadErrors(errorFiles1, errorFiles2)));
                    }
                }
            }
        }

        void formTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            formTimer.Stop();
            UploadCurrentFile();
        }

        private static byte[] StreamFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] fileData = new byte[fs.Length];
            fs.Read(fileData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return fileData;
        }

        private bool UploadData(string xmlData)
        {
            OMPropel.RequestInboundClient svc = new RequestInboundClient();
            OMPropel.RequestServiceResponse response;
            string userKey = "OMD000639||NEWHAVENDE||NEWHAVENDE";
            // string userKey = "CBO000639||NEWHAVENDE||NEWHAVENDE";
            
            string encryptedUserKey = Encrypt(userKey);

            if (_claimMode)
                response = svc.UploadClaim(encryptedUserKey, "NEWHAVENDE", xmlData);
            else
                response = svc.UploadEligibilityRequest(encryptedUserKey, "NEWHAVENDE", xmlData);

            if (!response.IsTranslationSuccessful)
            {
                foreach (string error in response.Errors)
                {
                    Console.WriteLine("Error reported by XML Service: " + error);
                }
            }
            
            return response.IsTranslationSuccessful;
        }

        public static string Encrypt(string TextToBeEncrypted)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            string Password = "P@SSWORD";
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(TextToBeEncrypted);
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string EncryptedData = Convert.ToBase64String(CipherBytes);
            return EncryptedData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartFileUpload();
        }

        internal void Initialize()
        {
            ResetForm();
        }
    }
}
