using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C_DentalClaimTracker.Properties;
using System.Linq;

namespace C_DentalClaimTracker
{
    public partial class frmClaimManager : Form
    {
        public frmSearchClaim searchForm { get; set; }
        private company formCompany;
        frmClaimStatus claimStatusForm;
        C_DentalClaimTracker.E_Claims.frmProcessor _processForm; 
        bool _viewingExistingSet = false;
        bool _actionTaken = false;
        Color FLASHCOLOR1;
        Color FLASHCOLOR2;
        Timer claimFlash = new Timer();
        bool _autoLoadSearchOnClose = false;
        private claim _nextClaim = null;
        private List<VerifyDataViewer> additionalDataTabs = new List<VerifyDataViewer>();
        private ctlClaimDataDisplay focusedControl;
        private EditModes _editMode;
        private claim _formClaim;
        private bool _changed = false;
        private bool _loading = false;
        private company_contact_info _currentContactInfo;
        private int SPACER = 0;
        private const int TOPPANELDEFAULTHEIGHT = 32;
        private const int LEFTPANELDEFAULTWIDTH = 562;
        private const int DEFAULTINSURANCETOP = 10;
        private const int NOTEPANELDEFAULTHEIGHT = 200;
        private const int NOTEPANELLOWHEIGHT = 125;
        private call _currentCall;
        private int _questionsAnswered;
        delegate void EmptyDelegate();
        Timer callTimer;
        bool onHold = false;
        TimeSpan callTime;
        TimeSpan holdTime;
        private claim LinkedClaim;
        private bool _readOnly;
        private bool _formClosing = false;
        List<claim> _viewingClaimSet;
        int _viewingClaimIndex;


        private void StandardConstructor()
        {
            InitializeComponent();
            InitializeCompanies();
            InitializeDateTimeBoxes();
            InitializeStatus();
            InitializeProviders();

            callTimer = new Timer();
            callTimer.Interval = 1000;
            callTimer.Tick += new EventHandler(callTimer_Tick);

            claimFlash.Interval = 3000;
            claimFlash.Tick += new EventHandler(claimFlash_Tick);

            FLASHCOLOR1 = Color.LightYellow;
            FLASHCOLOR2 = pnlTopPanel.BackColor;
        }

        
        public frmClaimManager()
        {
            _readOnly = false;
            _viewingClaimSet = null;
            StandardConstructor();
            AddNewClaim();
            AdjustDisplayDataHeights();

            _viewingExistingSet = false;
        }

        public frmClaimManager(claim toShow)
        {
            _readOnly = false;
            _viewingClaimSet = null;
            StandardConstructor();
            LoadClaim(toShow);
            AdjustDisplayDataHeights();

            _viewingExistingSet = false;
        }

        public frmClaimManager(claim toShow, bool readOnly)
        {
            _readOnly = readOnly;
            _viewingClaimSet = null;
            StandardConstructor();
            LoadClaim(toShow);
            AdjustDisplayDataHeights();

            HideReadOnly(readOnly);



            _viewingExistingSet = false;
        }

        public frmClaimManager(claim toShow, call ActiveCall)
        {
            _readOnly = false;
            _viewingClaimSet = null;
            StandardConstructor();
            LoadClaim(toShow);
            AdjustDisplayDataHeights();

            _viewingExistingSet = false;

            /*
            // Call Specific stuff
            ShowNewCallControls(true, false);

            pnlCallControls.Visible = true;
            tbpCallPage.Text = "(Multi-Claim) Call Status";
            CurrentCall = ActiveCall;
            mainQuestionViewer.CurrentCall = CurrentCall;
            callNotes.CurrentCall = CurrentCall;
             */
        }

        public frmClaimManager(claim toShow, call ActiveCall, List<claim> claimList)
        {
            _readOnly = false;
            StandardConstructor();

            _viewingClaimSet = claimList;
            _viewingExistingSet = true;
            
            LoadClaim(toShow);
            AdjustDisplayDataHeights();
            HideReadOnly(false);
        }

        public frmClaimManager(bool readOnly, List<claim> claimList, claim ActiveClaim)
        {
            _readOnly = readOnly;
            StandardConstructor();

            _viewingClaimSet = claimList;
            _viewingExistingSet = true;
            
            LoadClaim(ActiveClaim);
            AdjustDisplayDataHeights();
            HideReadOnly(readOnly);
        }



        private void HideReadOnly(bool readOnly)
        {
            
            cmdSave.Enabled = !readOnly;
            ctlStatusHandler.Enabled = !readOnly;
            callNotes.Enabled = !readOnly;
            pnlOwnerInfo.Visible = !readOnly;
            cmdApex.Visible = readOnly;
            cmdPaper.Visible = readOnly;

            if (readOnly)
            {
                // spltLeftRight.FixedPanel = FixedPanel.Panel1;
                
                spltLeftRight.SplitterDistance = spltLeftRight.Panel1.Width;
                spltLeftRight.Width = spltLeftRight.Panel1.Width;
                Width -= spltLeftRight.Panel2.Width;
                
                spltLeftRight.Panel2Collapsed = true;
                spltLeftRight.Panel2.Hide();
                
                // Left = Parent.Right -Width;
                Text = "Claim Manager - Read Only";
            }
        }
        

        private void InitializeDateTimeBoxes()
        {
            /*
            ctlOnHoldDate.CurrentDate = DateTime.Now;
            ctlPatientDOB.CurrentDate = DateTime.Now;
            ctlResentDate.CurrentDate = DateTime.Now;
            ctlSentDate.CurrentDate = DateTime.Now;
            ctlSubscriberDOB.CurrentDate = DateTime.Now;
            ctlTracerDate.CurrentDate = DateTime.Now;
            _changed = false;
             */
        }

        private void InitializeStatus()
        {
            cmbNewStatus.Items.Clear();
            cmbNewStatus.Items.Add("");

            claim_status cs = new claim_status();
            DataTable dt = cs.GetAllData("name");

            foreach (DataRow aRow in dt.Rows)
                cmbNewStatus.Items.Add(new claim_status((int) aRow["id"]));

        }

        public void InitializeProviders()
        {
            claim searchObject = new claim();

            DataTable providers = searchObject.Search("SELECT DISTINCT(doctor_provider_id), doctor_first_name, doctor_last_name FROM claims " +
                "WHERE doctor_provider_id IS NOT Null AND doctor_provider_id != '' AND doctor_provider_id NOT LIKE 'H%' ORDER BY doctor_provider_id");

            cmbOverrideProvider.Items.Clear();
            cmbOverrideProvider.Items.Add("");
            claim.OverrideProviderList().ForEach(p =>
            {
                cmbOverrideProvider.Items.Add(p.doctor_provider_id);
            });
        }

        public call CurrentCall
        {
            get { return _currentCall; }
            set { _currentCall = value; }
        }

        public claim FormClaim
        {
            get { return _formClaim; }
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
            /*
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
             */ 
        }

        private void LoadClaim(claim toLoad)
        {
            try
            {
                if (RecordChangeOK())
                {
                    _loading = true;

                    if (!_readOnly)
                        toLoad.LockClaim(true);


                    _editMode = EditModes.Edit;
                    _formClaim = toLoad;

                    UpdateOwnerInfo();
                    if (toLoad.claim_type == claim.ClaimTypes.SecondaryPredeterm)
                        ctlClaimDisplayServices.Caption = "Secondary Predeterm claim services";
                    else
                        ctlClaimDisplayServices.Caption = toLoad.claim_type.ToString() + " claim services";

                    #region Field assignment

                    // Services
                    txtAmountOfClaim.Text = toLoad.amount_of_claim.ToString("$0.00");

                    LoadProcedures(toLoad);

                    // Insurance
                    LoadInsurance(toLoad.LinkedCompany, toLoad.LinkedCompanyAddress);

                    // Patient
                    txtPatientName.Text = toLoad.PatientName;
                    txtPatientDOB.Text = FormatDateTime(toLoad.patient_dob);
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
                    txtDoctorNPI.Text = toLoad.doctor_fax_number;
                    txtDoctorAddress.Text = toLoad.doctor_address;
                    txtDoctorAddress2.Text = toLoad.doctor_address2;
                    txtDoctorCity.Text = toLoad.doctor_city;
                    txtDoctorState.Text = toLoad.doctor_state;
                    txtDoctorZIP.Text = toLoad.doctor_zip;

                    // Subscriber
                    txtSubscriberName.Text = toLoad.SubscriberName;
                    txtSubscriberDOB.Text = FormatDateTime(toLoad.subscriber_dob);

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
                    txtSentDate.Text = FormatDateTime(toLoad.sent_date);
                    txtResentDate.Text = FormatDateTime(toLoad.resent_date);
                    txtTracerDate.Text = FormatDateTime(toLoad.tracer_date);
                    txtOnHoldDate.Text = FormatDateTime(toLoad.on_hold_date);
                    if (Convert.ToBoolean(toLoad.open))
                        lblClaimPaid.Text = "Not Paid";
                    else
                        lblClaimPaid.Text = "Paid";
                    if (toLoad.Clinic != null)
                        txtClinic.Text = toLoad.Clinic.name;

                    txtDentrixClaimID.Text = toLoad.claimidnum;
                    txtDentrixClaimDB.Text = toLoad.claimdb;

                    // Notes
                    txtNotes.Text = toLoad.notes;

                    if (txtNotes.Text == "")
                        ctlClaimDisplayNotes.DisplayMode = ctlClaimDataDisplay.ClaimDataDisplayMode.Minimize;


                    #endregion

                    #region Handling Specific

                    LoadHandling();

                    #endregion

                    if (FormClaim.LinkedStatus != null)
                        lblStatusCurrent.Text = FormClaim.LinkedStatus.name;
                    else
                        lblStatusCurrent.Text = "{Empty}";


                    if (toLoad.revisit_date.HasValue)
                        lblRevisitCurrent.Text = toLoad.revisit_date.Value.ToShortDateString();
                    else
                        lblRevisitCurrent.Text = "{Empty}";

                    if (toLoad.LinkedChanges.Count > 0)
                        lnkViewClaimChangeHistory.Visible = true;

                    if (toLoad.claim_type == claim.ClaimTypes.Primary)
                    {
                        if (toLoad.HasSecondary)
                        {
                            lnkViewLinkedClaim.Text = "View Secondary Claim";
                            pnlViewLinkedClaim.Visible = true;
                            LinkedClaim = toLoad.LinkedSecondaryClaim;
                        }
                        else
                        {
                            pnlViewLinkedClaim.Visible = false;
                        }
                    }
                    else if (toLoad.claim_type == claim.ClaimTypes.Secondary)
                    {
                        if (toLoad.HasPrimary)
                        {
                            lnkViewLinkedClaim.Text = "View Primary Claim";
                            pnlViewLinkedClaim.Visible = true;
                            LinkedClaim = toLoad.LinkedPrimaryClaim;
                        }
                        else
                        {
                            pnlViewLinkedClaim.Visible = false;
                        }
                    }
                    else
                    {
                        pnlViewLinkedClaim.Visible = false;
                    }


                    // Load restriction claim data
                    claim restrictionClaim = provider_eligibility_restrictions.FindEligibilityRestrictions(toLoad);

                    if (restrictionClaim != null)
                    {
                        ctlClaimDisplayDoctor.BackColorCaption = Color.SandyBrown;
                        ctlClaimDisplayDoctor.Caption = ctlClaimDisplayDoctor.Caption + "  (" + restrictionClaim.doctor_last_name + ")";
                    }

                    callManager.LoadClaim(toLoad);
                    callNotes.LoadNotes(toLoad);
                    callNotes.CurrentClaim = toLoad;
                    cmbNewStatus.SelectedIndex = -1;
                    dtpNewRevisitDate.CurrentDate = null;
                    RefreshCallHistoryDropdown();

                    ShowPanel(cmdClaimInfo, pnlClaimData);

                    _changed = false;
                    _loading = false;
                }
            }
            catch (Exception e)
            {
                LoggingHelper.Log(e, false);
                MessageBox.Show(this, "An unexpected error occurred loading data to display the form. This claim cannot be loaded.\n\nThe system error message is: " + e.Message, "Unexpected error");
                ForceClose();
            }
        }

        private string FormatDateTime(DateTime? nullable)
        {
            if (nullable.HasValue)
                return nullable.Value.ToShortDateString();
            
            else
                return "";
        }

        private void ForceClose()
        {
            _changed = false;
            _readOnly = true;
            Close();
        }

        /// <summary>
        /// Loads the "handling" section of the form
        /// </summary>
        private void LoadHandling()
        {

            List<claim_batch> cb = _formClaim.LinkedBatches();
            dgvHandlingHistory.Rows.Clear();
            if (cb.Count > 0)
            {
                cmbHandling.Enabled = false;
                cmbHandling.SelectedIndex = cmbHandling.FindStringExact(cb[0].handlingAsString);

                // Load all the claim history info
                foreach (claim_batch aBatch in cb)
                {
                    dgvHandlingHistory.Rows.Add(new object[] { aBatch.id, aBatch.handlingAsString, aBatch.batch_date });
                }
            }
            else
            {
                ctlHandlingDisplay.DisplayMode = ctlClaimDataDisplay.ClaimDataDisplayMode.Normal;
                cmbHandling.Enabled = true;
                cmbHandling.SelectedIndex = cmbHandling.FindStringExact(_formClaim.handling);
            }

            cmbApexStandardOption.Items.Clear();
            cmbApexStandardOption.Items.Add("Select an option...");
            cmbApexStandardOption.Items.Add("NOATTACH");
            cmbApexStandardOption.Items.Add("FORCEPEND");

            if (_formClaim.claim_type == claim.ClaimTypes.Secondary)
                cmbApexStandardOption.Items.Add("SECONDARY");

            cmbApexStandardOption.SelectedIndex = 0;

            chkUseApexDefaults.Checked = !_formClaim.apex_override_default_message;

            if (chkUseApexDefaults.Checked)
            {
                // Find and use apex defaults
                SetApexToDefault();
            }
            else
            {
                txtApexCustomText.Text = _formClaim.apex_message_text;
            }


            txtNEA_Number.Text = _formClaim.nea_number;
            
            if (_formClaim.CheckForAddressOverride)
                cmbOverrideProvider.SelectedIndex = cmbOverrideProvider.FindStringExact(_formClaim.override_address_provider);
            else
                cmbOverrideProvider.SelectedIndex = 0;
            
        }

        private void SetApexToDefault()
        {
            apex_rules_rulelist arr = _formClaim.GetApplicableRule();

            if (arr == null)
            {
                txtApexCustomText.Text = "";
            }
            else
            {
                txtApexCustomText.Text = arr.rule_text;
            }
        }

        /// <summary>
        /// Fills the entire "claim list" with a list of best matches for the current claim
        /// </summary>
        private void InitializeRelatedClaims()
        {
            int MAXRESULTS = 20;
            List<claim> relatedClaims = new List<claim>();

            relatedClaims.AddRange(RecentMatchingSubscribers());

            if (relatedClaims.Count > MAXRESULTS)
            {
                relatedClaims.RemoveRange(0, relatedClaims.Count - MAXRESULTS);
            }

            dgvClaimsForSubscriber.Rows.Clear();
            foreach (claim aClaim in relatedClaims)
            {
                string isPaid;
                if (Convert.ToBoolean(aClaim.open))
                    isPaid = "Unpaid";
                else
                    isPaid = "Paid";

                dgvClaimsForSubscriber.Rows.Add(new object[] { aClaim.PatientName + " " + aClaim.date_of_service.Value.ToShortDateString() +
                     "\n" + aClaim.LinkedCompany.name + ", " + aClaim.subscriber_group_name + " (" + isPaid + ")", aClaim} );
            }
        }


        /// <summary>
        /// Sets the "next claim" box to be the next best match for the current claim
        /// </summary>
        private void FindBestNextMatch()
        {
            List<claim> bestClaimSet = new List<claim>();

            List<claim> workingSet = HasMatchingPatientMatchingInsurance();
            workingSet.Reverse();

            // Same patient with existing claim at insurance company
            bestClaimSet.AddRange(workingSet);

            if (bestClaimSet.Count == 0)
            {
                workingSet = HasSameInsuranceSamePhone();
                workingSet.Reverse();
                // Next patient, same insurance company, same phone number
                bestClaimSet.AddRange(workingSet);

                if (bestClaimSet.Count == 0)
                {
                    workingSet = HasSameInsuranceDifferentPhone();
                    workingSet.Reverse();
                    // Next patient, same insurance company, different phone number
                    bestClaimSet.AddRange(workingSet);
                }
            }

            if (bestClaimSet.Count > 0)
            {
                _nextClaim = bestClaimSet[0];
                FlashNextClaim(true);
            }
            else
            {
                _nextClaim = null;
                FlashNextClaim(false);
            }

            // SetNextClaimText(_nextClaim);
        }

        /// <summary>
        /// Checks to see whether a claim exists with the current insurance company using a
        /// different phone number. Returns the claim if so, if not returns null
        /// </summary>
        /// <returns></returns>
        private List<claim> HasSameInsuranceDifferentPhone()
        {
            string sql = "SELECT TOP 20 c.* FROM claims c" +
                " INNER JOIN companies cmp ON c.company_id = cmp.id" +
                " WHERE c.id != " + _formClaim.id +
                " AND c.[open] = 1 " +
                " AND c.company_id = '" + _formClaim.company_id +
                "' AND datediff(d, ISNULL(revisit_date, '1753-1-1'), GETDATE()) < 0";

            sql += SentDateWhereClause();

            sql += " ORDER BY patient_last_name, patient_first_name";

            return SearchSQLForMatchingClaim(sql);
        }

        /// <summary>
        /// Checks to see whether a claim exists with the current insurance company using the
        /// same phone number. Returns the claim if so, if not returns null
        /// </summary>
        /// <returns></returns>
        private List<claim> HasSameInsuranceSamePhone()
        {
            string sql = "SELECT TOP 20 c.* FROM claims c" +
                " INNER JOIN companies cmp ON c.company_id = cmp.id" +
                " WHERE c.id != " + _formClaim.id +
                " AND (SELECT COUNT(*) FROM company_contact_info cci WHERE cci.phone = '"
                    + _formClaim.LinkedCompanyAddress.phone + "') > 0" +
                " AND c.[open] = 1 " +
                " AND c.company_id = '" + _formClaim.company_id +
                "' AND datediff(d, ISNULL(revisit_date, '1753-1-1'), GETDATE()) < 0";

            sql += SentDateWhereClause();

            sql += " ORDER BY patient_last_name, patient_first_name";

            return SearchSQLForMatchingClaim(sql);
        }

        /// <summary>
        /// Checks to see whether a claim exists with the current insurance company using the
        /// same patient. Returns the claim if so, if not returns null
        /// </summary>
        /// <returns></returns>
        private List<claim> HasMatchingPatientMatchingInsurance()
        {
            string sql = "SELECT TOP 20 * FROM claims c WHERE id != " + _formClaim.id +
                " AND c.[open] = 1 " +
                " AND patient_first_name = '" + CommonFunctions.MakeDataSafe(_formClaim.patient_first_name) + 
                "' AND patient_last_name = '" + CommonFunctions.MakeDataSafe(_formClaim.patient_last_name) +
                "' AND datediff(d, ISNULL(revisit_date, '1/1/1753'), GETDATE()) < 0";
            
            // Prob is with DateAdd!

            if (_formClaim.patient_dob.HasValue)
            {
                sql += " AND DATEDIFF(d, patient_dob, '" + 
                    _formClaim.patient_dob.Value.ToString() + "') = 0";
            }

            sql += SentDateWhereClause();

            sql += " ORDER BY patient_last_name, patient_first_name";

            return SearchSQLForMatchingClaim(sql);
        }

        /// <summary>
        /// Checks to see whether a claim exists with the current insurance company using the
        /// same patient. Returns the claim if so, if not returns null
        /// </summary>
        /// <returns></returns>
        private List<claim> RecentMatchingSubscribers()
        {
            string sql = string.Format("SELECT * FROM claims c WHERE id != {0} " + 
                "AND subscriber_first_name = '{1}' AND subscriber_last_name = '{2}'" + 
                "AND subscriber_group_name = '{3}' AND subscriber_group_number = '{4}'" + 
                " AND subscriber_ssn = '{5}'", _formClaim.id, CommonFunctions.MakeDataSafe(_formClaim.subscriber_first_name),
                CommonFunctions.MakeDataSafe(_formClaim.subscriber_last_name), CommonFunctions.MakeDataSafe(_formClaim.subscriber_group_name),
                CommonFunctions.MakeDataSafe(_formClaim.subscriber_group_number), CommonFunctions.MakeDataSafe(_formClaim.subscriber_ssn.Replace("-", "")));
            
            sql += " ORDER BY date_of_service desc";

            return SearchSQLForMatchingClaim(sql);
        }

        private string SentDateWhereClause()
        {
            string toReturn = "";
            if (C_DentalClaimTracker.Properties.Settings.Default.SearchSentChecked)
            {
                toReturn = String.Format(" AND sent_date < DATEADD(hour, {0}, GETDATE())", ActiveUser.UserObject.UserData.search_form_sent_date);
            }

            return toReturn;
        }

        private List<claim> SearchSQLForMatchingClaim(string sql)
        {
            List<claim> toReturn = new List<claim>();
            DataTable matches = _formClaim.Search(sql);

            foreach (DataRow aMatch in matches.Rows)
            {
                claim aClaim = new claim();
                aClaim.Load(aMatch);
                toReturn.Add(aClaim);
            }

            return toReturn;
        }

        /// <summary>
        /// Makes the label that shows the next claim flash, drawing attention to it
        /// </summary>
        /// <param name="p"></param>
        private void FlashNextClaim(bool toFlash)
        {
            /*
            if (toFlash)
                lblNextClaim.BackColor = FLASHCOLOR1;
            else
            {
                lblNextClaim.BackColor = FLASHCOLOR2;
                claimFlash.Stop();
            }
             */
        }

        void claimFlash_Tick(object sender, EventArgs e)
        {
            /*
            if (lblNextClaim.BackColor == FLASHCOLOR2)
                lblNextClaim.BackColor = FLASHCOLOR1;
            else
                lblNextClaim.BackColor = FLASHCOLOR2;
             */
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
                formCompany = toLoad;
                txtInsuranceName.Text = toLoad.name;
                txtInsuranceAddress.Text = contactInfo.address;
                txtInsuranceAddress2.Text = contactInfo.address2;
                txtInsuranceCity.Text = contactInfo.city;
                txtInsuranceState.Text = contactInfo.state;
                txtInsuranceZIP.Text = contactInfo.zip;
                txtInsurancePhone.Text = contactInfo.phone_Object.FormattedPhone;


                if (toLoad.NumberOfAddresses > 1)
                {
                    lnkViewCompanyContactInfo.Enabled = true;
                }
                else
                {
                    lnkViewCompanyContactInfo.Enabled = false;
                }
            }
            else
            {
                // cmbInsuranceCarrier.SelectedIndex = -1;
                txtInsuranceAddress.Text = "";
                lnkViewCompanyContactInfo.Enabled = false;
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
                        toSave = _formClaim;
                    else
                    {
                        toSave = new claim();

                        toSave.created_on = DateTime.Now;
                        toSave.created_by = ActiveUser.UserObject.username;

                        _editMode = EditModes.Edit;

                    }

                    #region Field Assignments

                    SaveWithCheckForChange(ref toSave, "notes", txtNotes.Text);

                    toSave.handling = cmbHandling.Text;

                    if (chkUseApexDefaults.Enabled)
                        toSave.apex_override_default_message = !chkUseApexDefaults.Checked;
                    else
                        toSave.apex_override_default_message = false;

                    toSave.apex_message_text = txtApexCustomText.Text;
                    toSave.nea_number = txtNEA_Number.Text;
                    toSave.override_address_provider = cmbOverrideProvider.Text;

                    #endregion

                    toSave.Save();

                    _changed = false;
                    _actionTaken = true;
                    if (toSave.LinkedChanges.Count > 0)
                        lnkViewClaimChangeHistory.Visible = true;

                    choice choice = new choice();
                    call call = new call();

                    return true;
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error in frmClaimManager.Save\n" + err.Message, LogSeverity.Error);
                    MessageBox.Show(this, "An unexpected error occurred attempting to save this claim. Please report " +
                        "this error to an administrator:\n\n" + err.Message, "Unexpected Error in Save Routine", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            else
                return false;
        }

        private bool ValidateForm()
        {
            const string INVALIDDATE = "Not a valid date/time";
            List<string> invalidData = new List<string>();

            /*
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
            */

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
                oldValue = Convert.ToDateTime(toSave[field_name]);

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
                LoggingHelper.Log("Programmer error: ", LogSeverity.Critical,
                    new Exception("Uninitialized type in CheckValuesEqual function."), true);
                return false;
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
            /*
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
             */
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
            return true;
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void lnkViewCompanyContactInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formCompany != null)
            {
                frmCompanyContactInfo toShow = new frmCompanyContactInfo(formCompany, _currentContactInfo.order_id);
                if (toShow.ShowDialog(this) == DialogResult.OK)
                {
                    _currentContactInfo.order_id = toShow.newOrderID;
                }
            }
        }

        private void ctlClaimDisplayData_Resized(object sender, EventArgs e)
        {
            AdjustDisplayDataHeights();
        }

        private void AdjustDisplayDataHeights()
        {
            /*
            pnlClaimData.AutoScroll = false;
            // Insurance, Services, Subscriber, Patient, Doctor, General, Notes, Handling
            ctlClaimDisplayInsurance.Top = DEFAULTINSURANCETOP;
            AutoMove(ctlClaimDisplayServices, ctlClaimDisplayInsurance);
            AutoMove(ctlClaimDisplaySubscriber, ctlClaimDisplayServices);
            AutoMove(ctlClaimDisplayPatient, ctlClaimDisplaySubscriber);
            AutoMove(ctlClaimDisplayDoctor, ctlClaimDisplayPatient);
            AutoMove(ctlClaimDisplayGeneral, ctlClaimDisplayDoctor);
            AutoMove(ctlClaimDisplayNotes, ctlClaimDisplayGeneral);
            AutoMove(ctlHandlingDisplay, ctlClaimDisplayNotes);
            pnlClaimData.AutoScroll = true;
            pnlClaimData.ScrollControlIntoView(focusedControl);
             */
        }

        private void AutoMove(ctlClaimDataDisplay toMove, ctlClaimDataDisplay relativeTo)
        {
            toMove.Top = relativeTo.Top + relativeTo.Height + SPACER;
        }

        private void lnkViewClaimChangeHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewChangeHistory toShow = new frmViewChangeHistory(_formClaim);
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

        private void frmViewClaim_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool cancel = false;
            cmdApex.Focus();
            _formClosing = true;
            

            if (!_readOnly)
            {
                Save();

                if (cmbNewStatus.SelectedIndex <= 0 || !dtpNewRevisitDate.IsValid || dtpNewRevisitDate.CurrentDateText.Trim() == "")
                    cancel = IsShowExitFormCancelled();
                else
                {
                    // Save status here
                    _formClaim.SetStatusAndRevisitDate((claim_status)cmbNewStatus.SelectedItem, dtpNewRevisitDate.CurrentDate);
                }


                if (!cancel)
                {
                    TerminateCall();
                    if (claimStatusForm != null)
                    {
                        if (claimStatusForm.AsIs)
                        {
                            // They didn't make any changes on the claim status form - check the current call, and if no changes were made then
                            // log the action "reviewed claim"
                            if ((ctlStatusHandler._category == null) && (!_actionTaken))
                            {
                                ActiveUser.LogReview(_formClaim.id, "Review Time: " + callTime.TotalSeconds + " seconds");

                            }
                        }
                    }

                    if (searchForm != null)
                        searchForm.SearchThreadSafe(true);
                    UnlockClaim();
                    SavePositionPreferences();
                }
                else
                {
                    if (Settings.Default.UseAdvancedVideo)
                        Opacity = 1;

                    
                    RefreshCallHistoryDropdown();
                }
                _formClosing = false;
                e.Cancel = cancel;
            }

            if ((!cancel) && (_autoLoadSearchOnClose))
            {
                frmSearchClaim fsc = new frmSearchClaim();
                mdiMain.Instance().ShowForm(fsc);
            }

            if ((!cancel) && (_viewingClaimSet != null) && (_readOnly))
            {
                // Opened from Apex claim form, save the X and Y
                Settings.Default.EclaimsViewClaimsX = Left;
                Settings.Default.EclaimsViewClaimsY = Top;

                Settings.Default.Save();
            }
        }

        private void SavePositionPreferences()
        {
            if (!_readOnly)
            {
                if (WindowState == FormWindowState.Maximized)
                    ActiveUser.UserObject.UserData.claim_form_maximized = true;
                else
                {
                    ActiveUser.UserObject.UserData.claim_form_maximized = false;
                    if (Top >= 0)
                        ActiveUser.UserObject.UserData.claim_form_top = Top;
                    if (Left >= 0)
                        ActiveUser.UserObject.UserData.claim_form_left = Left;
                    if (Width > 100)
                        ActiveUser.UserObject.UserData.claim_form_width = Width;
                    if (Height > 100)
                        ActiveUser.UserObject.UserData.claim_form_height = Height;
                }
                

                ActiveUser.UserObject.UserData.Save();
            }
            
        }

        private void LoadPositionPreferences()
        {
            if (!_readOnly)
            {
                if ((Top >= 0) && (Left >= 0) && (Width > 300) && (Height > 300))
                {
                    try
                    {
                        StartPosition = FormStartPosition.Manual;
                        Top = ActiveUser.UserObject.UserData.claim_form_top;
                        Left = ActiveUser.UserObject.UserData.claim_form_left;

                        if (Height + 300 < Screen.PrimaryScreen.WorkingArea.Height)
                            Height = ActiveUser.UserObject.UserData.claim_form_height;

                        if (Width + 300 < Screen.PrimaryScreen.WorkingArea.Width)
                            Width = ActiveUser.UserObject.UserData.claim_form_width;

                        if (ActiveUser.UserObject.UserData.claim_form_maximized)
                            WindowState = FormWindowState.Maximized;

                    }
                    catch (Exception err)
                    {
                        LoggingHelper.Log("Positioning error occurred in frmClaimManager.LoadPositionPreferences", LogSeverity.Error, err, false);
#if DEBUG
                        MessageBox.Show("Error occurred with positioning.\n\n" + err.Message);
#endif 
                    }
                }
            }
        }

        /// <summary>
        /// Shows the classification form for a claim. Returns true if the user 
        /// cancelled out of the dialog.
        /// </summary>
        /// <returns></returns>
        private bool IsShowExitFormCancelled()
        {
            bool cancel;
            string statusString = "";
            if (cmbNewStatus.SelectedIndex > 0)
                statusString = cmbNewStatus.Text;

            DateTime? revisitDate = null;
            bool setRevisitDate = false;
            if (dtpNewRevisitDate.IsValid && dtpNewRevisitDate.CurrentDateText.Trim() != "")
            {
                setRevisitDate = true;
                revisitDate = dtpNewRevisitDate.CurrentDate;
            }

            // Show the form that allows them to change status / revisit date
            if (Settings.Default.UseAdvancedVideo)
                Opacity = .85;

            claimStatusForm = new frmClaimStatus(FormClaim, statusString, setRevisitDate, revisitDate);

            if (WindowState == FormWindowState.Minimized)
            {
                cancel = claimStatusForm.ShowDialog(this) == DialogResult.Cancel;
            }
            else
            {
                claimStatusForm.StartPosition = FormStartPosition.Manual;
                claimStatusForm.Left = Right - claimStatusForm.Width;
                claimStatusForm.Top = Top;
                cancel = claimStatusForm.ShowDialog(this) == DialogResult.Cancel;
            }

            return cancel;
        }

        private void UnlockClaim()
        {
            FormClaim.LockClaim(false);
        }

        private void TerminateCall()
        {
            if (CurrentCall != null)
            {
                callNotes.SaveNote();


                CurrentCall.OnHoldSeconds = System.Convert.ToInt32(holdTime.TotalSeconds);
                CurrentCall.DurationSeconds = System.Convert.ToInt32(callTime.TotalSeconds);
                CurrentCall.talked_to_human = chkTalkedWithPerson.Checked;
                if (ctlStatusHandler._category != null)
                    CurrentCall.call_status = ctlStatusHandler._category.id;
                CurrentCall.Save();

                // Remove any additional info tabs that might still have information
                foreach (VerifyDataViewer vdv in additionalDataTabs)
                {
                    if (!tbcNewCallData.TabPages.Contains(vdv))
                    {
                        foreach (choice aChoice in vdv.DataViewer.Choices)
                        {
                            aChoice.Delete();
                        }
                    }
                }


                ActiveUser.LogAction(ActiveUser.ActionTypes.EndCall, _formClaim.id, CurrentCall.id, "");
            }

            callManager.LoadClaim(_formClaim);

            if (!_formClosing)
            {
                RefreshCallHistoryDropdown();
            }

            ShowNewCallControls(true, true);
            pnlCallControls.Visible = false;
            _questionsAnswered = 0;
            CurrentCall = null;
            ctlStatusHandler.Initialize(_formClaim.company_id);
            ctlDataVerification.Initialize();
            mainQuestionViewer.ClearAllCategories();
            additionalDataTabs.Clear();
            callTimer.Stop();
            onHold = false;
            UpdateHoldTimerLabel();
            foreach (TabPage aTab in tbcNewCallData.TabPages)
            {
                if (aTab is VerifyDataViewer)
                {
                    tbcNewCallData.TabPages.Remove(aTab);
                    aTab.Dispose();
                }
            }
        }

        /// <summary>
        /// Fills in necessary info into the Call History Dropdown
        /// </summary>
        private void RefreshCallHistoryDropdown()
        {
            ctlPastCalls.DisplayClaim(_formClaim, true);
        }

        private void frmViewClaim_Load(object sender, EventArgs e)
        {
            ctlStatusHandler.Initialize(_formClaim.company_id);
            ctlDataVerification.Initialize();
            LoadPositionPreferences();
            LoadUserList();
            callNotes.InitializeQuickNotes();
            pnlCloseClaim.Visible = ActiveUser.UserObject.is_admin;
            try
            {
                cmbQuickSearch.SelectedIndex = 0;
            }
            catch { }
        }

        private void LoadUserList()
        {
            user u = new user();
            List<user> allUsers = u.GetActiveUsers;

            foreach (user aUser in allUsers)
            {

                ToolStripMenuItem tsddb = new ToolStripMenuItem(aUser.username);
                tsddb.Click += new EventHandler(mi_Click);
                tsddb.Tag = aUser;

                ctxUserList.Items.Add(tsddb);
            }
        }

        void mi_Click(object sender, EventArgs e)
        {
            ChangeOwner((user)((ToolStripMenuItem)sender).Tag);
        }

        private void ctlStatusHandler_AllChoicesMade(object sender, EventArgs e)
        {
            ShowNewCallControls(false, false);
            mainQuestionViewer.AddCategory(ctlStatusHandler.Category);

            if (ctlStatusHandler.Category.set_revisit_date == frmEditQuestionTree.SetRevisitDateOptions.Automated)
                dtpNewRevisitDate.DateValue = DateTime.Now.AddDays(ctlStatusHandler.Category.default_revisit_date);
            else if (ctlStatusHandler.Category.set_revisit_date == frmEditQuestionTree.SetRevisitDateOptions.User)
                dtpNewRevisitDate.DateValue = DateTime.Now.AddDays(ctlStatusHandler.Category.default_revisit_date);
            else
                dtpNewRevisitDate.DateValue = null;

            if (ctlStatusHandler.Category.linked_status > 0)
            {
                try
                {
                    cmbNewStatus.SelectedIndex = cmbNewStatus.FindStringExact(new claim_status(ctlStatusHandler.Category.linked_status).name);
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error occurred in frmClaimManager.ctlStatusHander_AllChoicesMade", LogSeverity.Error, err, false);
#if DEBUG
                    MessageBox.Show("DEBUG: Error displaying status.\n" + err.Message);
#endif
                }
            }
        }

        private void StartCall()
        {
            ShowNewCallControls(true, false);

            pnlCallControls.Visible = true;
            tbpCallPage.Text = "Condition";
            if (CurrentCall == null)
                InitializeNewCall();
        }

        private void lnkReclassify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainQuestionViewer.HasCategory)
            {
                if (MessageBox.Show(this, "This will allow you to select a new set of questions for this call. Any questions already answered will be removed. Would you like to continue?", 
                    "Reclassify Call?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
            }

            choice.ClearChoices(mainQuestionViewer.Choices);
            mainQuestionViewer.ClearAllCategories();
            ctlStatusHandler.Initialize(_formClaim.company_id);
            dtpNewRevisitDate.CurrentDate = null;
            cmbNewStatus.SelectedIndex = 0;
            StartCall();
        }

        /// <summary>
        /// Hides and shows the necessary panels when starting a new call, or reclassifying a call
        /// </summary>
        /// <param name="showNewCall"></param>
        /// <param name="showNewCallButton"></param>
        private void ShowNewCallControls(bool showClassification, bool showNewCallButton)
        {
            
            chkTalkedWithPerson.Visible = !showNewCallButton;

            if (showNewCallButton)
            {
                pnlNewCallTopPanel.Visible = false;
                mainQuestionViewer.Visible = false;
                ctlStatusHandler.Visible = false;
            }
            else
            {
                pnlNewCallTopPanel.Visible = !showClassification;
                mainQuestionViewer.Visible = !showClassification;    

                ctlStatusHandler.Visible = showClassification;
            }
        }

        private void ctlDataVerification_ItemCheckChanged(object sender, C_DentalClaimTracker.Call_Management.DataVerificationCheckChangeEventArgs e)
        {
            // Have to add a new tab representing the data (or remove that tab)
            if (e.IsChecked)
            {
                // Check and see if it was already added, if so we'll need to re-show the old tab
                bool exists = false;
                foreach (VerifyDataViewer aViewer in additionalDataTabs)
                {
                    if (aViewer.DataViewer.CurrentParentCategory.id == e.ChangedQuestion.id)
                    {
                        exists = true;
                        tbcNewCallData.TabPages.Add((TabPage)aViewer);
                        break;
                    }
                }

                if (!exists)
                {
                    // Add a new tab iwth e.changequestion
                    VerifyDataViewer vdv = new VerifyDataViewer(e.ChangedQuestion.id);
                    vdv.DataViewer = new C_DentalClaimTracker.Call_Management.CallQuestionViewer();
                    vdv.DataViewer.CurrentCall = CurrentCall;
                    vdv.DataViewer.AddCategory(e.ChangedQuestion);
                    vdv.DataViewer.QuestionAnswered += new EventHandler<C_DentalClaimTracker.Call_Management.QuestionAnsweredEventArgs>(Viewer_QuestionAnswered);
                    vdv.DataViewer.QuestionCleared += new EventHandler(Viewer_QuestionCleared);
                    vdv.Text = e.ChangedQuestion.text;
                    tbcNewCallData.TabPages.Add((TabPage)vdv);
                    additionalDataTabs.Add(vdv);
                }
            }
            else
            {
                foreach (TabPage aPage in tbcNewCallData.TabPages)
                {
                    if (aPage is VerifyDataViewer)
                    {
                        if (((VerifyDataViewer)aPage).DataViewer.CurrentParentCategory.id == e.ChangedQuestion.id)
                        {
                            tbcNewCallData.TabPages.Remove(aPage);
                        }
                    }
                }
            }
        }

        private void splitContainer2_DoubleClick(object sender, EventArgs e)
        {
            if (spltTopBottom.Panel1.Height != 1)
                spltTopBottom.SplitterDistance = 1;
            else
                spltTopBottom.SplitterDistance = TOPPANELDEFAULTHEIGHT;
        }

        private void spltLeftRight_DoubleClick(object sender, EventArgs e)
        {
            if (spltLeftRight.SplitterDistance != LEFTPANELDEFAULTWIDTH)
                spltLeftRight.SplitterDistance = LEFTPANELDEFAULTWIDTH;
            else
                spltLeftRight.SplitterDistance = 1;
        }

        private void callNotes_NewNotes(object sender, EventArgs e)
        {
            if (CurrentCall == null)
                InitializeNewCall();
            _actionTaken = true;
        }

        private void InitializeNewCall()
        {
            CurrentCall = new call();
            CurrentCall.created_on = DateTime.Now;
            CurrentCall.claim_id = _formClaim.id;
            CurrentCall.OnHoldSeconds = 0;
            CurrentCall.operatordata = ActiveUser.UserObject.username;
            CurrentCall.updated_on = DateTime.Now;
            CurrentCall.StartTime = DateTime.Now;
            CurrentCall.parent_id = 0;
            CurrentCall.Save();

            callManager.LoadClaim(_formClaim);

            mainQuestionViewer.CurrentCall = CurrentCall;
            callNotes.CurrentCall = CurrentCall;
            ActiveUser.LogAction(ActiveUser.ActionTypes.StartCall, _formClaim.id, CurrentCall.id, _formClaim.PatientName);
            callTime = new TimeSpan();
            callTimer.Start();
            ctlStatusHandler._category = null;
        }

        void callTimer_Tick(object sender, EventArgs e)
        {
            callTime = callTime.Add(new TimeSpan(TimeSpan.TicksPerSecond));
            UpdateCallTimerLabel();

            if (onHold)
            {
                holdTime = holdTime.Add(new TimeSpan(TimeSpan.TicksPerSecond));
                UpdateHoldTimerLabel();
            }
        }

        private void UpdateCallTimerLabel()
        {
            if (lblCallTime.InvokeRequired)
                Invoke(new EmptyDelegate(UpdateCallTimerLabel));
            else
            {
                string formattedTime = callTime.Hours.ToString("0") + ":" +
                    callTime.Minutes.ToString("00") + ":" + callTime.Seconds.ToString("00");

                lblCallTime.Text = "Call Time: " + formattedTime;

                Text = "Claim Manager (" + formattedTime + ")";
            }
        }

        private void UpdateHoldTimerLabel()
        {
            if (lblHoldTime.InvokeRequired)
                Invoke(new EmptyDelegate(UpdateHoldTimerLabel));
            else
            {
                lblHoldTime.Text = "Hold Time: " + holdTime.Hours.ToString("0") + ":" +
                    holdTime.Minutes.ToString("00") + ":" + holdTime.Seconds.ToString("00");
            }
        }

        private void tbcNavigator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcNavigator.SelectedTab == tabRelatedClaims)
            {
                InitializeRelatedClaims();
            }
        }

        private void Viewer_QuestionAnswered(object sender, C_DentalClaimTracker.Call_Management.QuestionAnsweredEventArgs e)
        {
            _questionsAnswered++;
        }

        private void Viewer_QuestionCleared(object sender, EventArgs e)
        {
            _questionsAnswered--;
        }

        private void cmdStartHold_Click(object sender, EventArgs e)
        {
            if (onHold)
            {
                lblHoldTime.BackColor = System.Drawing.SystemColors.Control;
                cmdStartHold.Text = "On Hold";
            }
            else
            {
                lblHoldTime.BackColor = Color.Yellow;
                cmdStartHold.Text = "Off Hold";
            }
            onHold = !onHold;
        }

        private void cmdMainPrintClaim_Click(object sender, EventArgs e)
        {
            ClaimTrackerCommon.PrintClaim(_formClaim);
        }

        private void mainQuestionViewer_Load(object sender, EventArgs e)
        {

        }

        private void callNotes_Load(object sender, EventArgs e)
        {

        }

        private void spltRightSide_DoubleClick(object sender, EventArgs e)
        {
            if (spltRightSide.SplitterDistance != spltRightSide.Height - NOTEPANELDEFAULTHEIGHT)
                spltRightSide.SplitterDistance = spltRightSide.Height - NOTEPANELDEFAULTHEIGHT;
            else
                spltRightSide.SplitterDistance = spltRightSide.Height - NOTEPANELLOWHEIGHT;
        }

        private void ctlStatusHandler_Load(object sender, EventArgs e)
        {

        }

        private void lnkViewLinkedClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadClaim(LinkedClaim);
        }

        private void ctlClaimDataDisplay_Enter(object sender, EventArgs e)
        {
            focusedControl = (ctlClaimDataDisplay)sender;
        }

        private void cmdCurrentOwner_Click(object sender, EventArgs e)
        {
            ctxUserList.Show(cmdCurrentOwner, new Point(cmdCurrentOwner.Width, 0));
        }

        private void ChangeOwner(user newUser)
        {
            if (FormClaim.IsOwned)
            {
                FormClaim.ReleaseOwner();
            }
            
            FormClaim.Owner = newUser;
            
            UpdateOwnerInfo();
        }

        private void UpdateOwnerInfo()
        {
            if (FormClaim.IsOwned)
            {
                //cmdCurrentOwner.Text = "Release";
                if (FormClaim.Owner.id == ActiveUser.UserObject.id)
                {
                    lblCurrentOwner.Text = "Owner: You";
                   // cmdCurrentOwner.Image = Properties.Resources.tag_blue_delete1;
                }
                else
                {
                    lblCurrentOwner.Text = "Owner: " + FormClaim.Owner.username;
                    //cmdCurrentOwner.Image = Properties.Resources.tag_blue1;
                }
            }
            else
            {
                lblCurrentOwner.Text = "Owner: None";
                //cmdCurrentOwner.Text = "Take";
                //cmdCurrentOwner.Image = Properties.Resources.tag_blue_add1;
            }

            cmdCurrentOwner.Left = lblCurrentOwner.Right + 5;
            lnkViewLinkedClaim.Left = cmdCurrentOwner.Right + 5;
        }

        private void cmdFindNextClaim_Click(object sender, EventArgs e)
        {
            if (pnlClaimsFromSearch.Visible)
                pnlClaimsFromSearch.Visible = false;
            else
            {
                pnlClaimsFromSearch.Visible = true;
                InitializeNextClaimData();
            }

        }

        private void InitializeNextClaimData()
        {
            dgvNextClaimDisplay.Rows.Clear();
            foreach (claim aClaim in _viewingClaimSet)
            {
                dgvNextClaimDisplay.Rows.Add(new object[] { aClaim.PatientName + " " + aClaim.date_of_service.Value.ToShortDateString() +
                     "\n" + aClaim.LinkedCompany.name + ", " + aClaim.subscriber_group_name, aClaim});
            }
        }

        private void MoveNextClaim()
        {
            if (_nextClaim != null)
            {
                MoveToClaim(_nextClaim, "Next Claim Button");
            }
            else
            {
                _autoLoadSearchOnClose = true;
                Close();
            }
        }

        private void MovePreviousClaim()
        {
            if (_viewingClaimIndex > 0)
                _viewingClaimIndex--;

            LoadClaim(_viewingClaimSet[_viewingClaimIndex]);
        }

        private void cmdApex_Click(object sender, EventArgs e)
        {
            cmbHandling.SelectedIndex = cmbHandling.FindStringExact("ApexEDI");

            _formClaim.handling = "ApexEDI";
            _formClaim.Save();

            UpdateProcessClaimsForm();
        }

        private void UpdateProcessClaimsForm()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(C_DentalClaimTracker.E_Claims.frmProcessor))
                {
                    ((C_DentalClaimTracker.E_Claims.frmProcessor)f).MarkClaimHandled(_formClaim);
                    break;
                }
            }
        }

        private void cmdPaper_Click(object sender, EventArgs e)
        {
            cmbHandling.SelectedIndex = cmbHandling.FindStringExact("Paper");

            _formClaim.handling = "Paper";
            _formClaim.Save();

            UpdateProcessClaimsForm();
        }

        private void frmClaimManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((_viewingClaimSet != null) && (_readOnly))
            {
                // Basically, if the form has been opened from Process claims

                if (e.KeyChar.ToString().ToUpper() == "R")
                {
                    cmdPaper.PerformClick();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "E")
                {
                    cmdApex.PerformClick(); 
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "U")
                {
                    cmbHandling.SelectedIndex = cmbHandling.FindStringExact("Unclassified");

                    _formClaim.handling = "Unclassified";
                    _formClaim.Save();

                    UpdateProcessClaimsForm();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "C")
                {
                    Close();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "N")
                {
                    MoveNextClaim();
                    e.Handled = true;
                }
                else if (e.KeyChar.ToString().ToUpper() == "P")
                {
                    MovePreviousClaim();
                    e.Handled = true;
                }
            }
        }

        private void dgvNextClaimDisplay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNextClaimDisplay.SelectedCells.Count > 0)
            {
                MoveToClaim((claim)dgvNextClaimDisplay.Rows[dgvNextClaimDisplay.SelectedCells[0].RowIndex].Cells[1].Value, "Multi Claim Call Next Claim Button");
                pnlClaimsFromSearch.Visible = false;
            }
        }

        private void MoveToClaim(claim toShow, string LogText)
        {
            bool cancel = false;
            TerminateCall();
            if (!_readOnly)
            {
                if (!RecordChangeOK())
                    cancel = true;
                else
                    cancel = IsShowExitFormCancelled();

                if (!cancel)
                    UnlockClaim();

                if (Settings.Default.UseAdvancedVideo)
                    Opacity = 1;
            }

            if (!cancel)
            {
                _viewingClaimIndex++;
                LoadClaim(toShow);
                ActiveUser.LogAction(ActiveUser.ActionTypes.ViewClaim, toShow.id, LogText + " " + toShow.PatientName);
                StartCall();
            }
        }

        private void txtQuickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QuickSearch();
                e.Handled = true;
            }
        }

        private void QuickSearch()
        {
            string sql = "SELECT TOP 40 c.* FROM claims c " +
                "LEFT JOIN Companies cmp ON c.company_id = cmp.id WHERE 0=0 ";

            if (cmbQuickSearch.SelectedIndex == 1) // PATIENT SSN
            {
                sql += "AND c.patient_ssn LIKE '%" + txtQuickSearch.Text + "%'";
            }
            else if (cmbQuickSearch.SelectedIndex == 2)
            {
                sql += "AND cmp.name LIKE '%" + txtQuickSearch.Text + "%'";
            }
            else // (cmbQuickSearch.SelectedIndex == 0) // PATIENT NAME
            {
                sql += claim.BuildWherePatientName(txtQuickSearch.Text, 1); // 1 = all
            }

            sql += " AND c.[open] = 1 ORDER BY cmp.name, c.subscriber_group_name, c.patient_last_name, c.patient_first_name";

            claim c = new claim();
            
            dgvNextClaimDisplay.Rows.Clear();
            foreach (DataRow aMatch in c.Search(sql).Rows)
            {
                c = new claim();
                c.Load(aMatch);
                dgvNextClaimDisplay.Rows.Add(new object[] { c.PatientName + " " + c.date_of_service.Value.ToShortDateString() +
                     "\n" + c.LinkedCompany.name + ", " + c.subscriber_group_name , c});
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            QuickSearch();
        }

        private void cmdClearSearch_Click(object sender, EventArgs e)
        {
            txtQuickSearch.Clear();
            dgvNextClaimDisplay.Rows.Clear();

            InitializeNextClaimData();
        }

        private void lblNextClaim_DoubleClick(object sender, EventArgs e)
        {
            // You can go to this claim by double-clicking on it, or view the claim list by hitting the claim list button
            MoveNextClaim();
        }

        private void lblNextClaim_Click(object sender, EventArgs e)
        {
            
        }

        private void frmClaimManager_Shown(object sender, EventArgs e)
        {
            if (!_readOnly)
                StartCall();
        }

        private void cmdResendClaim_Click(object sender, EventArgs e)
        {
            if (_processForm == null)
            {
                _processForm = new C_DentalClaimTracker.E_Claims.frmProcessor();
            }

            _processForm.ResendClaimApex(_formClaim);

            if (_formClaim.SetResendStatus())
            {
                if (_formClaim.status_id > 0)
                {
                    cmbNewStatus.SelectedIndex = cmbNewStatus.FindStringExact(new claim_status(_formClaim.status_id).name);
                }
                
                if (_formClaim.revisit_date.HasValue)
                    dtpNewRevisitDate.DateValue = _formClaim.revisit_date.Value;

            }

            ActiveUser.LogAction(ActiveUser.ActionTypes.ResendClaim, _formClaim.id, "Apex Resend");
            LoadHandling();
            _actionTaken = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            grpApexOptions.Enabled = !chkUseApexDefaults.Checked;

            if (chkUseApexDefaults.Checked)
            {
                SetApexToDefault();
            }
            if (!_loading)
                Save();
        }

        private void cmbHandling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHandling.SelectedIndex == 2) // Apex
            {
                chkUseApexDefaults.Enabled = true;
                grpApexOptions.Enabled = !chkUseApexDefaults.Checked;
            }
            else
            {
                chkUseApexDefaults.Enabled = false;
                grpApexOptions.Enabled = false;
            }
            if (!_loading) 
                Save();
        }

        private void cmbApexStandardOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApexStandardOption.SelectedIndex > 0)
            {
                txtApexCustomText.Text = cmbApexStandardOption.Text;
                cmbApexStandardOption.SelectedIndex = 0;
            }
            if (!_loading)
                Save();
        }

        private void frmClaimManager_Deactivate(object sender, EventArgs e)
        {
            callTimer.Stop();
        }

        private void frmClaimManager_Activated(object sender, EventArgs e)
        {
            if (callTimer != null)
                callTimer.Start();
        }

        private void Save_Claim(object sender, EventArgs e)
        {
            if (!_loading)
                Save();
        }

        private void chkCustomAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (!_loading)
                Save();
        }

        private void ctlClaimDisplayInsurance_Load(object sender, EventArgs e)
        {

        }

        private void cmdEndCall_Click(object sender, EventArgs e)
        {
            TerminateCall();
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will mark the claim as paid and hide it from searches. Are you sure you want to do this?", "Mark Claim Paid", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                _formClaim.open = 0;
                _formClaim.Save();
                lblClaimPaid.Text = "Paid";                
                MessageBox.Show("Claim marked as paid.");
            }
        }

        private void cmdClaimInfo_Click(object sender, EventArgs e)
        {
            ShowPanel(cmdClaimInfo, pnlClaimData);
        }

        /// <summary>
        /// Highlights the correct button and shows the panel
        /// </summary>
        /// <param name="cmdClaimInfo"></param>
        /// <param name="pnlClaimData"></param>
        private void ShowPanel(Button toHighlight, Panel pnlClaimData)
        {
            foreach (Control aControl in pnlDisplayPanel.Controls)
            {
                pnlDisplayPanel.Controls.Remove(aControl);
            }

            pnlDisplayPanel.Controls.Add(pnlClaimData);
            pnlClaimData.Dock = DockStyle.Fill;

            List<Button> allButtons = new List<Button>(new Button[] { cmdClaimInfo, cmdRelatedClaims, cmdSearchClaims, cmdWorkHistory});

            foreach (Button aButton in allButtons)
            {
                if (aButton == toHighlight)
                {
                    aButton.FlatStyle = FlatStyle.Flat;
                    aButton.BackColor = Color.LightYellow;
                }
                else
                {
                    aButton.FlatStyle = FlatStyle.Standard;
                    aButton.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void cmdWorkHistory_Click(object sender, EventArgs e)
        {
            ShowPanel(cmdWorkHistory, pnlPastStatus);
        }

        private void cmdSearchClaims_Click(object sender, EventArgs e)
        {
            InitializeNextClaimData();
            ShowPanel(cmdSearchClaims, pnlClaimsFromSearch);
        }

        private void cmdRelatedClaims_Click(object sender, EventArgs e)
        {
            InitializeRelatedClaims();
            ShowPanel(cmdRelatedClaims, pnlRelatedClaims);
        }

        private void dgvClaimsForSubscriber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClaimsForSubscriber.SelectedCells.Count > 0)
            {
                MoveToClaim((claim)dgvClaimsForSubscriber.Rows[dgvClaimsForSubscriber.SelectedCells[0].RowIndex].Cells[1].Value, "Claims For Subscriber Button");
                pnlClaimsFromSearch.Visible = false;
            }
        }
        
    }

    public class VerifyDataViewer : TabPage
    {
        private C_DentalClaimTracker.Call_Management.CallQuestionViewer ctlViewer;
        public int Index;

        public C_DentalClaimTracker.Call_Management.CallQuestionViewer DataViewer
        {
            get { return ctlViewer; }
            set
            {
                SuspendLayout();

                ctlViewer = value;
                ctlViewer.SuspendLayout();

                ctlViewer.AutoScroll = true;
                ctlViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                ctlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
                ctlViewer.Location = new System.Drawing.Point(0, 0);
                ctlViewer.Name = "ctlViewer" + Index;
                ctlViewer.Size = new System.Drawing.Size(653, 652);
                ctlViewer.TabIndex = 0;


                Controls.Add(this.ctlViewer);
                ctlViewer.ResumeLayout();
                ResumeLayout();
            }
        }

        public VerifyDataViewer(int index)
        {
            Location = new System.Drawing.Point(4, 22);
            Name = "tabDataViewer" + index;
            Size = new System.Drawing.Size(653, 652);
            TabIndex = 3;
            Text = "Verify Page";
            UseVisualStyleBackColor = true;

            Index = index;
        }
    }

    public class DisplayCall
    {
        private call _linkedCall;

        public call LinkedCall
        {
            get { return _linkedCall; }
            set { _linkedCall = value; }
        }

        public override string ToString()
        {
            int answersCount = _linkedCall.GetCallChoices().Count;
            string toReturn = _linkedCall.ToString() + "      (" + answersCount + " answers)";

            if (answersCount == 1)
                toReturn = toReturn.Replace("answers", "answer");

            if (LinkedCall.call_status > 0)
            {
                try { toReturn += " - " + _linkedCall.LinkedStatus.text; }
                catch { }
            }

            return toReturn;

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
            ToothRange = toDisplay.tooth_range_string;
            
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