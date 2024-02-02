using Pr38_TheMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pr38_TheMovies.Views
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingViewModel viewModel { get; set; } = new BookingViewModel();
        public BookingWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            int seatCount;

            if (!string.IsNullOrWhiteSpace(txtbxName.Text) &&
                int.TryParse(txtbxPhone.Text, out int b) == true &&
                !string.IsNullOrWhiteSpace(txtbxEmail.Text) &&
                int.TryParse(txtbxSeat.Text, out seatCount) == true)
            {
                viewModel.PhoneNumber = txtbxPhone.Text;
                viewModel.Email = txtbxEmail.Text;
                viewModel.SeatAmount = seatCount;
            }

            DialogResult = true;
        }
    }
}
