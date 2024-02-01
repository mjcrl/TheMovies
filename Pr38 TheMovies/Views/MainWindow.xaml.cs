using Pr38_TheMovies.Models;
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
        BookingRepository bookingRepository;
        public MainWindow()
        {
            InitializeComponent();
            bookingRepository = new BookingRepository();
            Movie m = new Movie("peepee", "poopoo", "53", "David", DateTime.Parse("03-04-2020 21:00:00"));
            Cinema c = new Cinema("Odense", "Cinemaxx");
            Showing s = new Showing(DateTime.Parse("03-04-2020 21:00:00"), 50, m, c);
            Booking b = new Booking(4, "perhansen12319@gmail.com", "29239328238923893892", s);
            bookingRepository.AddBooking(b);
            bookingRepository.Save();
        }
    }
}