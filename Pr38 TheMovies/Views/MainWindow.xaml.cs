using Pr38_TheMovies.ViewModels;
using Pr38_TheMovies.Views;
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

namespace Pr38_TheMovies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;
        BookingWindow bookingWindow;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bookingWindow = new BookingWindow();
            if (bookingWindow.ShowDialog() == true )
            {
                if (viewModel.SelectedShowing != null)
                {
                    viewModel.AddBooking(bookingWindow.viewModel.SeatAmount, bookingWindow.viewModel.Email,
                        bookingWindow.viewModel.PhoneNumber, viewModel.SelectedShowing.Showing);
                }
            }
            
        }
    }
}