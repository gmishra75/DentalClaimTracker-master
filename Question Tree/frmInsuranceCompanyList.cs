using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmInsuranceCompanyList : Form
    {
        private question _formQuestion;

        public frmInsuranceCompanyList(question qToShow)
        {
            InitializeComponent();
            _formQuestion = qToShow;

            lblTitle.Text += "\n\nShowing Insurance Companies for question:\n" + qToShow.text;
            InitializeInsuranceDropdown();
        }

        private void InitializeInsuranceDropdown()
        {
            clbInsuranceCompanies.Items.Add("All");

            company c = new company();

            foreach (DataRow aRow in c.GetAllData("name").Rows)
            {
                c = new company();
                c.Load(aRow);

                clbInsuranceCompanies.Items.Add(c);
            }

            DataTable matches = c.Search("SELECT * FROM question_insurance_companies WHERE question_id = " + _formQuestion.id);

            if (matches.Rows.Count > 0)
            {
                foreach (DataRow aMatch in matches.Rows)
                {
                    for (int i = 1; i < clbInsuranceCompanies.Items.Count; i++)
                    {

                        if (((company)clbInsuranceCompanies.Items[i]).id == (int)aMatch["insurance_id"])
                        {
                            clbInsuranceCompanies.SetItemChecked(i, true);

                            break;
                        }
                    }
                }
            }
            else
            {
                clbInsuranceCompanies.SetItemChecked(0, true);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            _formQuestion.ExecuteNonQuery("DELETE FROM question_insurance_companies WHERE question_id = " + _formQuestion.id);

            if (clbInsuranceCompanies.GetItemChecked(0))
            {
                // Do nothing!
            }
            else
            {
                foreach (company selectedCompany in clbInsuranceCompanies.CheckedItems)
                {
                    _formQuestion.ExecuteNonQuery("INSERT INTO question_insurance_companies (question_id, insurance_id) VALUES " +
                        "(" + _formQuestion.id + ", " + selectedCompany.id + ")");
                }
            }

            Close();
        }

        private void clbInsuranceCompanies_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    foreach (int checkedIndex in clbInsuranceCompanies.CheckedIndices)
                    {
                        if (checkedIndex > 0)
                            clbInsuranceCompanies.SetItemChecked(checkedIndex, false);
                    }
                }
            }
            else
                clbInsuranceCompanies.SetItemChecked(0, false);
        }
    }
}