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
    /// Interaction logic for frmReportClaimWPF.xaml
    /// </summary>
    public partial class frmReportWPF : UserControl
    {
        Brush PatientBrush;
        Brush InsuranceBrush;
        Brush UnselectedBrush;
        public event Action RequestClose;
        C_DentalClaimTracker.E_Claims.frmProcessor _processForm;
        string _whereClause;
        string _orderByClause;
        int previousInsuranceIndex = -1;
        int nextInsuranceIndex = -1;
        List<InsuranceCompanyGroups> carrierSource;

        public bool FilterByInsurance { get; set; }

        public frmReportWPF()
        {
            InitializeComponent();
            FilterByInsurance = false;
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (RequestClose != null)
                RequestClose();
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

        private void UserControl_Initialized(object sender, EventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

}
