using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmUnusualPaymentRules : Form
    {
        Control _lastControl = null;

        public frmUnusualPaymentRules()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            ctlUnusualPaymentRuleAddNew.OrderID = grpExistingRules.Controls.Count;
            ctlUnusualPaymentRuleAddNew.Save();

            AddUnusualRule(ctlUnusualPaymentRuleAddNew.LinkedRule);
            ctlUnusualPaymentRuleAddNew.Clear();
        }

        private void frmUnusualPaymentRules_Load(object sender, EventArgs e)
        {
            LoadPaymentRules();
        }

        private void LoadPaymentRules()
        {
            grpExistingRules.Controls.Clear();

            unusual_payment_rules toLoad = new unusual_payment_rules();
            
            DataTable allRules = toLoad.Search(toLoad.SearchSQL + " ORDER BY order_id");

            foreach (DataRow aRow in allRules.Rows)
            {
                toLoad.Load(aRow);
                AddUnusualRule(toLoad);
            }
        }

        private void AddUnusualRule(unusual_payment_rules toLoad)
        {
            int top = 20;

            if (_lastControl != null)
            {
                top = _lastControl.Bottom + 4;
            }
            ctlUnusualPaymentRule toAdd = new ctlUnusualPaymentRule();
            toAdd.AutoSave = true;
            toAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            toAdd.LinkedRule = null;
            toAdd.Location = new System.Drawing.Point(6, top);
            toAdd.Name = "ctlUnusualPaymentRuleAddNew";
            toAdd.OrderID = toLoad.order_id;
            toAdd.Size = new System.Drawing.Size(529, 25);
            toAdd.TabIndex = toLoad.order_id;
            toAdd.Deleted += toAdd_Deleted;
            grpExistingRules.Controls.Add(toAdd);

            toAdd.LinkedRule = toLoad;

            

            _lastControl = toAdd;

        }

        void toAdd_Deleted(object sender, EventArgs e)
        {
            LoadPaymentRules();
        }
    }
}