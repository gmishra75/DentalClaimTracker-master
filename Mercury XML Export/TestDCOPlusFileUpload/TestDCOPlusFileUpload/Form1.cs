using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using TestDCOPlusFileUpload.DCOPlus.Operations;
using System.Security.Cryptography;

namespace TestDCOPlusFileUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static byte[] StreamFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] fileData = new byte[fs.Length];
            fs.Read(fileData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return fileData;
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            ServiceSoapClient svc = new ServiceSoapClient();

            string userKey = "CBO00462||BRStest||BRStest";
            string encryptedUserKey = Encrypt(userKey);
            //Decrypt(encryptedUserKey);            
            
            byte[] fileData = StreamFile(FileToUpload.Text);
            //string testFileData = ExtractFileData(fileData);

            bool result = svc.UploadFile(encryptedUserKey, dlgPickFile.SafeFileName, fileData);
            MessageBox.Show(result.ToString());
        }

        private void ChooseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dlgPickFile.ShowDialog(this);
            FileToUpload.Text = dlgPickFile.FileName;
            Upload.Enabled = (FileToUpload.Text.Length > 0);
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

        //public static string Decrypt(string TextToBeDecrypted)
        //{
        //    string Password = "P@SSWORD";
        //    RijndaelManaged RijndaelCipher = new RijndaelManaged();
        //    string DecryptedData;
        //    byte[] EncryptedData = Convert.FromBase64String(TextToBeDecrypted);
        //    byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());
        //    PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);
        //    ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
        //    MemoryStream memoryStream = new MemoryStream(EncryptedData);
        //    CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);
        //    byte[] PlainText = new byte[EncryptedData.Length];
        //    int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
        //    memoryStream.Close();
        //    cryptoStream.Close();
        //    DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
        //    return DecryptedData;
        //}

        //private string ExtractFileData(byte[] Content)
        //{
        //    string Data = System.Text.ASCIIEncoding.ASCII.GetString(Content);
        //    return Data;
        //}

    }
}
