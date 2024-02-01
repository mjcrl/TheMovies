using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Booking
    {
        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Showing ShowingTBS { get; set; }

        public Booking(int ticketAmount, string email, string phoneNumber, Showing showingTBS)
        {
            TicketAmount = ticketAmount;
            Email = email;
            PhoneNumber = phoneNumber;
            ShowingTBS = showingTBS;
        }
        public string GetString()
        {
            return $"{ShowingTBS.Location.Name};{ShowingTBS.Location.City};{ShowingTBS.PlayingDate.ToString()};" +
                $"{ShowingTBS.MovieTBS.Title};{ShowingTBS.MovieTBS.Genre};{ShowingTBS.MovieTBS.Duration};" +
                $"{ShowingTBS.MovieTBS.Instructor};{ShowingTBS.MovieTBS.Premiere.ToString()};{Email};{PhoneNumber};{TicketAmount}";
        }
    }
}
