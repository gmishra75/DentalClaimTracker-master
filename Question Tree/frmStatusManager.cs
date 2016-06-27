using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmStatusManager : Form
    {
        claim_status selectedStatus;

        public frmStatusManager()
        {
            InitializeComponent();

            RefreshStatusList();
        }

        private void RefreshStatusList()
        {
            claim_status cs = new claim_status();

            foreach (DataRow aRow in cs.GetAllData("orderid").Rows)
            {
                cs = new claim_status();
                cs.Load(aRow);

                lstStatusList.Items.Add(cs);
            }

            if (lstStatusList.Items.Count > 0)
                lstStatusList.SelectedIndex = 0;
        }

        private void lstStatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStatusList.SelectedIndex > -1)
            {
                selectedStatus = (claim_status)lstStatusList.SelectedItem;

                txtName.Text = selectedStatus.name;
                txtDescription.Text = selectedStatus.description;
                txtClassifications.Text = GetClassifications();
                chkVisible.Checked = selectedStatus.user_visible;

                txtName.Enabled = true;
                txtDescription.Enabled = true;
                chkVisible.Enabled = true;
            }
        }

        private string GetClassifications()
        {
            string classifications = "";

            foreach (DataRow aRow in selectedStatus.Search("SELECT text FROM questions WHERE linked_status = " + selectedStatus.id +
                " ORDER BY text").Rows)
            {
                classifications += aRow[0].ToString() + "\r\n";
            }

            return classifications;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            selectedStatus.name = txtName.Text;
            selectedStatus.Save();

            int i = lstStatusList.SelectedIndex;

            lstStatusList.Items.Remove(lstStatusList.SelectedItem);

            lstStatusList.Items.Insert(i, selectedStatus);

            lstStatusList.SelectedIndex = i;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            selectedStatus.description = txtDescription.Text;
            selectedStatus.Save();
        }

        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            if (lstStatusList.SelectedIndex > 0)
            {
                // Switch the indexes of these two items
                int i = lstStatusList.SelectedIndex;

                selectedStatus.orderid = i - 1;
                selectedStatus.Save();

                claim_status switchStatus = (claim_status) lstStatusList.Items[lstStatusList.SelectedIndex - 1];
                switchStatus.orderid = i;
                switchStatus.Save();

                lstStatusList.Items.Remove(lstStatusList.SelectedItem);
                lstStatusList.Items.Insert(i - 1, selectedStatus);

                lstStatusList.SelectedIndex = i - 1;
            }
        }

        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            if (lstStatusList.SelectedIndex < lstStatusList.Items.Count - 1 && lstStatusList.SelectedIndex >= 0)
            {
                int i = lstStatusList.SelectedIndex;

                selectedStatus.orderid = i + 1;
                selectedStatus.Save();

                claim_status switchStatus = (claim_status)lstStatusList.Items[lstStatusList.SelectedIndex + 1];
                switchStatus.orderid = i;
                switchStatus.Save();

                lstStatusList.Items.Remove(lstStatusList.SelectedItem);
                lstStatusList.Items.Insert(i + 1, selectedStatus);

                lstStatusList.SelectedIndex = i + 1;
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (SelectedStatusNotUsed())
            {
                selectedStatus.Delete();

                int i = lstStatusList.SelectedIndex;

                lstStatusList.Items.Remove(lstStatusList.SelectedItem);

                if (i < lstStatusList.Items.Count - 1)
                    lstStatusList.SelectedIndex = i;
                else if (lstStatusList.Items.Count > 0)
                    lstStatusList.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(this, "This status cannot be deleted, it is being used by a claim.");
            }
        }

        private bool SelectedStatusNotUsed()
        {
            if (selectedStatus.Search("SELECT * FROM claims WHERE status_ID = " + selectedStatus.id).Rows.Count > 0)
                return false;
            else
                return true;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            claim_status cs = new claim_status();
            cs.name = "Enter name here...";
            cs.orderid = lstStatusList.Items.Count;
            cs.user_visible = true;
            cs.Save();

            lstStatusList.Items.Add(cs);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkVisible_Leave(object sender, EventArgs e)
        {
            selectedStatus.user_visible = chkVisible.Checked;
            selectedStatus.Save();
        }
    }
}