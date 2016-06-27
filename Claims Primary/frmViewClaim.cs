using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmViewClaim : Form
    {
        private EditModes _editMode;
        private List<claim> _claimsList;
        private int _currentIndex;
        private bool _changed = false;
        private bool _loading = false;
        private company_contact_info _currentContactInfo;
        private int SPACER = 10;
        private bool _updatingRevisitDate = false;

        public frmViewClaim()
        {
            InitializeComponent();
            InitializeCompanies();
            InitializeDateTimeBoxes();
            _claimsList = new List<claim>();
            AddNewClaim();
            AdjustDisplayDataHeights();
        }

        public frmViewClaim(List<claim> allClaims, int indexToView)
        {
            InitializeComponent();
            InitializeCompanies();
            InitializeDateTimeBoxes();
            _claimsList = allClaims;
            LoadClaim(indexToView);
            AdjustDisplayDataHeights();
        }

        private void InitializeDateTimeBoxes()
        {
            ctlOnHoldDate.CurrentDate = DateTime.Now;
            ctlPatientDOB.CurrentDate = DateTime.Now;
            ctlResentDate.CurrentDate = DateTime.Now;
            ctlSentDate.CurrentDate = DateTime.Now;
            ctlSubscriberDOB.CurrentDate = DateTime.Now;
            ctlTracerDate.CurrentDate = DateTime.Now;
            _changed = false;
        }

        /// <summary>
        /// Adds all the companies to the Company List without a default value
        /// </summary>
        private void InitializeCompanies()
        {
            InitializeCompanies(0);
        }

        /// <summary>
        /// Adds all the companies to the Company List
        /// </summary>
        private void InitializeCompanies(int defaultCompanyID)
        {
            company cmp = new company();
            DataTable allCompanies = cmp.Search(cmp.SearchSQL + " ORDER BY name");

            foreach (DataRow aRow in allCompanies.Rows)
            {
                cmp = new company();
                cmp.Load(aRow);
                cmbInsuranceCarrier.Items.Add(cmp);

                if (cmp.id == defaultCompanyID)
                    cmbInsuranceCarrier.SelectedItem = cmp;
            }
        }

        private void LoadClaim(int Index)
        {
            if (RecordChangeOK())
            {
                _loading = true;
                _editMode = EditModes.Edit;
                _currentIndex = Index;
                claim toLoad = new claim(_claimsList[_currentIndex].id);
                _claimsList[_currentIndex] = toLoad;

                #region Field assignment

                // Services
                nmbClaimAmount.Value = toLoad.amount_of_claim;

                LoadProcedures(toLoad);

                // Insurance
                LoadInsurance(toLoad.LinkedCompany, toLoad.LinkedCompanyAddress);

                // Patient
                txtPatientName.Text = toLoad.PatientName;

                ctlPatientDOB.CurrentDate = toLoad.patient_dob;

                txtPatientSSN.Text = toLoad.patient_ssn;
                txtPatientAddress.Text = toLoad.patient_address;
                txtPatientAddress2.Text = toLoad.patient_address2;
                txtPatientCity.Text = toLoad.patient_city;
                txtPatientState.Text = toLoad.patient_state;
                txtPatientZIP.Text = toLoad.patient_zip;

                // Doctor
                txtDoctorName.Text = toLoad.DoctorName;
                txtDoctorTaxID.Text = toLoad.doctor_tax_number;
                txtDoctorLicenseID.Text = toLoad.doctor_license_number;
                txtDoctorBC.Text = toLoad.doctor_bcbs_number;
                txtDoctorPhone.Text = toLoad.doctor_phone_number_object.FormattedPhone;
                txtDoctorFax.Text = toLoad.doctor_fax_number_object.FormattedPhone;
                txtDoctorAddress.Text = toLoad.doctor_address;
                txtDoctorAddress2.Text = toLoad.doctor_address2;
                txtDoctorCity.Text = toLoad.doctor_city;
                txtDoctorState.Text = toLoad.doctor_state;
                txtDoctorZIP.Text = toLoad.doctor_zip;

                // Subscriber
                txtSubscriberName.Text = toLoad.SubscriberName;
                ctlSubscriberDOB.CurrentDate = toLoad.subscriber_dob;
                
                txtSubscriberID.Text = toLoad.subscriber_number;
                txtSubscriberAltID.Text = toLoad.subscriber_alternate_number;
                txtSubscriberSSN.Text = toLoad.subscriber_ssn;
                txtSubscriberGroupName.Text = toLoad.subscriber_group_name;
                txtSubscriberGroupNum.Text = toLoad.subscriber_group_number;
                txtSubscriberAddress.Text = toLoad.subscriber_address;
                txtSubscriberAddress2.Text = toLoad.subscriber_address2;
                txtSubscriberCity.Text = toLoad.subscriber_city;
                txtSubscriberState.Text = toLoad.subscriber_state;
                txtSubscriberZIP.Text = toLoad.subscriber_zip;

                // General
                ctlSentDate.CurrentDate = toLoad.sent_date;
                ctlResentDate.CurrentDate = toLoad.resent_date;
                ctlTracerDate.CurrentDate = toLoad.tracer_date;
                ctlOnHoldDate.CurrentDate = toLoad.on_hold_date;
                chkClosed.Checked = !System.Convert.ToBoolean(toLoad.open);

                // Notes
                txtNotes.Text = toLoad.notes;
                

                #endregion

                #region Handling Specific
                    

                    claim_batch cb = toLoad.LinkedBatch();

                    if (cb != null)
                    {
                        cmbHandling.Enabled = false;
                        chkInBatch.Checked = true;
                        ctlBatchDate.DateValue = cb.batch_date;
                        cmbHandling.SelectedIndex = cmbHandling.FindStringExact(cb.handling);
                    }
                    else
                    {
                        cmbHandling.Enabled = true;
                        chkInBatch.Checked = false;
                        ctlBatchDate.Clear();
                        cmbHandling.SelectedIndex = cmbHandling.FindStringExact(toLoad.handling);
                    }

                #endregion

                if (toLoad.revisit_date.HasValue)
                    ctlRevisitDate.CurrentDate = toLoad.revisit_date;
                else
                    ctlRevisitDate.CurrentDate = DateTime.Now.AddDays(System.Convert.ToDouble(nmbRevisitInterval.Value));

                if (toLoad.LinkedChanges.Count > 0)
                    lnkViewClaimChangeHistory.Visible = true;

                Text = toLoad.claim_type.ToString() + " claim for " + toLoad.PatientName;
                callManager.LoadClaim(toLoad);

                _changed = false;
                _loading = false;
            }
        }

        private DateTime? GetDateValue(DateTime? dateToUse)
        {
            
            if (dateToUse.HasValue)
            {
                if (dateToUse.Value.Year == 1753)
                    return null;
                else
                    return dateToUse.Value;
            }
            else
            {
                return null;
            }
        }

        private void LoadProcedures(claim toLoad)
        {
            List<DisplayProcedure> procedureList = new List<DisplayProcedure>();

            foreach (procedure aProc in toLoad.LinkedProcedures)
            {
                procedureList.Add(new DisplayProcedure(aProc));
            }

            dgvProcedureData.DataSource = procedureList;

            int newHeight = dgvProcedureData.ColumnHeadersHeight;

            foreach (DataGridViewRow aRow in dgvProcedureData.Rows)
            {
                newHeight += aRow.Height;
            }

            dgvProcedureData.Height = newHeight + 2;

            dgvProcedureData.EnableHeadersVisualStyles = false;

            dgvProcedureData.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

            txtDateOfService.Text = GetDatesOfService();

            ctlClaimDisplayServices.ForceResize();

        }

        private string GetDatesOfService()
        {
            string toReturn = "";
            DateTime minDate;
            DateTime maxDate;

            if (dgvProcedureData.Rows.Count > 0)
            {
                minDate = System.Convert.ToDateTime(dgvProcedureData.Rows[0].Cells["colProcedureDate"].Value);
                maxDate = minDate;

                foreach (DataGridViewRow aRow in dgvProcedureData.Rows)
                {
                    DateTime thisDate = System.Convert.ToDateTime(aRow.Cells["colProcedureDate"].Value);

                    if (thisDate < minDate)
                        minDate = thisDate;

                    if (thisDate > maxDate)
                        maxDate = thisDate;
                    
                }

                if (minDate == maxDate)
                    toReturn = minDate.ToShortDateString();
                else
                    toReturn = minDate.ToShortDateString() + " - " + maxDate.ToShortDateString();
            }
            else
                toReturn = "N/A";

            return toReturn;
        }

        /// <summary>
        /// Pass new companies to load a blank company
        /// </summary>
        /// <param name="toLoad"></param>
        private void LoadInsurance(company toLoad, company_contact_info contactInfo)
        {
            _currentContactInfo = contactInfo;
            if (toLoad.name != "")
            {
                cmbInsuranceCarrier.SelectedIndex = cmbInsuranceCarrier.FindStringExact(toLoad.name);
                txtInsuranceAddress.Text = contactInfo.address;
                txtInsuranceAddress2.Text = contactInfo.address2;
                txtInsuranceCity.Text = contactInfo.city;
                txtInsuranceState.Text = contactInfo.state;
                txtInsuranceZIP.Text = contactInfo.zip;
                txtInsurancePhone.Text = contactInfo.phone_Object.FormattedPhone;


                if (toLoad.NumberOfAddresses > 1)
                {
                    lnkViewCompanyContactInfo.Visible = true;
                }
                else
                {
                    lnkViewCompanyContactInfo.Visible = false;
                }
            }
            else
            {
                cmbInsuranceCarrier.SelectedIndex = -1;
                txtInsuranceAddress.Text = "";
                lnkViewCompanyContactInfo.Visible = false;
            }
        }

        /// <summary>
        /// Returns null if the textbox is empty, otherwise returns the datetime value
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private DateTime? GetDateValueFromTextBox(string text)
        {
            if (text == "")
                return null;
            else
            {
                try
                {
                    DateTime? toReturn = System.Convert.ToDateTime(text);

                    return toReturn;
                }
                catch
                {
                    return null;
                }
            }
        }

        private void AddNewClaim()
        {
            _editMode = EditModes.AddNew;
            // Disable right side of the form
        }

        private void cmdNextClaim_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _claimsList.Count - 1)
            {
                LoadClaim(_currentIndex + 1);
            }
        }

        private void cmdPreviousClaim_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                LoadClaim(_currentIndex - 1);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {
            if (ValidateForm())
            {
                try
                {
                    claim toSave;

                    if (_editMode == EditModes.Edit)
                        toSave = _claimsList[_currentIndex];
                    else
                    {
                        toSave = new claim();

                        toSave.created_on = DateTime.Now;
                        toSave.created_by = ActiveUser.UserObject.username;

                        _editMode = EditModes.Edit;

                        _claimsList.Add(toSave);
                        _currentIndex = _claimsList.Count - 1;

                    }

                    #region Field Assignments

                    // Services
                    SaveWithCheckForChange(ref toSave, "amount_of_claim", nmbClaimAmount.Value * 100);



                    // Insurance
                    if (cmbInsuranceCarrier.SelectedIndex >= 0)
                    {
                        int newID = ((company)cmbInsuranceCarrier.SelectedItem).id;
                        int oldID = toSave.company_id;
                        if (toSave.company_id != newID)
                        {
                            AddChange(toSave.id, "company", toSave.LinkedCompany.name, new company(newID).name);
                            toSave.company_id = newID;
                        }

                        if (toSave.company_address_id != _currentContactInfo.order_id)
                        {
                            company_contact_info oldInfo = new company_contact_info();
                            company_contact_info newInfo = new company_contact_info();
                            oldInfo.Load(new int[] { oldID, toSave.company_address_id });
                            newInfo.Load(new int[] { newID, _currentContactInfo.order_id });

                            AddChange(toSave.id, "company_address", oldInfo.address, newInfo.address);
                            toSave.company_address_id = _currentContactInfo.order_id;
                        }
                    }

                    // Patient


                    // name has to be handled in a special way
                    if (toSave.PatientName != txtPatientName.Text)
                    {
                        AddChange(toSave.id, "patient_name", toSave.PatientName, txtPatientName.Text);
                        toSave.PatientName = txtPatientName.Text;
                    }

                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "patient_dob", ctlPatientDOB.CurrentDate);
                    SaveWithCheckForChange(ref toSave, "patient_ssn", txtPatientSSN.Text.Replace("-", ""));
                    SaveWithCheckForChange(ref toSave, "patient_address", txtPatientAddress.Text);
                    SaveWithCheckForChange(ref toSave, "patient_address2", txtPatientAddress2.Text);
                    SaveWithCheckForChange(ref toSave, "patient_city", txtPatientCity.Text);
                    SaveWithCheckForChange(ref toSave, "patient_state", txtPatientState.Text);
                    SaveWithCheckForChange(ref toSave, "patient_zip", txtPatientZIP.Text);

                    // Doctor
                    // name has to be handled in a special way
                    if (toSave.DoctorName != txtDoctorName.Text)
                    {
                        AddChange(toSave.id, "doctor_name", toSave.DoctorName, txtDoctorName.Text);
                        toSave.DoctorName = txtDoctorName.Text;
                    }

                    SaveWithCheckForChange(ref toSave, "doctor_tax_number", txtDoctorTaxID.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_license_number", txtDoctorLicenseID.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_bcbs_number", txtDoctorBC.Text);

                    // phone has to be handled in a special way
                    PhoneObject newDoctorPhone = new PhoneObject(txtDoctorPhone.Text);
                    if (toSave.doctor_phone_number_object.FormattedPhone != newDoctorPhone.FormattedPhone)
                    {
                        AddChange(toSave.id, "doctor_phone_number", toSave.doctor_phone_number_object.FormattedPhone,
                            newDoctorPhone.FormattedPhone);
                        toSave.doctor_phone_number_object = newDoctorPhone;
                    }
                    // phone has to be handled in a special way
                    PhoneObject newDoctorFax = new PhoneObject(txtDoctorFax.Text);
                    if (toSave.doctor_fax_number_object.FormattedPhone != newDoctorFax.FormattedPhone)
                    {
                        AddChange(toSave.id, "doctor_fax_number", toSave.doctor_fax_number_object.FormattedPhone,
                            newDoctorFax.FormattedPhone);
                        toSave.doctor_fax_number_object = newDoctorFax;
                    }

                    SaveWithCheckForChange(ref toSave, "doctor_address", txtDoctorAddress.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_address2", txtDoctorAddress2.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_city", txtDoctorCity.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_state", txtDoctorState.Text);
                    SaveWithCheckForChange(ref toSave, "doctor_zip", txtDoctorZIP.Text);

                    // Subscriber

                    // Need special code for name
                    if (toSave.SubscriberName != txtSubscriberName.Text)
                    {
                        AddChange(toSave.id, "subscriber_name", toSave.SubscriberName, txtSubscriberName.Text);
                        toSave.SubscriberName = txtSubscriberName.Text;
                    }

                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "subscriber_dob", ctlSubscriberDOB.CurrentDate);
                    SaveWithCheckForChange(ref toSave, "subscriber_number", txtSubscriberID.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_alternate_number", txtSubscriberAltID.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_ssn", txtSubscriberSSN.Text.Replace("-", ""));
                    SaveWithCheckForChange(ref toSave, "subscriber_group_name", txtSubscriberGroupName.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_group_number", txtSubscriberGroupNum.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_address", txtSubscriberAddress.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_address2", txtSubscriberAddress2.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_city", txtSubscriberCity.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_state", txtSubscriberState.Text);
                    SaveWithCheckForChange(ref toSave, "subscriber_zip", txtSubscriberZIP.Text);

                    // General
                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "sent_date", ctlSentDate.CurrentDate);
                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "resent_date", ctlResentDate.CurrentDate);
                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "on_hold_date", ctlOnHoldDate.CurrentDate);
                    SaveWithCheckForChangeSpecialDateTime(ref toSave, "tracer_date", ctlTracerDate.CurrentDate);

                    // Notes / Open
                    SaveWithCheckForChange(ref toSave, "notes", txtNotes.Text);

                    // Special for boolean
                    if (toSave.open != System.Convert.ToInt32(!chkClosed.Checked))
                    {
                        AddChange(toSave.id, "open", !chkClosed.Checked, chkClosed.Checked);
                        toSave.open = System.Convert.ToInt32(!chkClosed.Checked);
                    }

                    toSave.handling = cmbHandling.Text;

                    #endregion

                    

                    toSave.Save();

                    SaveRevisitDate();
                    _changed = false;
                    if (toSave.LinkedChanges.Count > 0)
                        lnkViewClaimChangeHistory.Visible = true;

                    choice choice = new choice();
                    call call = new call();

                    return true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, "An unexpected error occurred attempting to save this claim. Please report " +
                        "this error to an administrator:\n\n" + err.Message, "Unexpected Error in Save Routine", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            else
                return false;
        }

        private void SaveRevisitDate()
        {
            if (chkSetRevisitDate.Checked)
            {
                claim toSave = _claimsList[_currentIndex];
                toSave.revisit_date = ctlRevisitDate.CurrentDate;
                toSave.updated_on = System.DateTime.Now;
                toSave.Save();
            }
        }

        private bool ValidateForm()
        {
            const string INVALIDDATE = "Not a valid date/time";
            List<string> invalidData = new List<string>();

            if (!ctlSubscriberDOB.IsValid)
                invalidData.Add(GenerateInvalidText("Subscriber DOB", INVALIDDATE));

            if (!ctlPatientDOB.IsValid)
                invalidData.Add(GenerateInvalidText("Patient DOB", INVALIDDATE));

            if (!ctlSentDate.IsValid)
                invalidData.Add(GenerateInvalidText("Sent Date", INVALIDDATE));

            if (!ctlOnHoldDate.IsValid)
                invalidData.Add(GenerateInvalidText("On Hold Date", INVALIDDATE));

            if (!ctlResentDate.IsValid)
                invalidData.Add(GenerateInvalidText("Resent Date", INVALIDDATE));

            if (!ctlTracerDate.IsValid)
                invalidData.Add(GenerateInvalidText("Tracer Date", INVALIDDATE));

            if (!ctlRevisitDate.CurrentDate.HasValue)
                invalidData.Add(GenerateInvalidText("Revisit Date", "Please select a revisit date."));
            else if (ctlRevisitDate.CurrentDate < DateTime.Now.AddDays(-1))
                invalidData.Add(GenerateInvalidText("Revisit Date", "Revisit date cannot be in the past."));


            if (invalidData.Count > 0)
            {
                string formattedProbs = "";
                foreach (string aProb in invalidData)
                    formattedProbs += "\n" + aProb;

                MessageBox.Show(this, "The claim cannot be saved due to the following issues:\n" + formattedProbs +
                    "\n\nPlease fix these issues and then attempt to save the claim again.",
                    "Cannot save claim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;

        }

        private string GenerateInvalidText(string fieldName, string validationText)
        {
            return fieldName + " - " + validationText;
        }

        private bool DateFieldValid(string toCheck)
        {
            bool isValid;
            if (toCheck == "")
                isValid = true;
            else
            {
                try
                {
                    System.Convert.ToDateTime(toCheck);
                    isValid = true;
                }
                catch { isValid = false; }
            }

            return isValid;
        }

        /// <summary>
        /// Like the SaveWithCheckForChange, but uses a special format to deal with the fact that 
        /// we don't show the default date of 3/2/1753
        /// </summary>
        /// <param name="toSave"></param>
        /// <param name="p"></param>
        /// <param name="nullable"></param>
        private void SaveWithCheckForChangeSpecialDateTime(ref claim toSave, string field_name, DateTime? newValue)
        {
            DateTime? oldValue;
            if (toSave[field_name] == DBNull.Value)
                oldValue = new DateTime?();
            else
                oldValue = (DateTime?)toSave[field_name];

            bool valuesEqual;

            if (newValue == null)
            {
                if (!oldValue.HasValue)
                    valuesEqual = true;
                else if (oldValue.Value.Year == 1753)
                    valuesEqual = true;
                else
                    valuesEqual = false;
            }
            else
            {
                if (oldValue.HasValue)
                    valuesEqual = CheckValuesEqual(oldValue, newValue);
                else
                    valuesEqual = false;
            }

            if (!valuesEqual)
            {
                claim_change_log ccl = new claim_change_log();
                AddChange(toSave.id, field_name, toSave[field_name], newValue);

                toSave[field_name] = newValue;
            }
        }

        /// <summary>
        /// Updates a field to the new value, but makes a log of the change in the change log if necessary
        /// </summary>
        /// <param name="toSave">the claim object that will be updated</param>
        /// <param name="field_name">the name of the field to be updated</param>
        /// <param name="newValue">the new value of the field</param>
        private void SaveWithCheckForChange(ref claim toSave, string field_name, object newValue)
        {
            object oldValue;

            try
            {
                oldValue = toSave[field_name];
            }
            catch
            {
                // Make sure not to pass in an invalid field name here, or it will be confusing
                // and crash later one
                oldValue = null;
            }

            bool valuesEqual = CheckValuesEqual(toSave[field_name], newValue);

            if (!valuesEqual)
            {
                claim_change_log ccl = new claim_change_log();
                AddChange(toSave.id, field_name, toSave[field_name], newValue);

                toSave[field_name] = newValue;
            }
        }

        /// <summary>
        /// Looks at two values and attempts to determine their type and then compares them. 
        /// If it can't determine the type an exception is thrown
        /// </summary>
        /// <param name="p"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        private bool CheckValuesEqual(object oldValue, object newValue)
        {
            if (oldValue is decimal)
            {
                return (decimal)oldValue == (decimal)newValue;
            }
            else if (oldValue is DateTime)
            {
                if (newValue == null)
                    return false;

                return (DateTime)oldValue == (DateTime)newValue;
            }
            else if (oldValue is string)
            {
                return (string)oldValue == (string)newValue;
            }
            else if (oldValue is int)
            {
                return (int)oldValue == (int)newValue;
            }
            else if ((oldValue == null) || (oldValue == DBNull.Value))
            {
                return newValue == null;
            }
            else
            {
                throw new Exception("Uninitialized type in CheckValuesEqual function.");
            }
        }

        private void AddChange(int claim_id, string field_name, object oldValue, object newValue)
        {
            claim_change_log ccl = new claim_change_log();
            ccl.claim_id = claim_id;

            ccl.old_data = DataToString(oldValue);
            ccl.new_data = DataToString(newValue);
            ccl.field_info = field_name;
            ccl.change_date = DateTime.Now;

            ccl.Save();

        }

        private string DataToString(object toConvert)
        {
            string toReturn;
                if (toConvert == null)
                    toReturn = "";
                else
                    toReturn= toConvert.ToString();

            if (toReturn == "")
                return "{Empty}";
            else
                return toReturn;
        }

        private void cmbInsuranceCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInsuranceCarrier.SelectedIndex >= 0)
            {
                company c = (company)cmbInsuranceCarrier.SelectedItem;
                company_contact_info thisInfo;
                if (_loading)
                    thisInfo = _currentContactInfo;
                else
                    thisInfo = c.GetFirstContactInfo();
                LoadInsurance(c, thisInfo);
            }
            else
                txtInsuranceAddress.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _changed = true;
        }

        /// <summary>
        /// Used before showing a new claim. If the current claim has changed, asks the user if they'd 
        /// like to save it. Returns true if it's OK to proceed.
        /// </summary>
        /// <returns></returns>
        public bool RecordChangeOK()
        {
            if (_changed)
            {
                DialogResult result = MessageBox.Show(this, "The data for the current claim has changed. Would you like to save it before continuing?",
                    "Claim changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    return false;
                else if (result == DialogResult.Yes)
                    return Save();
                else
                    return true;

            }
            else
                return true;
        }

        private void lnkCreateCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewCompany toShow = new frmViewCompany(EditModes.AddDialog);
            if (toShow.ShowDialog() == DialogResult.OK)
            {
                InitializeCompanies(toShow.FormCompany.id);
            }
        }

        private void lnkEditCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbInsuranceCarrier.SelectedIndex >= 0)
            {
                frmViewCompany toShow = new frmViewCompany((company)cmbInsuranceCarrier.SelectedItem, _currentContactInfo);
                if (toShow.ShowDialog() == DialogResult.OK)
                {
                    InitializeCompanies(toShow.FormCompany.id);
                }
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void lnkViewCompanyContactInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCompanyContactInfo toShow = new frmCompanyContactInfo((company)cmbInsuranceCarrier.SelectedItem, _currentContactInfo.order_id);
            if (toShow.ShowDialog(this) == DialogResult.OK)
            {
                _currentContactInfo.order_id = toShow.newOrderID;
            }
        }

        private void ctlClaimDisplayData_Resized(object sender, EventArgs e)
        {
            AdjustDisplayDataHeights();
        }

        private void AdjustDisplayDataHeights()
        {
            // Insurance, Services, Subscriber, Patient, Doctor, Notes
            AutoMove(ctlClaimDisplayServices, ctlClaimDisplayInsurance);
            AutoMove(ctlClaimDisplaySubscriber, ctlClaimDisplayServices);
            AutoMove(ctlClaimDisplayPatient, ctlClaimDisplaySubscriber);
            AutoMove(ctlClaimDisplayDoctor, ctlClaimDisplayPatient);
            AutoMove(ctlClaimDisplayGeneral, ctlClaimDisplayDoctor);
            AutoMove(ctlClaimDisplayNotes, ctlClaimDisplayGeneral);
            AutoMove(ctlHandlingDisplay, ctlClaimDisplayNotes);
        }

        private void AutoMove(ctlClaimDataDisplay toMove, ctlClaimDataDisplay relativeTo)
        {
            toMove.Top = relativeTo.Top + relativeTo.Height + SPACER;
        }

        private void lnkViewClaimChangeHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewChangeHistory toShow = new frmViewChangeHistory(_claimsList[_currentIndex]);
            toShow.ShowDialog();
        }

        private void LeaveDateBox(TextBox tbLeft, DateTimePicker dtpLinkedDate)
        {
            if (CommonFunctions.IsDate(tbLeft.Text))
            {
                dtpLinkedDate.Value = Convert.ToDateTime(tbLeft.Text);
                tbLeft.BackColor = Color.White;
            }
            else if (tbLeft.Text == "")
                tbLeft.BackColor = Color.White;
            else
            {
                tbLeft.BackColor = Color.Yellow;
            }
        }

        private void nmbRevisitInterval_ValueChanged(object sender, EventArgs e)
        {
            _updatingRevisitDate = true;
            ctlRevisitDate.CurrentDate = DateTime.Now.AddDays(System.Convert.ToDouble(nmbRevisitInterval.Value));
            _updatingRevisitDate = false;
        }

        private void ctlRevisitDate_ValueChanged(object sender, EventArgs e)
        {
            if (!_updatingRevisitDate)
            {
                DateTime? newDate = ctlRevisitDate.CurrentDate;

                if (newDate.HasValue)
                {
                    TimeSpan difference = newDate.Value.Date - DateTime.Now.Date;
                    if (Convert.ToInt32(nmbRevisitInterval.Value) != difference.Days)
                    {
                        try
                        {
                            if (difference.Days >= 0)
                                nmbRevisitInterval.Value = Convert.ToDecimal(difference.Days);
                            else
                            {
                                if (nmbRevisitInterval.Value != 14)
                                    nmbRevisitInterval.Value = 14;
                                else
                                    nmbRevisitInterval_ValueChanged(null, null);
                            }

                        }
                        catch { } // Ignore, invalid entry
                    }
                }
            }
        }

        private void frmViewClaim_FormClosing(object sender, FormClosingEventArgs e)
        {
            callManager.TerminateCall(true);
            SaveRevisitDate();
            if (!RecordChangeOK())
            {
                e.Cancel = true;
            }
        }

        private void frmViewClaim_Load(object sender, EventArgs e)
        {

        }
    }

    public class DisplayProcedure
    {
        private procedure _linkedProcedure;
        private string _procedureDate;
        private string _adaCode;
        private string _description;
        private string _toothRange;
        private string _surfString;
        private string _amount;

        public DisplayProcedure(procedure toDisplay)
        {
            LinkedProcedure = toDisplay;
            if (toDisplay.pl_date.HasValue)
                ProcedureDate = toDisplay.pl_date.Value.ToShortDateString();
            else
                ProcedureDate = "";
            
            AdaCode = toDisplay.ada_code;
            Description = toDisplay.description;
            if (toDisplay.tooth_range_start == toDisplay.tooth_range_end)
                ToothRange = toDisplay.tooth_range_start.ToString();
            else
                ToothRange = toDisplay.tooth_range_start + "-" + toDisplay.tooth_range_end;
            SurfString = toDisplay.surf_string;
            Amount = toDisplay.amount.ToString("$#");
        }

        public procedure LinkedProcedure
        {
            get { return _linkedProcedure; }
            set { _linkedProcedure = value; }
        }
        public string ProcedureDate
        {
            get { return _procedureDate; }
            set { _procedureDate = value; }
        }
        public string AdaCode
        {
            get { return _adaCode; }
            set { _adaCode = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string ToothRange
        {
            get { return _toothRange; }
            set { _toothRange = value; }
        }
        public string SurfString
        {
            get { return _surfString; }
            set { _surfString = value; }
        }
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

    }
}