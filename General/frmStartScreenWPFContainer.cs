using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C_DentalClaimTracker.Claims_Primary;

namespace C_DentalClaimTracker.General
{
    public partial class frmStartScreenWPFContainer : Form
    {
        
        static frmStartScreenWPFContainer _instance = null;
        frmLoginWPF frmLogin;
        frmStartScreenWPF frmStartScreen;
        frmSearchClaimWPF frmSearchScreen;

        public static frmStartScreenWPFContainer Instance()
        {
            if (_instance == null)
            {
                _instance = new frmStartScreenWPFContainer();
            }
            return _instance;
        }

        public frmStartScreenWPFContainer()
        {
            InitializeComponent();
            
            frmLogin = new frmLoginWPF();
            frmLogin.LoginSuccess += frmLogin_LoginSuccess;
            frmLogin.RequestEditDBSettings += frmLogin_RequestEditDBSettings;
            frmLogin.RequestExit += wpf_RequestExit;

            elementHost1.Child = frmLogin;
            elementHost1.Focus();
        }

        void frmLogin_RequestEditDBSettings()
        {
            frmSettings toShow = new frmSettings(true);
            toShow.ShowDialog(this);
        }

        void frmLogin_LoginSuccess()
        {
            frmStartScreen = new frmStartScreenWPF();
            frmStartScreen.RequestClose += wpf_RequestClose;
            frmStartScreen.RequestExit += wpf_RequestExit;
            frmStartScreen.RequestSearch += wpf_RequestSearch;

            frmSearchScreen = new frmSearchClaimWPF();
            frmSearchScreen.RequestClose += frmSearchScreen_RequestClose;
            
            elementHost1.Child = frmStartScreen;
            elementHost1.Focus();

        }

        void frmSearchScreen_RequestClose()
        {
            if (frmStartScreen.SearchWhereClause != "")
            {
                frmSearchScreen.SetTitle("Search Claims");
                frmSearchScreen.ClearSearch();
            }

            elementHost1.Child = frmStartScreen;
            elementHost1.Focus();
        }

        void wpf_RequestExit()
        {
            try
            {
                mdiMain.Instance().Close();
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Unable to exit - please close any open Claim Tracker forms to complete exit.");
            }
        }

        void wpf_RequestSearch()
        {
            frmSearchScreen.SetTitle(frmStartScreen.SearchTitle);
            
            elementHost1.Child = frmSearchScreen;
            elementHost1.Focus();



            if (frmStartScreen.SearchWhereClause != "")
            {
                frmSearchScreen.InitializeDisplay(true, frmStartScreen.SearchWhereClause, " ORDER BY cmp.name, c.sent_date");
            }
            else
            {
                frmSearchScreen.InitializeDisplay(false);
            }
        }

        private void frmStartScreenWPFContainer_Load(object sender, EventArgs e)
        {

        }

        void wpf_RequestClose()
        {
            mdiMain.Instance().PrimaryStartScreen = this;
            mdiMain.Instance().Show();
            Hide();
        }

        private void frmStartScreenWPFContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmStartScreenWPFContainer_Activated(object sender, EventArgs e)
        {
            if (elementHost1.Child is frmSearchClaimWPF)
            {
                ((frmSearchClaimWPF)elementHost1.Child).ForceStatusUpdate();
            }
        }
    }
}
