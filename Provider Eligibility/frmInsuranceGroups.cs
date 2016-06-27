using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmInsuranceGroups : Form
    {
        public frmInsuranceGroups()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedItem();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            frmEditInsuranceGroup toShow = new frmEditInsuranceGroup();
            try
            { toShow.ShowDialog(); }
            catch { }

            LoadGroups();
        }

        private void LoadGroups()
        {
            insurance_company_group workingGroup = new insurance_company_group();

            DataTable allMatches = workingGroup.Search("SELECT * FROM insurance_company_groups ORDER BY id");

            dgvMain.Rows.Clear();
            foreach (DataRow aRow in allMatches.Rows)
            {
                workingGroup = new insurance_company_group();
                workingGroup.Load(aRow);

                dgvMain.Rows.Add(new object[] { workingGroup.name, workingGroup.description, workingGroup.GetFiltersAsString(), workingGroup });
            }
        }

        private void frmProviderEligibilityRestrictions_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSelectedItem();
        }

        private void EditSelectedItem()
        {
            frmEditInsuranceGroup toShow =
                new frmEditInsuranceGroup((insurance_company_group)dgvMain.SelectedRows[0].Cells["colGroupObject"].Value);

            toShow.ShowDialog();
            LoadGroups();
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvMain.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(this, "Are you sure you want to delete this?", "Delete Restriction?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete it, reload everything
                        ((insurance_company_group)dgvMain.SelectedRows[0].Cells["colGroupObject"].Value).Delete();
                        LoadGroups();
                    }
                }
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}