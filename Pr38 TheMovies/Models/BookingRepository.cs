using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class BookingRepository
    {
        private ObservableCollection<Booking> bookings;

        public BookingRepository()
        {
            bookings = new ObservableCollection<Booking>();
            // initRepo();
        }

        private void initRepo()
        {

        }

        public Booking AddBooking(int ticketAmount, string email, string phoneNumber)
        {
            Booking b = new Booking(ticketAmount, email, phoneNumber);
            bookings.Add(b);
            return b;
        }
    }
}
