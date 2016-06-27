using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using C_DentalClaimTracker;
using C_DentalClaimTracker.Claims_Primary;
using System.Text.RegularExpressions;
using System.Data;

namespace C_DentalClaimTracker.General
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class frmStartScreenWPF : UserControl
    {
        public List<claim> SearchClaims { get; set; }
        string resolveNowWhereClause { get; set; }
        string predetermsWhereClause { get; set; }
        public List<CheckBox> ClinicCheckBoxes { get; set; }
        
        public string SearchTitle { get; set; }
        public string SearchWhereClause { get; set; }

        public event Action RequestClose;
        public event Action RequestExit;
        public event Action RequestSearch;

        string claimsUnpaidWhereClause
        {
            get
            {
                // Unpaid Claims
                return " DATEDIFF(d, sent_date, GETDATE()) > " + GetMinimumDate().ToString("0") + " AND claim_type IN (0, 1) AND [open] = 1" + GetOfficeWhereClause();
            }
        }

        public frmStartScreenWPF()
        {
            InitializeComponent();
            SearchWhereClause = "";
            SearchTitle = "";
            ClinicCheckBoxes = new List<CheckBox>();
            FillOfficeList();
            UpdateButtonCounts();
            
            txtMinimumDays.Text = new user_preferences(ActiveUser.UserObject.id).reports_minimumdays.ToString("0");
        }

        private void FillOfficeList()
        {
            clinic aClinic = new clinic();

            foreach(DataRow aRow in aClinic.GetAllData("name").Rows)
            {
                aClinic = new clinic();
                aClinic.Load(aRow);

                pnlOffices.Children.Add(GenerateClinicUI(aClinic, user_preferences_clinics.Get(ActiveUser.UserObject.id, aClinic.id)));
            }
        }

        private UIElement GenerateClinicUI(clinic c, bool isChecked)
        {
            WrapPanel toReturn = new WrapPanel();
            toReturn.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            toReturn.ItemHeight = 30;
            Thickness margin = toReturn.Margin;
            margin.Right = 6;
            toReturn.Margin = margin;

            Label lbl = new Label();
            lbl.Content = c.name;
            lbl.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            lbl.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Right;
            lbl.FontSize = 14;
            lbl.Width = 120;

            CheckBox cb = new CheckBox();
            cb.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            cb.FontSize = 16;
            cb.IsChecked = isChecked;
            cb.Tag = c;
            cb.Checked += cb_Checked;
            cb.Unchecked += cb_Checked;
            ClinicCheckBoxes.Add(cb);

            toReturn.Children.Add(lbl);
            toReturn.Children.Add(cb);

            /*
            <WrapPanel HorizontalAlignment="Right" ItemHeight="30" Margin="0, 0, 6, 0">
                                <Label Content="New Haven " VerticalAlignment="Center" Visibility="Visible" HorizontalContentAlignment="Right" FontSize="14" Width="120" />
                                <CheckBox VerticalAlignment="Center" FontSize="16" IsChecked="True"></CheckBox>
                            </WrapPanel> */

            return toReturn;
        }

        void cb_Checked(object sender, RoutedEventArgs e)
        {
            user_preferences_clinics.Set(ActiveUser.UserObject.id, ((clinic)((Control)sender).Tag).id, ((CheckBox)sender).IsChecked.GetValueOrDefault(true));
            UpdateButtonCounts();
        }

        private void UpdateButtonCounts()
        {
            claim workingObject = new claim();
            
            // Resolve Now
            // Primary / Secondary claims over 60 days that haven't been looked at or need to be revisited
            resolveNowWhereClause = @" DATEDIFF(d, sent_date, GETDATE()) > 60
                AND (DATEDIFF(d, revisit_date, GETDATE()) > 1 OR revisit_date IS NULL) 
                AND claim_type IN (0, 1) AND [open] = 1" + GetOfficeWhereClause();

            txtResolveNow.Text = GetClaimCountText(resolveNowWhereClause, workingObject);

            txtUnpaidClaims.Text = GetClaimCountText(claimsUnpaidWhereClause, workingObject);

            // Process Claims
            string claimsNeedProcessSQL = string.Format("SELECT COUNT(c.id) FROM claims c LEFT JOIN Companies cmp ON c.company_id = cmp.id" +
                " WHERE c.[open] = 1 and c.id NOT IN (SELECT claim_ID FROM batch_claim_list WHERE still_in_batch = 1) AND c.date_of_service > '{0}'",
                CommonFunctions.ToMySQLDate(system_options.PredetermSearchDateMinimum));

            txtProcessClaims.Text = "(" + workingObject.Search(claimsNeedProcessSQL).Rows[0][0].ToString() + ")";

            // Predeterms
            predetermsWhereClause = " DATEDIFF(d, sent_date, GETDATE()) > 20 AND claim_type IN (2, 3) AND [open] = 1" + GetOfficeWhereClause();
            txtOpenPredeterms.Text = GetClaimCountText(predetermsWhereClause, workingObject);

            // Yesterday Claims


            // Import Date
            txtLastImport.Text = "Last " + system_options.GetLastImportDate().ToShortDateString();



        }

        private string GetClaimCountText(string where, claim workingObject)
        {
            return "(" + workingObject.Search("SELECT COUNT(*) FROM claims WHERE " + where).Rows[0][0].ToString() + ")";
        }

        private string GetOfficeWhereClause()
        {
            string toReturn;
            // 30 NH, 40 = HAMDEN, 50 = Woodbridge, 60 = Branford
            List<string> clinics = new List<string>();
            clinics.AddRange(ClinicCheckBoxes.Where(item => item.IsChecked.GetValueOrDefault(true)).Select(o => (((clinic) o.Tag).id.ToString())).ToList());

            if (clinics.Count > 0)
                toReturn = string.Format(" AND clinic_id IN ({0}) ", clinics.Aggregate((a, b) => a + "," + b));
            else
                toReturn = " AND clinic_id = 0 ";

            return toReturn;
        }

        private void btnAdvanced_Click(object sender, RoutedEventArgs e)
        {
            if (RequestClose != null)
                RequestClose();
        }

        private void btnProcessClaims_Click(object sender, RoutedEventArgs e)
        {
            E_Claims.frmProcessor fp = new E_Claims.frmProcessor();
            fp.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (RequestExit != null)
                RequestExit();
        }

        private void btnInvestigateClaims_Click(object sender, RoutedEventArgs e)
        {
            frmSearchClaim fs = new frmSearchClaim();
            fs.Show();
        }

        private void btnSearchClaims_Click(object sender, RoutedEventArgs e)
        {
            SearchWhereClause = "";
            SearchTitle = "Search Claims";

            if (RequestSearch != null)
                RequestSearch();
        }

        private void btnImportClaims_Click(object sender, RoutedEventArgs e)
        {
            frmImportData fi = new frmImportData();
            fi.Show();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            frmAboutBox fa = new frmAboutBox();
            fa.Show();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            frmUserControlPanel fcp = new frmUserControlPanel(ActiveUser.UserObject);
            fcp.Show();
        }

        private void lnkYesterdayClaims_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            frmSearchClaimWPFContainer fs = new frmSearchClaimWPFContainer();
            fs.Show();
        }

        private void btnClaimsPaidYesterday_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnpaidClaims_Click(object sender, RoutedEventArgs e)
        {
            SearchTitle = "Priority Report Claims";
            SearchWhereClause = " AND " + claimsUnpaidWhereClause;

            if (RequestSearch != null)
                RequestSearch();
        }

        private void btnResolveNowClaims_Click(object sender, RoutedEventArgs e)
        {
            SearchTitle = "Urgent Claims";
            SearchWhereClause = " AND " + resolveNowWhereClause;

            if (RequestSearch != null)
                RequestSearch();
        }

        private void btnPredeterms_Click(object sender, RoutedEventArgs e)
        {
            SearchTitle = "Open Predeterms";
            SearchWhereClause = " AND " + predetermsWhereClause;

            if (RequestSearch != null)
                RequestSearch();
        }

        private void btnAgingReportStandard_Click(object sender, RoutedEventArgs e)
        {
            Reporting.frmAgingReport fa = new Reporting.frmAgingReport();
            fa.IncludePrimary = true;
            fa.IncludeSecondary = true;
            fa.DateCriteria = GetMinimumDate();
            fa.ClinicCriteria = GetOfficeWhereClause();
            fa.Show();
        }

        private void btnAgingReportPredeterm_Click(object sender, RoutedEventArgs e)
        {
            Reporting.frmAgingReport fa = new Reporting.frmAgingReport();
            fa.IncludePredeterm = true;
            fa.DateCriteria = GetMinimumDate();
            fa.ClinicCriteria = GetOfficeWhereClause();
            fa.Show();
        }

        private decimal GetMinimumDate()
        {
            decimal defaultValue = 30;
            try
            {
                int val = Convert.ToInt32(txtMinimumDays.Text);

                if (val > 0)
                {
                    if (val > 9999)
                        return 9999;
                    else
                        return val;
                }
                else
                    return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        private void txtMinimumDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex NumEx = new Regex(@"^-?\d*\.?\d*$");

            if (sender is TextBox)
            {
                string text = (sender as TextBox).Text + e.Text;
                e.Handled = !NumEx.IsMatch(text);
            }
            else
                throw new NotImplementedException("TextBox_PreviewTextInput Can only Handle TextBoxes");
        }

        private void txtMinimumDays_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUnpaidClaims != null)
            {
                txtUnpaidClaims.Text = GetClaimCountText(claimsUnpaidWhereClause, new claim());

                user_preferences up = new user_preferences();
                up.Load(ActiveUser.UserObject.id);
                up.reports_minimumdays = Convert.ToInt32(GetMinimumDate());
                up.Save();
            }
        }

    }
}
