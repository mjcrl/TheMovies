using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class DataHandler
    {
        public static ObservableCollection<SuperObject?> initRepo(string type)
        {
            using StreamReader myReader = new StreamReader("Pr38_TheMoviesMedBilletAntal.csv");
            {
                string line = myReader.ReadLine();
                ObservableCollection<Movie> movies = null;
                ObservableCollection<Showing> showings = null;
                ObservableCollection<Booking> bookings = null;
                while (line != null)
                {
                    string[] parts = line.Split(';');
                    Movie movie = new Movie(parts[3], parts[4], parts[5], parts[6], DateTime.Parse(parts[7]));
                    movies.Add(movie);
                    Cinema cinema = new Cinema(parts[1], parts[0]);
                    Showing showing = new Showing(DateTime.Parse(parts[2]), 50, movie, cinema);
                    showings.Add(showing);
                    Booking booking = new Booking(int.Parse(parts[10]), parts[8], parts[9], showing);
                    bookings.Add(booking);
                }
                switch (type)
                {
                    case "MOVIE":
                        return movies;
                    case "SHOWING":
                        return showings;
                    case "BOOKING":
                        return bookings;
                    default:
                        return null;
                }
            }
        }
    }
}
