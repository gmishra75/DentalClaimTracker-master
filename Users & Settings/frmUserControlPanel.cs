using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmUserControlPanel : Form
    {
        user _formUser;
        bool _dataChanged;

        public frmUserControlPanel(user formUser)
        {
            InitializeComponent();
            _formUser = formUser;
            ShowData();
            FillOfficeList();
        }

        private void ShowData()
        {
            txtUserName.Text = _formUser.username;
            chkShowClaimSearch.Checked = _formUser.UserData.open_search_form;
            chkShowEclaims.Checked = _formUser.UserData.open_eclaims_form;
            try
            {
                nmbDefaultSearchDate.Value = Convert.ToDecimal(_formUser.UserData.search_form_sent_date);
            }
            catch
            {
                nmbDefaultSearchDate.Value = -40;
            }
            chkShowMyClaimsFirst.Checked = _formUser.UserData.show_my_claims_first;
            _dataChanged = false;
        }

        private void SaveData()
        {
            _formUser.UserData.open_search_form = chkShowClaimSearch.Checked;
            _formUser.UserData.open_eclaims_form = chkShowEclaims.Checked;
            _formUser.UserData.search_form_sent_date = Convert.ToInt32(nmbDefaultSearchDate.Value);
            _formUser.UserData.show_my_claims_first = chkShowMyClaimsFirst.Checked;
            _formUser.UserData.Save();
            _dataChanged = false;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            _dataChanged = true;
        }

        private void frmUserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !RecordChangeOK();
        }

        private bool RecordChangeOK()
        {
            if (_dataChanged)
            {
                DialogResult dr = MessageBox.Show(this, "Unsaved changes exist. Would you like to save these changes before continuing?",
                    "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                    return false;
                else if (dr == DialogResult.No)
                    return true;
                else
                {
                    SaveData();
                    return true;
                }
            }
            else
                return true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            _dataChanged = false;
            Close();
        }

        private void lnkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword toShow = new frmChangePassword(_formUser);
            toShow.ShowDialog(this);
        }
        private void FillOfficeList()
        {
            clinic aClinic = new clinic();
            int incr = 0;
            foreach (DataRow aRow in aClinic.GetAllData("name").Rows)
            {
                incr = incr + 30;
                aClinic = new clinic();
                aClinic.Load(aRow);
                var a = GenerateClinicUI(aClinic, user_preferences_clinics.Get(ActiveUser.UserObject.id, aClinic.id), incr);
                pnlOffices.Controls.Add(a);
            }
        }
        private Panel GenerateClinicUI(clinic c, bool isChecked, int incr)
        {
            CheckBox cb = new CheckBox();
            cb.Text = c.name;
            cb.AutoSize = true;
            cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cb.Size = new System.Drawing.Size(69, 17);
            cb.Location = new System.Drawing.Point(112, 6);
            cb.UseVisualStyleBackColor = true;
            cb.Tag = c;
            cb.Checked = isChecked;
            cb.CheckedChanged += checkBoxes_CheckedChanged;
            cb.CheckStateChanged += checkBoxes_CheckStateChanged;

            Panel toReturn = new Panel();
            toReturn.Size = new System.Drawing.Size(188, 26);
            toReturn.Location = new System.Drawing.Point(-5, incr);
            toReturn.Controls.Add(cb);

            return toReturn;
        }
        void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            //user_preferences_clinics.Set(ActiveUser.UserObject.id, ((clinic)((Control)sender).Tag).id, ((CheckBox)sender).Checked);
            //UpdateButtonCounts();
        }
        void checkBoxes_CheckStateChanged(object sender, EventArgs e)
        {
        }
    }
}