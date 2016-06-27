using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Provider_Eligibility
{
    public partial class frmSelectProvider : Form
    {
        claim _selectedClaim = null;
        public frmSelectProvider()
        {
            InitializeComponent();
        }

        public claim SelectedClaim
        {
            get { return _selectedClaim; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProvider();

        }

        private void SearchProvider()
        {
            claim searchObject = new claim();

            DataTable providers = searchObject.Search("SELECT DISTINCT(doctor_provider_id), doctor_first_name, doctor_last_name FROM claims " +
                "WHERE doctor_provider_id IS NOT Null ");

            foreach (DataRow aRow in providers.Rows)
            {
                searchObject = new claim();
                string sql = "SELECT TOP 1 * FROM claims WHERE doctor_provider_id = '" + aRow["doctor_provider_id"] +
                    "' ORDER BY ID desc";
                searchObject.Load(searchObject.Search(sql).Rows[0]);

                dgvResults.Rows.Add(new object[] { aRow["doctor_provider_id"].ToString(), 
                    aRow["doctor_first_name"].ToString() + " " + aRow["doctor_last_name"].ToString(), searchObject });
            }
        }

        private void btnOpenClaim_Click(object sender, EventArgs e)
        {
            ChooseSelectedProvider();
        }

        private void ChooseSelectedProvider()
        {
            if (dgvResults.SelectedCells.Count > 0)
            {
                _selectedClaim = (claim) dgvResults.Rows[dgvResults.SelectedCells[0].RowIndex].Cells["colClaimObject"].Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dgvResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseSelectedProvider();
        }

        private void frmSelectProvider_Load(object sender, EventArgs e)
        {
            SearchProvider();
        }
    }
}