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

namespace C_DentalClaimTracker.Claims_Primary
{
    /// <summary>
    /// Interaction logic for frmSearchClaimWPF.xaml
    /// </summary>
    public partial class wpfClaimSubset : UserControl
    {
        public event Action RequestClose;
        

        public wpfClaimSubset()
        {
            InitializeComponent();
            
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (RequestClose != null)
                RequestClose();
        }

        

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnResend_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChangeProvider()
        {
            
        }

        private void cmbChangeStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cmbChangeProvider_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeProvider();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }



    }



}
