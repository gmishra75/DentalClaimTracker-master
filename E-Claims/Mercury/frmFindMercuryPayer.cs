using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    public partial class frmFindMercuryPayer : Form
    {
        public string PayerID { get; set; }
        public string PayerName { get; set; }
        public frmFindMercuryPayer(string defaultProviderText = "")
        {
            InitializeComponent();
            PayerID = "";
            lblProviderInfo.Text = defaultProviderText;
            txtProviderName.Text = defaultProviderText;
        }

        private void frmFindMercuryPayer_Load(object sender, EventArgs e)
        {
            // On load, populate the All Payers box and do our initial SQL search for matches
            // split the string on space and search for each word
            mercury_payer_list mpl = new mercury_payer_list();

            foreach (DataRow aRow in mpl.GetAllData("name").Rows)
            {
                lstAllPayers.Items.Add(new PayerDisplayData(aRow["name"].ToString(), aRow["payer_id"].ToString(), (int) aRow["id"]));
            }

            Search();
        }

        private void Search()
        {
            string searchText = CommonFunctions.TrimSpaces(txtProviderName.Text);
            string baseSQL = string.Format("SELECT mpl.name, mpl.payer_id, mpl.id FROM mercury_payer_list mpl " +
                "LEFT JOIN mercury_payer_alias mpa ON mpl.id = mpa.mercury_id WHERE " +
                "mpl.Name = '{0}' OR mpa.alias = '{0}' ORDER BY mpl.name", searchText);

            mercury_payer_list mpl = new mercury_payer_list();

            lstSearchResults.Items.Clear();
            FillSearchResults(mpl.Search(baseSQL));

            string extraSQL = string.Format("SELECT mpl.name, mpl.payer_id, mpl.id FROM mercury_payer_list mpl " +
                "LEFT JOIN mercury_payer_alias mpa ON mpl.id = mpa.mercury_id WHERE " +
                "mpl.Name LIKE '%{0}%' OR mpa.alias LIKE '%{0}%' ORDER BY mpl.name", searchText);

            FillSearchResults(mpl.Search(extraSQL));

            if (searchText.Contains(" "))
            {
                // All Match
                string[] individualTerms = searchText.Split(" "[0]);
                string individualSQL = "SELECT mpl.name, mpl.payer_id, mpl.id FROM mercury_payer_list mpl " +
                "LEFT JOIN mercury_payer_alias mpa ON mpl.id = mpa.mercury_id WHERE 1 = 1 ";

                foreach (string term in individualTerms)
                    individualSQL += string.Format(" AND mpl.Name LIKE '%{0}%'", term);

                individualSQL += " ORDER BY NAME";

                FillSearchResults(mpl.Search(individualSQL));


                // One Match
                individualSQL = "SELECT mpl.name, mpl.payer_id, mpl.id FROM mercury_payer_list mpl " +
                "LEFT JOIN mercury_payer_alias mpa ON mpl.id = mpa.mercury_id WHERE 0 = 1 ";

                foreach (string term in individualTerms)
                    individualSQL += string.Format(" OR mpl.Name LIKE '%{0}%'", term);
                
                individualSQL += " ORDER BY NAME";

                FillSearchResults(mpl.Search(individualSQL));
            }
        }

        private void FillSearchResults(DataTable data)
        {
            foreach (DataRow aRow in data.Rows)
            {
                if (lstSearchResults.FindStringExact(aRow[0].ToString()) == ListBox.NoMatches)
                    lstSearchResults.Items.Add(new PayerDisplayData(aRow[0].ToString(), aRow[1].ToString(), (int)aRow["id"]));
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSelectPayer_Click(object sender, EventArgs e)
        {
            UseSelectedCode();
        }

        private void UseSelectedCode()
        {
            bool isValid = true;
            if (lstSearchResults.Items.Count == 0)
            {
                MessageBox.Show(this, "No matches were found. Please double-click a valid entry from the All Payers list or try another search.");
                isValid = false;
            }
            else if (lstSearchResults.Items.Count == 1)
                lstSearchResults.SelectedIndex = 0;
            else if (lstSearchResults.SelectedIndex == ListBox.NoMatches)
            {
                MessageBox.Show(this, "Please select an item from the Matching Payers list above or double-click a valid entry from the All Payers list.");
                isValid = false;
            }
            
            if (isValid)
            {
                PayerID = ((PayerDisplayData)lstSearchResults.SelectedItem).PayerID;
                PayerName = ((PayerDisplayData)lstSearchResults.SelectedItem).DisplayData;
                AddAlias((PayerDisplayData)lstSearchResults.SelectedItem);
                Close();
            }
                
        }

        private void btnUseCode_Click(object sender, EventArgs e)
        {
            if (txtOverrideCode.Text.Trim() == "")
                MessageBox.Show(this, "The override code cannot be empty.");
            else
            {
                // Just assume code is OK and they aren't pulling shenanigans
                UseOverrideData();
                Close();
            }
        }

        private void lstAllPayers_DoubleClick(object sender, EventArgs e)
        {
            if (lstAllPayers.SelectedIndex >= 0)
            {
                PayerID = ((PayerDisplayData)lstAllPayers.SelectedItem).PayerID;
                Close();
            }
        }

        private void AddAlias(PayerDisplayData pdd)
        {
            try
            {
                mercury_payer_alias mpa = new mercury_payer_alias();
                mpa.alias = lblProviderInfo.Text;
                mpa.mercury_id = pdd.ID;
                mpa.Save();
            }
            catch // Just let this go, probably a duplicate key error which we don't care about
            {}
        }

        private void lstSearchResults_DoubleClick(object sender, EventArgs e)
        {
            UseSelectedCode();
        }

        private void frmFindMercuryPayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PayerID == "")
            {
                if (txtOverrideCode.Text.Trim() == "")
                {
                    MessageBox.Show("The override code cannot be empty.");
                    e.Cancel = true;
                }
                else
                    UseOverrideData();
                
            }
        }

        private void UseOverrideData()
        {
            PayerID = txtOverrideCode.Text.Trim();
            PayerName = lblProviderInfo.Text;
        }

        
    }
}
