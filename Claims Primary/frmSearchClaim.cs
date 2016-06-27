using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using NHDG.EClaims;
using System.Threading;
using System.Diagnostics;
using System.Data.OleDb;
using C_DentalClaimTracker.Claims_Primary.SearchResults;
using C_DentalClaimTracker.Claims_Primary;
using System.Linq;

namespace C_DentalClaimTracker
{
    public partial class frmSearchClaim : Form
    {
        List<DataGridViewRow> printRows;
        List<DataGridViewColumn> printListColumns;
        StringFormat strFormat; //Used to format the grid rows.
        List<InsuranceCompanyGroups> formGroups;
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        ParameterizedThreadStart ts;
        Thread t;
        Thread tBin;
        ParameterizedThreadStart tBins;
        string lastCountSQL;
        List<ComboItemForCompanyString> companyList = new List<ComboItemForCompanyString>();
        private const int STARTSWITHSEARCHTYPEINDEX = 2;
        private const int EXACTSEARCHTYPEINDEX = 3;
        DataGridViewCellStyle highlightedRow = new DataGridViewCellStyle();
        DataGridViewCellStyle invalidRow = new DataGridViewCellStyle();
        private delegate void SearchDelegate(MainSearchSearchResultList mssrl);
        private delegate void AddRowDelegate(object[] rowToAdd, bool insert);
        private delegate void BinUIDelegate(List<int> binCounts);
        private delegate void CompanyUIDelegate(List<ComboItemForCompanyString> ListToAdd);
        int currentUserID;
        int maxResults;
        bool _loading = false;
        FormSearchMode _searchMode = FormSearchMode.Unsent;
        C_DentalClaimTracker.E_Claims.frmProcessor _processForm;
        int ActiveThreadID = 0;
        int binThreadID = 0;
        MainSearchSearchResultList primarySearchResults;
        private delegate string BuildWhereDelegate(bool useBin, bool useCompany);
        Stopwatch searchTimer = new Stopwatch();

        enum FormSearchMode
        {
            Unsent,
            Waiting,
            Resolve,
            All,
            MyClaims
        }

        public frmSearchClaim()
        {
            InitializeComponent();
            InitializeProviders();
            InitializePrintListColumns();
            _loading = true;

            ts = new ParameterizedThreadStart(Search);
            tBins = new ParameterizedThreadStart(UpdateBinsAndCompanies);
            
            highlightedRow.BackColor = Color.LightBlue;
            invalidRow.BackColor = Color.LightGray;
            currentUserID = ActiveUser.UserObject.id;

        }

        private void InitializeProviders()
        {
            claim searchObject = new claim();

            cmbProviderID.Items.Clear();
            cmbProviderID.Items.Add("");
            ctxtProviderList.Items.Add("", null, new EventHandler(ctxtProviderList_Click));
            claim.OverrideProviderList().ForEach(p =>
            {
                cmbProviderID.Items.Add(p.doctor_provider_id);
                ctxtProviderList.Items.Add(p.doctor_provider_id, null, new EventHandler(ctxtProviderList_Click));
            });
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchThreadSafe(true);
        }

        public void SearchThreadSafe(bool useMultiThread)
        {
            try
            {
                
                if (useMultiThread)
                {
                    searchTimer.Reset();
                    searchTimer.Start();
                    t = new Thread(ts);
                    ActiveThreadID = t.ManagedThreadId;
                    maxResults = System.Convert.ToInt32(nmbMaxResults.Value);
                    string sql = BuildSQL();
                    Debug.WriteLine(" thread started.");
                    
                    if (t.ManagedThreadId == ActiveThreadID)
                    {
                        lblSearching.Visible = true;
                        t.Start(sql);
                        UpdateBinsAndCompaniesThreadSafe(BuildCountSQL());
                    }
                    else
                        Debug.WriteLine("Aborting search thread " + Thread.CurrentThread.ManagedThreadId);
                }
                else
                {
                    // Not multithreading
                    maxResults = System.Convert.ToInt32(nmbMaxResults.Value);
                    string sql = BuildSQL();
                    Search(sql);
                    UpdateBinsAndCompaniesThreadSafe(BuildCountSQL());
                }
            }
            catch (Exception err)
            {
                string errData = err.Message;
                Exception temp = err;
                while (temp.InnerException != null)
                {
                    temp = temp.InnerException;
                    errData += "\n\n" + temp.Message;
                }
                LoggingHelper.Log("Error in frmSearchClaim.SearchThreadSafe", LogSeverity.Warning, err);
                MessageBox.Show(this, "There was an error retrieving search results. There may be a problem with your database connection.\n\n" + errData,
                    "Could not search");
            }
        }

        private string BuildCountSQL()
        {
            string toReturn = "SELECT count(*) FROM claims c " +
                "LEFT JOIN Companies cmp ON c.company_id = cmp.id " +
                "LEFT JOIN users u ON c.owner_id = u.id ";

            toReturn += BuildWhere(false, true);
            lastCountSQL = toReturn;
            return toReturn;
        }

        private void Search(object searchSQL)
        {
            claim c = new claim();
            if (ValidateForm())
            {
                try
                {
                    DateTime startTime = DateTime.Now;
                    
                    
                    DataTable dt = c.Search((string) searchSQL);
                    Debug.WriteLine("Time for primary search: " + new TimeSpan(DateTime.Now.Ticks - startTime.Ticks).TotalSeconds + " seconds");
                    List<object[]> allRowsToAdd = new List<object[]>();
                    bool showUserClaimsFirst = ActiveUser.UserObject.UserData.show_my_claims_first;
                    Debug.WriteLine("Time for get all restrictions: " + new TimeSpan(DateTime.Now.Ticks - startTime.Ticks).TotalSeconds + " seconds");
                    MainSearchSearchResultList mssrl = new MainSearchSearchResultList();
                    MainSearchSearchResult mssr;

                    var perList = provider_eligibility_restrictions.GetAllDataAsList();

                    foreach (DataRow aRow in dt.Rows)
                    {
                        if (Thread.CurrentThread.ManagedThreadId != ActiveThreadID)
                        {
                            Debug.WriteLine("Cancelling a search thread.");
                            return;
                        }
                        c = new claim();
                        c.Load(aRow);
                        int owner_id = CommonFunctions.DBNullToZero(c["owner_id"]);

                        string statusText;
                        string lastEditText;
                        string provider_info = "";
                        string assnText;
                        DateTime? patientDOB = null;
                        DateTime? revisitDate = null;
                        DateTime? lastSent = null;

                        if (c.status_id > 0)
                        {
                            statusText = new claim_status(c.status_id).name;
                        }
                        else
                            statusText = "-";

                        user_action_log ual = new user_action_log();
                        ual.claim_id = c.id;
                        DataTable matches = ual.Search(ual.SearchSQL + " AND action_id <> " + (int) C_DentalClaimTracker.ActiveUser.ActionTypes.ReviewClaim + " ORDER BY action_taken_time desc");
                        if (matches.Rows.Count > 0)
                        {
                            // We want the info from the last change
                            ual.Load(matches.Rows[0]);
                            lastEditText = ual.LinkedUser.username + " " + ual.action_taken_time.ToShortDateString();
                        }
                        else
                        {
                            lastEditText = "None";
                        }

                        try
                        {
                                // Check for provider eligibility substitutions, add doctor name as ()
                                provider_info = c.doctor_last_name;
                                claim switchToClaim = provider_eligibility_restrictions.FindEligibilityRestrictions(c, perList);

                                if (switchToClaim != null)
                                    provider_info += " (" + switchToClaim.doctor_provider_id + ")";
                                else if (c.CheckForAddressOverride)
                                    provider_info += string.Format(" ({0})", c.override_address_provider);
                            
                        }
                        catch { Debug.WriteLine("Error getting provider info in search form."); }



                        if (c.Owner != null)
                            assnText = c.Owner.username;
                        else
                            assnText = "";

                        

                        if (CheckDateTimeValue(c.patient_dob) != null)
                            patientDOB = c.patient_dob;

                        if (CheckDateTimeValue(c.revisit_date) != null)
                            revisitDate = c.revisit_date;

                        lastSent = c.GetMostRecentSentDate();



                        mssr = new MainSearchSearchResult(c.PatientLastNameCommaFirst, patientDOB,
                         c.LinkedCompany.name, c.amount_of_claim.ToString("$0"), c.date_of_service, 
                            c.claim_type_display(true), revisitDate, assnText, provider_info, statusText, lastEditText, c.claimidnum, c.claimdb, c, c.DatesOfServiceString(), lastSent);

                        if ((showUserClaimsFirst) && (owner_id == currentUserID))
                            mssrl.Insert(0, mssr);                        
                        else
                            mssrl.Add(mssr);
                        

                        if (allRowsToAdd.Count == maxResults)
                            break;
                    }


                    Debug.WriteLine("Primary search took: " + new TimeSpan(DateTime.Now.Ticks - startTime.Ticks).TotalSeconds + " seconds");
                    if (Thread.CurrentThread.ManagedThreadId != ActiveThreadID)
                    {
                        Debug.WriteLine("Search was cancelled, cancelling a search thread.");
                        return;
                    }
                    FinalSearchTouchup(mssrl);
                    

                }
                catch (Exception err)
                {
                    string errData = "Error in search function: " + err.Message;
                    Exception temp = err;
                    while (temp.InnerException != null)
                    {
                        temp = temp.InnerException;
                        errData += "\n\n" + temp.Message;
                    }
                    System.Diagnostics.Debug.WriteLine(errData);
                    LoggingHelper.Log("Error in frmSearchClaim.Search", LogSeverity.Error, err);
                    FinalSearchTouchup(null);
                }
            }
            
        }

        private void AddRow(object[] rowToAdd, bool insert)
        {
            if (dgvResults.InvokeRequired)
            {
                AddRowDelegate ard = new AddRowDelegate(AddRow);
                Invoke(ard, new object[] { rowToAdd, insert });
            }
            else
            {
                claim c;
                if (insert)
                {
                    dgvResults.Rows.Add(rowToAdd);
                    c = (claim)dgvResults.Rows[dgvResults.Rows.Count - 1].Cells["colClaimObject"].Value;
                }
                else
                {
                    dgvResults.Rows.Insert(0, rowToAdd);
                    c = (claim)dgvResults.Rows[0].Cells["colClaimObject"].Value;
                }

                // iterate through the rows and highlight the ones with revisit dates
                if (c.revisit_date.HasValue)
                    if (c.revisit_date.Value.Date <= DateTime.Now.Date)
                        dgvResults.Rows[dgvResults.Rows.Count - 1].DefaultCellStyle = highlightedRow;
                    else if (c.revisit_date.Value.Date > DateTime.Now.Date)
                        dgvResults.Rows[dgvResults.Rows.Count - 1].DefaultCellStyle = invalidRow;
            }
        }

        private void FinalSearchTouchup(MainSearchSearchResultList mssrl)
        {
            try
            {
                if (dgvResults.InvokeRequired)
                {
                    // Call this method
                    SearchDelegate sd = new SearchDelegate(FinalSearchTouchup);
                    Invoke(sd, new object[] { mssrl });
                }
                else
                {
                    int counterMax;
                    if (mssrl == null)
                        counterMax = 0;
                    else if (mssrl.Count > maxResults)
                        counterMax = maxResults;
                    else
                        counterMax = mssrl.Count;

                    dgvResults.SuspendLayout();
                    dgvResults.DataSource = null;
                    primarySearchResults = mssrl;
                    bsResults.DataSource = mssrl;

                    dgvResults.DataSource = bsResults;
                    
                    dgvResults.ResumeLayout();

                    if (dgvResults.SortedColumn != null)
                    {
                        if (dgvResults.SortOrder == System.Windows.Forms.SortOrder.Descending)
                            dgvResults.Sort(dgvResults.SortedColumn, ListSortDirection.Descending);
                        else
                            dgvResults.Sort(dgvResults.SortedColumn, ListSortDirection.Ascending);
                    }

                    UpdateBinLabel();

                    searchTimer.Stop();
                    lblSearchTime.Text = string.Format("Search time: {0} ms", searchTimer.ElapsedMilliseconds);
                    lblSearching.Visible = false;
                }
            }
            catch (Exception err)
            {
                string errData = err.Message;
                Exception temp = err;
                while (temp.InnerException != null)
                {
                    temp = temp.InnerException;
                    errData += "\n\n" + temp.Message;
                }
                System.Diagnostics.Debug.WriteLine(errData);
                LoggingHelper.Log("Error in frmSearchClaim.FinalSearchTouchup", LogSeverity.Error, err, false);
                try
                {

                    FinalSearchTouchup(null);
                }
                catch (Exception err2)
                {
                    LoggingHelper.Log("Error in level 2 of frmSearchClaim.FinalSearchTouchup", LogSeverity.Error, err2, false);
                    Debug.WriteLine("An error occurred doing search touchup. " + err2.Message);
                }
            }
        }

        private void UpdateBinLabel()
        {
            try
            {
                if (cmdUnsubmittedBin.Tag != null)
                {
                    string rows = dgvResults.Rows.Count.ToString();

                    cmdUnsubmittedBin.Text = "Unsent (" + cmdUnsubmittedBin.Tag.ToString() + ")";
                    cmdResolveBin.Text = "Resolve (" + cmdResolveBin.Tag.ToString() + ")";
                    cmdAllBin.Text = "All (" + cmdAllBin.Tag.ToString() + ")";

                    if (_searchMode == FormSearchMode.Unsent)
                        VerifyBinLabel(cmdUnsubmittedBin, rows, cmdUnsubmittedBin.Tag.ToString(), "Unsent");
                    else if (_searchMode == FormSearchMode.Resolve)
                        VerifyBinLabel(cmdResolveBin, rows, cmdResolveBin.Tag.ToString(), "Resolve");
                    else if (_searchMode == FormSearchMode.All)
                    {
                        VerifyBinLabel(cmdAllBin, rows, cmdAllBin.Tag.ToString(), "All");
                    }
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error occurred updating bin labels.", LogSeverity.Error, err, false);
                Debug.WriteLine("Error occurred updating bin labels.\n" + err.Message);
            }
        }

        private void VerifyBinLabel(Button cmdButton, string rowCount, string binCount, string lblText)
        {
            try
            {
                int rows = System.Convert.ToInt32(rowCount);
                int bins = System.Convert.ToInt32(binCount);

                if (bins > rows)
                    cmdButton.Text = lblText + " (MAX/" + cmdButton.Tag.ToString() + ")";

                // no need to change otherwise, label already set
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error occurred in VerifyBinLabel", LogSeverity.Error, err, false);
                Debug.WriteLine("Error occurred with bin labels: " + err.Message);
            }
        }

        private DateTime? CheckDateTimeValue(DateTime? currentValue)
        {
            if (currentValue.HasValue)
            {
                if (currentValue.Value.Year == 1753)
                    return null;
                else
                    return currentValue;
            }
            else
                return null;
        }

        private bool ValidateForm()
        {
            string errors = "Your search could not be completed. The following errors were found on the form:\n";
            bool error = false;

            if (txtClaimAmount.Text != "")
            {
                if (!CommonFunctions.IsNumeric(txtClaimAmount.Text))
                {
                    errors += "\nClaim amount is not numeric";
                    error = true;
                }
            }



            if (!ctlPatientDOB.IsValid)
            {
                errors += "\nThe patient DOB is not a valid date";
                error = true;
            }

            errors += "\n\nPlease fix the above problems and try your search again.";

            if (error)
            {
                MessageBox.Show(this, errors, "Could not search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return !error;
        }

        private string BuildSQL()
        {
            string toReturn = "SELECT TOP " + nmbMaxResults.Value.ToString() + " c.* FROM claims c " +
                "LEFT JOIN Companies cmp ON c.company_id = cmp.id " +
                "LEFT JOIN users u ON c.owner_id = u.id ";
            toReturn += BuildWhere(true, true);
            toReturn += " ORDER BY c.revisit_date asc, cmp.name";
            

            return toReturn;
        }

        /// <summary>
        /// Builds the WHERE statement for this form
        /// </summary>
        /// <param name="useBin">Should the current bin be included in the where statement limiting results</param>
        /// <returns></returns>
        private string BuildWhere(bool useBin, bool useCompanies)
        {
            if (cmbCompanyDropdown.InvokeRequired)
            {
                return (string)Invoke(new BuildWhereDelegate(BuildWhere), useBin, useCompanies);
            }
            else
            {

                string toReturn = "";

                if (cmbCompanyDropdown.Text != "" && useCompanies)
                {
                    // This is a little strange, but we need to do searches for the company name with and without the parentheses 
                    // The display may or may not have parens at the time the search happens due to multi-threading
                    // 
                    string companyName = cmbCompanyDropdown.Text;

                    if (companyName.IndexOf(" (") > 0)
                    {
                        // If a company is displaying numbers after the name, remove them for the search
                        companyName = companyName.Substring(0, companyName.LastIndexOf(" ("));

                    }
                    InsuranceCompanyGroups icg = null;

                    if (cmbCompanyDropdown.FindStringExact(cmbCompanyDropdown.Text) >= 0)
                    {
                        icg = ((InsuranceCompanyGroups)cmbCompanyDropdown.Items[cmbCompanyDropdown.FindStringExact(cmbCompanyDropdown.Text)]);
                    }
                    else if (cmbCompanyDropdown.FindStringExact(companyName) >= 0)
                    {
                        icg = ((InsuranceCompanyGroups)cmbCompanyDropdown.Items[cmbCompanyDropdown.FindStringExact(cmbCompanyDropdown.Text)]);
                    }

                    if (icg != null)
                    {
                        if (icg.Group == null)
                            toReturn += BuildWhereSingle("cmp.id", icg.Companies[0].id.ToString(), DataTypes.Numeric);
                        else
                            toReturn = string.Format(" AND cmp.id IN({0})", ClaimTrackerCommon.CompaniesToInString(icg.Companies));
                    }

                    else
                    {
                        // May have to remove final characters
                        toReturn += BuildWhereSingle("cmp.name", companyName, DataTypes.Text);
                    }

                }

                toReturn += claim.BuildWherePatientName(txtPatientName.Text, cmbSearchType.SelectedIndex);
                toReturn += BuildWhereSingle("c.patient_dob", ctlPatientDOB.CurrentDateText, DataTypes.Date);
                if (CommonFunctions.IsNumeric(txtClaimAmount.Text))
                {
                    // Have to multiply whatever they put in by 100, blech
                    toReturn += BuildWhereSingle("c.amount_of_claim", (System.Convert.ToDecimal(txtClaimAmount.Text) * 100).ToString("#"), DataTypes.Numeric);
                }
                else
                    txtClaimAmount.Text = "";
                toReturn += BuildWhereSingle("c.subscriber_group_number", txtGroupNum.Text, DataTypes.Text);
                toReturn += BuildWhereSingle("c.subscriber_group_name", txtGroupPlan.Text, DataTypes.Text);


                toReturn += BuildWhereSingle("c.sent_date", ctlSentDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkSentDateEnabled.Checked);
                toReturn += BuildWhereSingle("c.resent_date", ctlResentDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkResentDateEnabled.Checked);
                toReturn += BuildWhereSingle("c.on_hold_date", ctlOnHoldDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkHoldDateEnabled.Checked);
                toReturn += BuildWhereSingle("c.tracer_date", ctlTracerDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkTracerDateEnabled.Checked);
                toReturn += BuildWhereSingle("c.status_last_date", ctlLastUpdateDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkLastUpdateEnabled.Checked);
                toReturn += BuildWhereSingle("c.revisit_date", dtpRevisitDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkRevisitDate.Checked);
                toReturn += BuildWhereSingle("c.created_on", dtpCreateDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex), chkCreateDate.Checked);

                // Last Sent date
                if (chkLastSent.Checked)
                {
                    toReturn += " AND (SELECT MAX(bcl.last_send_date) FROM batch_claim_list bcl WHERE bcl.claim_id = c.id)";

                    // Have to do special processing for the date
                    DateTime compareDate = System.Convert.ToDateTime(dtpLastSent.CurrentDateText);
                    string dateWhere;
                    if (ConvertToSearchType(cmbDateFilterType.SelectedIndex) == DataObject.SearchTypes.Before)
                    {
                        dateWhere = " < '" + CommonFunctions.ToMySQLDateTime(compareDate) + "'";
                    }
                    else if (ConvertToSearchType(cmbDateFilterType.SelectedIndex) == DataObject.SearchTypes.After)
                    {
                        dateWhere = " > '" + CommonFunctions.ToMySQLDateTime(compareDate) + "'";
                    }
                    else
                    {
                        dateWhere = " <= '" + CommonFunctions.ToMySQLDateTime(compareDate.AddDays(1)) + "'";
                        dateWhere += " AND (SELECT MAX(bcl.last_send_date) FROM batch_claim_list bcl WHERE bcl.claim_id = c.id)";
                        dateWhere += " >= '" + CommonFunctions.ToMySQLDateTime(compareDate) + "'";
                    }
                    toReturn += dateWhere;
                }


                // Open claims only
                if ((_searchMode != FormSearchMode.All) || (chkOpenClaimsOnly.Checked) || !useBin)
                    toReturn += " AND c.[open] = 1";
                else
                    toReturn += "";

                if (useBin)
                {
                    if (_searchMode == FormSearchMode.Unsent)
                        toReturn += BuildWhereUnsent();
                    else if (_searchMode == FormSearchMode.Resolve)
                        toReturn += BuildWhereHideNotYetRevisitDate();
                    else if (_searchMode == FormSearchMode.Waiting)
                        toReturn += BuildWhereShowNotYetRevisitDate();
                    else if (_searchMode == FormSearchMode.MyClaims)
                    {
                        if (ActiveUser.UserObject.is_admin)
                            toReturn += " AND c.owner_id > 0";
                        else
                            toReturn += " AND c.owner_id = " + ActiveUser.UserObject.id;
                    }
                }

                #region Types
                string typesString = "";

                if (chkShowPrimary.Checked)
                    typesString += "(c.claim_type = " + (int)claim.ClaimTypes.Primary + ")";
                if (chkShowSecondary.Checked)
                {
                    if (typesString != string.Empty)
                        typesString += " OR ";

                    typesString += "(c.claim_type = " + (int)claim.ClaimTypes.Secondary + ")";
                }
                if (chkShowPredeterms.Checked)
                {
                    if (typesString != string.Empty)
                        typesString += " OR ";

                    if (system_options.LimitPredetermsOnSearch)
                        typesString += "(c.claim_type = " + (int)claim.ClaimTypes.Predeterm +
                            " OR c.claim_type = " + (int)claim.ClaimTypes.SecondaryPredeterm +
                            " AND c.date_of_service > '" + CommonFunctions.ToMySQLDate(system_options.PredetermSearchDateMinimum) + "')";
                    else
                        typesString += "(c.claim_type = " + (int)claim.ClaimTypes.Predeterm + " OR c.claim_type = "
                            + (int)claim.ClaimTypes.SecondaryPredeterm + ")";
                }

                if (typesString == "")
                    typesString = "(c.claim_type = -1)";
                #endregion
                toReturn += " AND (" + typesString + ")";

                #region Clinic
                string clinicSQL = "";

                if (cmbClinic.SelectedIndex > 0) // 0 = all clinics
                {
                    clinicSQL += " AND c.clinic_id = " + ((clinic)cmbClinic.SelectedItem).id;
                }

                #endregion
                toReturn += clinicSQL;

                #region Status
                string statusSQL = "";
                if (cmbStatus.SelectedIndex == 1)
                {
                    statusSQL = " AND c.status_id is NULL";
                }
                else if (cmbStatus.SelectedIndex > 1)
                {
                    statusSQL = " AND c.status_id = " + ((claim_status)cmbStatus.SelectedItem).id;
                }
                #endregion
                toReturn += statusSQL;

                if (CommonFunctions.IsNumeric(txtBatchNumber.Text))
                    toReturn += " AND c.id IN (SELECT claim_id FROM batch_claim_list WHERE batch_id = " + Convert.ToInt32(txtBatchNumber.Text) + ")";

                if (cmbProviderID.SelectedIndex > 0)
                    toReturn += BuildWhereSingle("c.doctor_provider_id", cmbProviderID.Text, DataTypes.Text, DataObject.SearchTypes.Exact);

                if (chkNEANumOnly.Checked)
                    toReturn += " AND (c.nea_number != '' OR (SELECT COUNT(*) FROM notes WHERE note_text like '%nea%' and claim_id = c.id) > 0)";


                // Replace the first instance of AND with WHERE
                Regex r = new Regex(" AND ", RegexOptions.IgnoreCase);
                toReturn = r.Replace(toReturn, " WHERE ", 1);

                return toReturn;
            }
        }

        
        private DataObject.SearchTypes ConvertToSearchType(int p)
        {
            if (p == 0) // before
                return DataObject.SearchTypes.Before;
            else if (p == 1)
                return DataObject.SearchTypes.After;
            else
                return DataObject.SearchTypes.Exact;
        }

        /// <summary>
        /// Hide all claims where revisit date is greater than the current date
        /// </summary>
        /// <returns></returns>
        private string BuildWhereHideNotYetRevisitDate()
        {
             return " AND (DATEDIFF(d, c.revisit_date, GETDATE()) >= 0)";
        }

        private string BuildWhereShowNotYetRevisitDate()
        {
            return " AND (DATEDIFF(d, c.revisit_date, GETDATE()) < 1)";
        }


        private string BuildWhereUnsent()
        {
            return " AND (SELECT Count(*) FROM batch_claim_list WHERE claim_id = c.id) = 0";
        }

        

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        private string BuildWhereSingle(string colName, string data, DataTypes dt, DataObject.SearchTypes st, bool enabled)
        {
            if (enabled)
                return BuildWhereSingle(colName, data, dt, st);
            else
                return "";
        }

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        private string BuildWhereSingle(string colName, string data, DataTypes dt, DataObject.SearchTypes st)
        {
            if (data == "")
                return "";
            else
            {
                string safeData = data.Replace("'", "''");
                string toReturn = " AND ";

                if (dt == DataTypes.Text)
                {
                    if (st == DataObject.SearchTypes.Contains)
                        toReturn += colName + " LIKE '%" + safeData + "%'";
                    else if (st == DataObject.SearchTypes.BeginsWith)
                        toReturn += colName + " LIKE '" + safeData + "%'";
                    else
                        toReturn += colName + " = '" + safeData + "'";
                }
                else if ((dt == DataTypes.Numeric) || (dt == DataTypes.Boolean))
                    toReturn += colName + " = " + safeData;
                else if (dt == DataTypes.Date)
                {
                    
                    // Have to do special processing for the date
                    DateTime compareDate = System.Convert.ToDateTime(safeData);
                    string dateWhere;
                    if (st == DataObject.SearchTypes.Before)
                    {
                        dateWhere = "'" + CommonFunctions.ToMySQLDateTime(compareDate) + "' > {colname}";
                    }
                    else if (st == DataObject.SearchTypes.After)
                    {
                        dateWhere = "'" + CommonFunctions.ToMySQLDateTime(compareDate) + "' < {colname}";
                    }
                    else
                    {
                        dateWhere = "YEAR({colname}) = '" + compareDate.Year + "' AND MONTH({colname}) = '" +
                            compareDate.Month + "' AND DAY({colname}) = '" + compareDate.Day + "'";
                    }

                    dateWhere = dateWhere.Replace("{colname}", colName);
                    toReturn += dateWhere;
                }
                
                return toReturn;
            }
        }

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        private string BuildWhereSingle(string colName, string data, DataTypes dt)
        {
            if (cmbSearchType.SelectedIndex == EXACTSEARCHTYPEINDEX)
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.Exact);
            else if (cmbSearchType.SelectedIndex == STARTSWITHSEARCHTYPEINDEX)
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.BeginsWith);
            else
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.Contains);
        }


        private void frmSearchClaim_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime defaultSentDate = DateTime.Now.Subtract(new TimeSpan(30, 0, 0, 0));

                ctlPatientDOB.SetDefaultDate(DateTime.Now);
                if (ActiveUser.UserObject.UserData.search_form_sent_date > 0)
                {
                    ctlSentDate.CurrentDate = DateTime.Now.Subtract(new TimeSpan(ActiveUser.UserObject.UserData.search_form_sent_date, 0, 0, 0));
                }
                else 
                {
                    ctlSentDate.CurrentDate = DateTime.Now.Subtract(new TimeSpan(40, 0, 0, 0));
                    chkSentDateEnabled.Checked = false;
                }
                ctlResentDate.CurrentDate = defaultSentDate;
                ctlOnHoldDate.CurrentDate = defaultSentDate;
                ctlTracerDate.CurrentDate = defaultSentDate;
                ctlLastUpdateDate.CurrentDate = defaultSentDate;

                InitializeCompanyNamesPartial();
                InitializeClinics();
                InitializeStatus();

                cmbSearchType.SelectedIndex = 0;
                cmbDateFilterType.SelectedIndex = 0;

                // Default Combo Box Settings
                cmbClinic.SelectedIndex = cmbClinic.FindStringExact(Properties.Settings.Default.SearchDefaultClinic);
                cmbStatus.SelectedIndex = cmbStatus.FindStringExact(Properties.Settings.Default.SearchDefaultStatus);

                if (cmbClinic.SelectedIndex == -1)
                    cmbClinic.SelectedIndex = 0;
                if (cmbStatus.SelectedIndex == -1)
                    cmbStatus.SelectedIndex = 0;

                lastCountSQL = BuildCountSQL();

            }

            catch (Exception err)
            {
                string errData = err.Message;
                Exception temp = err;
                while (temp.InnerException != null)
                {
                    temp = temp.InnerException;
                    errData += "\n\n" + temp.Message;
                }
                LoggingHelper.Log("Error in frmSearchClaim_Load", LogSeverity.Error, err, false);
                MessageBox.Show(this, "There was an error retrieving search results. There may be a problem with your database connection.\n\n" + errData,
                    "Could not search");
            }

            _loading = false;
            SetBinAppearance(cmdAllBin);
            UpdateBinsAndCompaniesThreadSafe(BuildCountSQL());
            // SearchThreadSafe(true);
        }

        private void UpdateBinsAndCompaniesThreadSafe(string searchSQL)
        {
            try
            {
                // /* Multithreading breaking stuff
                // Explicitly create connections here, avoid data objects

                tBin = new Thread(tBins);
                binThreadID = tBin.ManagedThreadId;
                tBin.Start(searchSQL);
            }
            catch (Exception err)
            {
                string errData = err.Message;
                Exception temp = err;
                while (temp.InnerException != null)
                {
                    temp = temp.InnerException;
                    errData += "\n\n" + temp.Message;
                }
                LoggingHelper.Log("Error in frmSearchClaim.UpdateBinsAndCompaniesThreadSafe", LogSeverity.Error, err);
                MessageBox.Show(this, "There was an error updating bin counts. There may be a problem with your database connection.\n\n" + errData,
                    "Could not search");
            }
        }

        private void UpdateBinsAndCompanies(object searchSQL)
        {
            List<int> binCounts = new List<int>();
            ConnectionAlias ca = new ConnectionAlias();

            OleDbConnection connObject = new OleDbConnection(ca.GetConnectionString());
            OleDbCommand commObject = new OleDbCommand();

            connObject.Open();
            commObject.Connection = connObject;

            // claim c = new claim();

            string baseSQL = (string) searchSQL;

            string openSQL = baseSQL;
            string unsubmittedSQL = baseSQL + " AND (SELECT COUNT(*) FROM batch_claim_list bcl WHERE bcl.claim_id = c.id) = 0";

            string resolveSQL = baseSQL + BuildWhereHideNotYetRevisitDate();

            

            if (Thread.CurrentThread.ManagedThreadId != binThreadID)
            {
                Debug.WriteLine("Bin thread aborted.");
                connObject.Close();
                return;
            }
            binCounts.Add(GetFirstResultAsInt(commObject, unsubmittedSQL)); //   Convert.ToInt32(c.Search(workingSQL).Rows[0][0]));
            binCounts.Add(GetFirstResultAsInt(commObject, resolveSQL));
            binCounts.Add(GetFirstResultAsInt(commObject, baseSQL));
            if (Thread.CurrentThread.ManagedThreadId != binThreadID)
            {
                Debug.WriteLine("Bin thread aborted.");
                connObject.Close();
                return;
            }

            if (Thread.CurrentThread.ManagedThreadId != binThreadID)
            {
                Debug.WriteLine("Bin thread aborted.");
                connObject.Close();
                return;
            } 

            BinUIUpdate(binCounts);

            InitializeCompanyNamesFull(commObject);
            connObject.Close();
        }

        private int GetFirstResultAsInt(OleDbCommand commObject, string workingSQL)
        {
            try
            {
                commObject.CommandText = workingSQL;
                OleDbDataReader dr = commObject.ExecuteReader();
                DataTable toReturn = new DataTable();
                toReturn.Load(dr);

                return Convert.ToInt32(toReturn.Rows[0][0]); ;
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in frmSearchClaim.GetFirstResultsasInt", LogSeverity.Error, err, false);
                Debug.WriteLine("Error in GetFirstResultasInt: " + err.Message);
                return 0;
            }
        }

        private void BinUIUpdate(List<int> binCounts)
        {
            if (cmdUnsubmittedBin.InvokeRequired)
            {
                BinUIDelegate bui = new BinUIDelegate(BinUIUpdate);
                Invoke(bui, new object[] { binCounts });
            }
            else
            {
                if (binCounts.Count == 3)
                {
                    cmdUnsubmittedBin.Text = "Unsent (" + binCounts[0] + ")";
                    cmdUnsubmittedBin.Tag = binCounts[0];
                    cmdResolveBin.Text = "Resolve (" + binCounts[1] + ")";
                    cmdResolveBin.Tag = binCounts[1];
                    cmdAllBin.Text = "All (" + binCounts[2] + ")";
                    cmdAllBin.Tag = binCounts[2];
                }
                else
                {
                    LoggingHelper.Log("Error in frmSearchClaim.BinUIUpdate", LogSeverity.Error,
                        new Exception("An unexpected expected error occurred in Windows when updating bins. You may need to restart your computer."), true);
                }
            }
        }

        private void InitializeStatus()
        {
            claim_status cs = new claim_status();

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Show All");
            cmbStatus.Items.Add("No Status");
            foreach (DataRow aStatus in cs.GetVisibleStatus().Rows)
            {
                cs = new claim_status();
                cs.Load(aStatus);
                cmbStatus.Items.Add(cs);
                cmdCheckedStatus.Items.Add(cs);
            }
        }

        private void InitializeClinics()
        {
            clinic cln = new clinic();
            
            cmbClinic.Items.Clear();
            cmbClinic.Items.Add("Show All");

            DataTable dt = cln.Search(cln.SearchSQL + " ORDER BY name");
            foreach (DataRow aClinic in dt.Rows)
            {
                cln = new clinic();
                cln.Load(aClinic);
                cmbClinic.Items.Add(cln);
            }
        }

        private void InitializeCompanyNamesPartial()
        {
            company cmps = new company();
            formGroups = cmps.GetInsuranceCompaniesAsGroup();

            bsCompanies.DataSource = formGroups;

            cmbCompanyDropdown.SelectedIndex = -1;
        }

        private void InitializeCompanyNamesFull(OleDbCommand commObject)
        {
            commObject.CommandText = "SELECT COUNT(*), cmp.[name] FROM claims c INNER JOIN companies cmp ON c.company_id = cmp.id " +
                BuildWhere(false, false) + " GROUP BY company_id, cmp.[name] ORDER BY cmp.[name] ";

            OleDbDataReader dr = commObject.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            List<ComboItemForCompanyString> cifcList = new List<ComboItemForCompanyString>();
            dr.Close();

            foreach (DataRow aCompany in dt.Rows)
            {
                cifcList.Add(new ComboItemForCompanyString(aCompany["name"].ToString(), System.Convert.ToInt32(aCompany[0])));
            }

            foreach (InsuranceCompanyGroups aGroup in formGroups)
            {
                if (aGroup.Companies.Count > 1)
                {
                    commObject.CommandText = "SELECT COUNT(*) FROM claims c " + BuildWhere(false, false) + " AND c.company_id IN(" + aGroup.CompanyIDAsString() +
                        ")";
                    dr = commObject.ExecuteReader();
                    dr.Read();
                    cifcList.Add(new ComboItemForCompanyString(aGroup.Name, System.Convert.ToInt32(dr[0]), true));
                    dr.Close();
                }

            }

            
            InitializeCompanyNamesFull(cifcList);
            commObject.Connection.Close();
        }

        private void InitializeCompanyNamesFull(List<ComboItemForCompanyString> ListToAdd)
        {
            if (cmbCompanyDropdown.InvokeRequired)
            {
                CompanyUIDelegate bui = new CompanyUIDelegate(InitializeCompanyNamesFull);
                Invoke(bui, new object[] { ListToAdd });
            }
            else
            {
                string oldText = cmbCompanyDropdown.Text;

                if (cmbCompanyDropdown.Items.Count >= 0)
                {
                    cmbCompanyDropdown.BindingContext[cmbCompanyDropdown.DataSource].SuspendBinding();
                    
                    foreach (InsuranceCompanyGroups icg in formGroups)
                    {
                        icg.Count = 0;
                        foreach (ComboItemForCompanyString cifc in ListToAdd)
                        {
                            if ((icg.Name == cifc.Company) && (icg.Companies.Count > 1 == cifc.IsGroup))
                            {
                                icg.Count = cifc.NumClaims;
                                break;
                            }
                        }
                    }
                    cmbCompanyDropdown.BindingContext[cmbCompanyDropdown.DataSource].ResumeBinding();
                }

                cmbCompanyDropdown.Text = oldText;
            }
        }

        private void cmdOpenClaim_Click(object sender, EventArgs e)
        {
            OpenClaim();
        }

        private void OpenClaim()
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                frmClaimManager toShow;
                bool found = false;
                claim selectedClaim = (claim)dgvResults.SelectedRows[0].Cells["colClaimObject"].Value;

                foreach (Form aForm in Application.OpenForms)
                {
                    if (aForm is frmClaimManager)
                    {
                        if (((frmClaimManager)aForm).FormClaim.id == selectedClaim.id)
                        {
                            toShow = (frmClaimManager)aForm;
                            if (toShow.WindowState == FormWindowState.Minimized)
                                toShow.WindowState = FormWindowState.Normal;
                            else
                                toShow.BringToFront();
                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    bool readOnly = false;

                    // Double-check to verify the form isn't currently being edited by another user.
                    // If it is, give them the option to open it read-only, or to force full-access
                    List<user> usersViewingclaim = selectedClaim.UsersViewingClaim(true);
                    if (usersViewingclaim.Count > 0)
                    {
                        string userList = string.Empty;
                        foreach (user aUser in usersViewingclaim)
                        {
                            if (userList != string.Empty)
                                userList += "; ";
                            userList += aUser.username;
                        }

                        frmClaimInUseDialog frmInUse = new frmClaimInUseDialog(userList);
                        frmInUse.ShowDialog();

                        if (frmInUse.UserChoice == frmClaimInUseDialog.ClaimInUseChoice.DoNotOpen)
                            return;
                        else if (frmInUse.UserChoice == frmClaimInUseDialog.ClaimInUseChoice.OpenReadOnly)
                            readOnly = true;
                    }


                    List<claim> searchList = new List<claim>();

                    foreach (DataGridViewRow aRow in dgvResults.Rows)
                    {
                        searchList.Add((claim)aRow.Cells[colClaimObject.Index].Value);
                    }


                    toShow = new frmClaimManager(readOnly, searchList, selectedClaim);
                    toShow.searchForm = this;
                    if (readOnly)
                        ActiveUser.LogAction(ActiveUser.ActionTypes.ViewClaim, selectedClaim.id, "(Read Only) " + selectedClaim.PatientName);
                    else
                        ActiveUser.LogAction(ActiveUser.ActionTypes.ViewClaim, selectedClaim.id, selectedClaim.PatientName);

                    try
                    {
                        toShow.Left = 0;
                        toShow.Top = 0;
                        toShow.Show();
                    }
                    catch (Exception err)
                    {
                        LoggingHelper.Log(err, false);
                        MessageBox.Show(this, "An unexpected error occurred loading the form. The claim cannot be shown.");
                    }
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvResults_DoubleClick(object sender, EventArgs e)
        {
            OpenClaim();
        }

        

        private void ctlSentDate_ValueChanged(object sender, EventArgs e)
        {
            SentDateChanged();
        }

        private void SentDateChanged()
        {
            if (!_loading)
            {
                if ((ctlSentDate.CurrentDate.HasValue) && (chkSentDateEnabled.Checked))
                {
                    TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - ctlSentDate.CurrentDate.Value.Ticks);

                    ActiveUser.UserObject.UserData.search_form_sent_date = ts.Days;
                }
                else
                {
                    ActiveUser.UserObject.UserData.search_form_sent_date = 0;
                }

                ActiveUser.UserObject.Save();
            }
        }

        private void chkSentDateEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SentDateChanged();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmSearchClaim_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void cmdBin_Clicked(object sender, EventArgs e)
        {
            SetBinAppearance((Button)sender);
            grpAllBin.Enabled = sender == cmdAllBin;
            
            SearchThreadSafe(true);
        }

        private void SetBinAppearance(Button toHighlight)
        {
            List<Button> allButtons = new List<Button>(new Button[] { cmdAllBin, cmdUnsubmittedBin, cmdResolveBin });

            foreach (Button aButton in allButtons)
            {
                if (aButton == toHighlight)
                {
                    aButton.FlatStyle = FlatStyle.Flat;
                    aButton.BackColor = Color.LightYellow;
                    if (aButton == cmdUnsubmittedBin)
                        _searchMode = FormSearchMode.Unsent;
                    else if (aButton == cmdResolveBin)
                        _searchMode = FormSearchMode.Resolve;
                    else
                        _searchMode = FormSearchMode.All;
                }
                else
                {
                    aButton.FlatStyle = FlatStyle.Standard;
                    aButton.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSearchClaim_FormClosing(object sender, FormClosingEventArgs e)
        {
            C_DentalClaimTracker.Properties.Settings.Default.Save();
        }

        private void CheckedItemsButton_Click(object sender, EventArgs e)
        {
            List<claim> checkedClaims = GetCheckedClaims();

            if (checkedClaims.Count > 0)
            {
                if (sender == cmdPrint)
                    PrintCheckedClaims(checkedClaims);
                else if (sender == cmdResend)
                    ResendCheckedClaims(checkedClaims);
                else if (sender == cmdSetStatus)
                    ChangeStatusCheckedClaims(checkedClaims);
            }
            else
            {
                MessageBox.Show(this, "Please check one or more claims to perform this action.");
            }
        }

        private List<claim> GetCheckedClaims()
        {
            List<claim> checkedClaims = new List<claim>();
            foreach (DataGridViewRow dr in dgvResults.Rows)
            {
                if (dr.Cells[0].Value != null)
                    if ((bool)dr.Cells[0].Value)
                        checkedClaims.Add((claim)dr.Cells[colClaimObject.Index].Value);
            }
            return checkedClaims;
        }

        private List<DataGridViewRow> GetCheckedRows()
        {
            List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow dr in dgvResults.Rows)
            {
                if (dr.Cells[0].Value != null)
                    if ((bool)dr.Cells[0].Value)
                        checkedRows.Add(dr);
            }
            return checkedRows;
        }

        private void ChangeStatusCheckedClaims(List<claim> checkedClaims)
        {
            if (cmdCheckedStatus.SelectedIndex >= 0)
            {
                claim_status newStatus = (claim_status) cmdCheckedStatus.SelectedItem;
                foreach (claim aClaim in checkedClaims)
                {
                    aClaim.SetStatusAndRevisitDate(newStatus, aClaim.revisit_date);
                }

                SetCheckedClaimsNewStatus(newStatus);
            }
            // They shouldn't be able to click  so just do nothing, they can obviously see there's no status
            
        }

        private void SetCheckedClaimsNewStatus(claim_status newStatus)
        {
            foreach (DataGridViewRow dr in dgvResults.Rows)
            {
                if (dr.Cells[0].Value != null)
                    if ((bool)dr.Cells[0].Value)
                        dr.Cells[colStatus.Index].Value = newStatus.name;
                
            }
        }

        private void ResendCheckedClaims(List<claim> checkedClaims)
        {
            if (_processForm == null)
            {
                _processForm = new C_DentalClaimTracker.E_Claims.frmProcessor();
                
            }

            foreach (claim aClaim in checkedClaims)
            {
                try
                {
                    _processForm.ResendClaimApex(aClaim);
                    aClaim.SetResendStatus();
                    ActiveUser.LogAction(ActiveUser.ActionTypes.ResendClaim, aClaim.id, "Apex Resend");

                    if (system_options.ResendStatus > 0)
                    {
                        SetCheckedClaimsNewStatus(new claim_status(system_options.ResendStatus));
                    }
                }
                catch (Exception e)
                {
                    LoggingHelper.Log(e, false);
                }
            }
        }

        private void PrintCheckedClaims(List<claim> checkedClaims)
        {
            ClaimTrackerCommon.PrintClaims(checkedClaims);
        }

        private void cmdCheckedStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSetStatus.Enabled = cmdCheckedStatus.SelectedIndex >= 0;
                
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                ctlNotes.LoadNotes((claim)dgvResults.SelectedRows[0].Cells["colClaimObject"].Value);
                spltMain.Panel2Collapsed = ctlNotes.Notes.Count == 0;
            }
        }

        private void frmSearchClaim_Shown(object sender, EventArgs e)
        {
            
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetToCustomAddress_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(this, "Coming soon!");
            ctxtProviderList.Show(btnSetToCustomAddress.PointToScreen(Point.Empty).X + btnSetToCustomAddress.Width, btnSetToCustomAddress.PointToScreen(Point.Empty).Y);
        }

        private void ctxtProviderList_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> checkedRows = GetCheckedRows();
            string clickedProvider = ((ToolStripItem)sender).Text;
            if (checkedRows.Count > 0)
            {
                foreach (DataGridViewRow aRow in checkedRows)
                {
                    claim c = (claim)aRow.Cells["colClaimObject"].Value;
                    c.override_address_provider = clickedProvider;
                    c.Save();
                }

                SearchThreadSafe(true);
            }
            else
            {
                MessageBox.Show(this, "Please check one or more claims to perform this action.");
            }
        }

        private void dgvResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Compare the column to the column you want to format
            if (this.dgvResults.Columns[e.ColumnIndex] == coldate_of_service)
            {
                //get the IChessitem you are currently binding, using the index of the current row to access the datasource
                // DataGridViewRow dgvRow = 
                MainSearchSearchResult list = primarySearchResults[e.RowIndex];
                //check the condition
                if (list.DateOfServiceRange == "")
                {
                    e.CellStyle.Font = new Font(dgvResults.DefaultCellStyle.Font, FontStyle.Regular);
                }
                else
                {
                    e.CellStyle.Font = new Font(dgvResults.DefaultCellStyle.Font, FontStyle.Bold);
                    dgvResults.Rows[e.RowIndex].Cells[coldate_of_service.Name].ToolTipText = CommonFunctions.DBNullToString(dgvResults.Rows[e.RowIndex].Cells[colDOSRange.Name].Value);
                }
            }
        }

        private void cmbCompanyDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            ComboBox combo = ((ComboBox)sender);
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
            {
                Font font = e.Font;
                if (((InsuranceCompanyGroups)cmbCompanyDropdown.Items[e.Index]).Group != null)
                    font = new System.Drawing.Font(font, FontStyle.Bold);
                e.DrawBackground();
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), font, brush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cmdPrintList_Click(object sender, EventArgs e)
        {
            printRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow dgvr in dgvResults.Rows)
            {
                if (dgvr.Selected)
                    printRows.Add(dgvr);
            }

            PrintDialog pDialog = new PrintDialog();
            
            pDialog.Document = printDocument1;
            printDocument1.DocumentName = "Claim List";
            if (pDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void cmdPrintAll_Click(object sender, EventArgs e)
        {
            printRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow dgvr in dgvResults.Rows)
                printRows.Add(dgvr);

            PrintDialog objPPdialog = new PrintDialog();

            objPPdialog.Document = printDocument1;
            printDocument1.DocumentName = "Claim List";
            if (objPPdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                StringFormat strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in printListColumns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in printListColumns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= printRows.Count - 1)
                {
                    DataGridViewRow GridRow = printRows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary", new Font(dgvResults.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(dgvResults.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dgvResults.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvResults.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(new Font(dgvResults.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in printListColumns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents        

                        foreach (DataGridViewColumn aCol in printListColumns)
                        {
                            DataGridViewCell Cel = GridRow.Cells[aCol.Name];
                            if (Cel.Value != null)
                            {
                                string printValue = Cel.Value is DateTime ? ((DateTime)Cel.Value).ToShortDateString() : Cel.Value.ToString();

                                e.Graphics.DrawString(printValue, Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializePrintListColumns()
        {
            printListColumns = new List<DataGridViewColumn>();
            printListColumns.AddRange(new DataGridViewColumn[] { PatientName, PatientDOB, colCarrier, Amount, coldate_of_service, colType, colRevisitDate, colProvider, colStatus, colLastEdit});
        }

        private void lnkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckAllSearchItems(true);
        }

        private void CheckAllSearchItems(bool toCheck)
        {
            foreach (DataGridViewRow dgvr in dgvResults.Rows)
            {
                dgvr.Cells[colCheck.DisplayIndex].Value = toCheck;
            }
        }

        private void lnkUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckAllSearchItems(false);
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAllSearchItems(true);
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAllSearchItems(false);
        }

        internal void SetBatchNo(string batchNo)
        {
            txtBatchNumber.Text = batchNo;
        }

        internal void ShowAllTab()
        {
            cmdBin_Clicked(cmdAllBin, null);
        }

        
    }

    public class ComboItemForCompany
    {
        private company _company;
        private int _numClaims;

        public ComboItemForCompany(company c, int count)
        {
            _company = c;
            _numClaims = count;
        }

        public company Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public int NumClaims
        {
            get { return _numClaims; }
            set { _numClaims = value; }
        }

        public override string ToString()
        {
            if (NumClaims >= 0)
                return Company.name + " (" + NumClaims + ")";
            else
                return Company.name;
        }

    }

    public class ComboItemForCompanyString
    {
        private string _company;
        private int _numClaims;
        public bool IsGroup { get; set; }

        public ComboItemForCompanyString(string c, int count, bool is_group = false)
        {
            _company = c;
            _numClaims = count;
            IsGroup = is_group;
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public int NumClaims
        {
            get { return _numClaims; }
            set { _numClaims = value; }
        }

        public override string ToString()
        {
            if (NumClaims >= 0)
                return _company + " (" + NumClaims + ")";
            else
                return _company;
        }

    }
}