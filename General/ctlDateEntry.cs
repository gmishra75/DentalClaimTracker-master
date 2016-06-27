using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class ctlDateEntry : UserControl
    {
        private bool _dateSelectionVisible = true;
        public event EventHandler ValueChanged;
        private bool _isValid = true;
        private DateTime? _currentDate;
        bool eventsOn = true;
        private bool _isReadOnly = false;

        public ctlDateEntry()
        {
            InitializeComponent();
        }

        public bool IsValid
        {
            get { return _isValid; }
        }

        public string CurrentDateText
        {
            get { return txtDate.Text; }
        }


        /// <summary>
        /// The date shown in the control (alias for CurrentDate)
        /// </summary>
        public DateTime? DateValue
        {
            get { return CurrentDate; }
            set
            {
                CurrentDate = value;
            }
        }

        /// <summary>
        /// The date shown in the control.
        /// </summary>
        public DateTime? CurrentDate
        {
            get
            {
                if (CommonFunctions.IsDate(txtDate.Text))
                {
                    try
                    {
                        DateTime newDate = Convert.ToDateTime(txtDate.Text);
                        _currentDate = newDate;
                    }
                    catch { } //ignore
                }
                else
                    _currentDate = null;

                return _currentDate;
            }
            set
            {
                bool valueHasChanged;
                if (value.HasValue)
                {
                    if (!CurrentDate.HasValue)
                        valueHasChanged = true;
                    else if (CurrentDate.Value.Date != value.Value.Date)
                        valueHasChanged = true;
                    else
                        valueHasChanged = false;

                    if (value.Value.Year == 1753) // Special Dentrix thing
                        txtDate.Text = "";
                    else
                    {
                        if (dtpDate.Value != value.Value)
                            dtpDate.Value = value.Value;
                        txtDate.Text = value.Value.ToShortDateString();
                    }
                }
                else
                {
                    if (CurrentDate.HasValue)
                        valueHasChanged = true;
                    else
                        valueHasChanged = false;

                    txtDate.Text = "";

                }

                _currentDate = value;
                if (valueHasChanged)
                {
                    if (eventsOn)
                    {
                        if (ValueChanged != null)
                            ValueChanged(this, new EventArgs());
                    }
                }

            }
        }

        public bool DateSelectionVisible
        {
            get { return _dateSelectionVisible; }
            set
            {
                _dateSelectionVisible = value;
                if (_dateSelectionVisible)
                {
                    btnDate.Visible = true;
                    dtpDate.Visible = true;
                }
                else
                {
                    btnDate.Visible = false;
                    dtpDate.Visible = false;
                }


            }
        }

        public bool ReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                _isReadOnly = value;

                txtDate.ReadOnly = _isReadOnly;
                dtpDate.Enabled = !_isReadOnly;
            }
        }


        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (CommonFunctions.IsDate(txtDate.Text))
            {
                try
                {
                    txtDate.BackColor = Color.White;
                    _isValid = true;
                }
                catch
                {
                    txtDate.BackColor = Color.Yellow;
                    _isValid = false;
                }
            }
            else if (txtDate.Text == "")
            {
                txtDate.BackColor = Color.White;
                _isValid = true;
            }
            else
            {
                txtDate.BackColor = Color.Yellow;
                _isValid = false;
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            dtpDate.Focus();
            SendKeys.SendWait("%{DOWN}");
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            CurrentDate = dtpDate.Value;
        }

        public void SetDefaultDate(DateTime defaultDate)
        {
            eventsOn = false;
            CurrentDate = defaultDate;
            CurrentDate = null;
            eventsOn = true;
        }


        /// <summary>
        /// Clears the text box of all data
        /// </summary>
        internal void Clear()
        {
            txtDate.Text = "";
        }
    }
}
