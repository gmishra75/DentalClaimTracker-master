using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmApexBrowser : Form
    {
        string STARTADDRESS = C_DentalClaimTracker.Properties.Settings.Default.ApexSiteURL;
        string AFTERLOGIN = "https://www.apexedi.com/doctorHome.jsp";
        string SIMPLEUPLOAD = "https://www.apexedi.com/simpleUpload.jsp";
        string REPORTS = "https://www.apexedi.com/correspondence.jsp";

        public frmApexBrowser()
        {
            InitializeComponent();
            wbMain.Navigate(STARTADDRESS);
        }

        private void frmApexBrowser_Load(object sender, EventArgs e)
        {
           
        }

        private void lnkTest1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string errorText = "";

            if (wbMain.Url.AbsoluteUri == STARTADDRESS)
            {
                try
                {
                    wbMain.Document.All["username"].InnerText = "nhd";
                    // wbMain.Document.All["ctl00_Main_txtIdea"].InnerText = "automation test";

                }
                catch (Exception err)
                {
                    errorText += "\n" + err.Message;
                }
                try
                {
                    wbMain.Document.All["password"].InnerText = "QEKAMG";
                    // wbMain.Document.All["ctl00_Main_txtEmail"].InnerText = "aaron";
                }
                catch (Exception err)
                {
                    errorText += "\n" + err.Message;
                }

                // wbMain.Document.GetElementById("ctl00$Main$btnSubmit").InvokeMember("click");
                wbMain.Document.GetElementById("loginBtn").InvokeMember("click");

            }
            else if (wbMain.Url.AbsoluteUri == AFTERLOGIN)
            {
                wbMain.Navigate(SIMPLEUPLOAD);
            }
            else if (wbMain.Url.AbsoluteUri == SIMPLEUPLOAD)
            {
                // Should be clicking on upload here before redirecting to the reports page
                wbMain.Navigate(REPORTS);
            }


            if (errorText != string.Empty)
            {
                MessageBox.Show("There was an error loading the webpage." + errorText);
            }
        }
    }
}