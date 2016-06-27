using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.E_Claims
{
    public partial class frmApexRulesManager : Form
    {
        public frmApexRulesManager()
        {
            InitializeComponent();
        }

        private void frmApexRulesManager_Load(object sender, EventArgs e)
        {
            InitializeRules();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            frmApexRulesEdit toShow = new frmApexRulesEdit(null);
            toShow.ShowDialog(this);
            InitializeRules();
        }

        private void InitializeRules()
        {
            apex_rules_rulelist arr = new apex_rules_rulelist();
            List<apex_rules_rulelist> arrList = arr.GetAllRules(true);

            dgvMain.Rows.Clear();
            foreach (apex_rules_rulelist aRule in arrList)
            {
                dgvMain.Rows.Add(new object[] { aRule.name, aRule.rule_text, aRule.LinkedProcedureCodesAsString, 
                    aRule.apply_primary, aRule.apply_secondary, aRule.apply_predeterm, aRule.LinkedInsuranceAsString, aRule } );

            }
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                frmApexRulesEdit toShow = new frmApexRulesEdit((apex_rules_rulelist)dgvMain.SelectedRows[0].Cells["colRuleObject"].Value);
                toShow.ShowDialog(this);
                InitializeRules();
            }
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                int rowIndex = dgvMain.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    if (rowIndex > 0)
                    {
                        DataGridViewRow dgvr = dgvMain.Rows[rowIndex];
                        apex_rules_rulelist arr = (apex_rules_rulelist) dgvr.Cells[colRuleObject.Index].Value;
                        arr.priority = rowIndex - 1;
                        arr.Save();

                        arr = (apex_rules_rulelist)dgvMain.Rows[rowIndex - 1].Cells[colRuleObject.Index].Value;
                        arr.priority = rowIndex + 1;
                        arr.Save();

                        dgvMain.Rows.RemoveAt(rowIndex);
                        dgvMain.Rows.Insert(rowIndex - 1, dgvr);



                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (rowIndex < dgvMain.Rows.Count - 1)
                    {
                        DataGridViewRow dgvr = dgvMain.Rows[rowIndex];

                        apex_rules_rulelist arr = (apex_rules_rulelist)dgvr.Cells[colRuleObject.Index].Value;
                        arr.priority = rowIndex + 1;
                        arr.Save();

                        arr = (apex_rules_rulelist)dgvMain.Rows[rowIndex + 1].Cells[colRuleObject.Index].Value;
                        arr.priority = rowIndex - 1;
                        arr.Save();


                        dgvMain.Rows.RemoveAt(rowIndex);
                        dgvMain.Rows.Insert(rowIndex + 1, dgvr);
                    }
                }
            }
        }
    }
}