using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace Pr38_TheMovies.Models
{
    public class BookingRepository
    {
        private ObservableCollection<Booking> bookings;

        public BookingRepository()
        {
            bookings = new ObservableCollection<Booking>();

            // ####
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? connectionString = config.GetConnectionString("MyDBConnection");
            // ####

            initRepo();
        }

        private void initRepo()
        {
            using StreamReader myReader = new StreamReader("Pr38_TheMoviesMedBilletAntal.csv");
            {
                string line = myReader.ReadLine();
                Movie movie;
                Showing showing;
                Booking booking;
                Cinema cinema;
                while (line != null)
                {
                    string[] parts = line.Split(';');
                    movie = new Movie(parts[3], parts[4], parts[5], parts[6], DateTime.Parse(parts[7]));
                    cinema = new Cinema(parts[1], parts[0]);
                    showing = new Showing(DateTime.Parse(parts[2]), 50, movie, cinema);
                    booking = new Booking(int.Parse(parts[10]), parts[8], parts[9], showing);
                    if (booking != null )
                    {
                        bookings.Add(booking);
                    }
                    line = myReader.ReadLine();
                }
            }
        }

        public Booking AddBooking(int ticketAmount, string email, string phoneNumber, Showing showingTBS)
        {
            Booking b = new Booking(ticketAmount, email, phoneNumber, showingTBS);
            bookings.Add(b);
            return b;
        }

        public Booking AddBooking(Booking booking)
        {
            bookings.Add(booking);
            return booking;
        }

        public void DeleteBooking(Booking booking)
        {
            bookings.Remove(booking);
        }

        public void Save()
        {
            using StreamWriter myWriter = new StreamWriter("Pr38_TheMoviesMedBilletAntal.csv");
            {
                foreach (Booking booking in bookings)
                {
                    string output = booking.GetString();
                    myWriter.WriteLine(output);
                }
            }
        }
    }
}
