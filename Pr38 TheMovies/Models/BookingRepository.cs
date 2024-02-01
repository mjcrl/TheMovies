using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            DataHandler.initRepo();
            if (bookings != null)
            {
                bookings.Add();
            }
        }

        public Booking AddBooking(int ticketAmount, string email, string phoneNumber, Showing showingTBS)
        {
            Booking b = new Booking(ticketAmount, email, phoneNumber, showingTBS);
            bookings.Add(b);
            return b;
        }

        public void DeleteBooking(Booking booking)
        {
            bookings.Remove(booking);
        }

        public void save()
        {

        }
    }
}
