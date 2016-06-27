using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace C_DentalClaimTracker
{
    public partial class frmMultiClaimCall : Form
    {
        Color LABELHIGHLIGHTCOLOR = Color.LightYellow;
        Color LABELSTANDARDCOLOR = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
        int DEFAULTCARRIERINFOWIDTH = 545;
        int DEFAULTSEARCHINFOHEIGHT = 177;
        int DEFAULTCARRIERLISTWIDTH = 200;
        private const int STARTSWITHSEARCHTYPEINDEX = 2;
        private const int EXACTSEARCHTYPEINDEX = 3;
        private int _claimCount = 0;
        private int _controlCount = 0;
        private int _lastCarriersCheckedAmount = -1;
        int SPACER = 0;
        List<claim> _currentClaims = new List<claim>();
        private int DEFAULTY = 6;
        private const int DEFAULTINSURANCETOP = 10;
        List<ctlMultiClaimCallClaimDisplay> currentClaimControls = new List<ctlMultiClaimCallClaimDisplay>();
        List<Control> currentAllControls = new List<Control>();

        Timer callTimer;
        TimeSpan callTime;
        delegate void EmptyDelegate();
        call FormCall;
        ctlClaimDataDisplay focusedControl;
        bool _isSearching = false;

        public frmMultiClaimCall()
        {
            InitializeComponent();
            callTimer = new Timer();
            callTimer.Interval = 1000;
            callTimer.Tick += new EventHandler(callTimer_Tick);
            WindowState = FormWindowState.Maximized;
        }

        #region Search Related

        private void Search(string sql)
        {
            _isSearching = true;
            claim c = new claim();
            
            DataTable dt = c.Search(sql);

            List<string> addedCompanies = new List<string>();
            List<CompanyDropDownItem> combosToAdd = new List<CompanyDropDownItem>();

            foreach (DataRow aClaim in dt.Rows)
            {
                string CompanyName = aClaim["NAME"].ToString();
                
                if (addedCompanies.Contains(CompanyName))
                {
                    combosToAdd[combosToAdd.Count - 1].ClaimIDs.Add((int) aClaim["CLAIMID"]);
                }
                else
                {
                    addedCompanies.Add(CompanyName);
                    CompanyDropDownItem newItem = new CompanyDropDownItem((int) aClaim["COMPANYID"], aClaim["NAME"].ToString(),
                        (int)aClaim["CLAIMID"]);
                    combosToAdd.Add(newItem);
                }
            }

            List<CompanyDropDownItem> selectedItems = new List<CompanyDropDownItem>();

            foreach(CompanyDropDownItem anItem in chkCarrierList.CheckedItems)
            {
                selectedItems.Add(anItem);
            }
            
            chkCarrierList.Items.Clear();
            foreach (CompanyDropDownItem toAdd in combosToAdd)
            {
                chkCarrierList.Items.Add(toAdd, true);
            }

            for (int i = 0; i < chkCarrierList.Items.Count; i++)
            {
                CompanyDropDownItem anItem = (CompanyDropDownItem) chkCarrierList.Items[i];
                foreach (CompanyDropDownItem checkedItem in selectedItems)
                {
                    if (anItem.CompanyID == checkedItem.CompanyID)
                        chkCarrierList.SetItemChecked(i, true);
                        
                }
            }

            if ((chkCarrierList.Items.Count > 0) && (chkCarrierList.CheckedItems.Count == 0))
                chkCarrierList.SetItemChecked(0, true);

            UpdateDisplay();
        }

        private string BuildAdvancedSQL()
        {
            string toReturn = "SELECT c.id AS CLAIMID, cmp.id AS COMPANYID, cmp.name AS NAME FROM claims c " +
                "LEFT JOIN Companies cmp ON c.company_id = cmp.id " +
                "LEFT JOIN users u ON c.owner_id = u.id ";


            // WHERE
            if (cmbCompanyDropdown.Text != "")
            {
                string companyName = string.Empty;

                if (cmbCompanyDropdown.Text.LastIndexOf(" (") - 1 > 0)
                    companyName = cmbCompanyDropdown.Text.Remove(cmbCompanyDropdown.Text.LastIndexOf("(") - 1);

                if (cmbCompanyDropdown.FindStringExact(cmbCompanyDropdown.Text) >= 0)
                    toReturn += BuildWhereSingle("cmp.name", companyName, DataTypes.Text, DataObject.SearchTypes.Exact);
                else
                    toReturn += BuildWhereSingle("cmp.name", cmbCompanyDropdown.Text, DataTypes.Text);
            }

            toReturn += BuildWherePatientName(txtPatientName.Text, DataTypes.Text);
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

            if (chkSentDateEnabled.Checked)
                toReturn += BuildWhereSingle("c.sent_date", ctlSentDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex));
            if (chkResentDateEnabled.Checked)
                toReturn += BuildWhereSingle("c.resent_date", ctlResentDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex));
            if (chkHoldDateEnabled.Checked)
                toReturn += BuildWhereSingle("c.on_hold_date", ctlOnHoldDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex));
            if (chkTracerDateEnabled.Checked)
                toReturn += BuildWhereSingle("c.tracer_date", ctlTracerDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex));
            if (chkLastUpdateEnabled.Checked)
                toReturn += BuildWhereSingle("c.status_last_date", ctlLastUpdateDate.CurrentDateText, DataTypes.Date, ConvertToSearchType(cmbDateFilterType.SelectedIndex));

            toReturn += BuildWhereOpen();
            toReturn += BuildWhereHideRecent();
            toReturn += BuildWhereTypes();
            toReturn += BuildWhereClinic();
            toReturn += BuildWhereOwner();

            // Replace the first instance of AND with WHERE
            Regex r = new Regex(" AND ", RegexOptions.IgnoreCase);
            toReturn = r.Replace(toReturn, " WHERE ", 1);

            // ORDER BY
            toReturn += " ORDER BY cmp.name, c.subscriber_group_name, c.patient_last_name, c.patient_first_name";

            return toReturn;
        }

        private string BuildBasicSQL()
        {
            string toReturn = "SELECT c.id AS CLAIMID, cmp.id AS COMPANYID, cmp.name AS NAME FROM claims c " +
                "LEFT JOIN Companies cmp ON c.company_id = cmp.id " +
                "LEFT JOIN users u ON c.owner_id = u.id WHERE c.[open] = 1 ";

            // WHERE
            if (cmbBasicCarrierGroup.SelectedIndex > 0) // 0 = ALL
            {
                string carrierSQL = "";
                insurance_company_group icg = (insurance_company_group) cmbBasicCarrierGroup.SelectedItem;


                foreach (insurance_company_groups_filters icgf in icg.Filters)
                {
                    if (icgf.filter_text.StartsWith("NOT ", StringComparison.OrdinalIgnoreCase))
                    {
                        if (carrierSQL.Length > 0)
                            carrierSQL += " AND";

                        carrierSQL += string.Format(" cmp.name NOT LIKE '{0}'", icgf.filter_text.Substring(4));
                    }
                    else
                    {
                        if (carrierSQL.Length > 0)
                            carrierSQL += " OR";

                        carrierSQL += string.Format(" cmp.name LIKE '{0}'", icgf.filter_text);
                    }
                }

                carrierSQL = " AND (" + carrierSQL + ")";

                toReturn += carrierSQL;
            }

            toReturn += BuildWherePatientName(txtBasicPatientName.Text, DataTypes.Text);
            toReturn += BuildWhereSingle("c.subscriber_group_number", txtBasicGroupNumber.Text, DataTypes.Text);
            toReturn += BuildWhereSingle("c.subscriber_group_name", txtBasicGroupName.Text, DataTypes.Text);

            if (cmbBasicClinic.SelectedIndex > 0) // 0 = all clinics
            {
                toReturn += " AND c.clinic_id = " + ((clinic)cmbBasicClinic.SelectedItem).id;
            }

            toReturn += " ORDER BY cmp.name, c.subscriber_group_name, c.patient_last_name, c.patient_first_name";

            return toReturn;
        }

        private string BuildWhereOwner()
        {
            string ownerSQL = "";
            if (cmbStatus.SelectedIndex > 0)
            {
                ownerSQL = " AND c.status_id = " + ((claim_status)cmbStatus.SelectedItem).id;
            }

            return ownerSQL;
        }

        private string BuildWhereClinic()
        {
            string clinicSQL = "";

            if (cmbClinic.SelectedIndex > 0) // 0 = all clinics
            {
                clinicSQL += " AND c.clinic_id = " + ((clinic)cmbClinic.SelectedItem).id;
            }

            return clinicSQL;
        }

        private string BuildWhereTypes()
        {
            string typesString = "";

            if (chkShowPrimary.Checked)
                typesString += "," + (int)claim.ClaimTypes.Primary;
            if (chkShowSecondary.Checked)
                typesString += "," + (int)claim.ClaimTypes.Secondary;
            if (chkShowPredeterms.Checked)
                typesString += "," + (int)claim.ClaimTypes.Predeterm;

            if (typesString != "")
                typesString = typesString.Substring(1);
            else
                typesString = "-1";

            return " AND c.claim_type IN(" + typesString + ")";
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

        private string BuildWherePatientName(string data, DataTypes dataTypes)
        {
            if (data == "")
                return "";
            else
            {
                string toReturn = " AND (";
                data = data.Replace(",", "");
                data = data.Replace("%", "");

                CommonFunctions.FormattedName formattedName = CommonFunctions.GetFormattedName(data);



                if (formattedName.LastName != "")
                {
                    toReturn += "((patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%')";
                    toReturn += " OR (patient_first_name LIKE '%" + formattedName.LastName.Replace("'", "''") + "%'";
                    toReturn += " AND patient_last_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'))";
                }
                else
                {
                    toReturn += "patient_first_name LIKE '%" + formattedName.FirstName.Replace("'", "''") + "%'";
                    toReturn += " OR patient_first_name LIKE '%" + data.Replace("'", "''") + "%'";
                    toReturn += " OR patient_last_name LIKE '%" + data.Replace("'", "''") + "%'";
                }

                if (cmbSearchType.SelectedIndex == STARTSWITHSEARCHTYPEINDEX) // Starts With
                {
                    // Remove the last % sign
                    toReturn = toReturn.Replace("'%", "'");
                }
                else if (cmbSearchType.SelectedIndex == EXACTSEARCHTYPEINDEX)
                {
                    // Remove all % signs
                    toReturn = toReturn.Replace("%", "");
                }

                toReturn += ")";

                return toReturn;
            }
        }

        private string BuildWhereHideRecent()
        {
            if (chkHideRecentClaims.Checked)
            {
                /*
                 * OLD
                 * return " AND ((DATEDIFF(c.updated_on, GETDATE()) < (-" + System.Convert.ToInt32(nmbDayCount.Value) + ") " +
                    "OR c.updated_on is null) AND " + 
                "DATEDIFF(c.sent_date, GETDATE()) < (-" + System.Convert.ToInt32(nmbDayCount.Value) + ") AND " + 
                "DATEDIFF(c.resent_date, GETDATE()) < (-" + System.Convert.ToInt32(nmbDayCount.Value) + "))";
                 */

                return " AND (DATEDIFF(d, c.revisit_date, GETDATE()) < 1 OR c.revisit_date is null)";

            }
            else
                return "";
        }

        private string BuildWhereOpen()
        {
            if (chkOpenClaimsOnly.Checked)
                return " AND c.[open] = 1";
            else
                return "";
        }

        /// <summary>
        /// Builds a where clause for a specified column/field of a specified type with data as
        /// a condition. Returns "" if data is empty.
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="data"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
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
                else if (dt == DataTypes.Numeric)
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
        /// <param name="colName"></param>
        /// <param name="data"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string BuildWhereSingle(string colName, string data, DataTypes dt)
        {
            if (cmbSearchType.SelectedIndex == EXACTSEARCHTYPEINDEX)
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.Exact);
            else if (cmbSearchType.SelectedIndex == STARTSWITHSEARCHTYPEINDEX)
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.BeginsWith);
            else
                return BuildWhereSingle(colName, data, dt, DataObject.SearchTypes.Contains);
        }

        #endregion

        private void lblClaimInformation_MouseEnter(object sender, EventArgs e)
        {
            Label s = (Label)sender;
            s.BackColor = LABELHIGHLIGHTCOLOR;
            s.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblClaimInformation_MouseLeave(object sender, EventArgs e)
        {
            Label s = (Label)sender;
            s.BackColor = LABELSTANDARDCOLOR;
            s.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ctlMultiClaimCallClaimDisplay_Minimized(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ctlMultiClaimCallClaimDisplay_Maximized(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            pnlClaimControls.AutoScroll = false;
            if (currentAllControls.Count > 0)
                currentAllControls[0].Top = DEFAULTY;
            for (int i = 1; i < currentAllControls.Count; i++)
            {
                currentAllControls[i].Top = currentAllControls[i - 1].Top + currentAllControls[i - 1].Height + SPACER;
            }
            pnlClaimControls.AutoScroll = true;
        }

        private void ctlMultiClaimCallClaimDisplay_SaveChanges(object sender, EventArgs e)
        {
            ctlMultiClaimCallClaimDisplay current = (ctlMultiClaimCallClaimDisplay)sender;

            if (FormCall == null)
                FormCall = GetNewCall();
            
            current.CurrentCall = FormCall;
        }

        private call GetNewCall()
        {
            call toReturn = new call();

            toReturn.created_on = DateTime.Now;
            toReturn.claim_id = 0;
            toReturn.operatordata = ActiveUser.UserObject.username;
            toReturn.StartTime = DateTime.Now;
            toReturn.parent_id = 0;
            toReturn.Save();
            return toReturn;
        }

        private void cmbCarrierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateDisplay()
        {
            string carrierLabel = "";
            cmbPage.Items.Clear();
            cmbPage2.Items.Clear();

            _currentClaims = new List<claim>();

            foreach (CompanyDropDownItem anItem in chkCarrierList.CheckedItems)
            {

                if (_currentClaims.Count == 0)
                {
                    _currentClaims.AddRange(anItem.Claims);
                    carrierLabel = anItem.CompanyName;
                }
                else
                {
                    // Impossible to understand sort algorithm

                    // Find the correct position to insert here
                    foreach (claim aClaim in anItem.Claims)
                    {
                        // Move it in its current spot
                        int newIndex = 0;
                        for (int i = 0; i < _currentClaims.Count; i++)
                        {
                            newIndex = i + 1;
                            if (_currentClaims[i].subscriber_group_name == aClaim.subscriber_group_name)
                            {
                                string groupName = aClaim.subscriber_group_name;
                                // Find out where it goes
                                for (int j = i; j < _currentClaims.Count; j++)
                                {
                                    newIndex = j;
                                    if (_currentClaims[j].subscriber_group_name != groupName)
                                    {
                                        break;
                                    }
                                    else if (_currentClaims[j].patient_last_name == aClaim.patient_last_name)
                                    {
                                        string patientLastName = aClaim.patient_last_name;
                                        // Sort by first name
                                        for (int k = j; k < _currentClaims.Count; k++)
                                        {
                                            newIndex = k;
                                            if (_currentClaims[k].patient_last_name != patientLastName)
                                                break;
                                            else if (String.Compare(_currentClaims[k].patient_first_name, aClaim.patient_first_name, true) > 0)
                                                break;
                                        }
                                        break;
                                    }
                                    else if (String.Compare(_currentClaims[j].patient_last_name, aClaim.patient_last_name, true) > 0)
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                if (String.Compare(_currentClaims[i].subscriber_group_name, aClaim.subscriber_group_name, true) > 0)
                                {
                                    newIndex = i;
                                    break;
                                }
                            }
                        }

                        _currentClaims.Insert(newIndex, aClaim);
                    }

                    
                    if (carrierLabel != string.Empty)
                        carrierLabel += ", ";

                    carrierLabel += anItem.CompanyName;
                }

            }


            lblCarrierList.Text = carrierLabel;
            int maxClaims = C_DentalClaimTracker.Properties.Settings.Default.MultipleClaimClaimsVisible;
            int numPages = (_currentClaims.Count + 19) / maxClaims;

            for (int i = 0; i * maxClaims < _currentClaims.Count; i++)
            {
                string pageText = "Page " + (i + 1) + " of " + numPages;

                cmbPage.Items.Add(pageText);
                cmbPage2.Items.Add(pageText);
            }

            if (cmbPage.Items.Count > 0)
                cmbPage.SelectedIndex = 0;
            else
                cmbPage.SelectedIndex = -1;

        }

        private void ClearAllClaims(bool hideClaims = false)
        {
            _claimCount = 0;
            _controlCount = 0;
            List<Control> toDispose = new List<Control>();
            foreach (Control cdd in currentAllControls)
            {
                if (cdd is ctlMultiClaimCallClaimDisplay)
                {
                    ((ctlMultiClaimCallClaimDisplay)cdd).SetToMinimizeHeight();
                    cdd.Visible = hideClaims;
                }
                else
                {
                    toDispose.Add(cdd);
                    cdd.Visible = false;
                }
            }

            for (int i = 0; i < toDispose.Count; i++)
            {
                toDispose[i].Dispose();
                toDispose[i] = null;
            }
            currentAllControls.Clear();
        }

        private void AddClaim(claim c)
        {
            int defaultX = 0;
            
            
            int top;

            if (_controlCount > 0)
            {
                top = currentAllControls[_controlCount - 1].Top + currentAllControls[_controlCount - 1].Height + SPACER;
            }
            else
                top = DEFAULTY;

            ctlMultiClaimCallClaimDisplay toAdd;
            if (_claimCount >= currentClaimControls.Count)
            {
                toAdd = new ctlMultiClaimCallClaimDisplay();
                toAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
                toAdd.CurrentCall = null;
                toAdd.LinkedClaim = null;
                toAdd.SuspendLayout();
                pnlClaimControls.Controls.Add(toAdd);
                toAdd.Location = new System.Drawing.Point(defaultX, top);
                toAdd.Name = "ctlMultiClaimCallClaimDisplay" + _claimCount;
                toAdd.Size = new System.Drawing.Size(pnlClaimControls.Width, 30);
                toAdd.TabIndex = _claimCount;
                toAdd.SaveChanges += new System.EventHandler(this.ctlMultiClaimCallClaimDisplay_SaveChanges);
                toAdd.Maximized += new System.EventHandler(this.ctlMultiClaimCallClaimDisplay_Maximized);
                toAdd.Minimized += new System.EventHandler(this.ctlMultiClaimCallClaimDisplay_Minimized);
                toAdd.RequestViewClaim += new EventHandler(toAdd_RequestViewClaim);
                toAdd.CallStarted += new EventHandler(ctlMultiClaimCallClaimDisplay_CallStarted);
                toAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                currentClaimControls.Add(toAdd);
                currentAllControls.Add(toAdd);
                toAdd.ResumeLayout();
            }
            else
            {
                toAdd = currentClaimControls[_claimCount];
                currentAllControls.Add(toAdd);
                toAdd.Visible = true;
                toAdd.ClearStatus();
            }

            toAdd.SetToMinimizeHeight();
            toAdd.LoadClaim(c);
            
            
            _claimCount++;
            _controlCount++;
            
        }

        void ctlMultiClaimCallClaimDisplay_CallStarted(object sender, EventArgs e)
        {
            ((ctlMultiClaimCallClaimDisplay)sender).CurrentCall.parent_id = FormCall.id;
        }

        void toAdd_RequestViewClaim(object sender, EventArgs e)
        {
            frmClaimManager toShow = new frmClaimManager(true, _currentClaims, ((ctlMultiClaimCallClaimDisplay)sender).LinkedClaim);
            toShow.ShowDialog();

            ((ctlMultiClaimCallClaimDisplay)sender).LoadClaim(toShow.FormClaim);
        }

        private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPage2.SelectedIndex = cmbPage.SelectedIndex;
            DisplayActivePage();
        }

        private void DisplayActivePage()
        {
            pnlClaimControls.SuspendLayout();
            pnlClaimControls.AutoScroll = false;

            EndAllActiveCalls();
            ClearAllClaims();

            string lastGroupName = "|InvalidGroupName|";
            ctlMultiClaimCallLabel lastLabel = null;
            if (cmbPage.SelectedIndex >= 0)
            {

                for (int i = cmbPage.SelectedIndex * 20; i < cmbPage.SelectedIndex * 20 + 20; i++)
                {
                    if (_currentClaims.Count > i)
                    {
                        // Check to see if we have a new group. If so, we need a label as well
                        if (_currentClaims[i].subscriber_group_name != lastGroupName)
                        {
                            lastLabel = AddLabel(_currentClaims[i].LinkedCompany.name, _currentClaims[i].subscriber_group_name);
                            lastGroupName = _currentClaims[i].subscriber_group_name;
                        }

                        AddClaim(_currentClaims[i]);

                        lastLabel.TryAddPhone(_currentClaims[i].LinkedCompanyAddress.phone);
                    }
                    else
                    {
                        int currentIndex = i - (cmbPage.SelectedIndex * 20);
                        if (currentClaimControls.Count > currentIndex)
                            currentClaimControls[currentIndex].Visible = false;
                    }
                }
            }
            else
            {
                ClearAllClaims(true);
            }
            pnlClaimControls.AutoScroll = true;
            pnlClaimControls.ResumeLayout();

            ResizeControls();
        }

        /// <summary>
        /// Loops through all the shown claims and ends any active calls
        /// </summary>
        private void EndAllActiveCalls()
        {
            foreach (Control c in currentAllControls)
            {
                if (c is ctlMultiClaimCallClaimDisplay)
                {
                    ctlMultiClaimCallClaimDisplay toEnd = (ctlMultiClaimCallClaimDisplay)c;

                    toEnd.TerminateCall();
                }
            }
        }

        private ctlMultiClaimCallLabel AddLabel(string companyName, string groupName)
        {
            if (groupName == "")
                groupName = "(No Group)";
            int defaultX = 0;
            int defaultY = 6;

            int top;

            if (_controlCount > 0)
            {
                top = currentAllControls[_controlCount - 1].Top + currentAllControls[_controlCount - 1].Height + SPACER;
            }
            else
                top = defaultY;

            ctlMultiClaimCallLabel toAdd = new ctlMultiClaimCallLabel();
            pnlClaimControls.Controls.Add(toAdd);
            toAdd.Location = new System.Drawing.Point(defaultX, top);
            toAdd.Name = "lblGroupNameDisplay" + _controlCount;
            toAdd.Size = new System.Drawing.Size(pnlClaimControls.Width, 20);
            toAdd.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            toAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toAdd.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            toAdd.GroupName = groupName;
            toAdd.Company_Name = companyName;
            currentAllControls.Add(toAdd);
            _controlCount++;

            return toAdd;
        }

        private void lblSearchOptions_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void DisplayAdvancedSearch(bool display)
        {
            Label lblHighlight;
            Label lblLowlight;
            Font oldFont = lblAdvancedSearch.Font;
            
            


            int displayHeight = pnlTopHeader.Height;

            if (display)
            {
                displayHeight += pnlAdvancedSearch.Height;
                lblHighlight = lblAdvancedSearch;
                lblLowlight = lblBasicSearch;
            }
            else
            {
                displayHeight += pnlBasicSearch.Height;
                lblHighlight = lblBasicSearch;
                lblLowlight = lblAdvancedSearch;
            }

            pnlBasicSearch.Visible = !display;
            pnlAdvancedSearch.Visible = display;


            lblHighlight.BackColor = Color.SkyBlue;
            lblHighlight.Font = new Font(oldFont, FontStyle.Bold);
            lblHighlight.BorderStyle = BorderStyle.FixedSingle;

            lblLowlight.BackColor = Color.FromArgb(243, 243, 243);
            lblLowlight.Font = new Font(oldFont, FontStyle.Regular);
            lblHighlight.BorderStyle = BorderStyle.Fixed3D;

            spltTopBottom.SplitterDistance = displayHeight;
        }

        private bool SearchInfoVisible()
        {
            return spltTopBottom.SplitterDistance == DEFAULTSEARCHINFOHEIGHT;
        }

        private void lblClaimInformation_Click(object sender, EventArgs e)
        {

        }

        private void cmdStartCall_Click(object sender, EventArgs e)
        {
            StartCall();
        }

        private void StartCall()
        {
            
            FormCall = GetNewCall();
            ActiveUser.LogAction(ActiveUser.ActionTypes.StartMultiClaimCall, 0, FormCall.id, "");
            callTime = new TimeSpan(0);
            callTimer.Start();
        }

        void callTimer_Tick(object sender, EventArgs e)
        {
            callTime = callTime.Add(new TimeSpan(0, 0, 1));
            TickTimer();
        }

        private void TickTimer()
        {
            if (InvokeRequired)
            {
                EmptyDelegate ed = new EmptyDelegate(TickTimer);
                Invoke(ed);
            }
            else
            {
                string callMinutesDisplay;

                if (callTime.Minutes > 10)
                    callMinutesDisplay = callTime.Minutes.ToString();
                else
                    callMinutesDisplay = "0" + callTime.Minutes;

                string callSecondsDisplay;
                int callSeconds;

                callSeconds = callTime.Seconds % 60;

                if (callSeconds > 10)
                    callSecondsDisplay = callSeconds.ToString();
                else
                    callSecondsDisplay = "0" + callSeconds;

                Text = "Multiple Claim Call: " + callMinutesDisplay + ":" + callSecondsDisplay;
            }
        }

        private void cmdEndCall_Click(object sender, EventArgs e)
        {
            EndCall();
        }

        private void EndCall()
        {
            callTimer.Stop();
            EndAllActiveCalls();
            ActiveUser.LogAction(ActiveUser.ActionTypes.EndMultiClaimCall, 0, FormCall.id, "");
            FormCall.DurationSeconds = Convert.ToInt32(callTime.TotalSeconds);
            FormCall.Save();
            
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
        }

        private void AdvancedSearch()
        {
            Search(BuildAdvancedSQL());
        }

        private void frmMultiClaimCall_Load(object sender, EventArgs e)
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

            InitializeCompanyNames();
            InitializeCarrierGroups();
            InitializeClinics();
            InitializeStatus();
            cmbClinic.SelectedIndex = cmbClinic.FindStringExact(Properties.Settings.Default.SearchDefaultClinic);

            if (cmbClinic.SelectedIndex == -1)
                cmbClinic.SelectedIndex = 0;

            cmbSearchType.SelectedIndex = 0;
            cmbDateFilterType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        private void InitializeStatus()
        {
            claim_status cs = new claim_status();

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Show All");

            foreach (DataRow aStatus in cs.GetAllData("orderid").Rows)
            {
                cs = new claim_status();
                cs.Load(aStatus);
                cmbStatus.Items.Add(cs);
            }

        }

        private void InitializeClinics()
        {
            clinic cln = new clinic();

            cmbClinic.Items.Clear();
            cmbBasicClinic.Items.Clear();
            cmbClinic.Items.Add("Show All");
            cmbBasicClinic.Items.Add("Show All");

            DataTable dt = cln.Search(cln.SearchSQL + " ORDER BY name");
            foreach (DataRow aClinic in dt.Rows)
            {
                cln = new clinic();
                cln.Load(aClinic);
                cmbClinic.Items.Add(cln);
                cmbBasicClinic.Items.Add(cln);
            }
        }

        private void InitializeCompanyNames()
        {
            company cmps = new company();
            DataTable dt = cmps.Search(cmps.SearchSQL + " ORDER BY name");
            

            foreach (DataRow aCompany in dt.Rows)
            {
                cmps = new company();
                cmps.Load(aCompany);
                DataTable matches = cmps.Search("SELECT Count(*) FROM claims WHERE company_id = " + cmps.id);
                ComboItemForCompany cifc = new ComboItemForCompany(cmps, System.Convert.ToInt32(matches.Rows[0][0]));
                cmbCompanyDropdown.Items.Add(cifc);
            }
        }

        private void InitializeCarrierGroups()
        {
            insurance_company_group icg = new insurance_company_group();
            DataTable dt = icg.Search(icg.SearchSQL + " ORDER BY name");
            cmbBasicCarrierGroup.Items.Clear();

            cmbBasicCarrierGroup.Items.Add("");

            foreach (DataRow aGroup in dt.Rows)
            {
                icg = new insurance_company_group();
                icg.Load(aGroup);

                cmbBasicCarrierGroup.Items.Add(icg);
            }
        }

        private void frmMultiClaimCall_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndCall();
        }

        private void ctlClaimDisplay_Enter(object sender, EventArgs e)
        {
            focusedControl = (ctlClaimDataDisplay)sender;
        }

        private void lblCarrierSelection_DoubleClick(object sender, EventArgs e)
        {
            if (spltCarrierListDataDisplay.SplitterDistance == DEFAULTCARRIERLISTWIDTH)
                ShowCarrierSelection(false);
            else
                ShowCarrierSelection(true);
        }

        private void ShowCarrierSelection(bool show)
        {
            if (show)
                spltCarrierListDataDisplay.SplitterDistance = DEFAULTCARRIERLISTWIDTH;
            else
                spltCarrierListDataDisplay.SplitterDistance = lblCarrierSelection.Width;
        }

        private void lblCarrierSelection_Click(object sender, EventArgs e)
        {

        }

        private void chkCarrierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isSearching)
            {
                if (_lastCarriersCheckedAmount != chkCarrierList.CheckedItems.Count)
                {
                    _lastCarriersCheckedAmount = chkCarrierList.CheckedItems.Count;
                    UpdateDisplay();

                    if (_lastCarriersCheckedAmount == 0)
                        DisplayActivePage();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spltTopBottom_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMultiClaimCall_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void frmMultiClaimCall_Shown(object sender, EventArgs e)
        {
            StartCall();
            DisplayAdvancedSearch(false);
            ShowCarrierSelection(false);
        }

        private void btnBasicSearch_Click(object sender, EventArgs e)
        {
            PerformBasicSearch();
        }

        private void PerformBasicSearch()
        {
            Search(BuildBasicSQL());
        }

        private void lblAdvancedSearch_Click(object sender, EventArgs e)
        {
            DisplayAdvancedSearch(true);
        }

        private void lblBasicSearch_Click(object sender, EventArgs e)
        {
            DisplayAdvancedSearch(false);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (cmbPage.SelectedIndex < cmbPage.Items.Count - 1)
            {
                cmbPage.SelectedIndex = cmbPage.SelectedIndex + 1;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (cmbPage.SelectedIndex > 0)
            {
                cmbPage.SelectedIndex = cmbPage.SelectedIndex - 1;
            }
        }

        private void pnlBasicSearch_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnBasicSearch;
        }

        private void pnlBasicSearch_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void pnlAdvancedSearch_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void pnlAdvancedSearch_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnAdvancedSearch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPage.SelectedIndex = cmbPage2.SelectedIndex;
        }

    }

    class CompanyDropDownItem
    {
        private int _companyID;
        private string _companyName;
        private List<claim> _claims;
        private List<int> _claimIDs;
        private bool _claimsInitialized;

        public int CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public List<int> ClaimIDs
        {
            get { return _claimIDs; }
            set { _claimIDs = value; }
        }
        public List<claim> Claims
        {
            get 
            {
                if (!_claimsInitialized)
                {
                    _claims = new List<claim>();
                    foreach (int id in _claimIDs)
                    {
                        claim c = new claim(id);
                        _claims.Add(c);
                    } 
                    _claimsInitialized = true;
                }
                return _claims; 
            }
            set { _claims = value; }
        }


        /// <summary>
        /// By default the claimCount is set to 1 on initializing
        /// </summary>
        /// <param name="companyID"></param>
        /// <param name="companyName"></param>
        public CompanyDropDownItem(int companyID, string companyName, int claimID)
        {
            CompanyID = companyID;
            CompanyName = companyName;
            _claimIDs = new List<int>();
            _claimIDs.Add(claimID);
            
            _claimsInitialized = false;
        }

        public override string ToString()
        {
            return CompanyName + " (" + _claimIDs.Count + ")";
        }
    }
}