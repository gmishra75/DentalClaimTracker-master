using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Data.OleDb;

namespace C_DentalClaimTracker.Claims_Primary
{
    /// <summary>
    /// Interaction logic for frmSearchClaimWPF.xaml
    /// </summary>
    public partial class frmSearchClaimWPF : UserControl
    {
        Brush PatientBrush;
        Brush InsuranceBrush;
        Brush UnselectedBrush;
        public event Action RequestClose;
        C_DentalClaimTracker.E_Claims.frmProcessor _processForm;
        int maxResults;
        string _whereClause;
        string _orderByClause;
        int previousInsuranceIndex = -1;
        int nextInsuranceIndex = -1;
        List<InsuranceCompanyGroups> carrierSource;
        bool _loading = false;

        private FormSearchModes _formSearchMode;
        public bool FilterByInsurance { get; set; }

        public frmSearchClaimWPF()
        {
            InitializeComponent();
            PatientBrush = btnPatient.Background;
            InsuranceBrush = btnInsurance.Background;
            UnselectedBrush = new SolidColorBrush(Color.FromArgb(255, 232, 232, 232));
            FilterByInsurance = false;
        }

        /// <summary>
        /// Toggles between Patient/Insurance visibility, and handles visibility of insurance filter box
        /// </summary>
        /// <param name="newMode"></param>
        private void SetFormSearchMode(FormSearchModes newMode)
        {
            if (FilterByInsurance)
                pnlInsuranceFilter.Visibility = System.Windows.Visibility.Visible;
            else
                pnlInsuranceFilter.Visibility = System.Windows.Visibility.Collapsed;

            if (newMode == FormSearchModes.ClaimList)
            {
                pnlSearchBar.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                pnlSearchBar.Visibility = System.Windows.Visibility.Visible;

                Storyboard storyboard = null;

                if (newMode == FormSearchModes.Patient && _formSearchMode != FormSearchModes.Patient)
                {
                    storyboard = this.Resources["openPatient"] as Storyboard;
                    _formSearchMode = FormSearchModes.Patient;
                }
                else if (newMode == FormSearchModes.Insurance && _formSearchMode != FormSearchModes.Insurance)
                {
                    storyboard = this.Resources["openInsurance"] as Storyboard;
                    _formSearchMode = FormSearchModes.Insurance;
                }

                if (storyboard != null)
                {
                    storyboard.Completed += storyboard_Completed;
                    storyboard.Begin();
                }
            }
        }

        public void InitializeDisplay(bool isClaimList, string whereClause = "", string orderByClause = "")
        {
            _whereClause = whereClause;
            _orderByClause = orderByClause;

            if (isClaimList)
            {
                claim c = new claim();
                FilterByInsurance = true;
                SetFormSearchMode(FormSearchModes.ClaimList);
                company comp = new company();
                InsuranceCompanyGroups icg = new InsuranceCompanyGroups();
                carrierSource = new List<InsuranceCompanyGroups>();
                carrierSource = comp.GetInsuranceCompaniesAsGroup();

                // Update 'Count' for each item, remove items with no matches
                OleDbConnection connObject = new OleDbConnection(new ConnectionAlias().GetConnectionString());
                OleDbCommand commObject = new OleDbCommand();
                OleDbDataReader dr;
                List<InsuranceCompanyGroups> toRemove = new List<InsuranceCompanyGroups>();
                connObject.Open();
                commObject.Connection = connObject;
                
                // For the groups only, get a count of claims
                foreach (InsuranceCompanyGroups aGroup in carrierSource)
                {
                    commObject.CommandText = "SELECT COUNT(*) FROM claims c " + BuildSQL(true, false) + " AND c.company_id IN(" + aGroup.CompanyIDAsString() + ")";
                    dr = commObject.ExecuteReader();
                    dr.Read();
                    aGroup.Count = System.Convert.ToInt32(dr[0]);

                    dr.Close();
                    if (aGroup.Count == 0)
                        toRemove.Add(aGroup);
                }

                // Remove any groups with a count of 0
                toRemove.ForEach(t => carrierSource.Remove(t));


                // Add "All" Item
                icg.Name = "All";
                icg.Count = -1;

                carrierSource.Insert(0, icg);

                cmbCarrierFilter.ItemsSource = carrierSource;
                  
                if (cmbCarrierFilter.Items.Count > 1)
                    cmbCarrierFilter.SelectedIndex = 1;
                else
                    cmbCarrierFilter.SelectedIndex = 0;
            }
            else
            {
                FilterByInsurance = false;
                SetFormSearchMode(FormSearchModes.Patient);
            }
        }

        void storyboard_Completed(object sender, EventArgs e)
        {
            if (_formSearchMode == FormSearchModes.Patient)
                txtPatientName.Focus();
            else
                txtInsuranceName.Focus();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            InitializeStatus();
            InitializeProviderList();
            
        }

        private void InitializeProviderList()
        {
            claim searchObject = new claim();

            cmbChangeProvider.Items.Clear();
            cmbChangeProvider.Items.Add("Reset to Default");
            claim.OverrideProviderList().ForEach(p =>
            {
                cmbChangeProvider.Items.Add(p.doctor_provider_id);
            });
        }

        private void InitializeStatus()
        {
            claim_status cs = new claim_status();

            cmbChangeStatus.Items.Clear();
            cmbChangeStatus.Items.Add("{Clear Status}");
            foreach (DataRow aStatus in cs.GetVisibleStatus().Rows)
            {
                cs = new claim_status();
                cs.Load(aStatus);
                cmbChangeStatus.Items.Add(cs);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (RequestClose != null)
                RequestClose();
        }

        private void btnPatient_Click(object sender, RoutedEventArgs e)
        {
            SetFormSearchMode(FormSearchModes.Patient);
        }

        private void btnInsurance_Click(object sender, RoutedEventArgs e)
        {
            SetFormSearchMode(FormSearchModes.Insurance);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Search();
        }

        public void Search()
        {
            _loading = true;
            claim c = new claim();


            // Change how this works a bit - if we are in "group by insurance" mode then we are only giving a small subset
            DataTable results = new claim().Search(BuildSQL());
            List<provider_eligibility_restrictions> restrictions = provider_eligibility_restrictions.GetAllDataAsList();

            foreach (DataRow aRow in results.Rows)
            {
                // Check for provider eligibility substitutions, add doctor name as []
                string switchToClaim = provider_eligibility_restrictions.FindEligibilityRestrictions(aRow["Provider"].ToString(), aRow["Carrier"].ToString(), Convert.ToDateTime(aRow["DOS"].ToString()), restrictions);

                aRow["AlternateProvider"] = "Performing Provider: " + aRow["Provider"];

                if (switchToClaim != "")
                    aRow["Provider"] = "[" + switchToClaim + "]";
                else if (aRow["override_address_provider"].ToString().Trim().Length > 0)
                    aRow["Provider"] = "[" + aRow["override_address_provider"].ToString().Trim() + "]";


                // Check to see if Date of service is a range
                try
                {
                    if (Convert.ToDateTime(aRow["dos"]) != Convert.ToDateTime(aRow["LastDOS"]))
                    {
                        aRow["dos"] = "[" + aRow["dos"] + "]";
                        aRow["LastDOS"] = "Final DOS: " + aRow["LastDOS"];
                    }
                }
                catch { } // Ignore, just means there's a claim with no procedures

            }

            datResults.DataContext = results.DefaultView;
            lblSearchResults.Content = string.Format("Search Results ({0})", results.Rows.Count);
            _loading = false;
        }

        public void ShowSearchBar()
        {
            pnlSearchBar.Visibility = System.Windows.Visibility.Visible;
        }

        public void ClearSearch()
        {
            datResults.DataContext = null;
            lblSearchResults.Content = "Search Results";
        }

        public void SetTitle(string newTitle)
        {
            lblTitle.Content = newTitle;
        }

        /// <summary>
        /// Builds the SQL to be used on this form. If whereonly is true, will return only the where clause
        /// </summary>
        /// <param name="whereOnly"></param>
        /// <returns></returns>
        private string BuildSQL(bool whereOnly = false, bool includeCarrierFilter = true)
        {
            string toReturn;
            
            if (whereOnly)
                toReturn = "WHERE 0=0 ";
            else
                toReturn = @"SELECT TOP 500 c.patient_last_name + ', ' + c.patient_first_name AS 'PatientName', c.id as 'ID', 
                CONVERT(varchar, c.patient_dob, 101) AS 'DOB', cmp.name AS 'Carrier', c.amount_of_claim / 100 AS 'Amount', 
                CONVERT(varchar, c.date_of_service , 101) AS 'DOS', c.date_of_service, c.patient_dob, 
                CASE c.claim_type  
                    WHEN 0 THEN 'PRIM'
                    WHEN 1 THEN 'SEC'
                    When 2 THEN 'PRE'
                    WHEN 3 THEN 'SECPRE'
                ELSE '?'
                END AS 'Type', CONVERT(varchar, c.revisit_date, 101) AS 'Revisit', c.revisit_date,
                c.doctor_provider_id AS 'Provider', c.doctor_provider_id as 'AlternateProvider', cs.name AS 'Status', 
                CONVERT(varchar, (SELECT MAX(csent.sent_date) FROM claim_sent_history csent WHERE csent.claim_id = c.id), 101) AS 'LastSent',
                (SELECT MAX(csent.sent_date) FROM claim_sent_history csent WHERE csent.claim_id = c.id) AS 'last_sent',
                (SELECT CONVERT(varchar, MAX(alog.action_taken_time), 101) FROM user_action_log alog WHERE alog.claim_id = c.id) AS 'LastEdit',
                (SELECT MAX(alog.action_taken_time) FROM user_action_log alog WHERE alog.claim_id = c.id) AS 'last_edit', override_address_provider,
                (SELECT TOP 1 username FROM user_action_log alog inner join users u on alog.user_id = u.id WHERE alog.claim_id = c.id ORDER BY action_taken_time desc) AS 'User',
                CONVERT(varchar, (SELECT MAX(pl_date) FROM procedures p WHERE p.claim_id = c.id), 101) AS 'LastDOS',
                (SELECT MAX(pl_date) FROM procedures p WHERE p.claim_id = c.id) AS 'last_dos'
                FROM claims c
                LEFT JOIN Companies cmp ON c.company_id = cmp.id
                LEFT JOIN users u ON c.owner_id = u.id
                LEFT JOIN claimstatus cs ON cs.id = c.status_id
                WHERE 0=0 ";


            claim_change_log c = new claim_change_log();

            if (_whereClause == "")
            {

                if (_formSearchMode == FormSearchModes.Patient)
                {
                    // create custom search string for patient name
                    toReturn += BuildWherePatientName(txtPatientName.Text, 1);
                    if (chkPatientUnpaidClaimsOnly.IsChecked.GetValueOrDefault(true))
                        toReturn += BuildWhereSingle("c.[open]", "1", DataTypes.Numeric, DataObject.SearchTypes.Exact);

                    if (chkPatientExcludeWorkedClaims.IsChecked.GetValueOrDefault(true))
                        toReturn += BuildWhereSingle("c.revisit_date", CommonFunctions.ToSQLServerDateTime(DateTime.Now), DataTypes.Date, DataObject.SearchTypes.After);

                }
                else if (_formSearchMode == FormSearchModes.Insurance)
                {
                    // name, age, worked claims
                    toReturn += BuildWhereSingle("cmp.name", txtInsuranceName.Text.Trim(), DataTypes.Text, DataObject.SearchTypes.Contains);

                    // Do the "by date" filtering
                    string dateFilterString = string.Empty;

                    // Only add SQL if at least one is unchecked 
                    if (!chkAge24.IsChecked.GetValueOrDefault(true) || !chkAge44.IsChecked.GetValueOrDefault(true) || !chkAge45.IsChecked.GetValueOrDefault(true))
                    {
                        if (chkAge24.IsChecked.GetValueOrDefault(true)) // 0-24
                            dateFilterString += " date_of_service > DATEADD(\"day\", -24, GETDATE())";

                        if (chkAge44.IsChecked.GetValueOrDefault(true)) // 25-44
                        {
                            if (dateFilterString != string.Empty)
                                dateFilterString += " OR ";
                            dateFilterString += " (date_of_service > DATEADD(\"day\", -24, GETDATE()) AND date_of_service < DATEADD(\"d\", -45, GETDATE()))";
                        }

                        if (chkAge45.IsChecked.GetValueOrDefault(true)) // 45+
                        {
                            if (dateFilterString != string.Empty)
                                dateFilterString += " OR ";
                            dateFilterString += " date_of_service < DATEADD(\"day\", -45, GETDATE())";
                        }
                    }


                    if (dateFilterString != string.Empty)
                        toReturn += string.Format(" AND ({0})", dateFilterString);

                    if (chkInsuranceExcludeWorked.IsChecked.GetValueOrDefault(true))
                        toReturn += BuildWhereSingle("c.[open]", "1", DataTypes.Numeric, DataObject.SearchTypes.Exact);
                }
            }
            else
            {
                toReturn += _whereClause;

                if (FilterByInsurance && cmbCarrierFilter.SelectedIndex > 0 && includeCarrierFilter)
                {
                    // Add a company criteria
                    // toReturn += " AND cmp.id = " + cmbCarrierFilter.SelectedValue;

                    InsuranceCompanyGroups icg = null;

                    if (carrierSource.Find(item => item.ToString() == ((InsuranceCompanyGroups) cmbCarrierFilter.SelectedItem).ToString()) != null)
                    {
                        icg = (InsuranceCompanyGroups)cmbCarrierFilter.SelectedItem;

                        if (icg.Group == null)
                            toReturn += BuildWhereSingle("cmp.id", icg.Companies[0].id.ToString(), DataTypes.Numeric, DataObject.SearchTypes.Exact);
                        else
                            toReturn += string.Format(" AND cmp.id IN({0})", ClaimTrackerCommon.CompaniesToInString(icg.Companies));
                    }
                }
            }

            if (!whereOnly)
            {
                if (_orderByClause == "")
                {
                    toReturn += " ORDER BY c.sent_date";
                }
                else
                    toReturn += _orderByClause;
            }


            return toReturn;
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

        public static string BuildWherePatientName(string data, int SearchIndex)
        {
            const int STARTSWITHSEARCHTYPEINDEX = 2;
            const int EXACTSEARCHTYPEINDEX = 3;

            if (data == "")
                return " AND 0=0";
            else
            {
                string toReturn = " AND (";
                data = data.Replace(",", "");
                data = data.Replace("%", "");
                data = data.Trim();
                CommonFunctions.FormattedName formattedName = CommonFunctions.GetFormattedName(data);



                if (formattedName.LastName != "")
                {
                    toReturn += "((patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%')";
                    toReturn += " OR (patient_first_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'))";
                    toReturn += " OR patient_last_name LIKE '%" + data.Replace("'", "''") + "%'";
                }
                else
                {
                    toReturn += "patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " OR patient_first_name LIKE '%" + data.Replace("'", "''") + "%'";
                    toReturn += " OR patient_last_name LIKE '%" + data.Replace("'", "''") + "%'";
                }

                if (SearchIndex == STARTSWITHSEARCHTYPEINDEX) // Starts With
                {
                    // Remove the last % sign
                    toReturn = toReturn.Replace("'%", "'");
                }
                else if (SearchIndex == EXACTSEARCHTYPEINDEX)
                {
                    // Remove all % signs
                    toReturn = toReturn.Replace("%", "");
                }

                toReturn += ")";

                return toReturn;
            }
        }

        public enum FormSearchModes
        {
            Patient, Insurance, ClaimList
        }

        private void lblPatientSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void datResults_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenSelectedClaim();
        }

        private void OpenSelectedClaim()
        {
            if (datResults.SelectedItems.Count == 1)
            {
                int claimID = Convert.ToInt32(((DataRowView)datResults.SelectedItem).Row["ID"]);

                frmClaimManager toShow;
                bool found = false;
                claim selectedClaim = new claim(claimID);

                /*
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
                 */

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

                    foreach (DataRowView anItem in datResults.Items)
                    {
                        searchList.Add(new claim(Convert.ToInt32(anItem.Row["ID"])));
                    }

                    toShow = new frmClaimManager(readOnly, searchList, selectedClaim);

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
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenSelectedClaim();
        }

        private List<claim> GetSelectedClaims()
        {
            List<claim> selectedClaims = new List<claim>();

            foreach (DataRowView aRow in datResults.SelectedItems)
            {
                selectedClaims.Add(new claim(Convert.ToInt32(aRow["ID"])));
            }
            return selectedClaims;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            if (datResults.SelectedItems.Count == 1)
                ClaimTrackerCommon.PrintClaims(GetSelectedClaims());

        }

        private void btnResend_Click(object sender, RoutedEventArgs e)
        {
            if (_processForm == null)
            {
                _processForm = new C_DentalClaimTracker.E_Claims.frmProcessor();

            }

            foreach (claim aClaim in GetSelectedClaims())
            {
                try
                {
                    _processForm.ResendClaimApex(aClaim);
                    aClaim.SetResendStatus();
                    ActiveUser.LogAction(ActiveUser.ActionTypes.ResendClaim, aClaim.id, "Apex Resend");

                    if (system_options.ResendStatus > 0)
                    {
                        RefreshStatus(new claim_status(system_options.ResendStatus).name);
                    }
                }
                catch (Exception ex)
                {
                    LoggingHelper.Log(ex, false);
                }
            }
        }

        private void RefreshStatus(string claim_status)
        {
            DataView dv = (DataView)datResults.DataContext;

            foreach (object aRow in datResults.SelectedItems)
            {
                dv[datResults.Items.IndexOf(aRow)]["Status"] = claim_status;
            }
        }

        private void SetStatus()
        {
            string newStatusName = "";
            claim_status newStatus = null;
            bool needsNewStatus = false;

            if (cmbChangeStatus.SelectedIndex == 0)
            {
                needsNewStatus = true;
                newStatus = null;
                newStatusName = "";
            }

            else if (cmbChangeStatus.SelectedIndex > 0)
            {
                needsNewStatus = true;
                newStatus = ((claim_status)cmbChangeStatus.SelectedItem);
                newStatusName = newStatus.name;

            }

            if (needsNewStatus)
            {

                foreach (claim aClaim in GetSelectedClaims())
                {
                    try
                    {
                        if (newStatus == null)
                            aClaim.ResetStatus();
                        else
                            aClaim.SetStatusAndRevisitDate(newStatus, null);
                    }
                    catch (Exception ex)
                    {
                        LoggingHelper.Log("Error changing status on search form.", LogSeverity.Error, ex, false);
                    }
                }

                RefreshStatus(newStatusName);
            }
            
            cmbChangeStatus.SelectedIndex = -1;
        }

        private void ChangeProvider()
        {
            if (cmbChangeProvider.SelectedIndex >= 0)
            {
                string newProviderText;
                if (cmbChangeProvider.SelectedIndex == 0)
                    newProviderText = "";
                else
                    newProviderText = cmbChangeProvider.SelectedItem.ToString();

                foreach (claim aClaim in GetSelectedClaims())
                {
                    aClaim.override_address_provider = newProviderText;
                    aClaim.Save();
                }

                RefreshProvider(newProviderText);

                cmbChangeProvider.SelectedIndex = -1;
            }
        }

        private void RefreshProvider(string newProvider)
        {
            DataView dv = (DataView)datResults.DataContext;
            
            string newProviderText;

            if (newProvider != "")
            {
                foreach (object aRow in datResults.SelectedItems)
                {
                    dv[datResults.Items.IndexOf(aRow)]["Provider"] = "[" + newProvider + "]";
                }
            }
            else
            {
                newProviderText = "[" + newProvider + "]";
                foreach (object aRow in datResults.SelectedItems)
                {
                    string startText = dv[datResults.Items.IndexOf(aRow)]["AlternateProvider"].ToString();

                    if (startText.Contains(" "))
                        dv[datResults.Items.IndexOf(aRow)]["Provider"] = startText.Substring(startText.LastIndexOf(" ") + 1);
                }
            }

            
        }

        private void btnCustomAddress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbChangeStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetStatus();
        }

        private void cmbChangeProvider_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeProvider();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtPatientName.Focus();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (RequestClose != null)
                RequestClose();
        }

        private void datResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string noteText = "";

            if (datResults.SelectedItem != null)
            {
                claim c = new claim(Convert.ToInt32(((DataRowView)datResults.SelectedItem).Row["ID"]));

                foreach (notes note in c.GetNotes())
                {
                    noteText += note.Note;

                    if (note.created_on == null)
                        noteText += " (" + note.operatorId + " Unknown time)";
                    else
                        noteText += " (" + note.operatorId + " " + note.created_on.Value.ToShortDateString() + ")";

                    noteText += "\n";
                }
            }

            noteText = noteText.Trim();
            if (noteText != "")
            {
                pnlNotes.Visibility = System.Windows.Visibility.Visible;
                txtNotes.Text = noteText;
            }
            else
            {
                pnlNotes.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void cmbCarrierFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCarrierFilter.SelectedIndex >= 0)
                Search();

            if (cmbCarrierFilter.SelectedIndex >= 0)
            {
                // Find first previous insurance company with non-zero claims
                previousInsuranceIndex = cmbCarrierFilter.SelectedIndex - 1;
                nextInsuranceIndex = cmbCarrierFilter.SelectedIndex + 1;

                while (previousInsuranceIndex != cmbCarrierFilter.SelectedIndex)
                {
                    if (previousInsuranceIndex < 0)
                        previousInsuranceIndex = cmbCarrierFilter.Items.Count - 1;

                    if (((InsuranceCompanyGroups)cmbCarrierFilter.Items[previousInsuranceIndex]).Count > 0)
                        break;
                    else
                        previousInsuranceIndex--;
                }

                while (nextInsuranceIndex != cmbCarrierFilter.SelectedIndex)
                {
                    if (nextInsuranceIndex == cmbCarrierFilter.Items.Count)
                        nextInsuranceIndex = 0;

                    if (((InsuranceCompanyGroups)cmbCarrierFilter.Items[nextInsuranceIndex]).Count > 0)
                        break;
                    else
                        nextInsuranceIndex++;
                }

                txtPreviousCarrier.Text = ((InsuranceCompanyGroups)cmbCarrierFilter.Items[previousInsuranceIndex]).ToString();
                txtNextCarrier.Text = ((InsuranceCompanyGroups)cmbCarrierFilter.Items[nextInsuranceIndex]).ToString();
            }
            else
            {
                previousInsuranceIndex = -1;
                nextInsuranceIndex = -1;

                txtPreviousCarrier.Text = "";
                txtNextCarrier.Text = "";
            }

        }

        private void btnPreviousCarrier_Click(object sender, RoutedEventArgs e)
        {
            if (previousInsuranceIndex > -1)
                cmbCarrierFilter.SelectedIndex = previousInsuranceIndex;
        }

        private void btnNextCarrier_Click(object sender, RoutedEventArgs e)
        {
            if (nextInsuranceIndex > -1)
                cmbCarrierFilter.SelectedIndex = nextInsuranceIndex;
        }


        internal void ForceStatusUpdate()
        {
            if (!_loading)
            {
                DataView dv = (DataView)datResults.DataContext;

                foreach (object aRow in datResults.SelectedItems)
                {
                    // load claim
                    try
                    {
                        claim c = new claim(Convert.ToInt32(dv[datResults.Items.IndexOf(aRow)]["id"]));
                        dv[datResults.Items.IndexOf(aRow)]["Status"] = c.LinkedStatus.name;
                        if (c.revisit_date.HasValue)
                            dv[datResults.Items.IndexOf(aRow)]["revisit"] = c.revisit_date.Value.ToString("MM/dd/yyyy");
                        else
                            dv[datResults.Items.IndexOf(aRow)]["revisit"] = "";
                    }
                    catch { }
                }
            }
        }
    }

    class CarrierDisplay
    {
        public int ID { get; set; }
        public string Display { get; set; }

        public CarrierDisplay(int id, string display)
        {
            this.ID = id;
            this.Display = display;
        }

        public override string ToString()
        {
            return Display;
        }
    }

}
