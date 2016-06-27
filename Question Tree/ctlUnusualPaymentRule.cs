using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class ctlUnusualPaymentRule : UserControl
    {
        private bool _loading = true;
        public event EventHandler Deleted;
        private unusual_payment_rules _linkedRule = null;
        private int _orderID = 0;
        private bool _autoSave = true;

        public ctlUnusualPaymentRule()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        public unusual_payment_rules LinkedRule
        {
            get
            { return _linkedRule; }
            set
            { 
                LoadRule(value);
            }
        }

        /// <summary>
        /// Be sure to manually set this when placing the control
        /// </summary>
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public bool AutoSave
        {
            get { return _autoSave; }
            set { _autoSave = value; }
        }

        private void InitializeComboBoxes()
        {
            cmbOperatorDropDown.Items.Add("Less than");
            cmbOperatorDropDown.Items.Add("Equal to");
            cmbOperatorDropDown.Items.Add("Greater than");

            cmbAmountTypeDropdown.Items.Add("Dollars");
            cmbAmountTypeDropdown.Items.Add("Percent");
        }

        public void LoadRule(unusual_payment_rules Linked_Rule)
        {
            _loading = true;
            _linkedRule = Linked_Rule;

            if (_linkedRule != null)
            {
                nmbAmount.Value = _linkedRule.amount;
                cmbAmountTypeDropdown.SelectedIndex = (int)_linkedRule.amount_type_code;
                cmbOperatorDropDown.SelectedIndex = (int)_linkedRule.operator_code;
                _orderID = _linkedRule.order_id;
                txtProcessCode.Text = _linkedRule.process_code;
            }
            _loading = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            // Delete it from the DB here
            _linkedRule.Delete();

            if (Deleted != null)
                Deleted(this, new EventArgs());
        }

        public void Save()
        {
            if (_linkedRule == null)
            {
                _linkedRule = new unusual_payment_rules();
            }
            _linkedRule.amount = nmbAmount.Value;
            _linkedRule.amount_type_code = (unusual_payment_rules.AmountTypeCodes)cmbAmountTypeDropdown.SelectedIndex;
            _linkedRule.operator_code = (unusual_payment_rules.OperatorCodes)cmbOperatorDropDown.SelectedIndex;
            _linkedRule.order_id = _orderID;
            _linkedRule.process_code = txtProcessCode.Text.Trim();

            _linkedRule.Save();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            if ((!_loading) && (AutoSave))
                Save();
     
        }

        private void NumberValueChanged(object sender, EventArgs e)
        {
            // Only save here if the value has changed
            if ((!_loading) && (AutoSave))
            {
                // Look for an old amount
                bool valueChanged = false;

                if (_linkedRule != null)
                    if (nmbAmount.Value != _linkedRule.amount)
                        valueChanged = true;

                if (valueChanged)
                    Save();
            }
        }

        private void ctlUnusualPaymentRule_Load(object sender, EventArgs e)
        {
            _loading = true;
            cmbAmountTypeDropdown.SelectedIndex = 0;
            cmbOperatorDropDown.SelectedIndex = 0;
            _loading = false;
        }

        public void Clear()
        {
            _loading = true;
            _linkedRule = null;
            txtProcessCode.Text = "";
            cmbAmountTypeDropdown.SelectedIndex = 0;
            cmbOperatorDropDown.SelectedIndex = 0;
            nmbAmount.Value = 0;
            _loading = false;
        }

     
    }
}
