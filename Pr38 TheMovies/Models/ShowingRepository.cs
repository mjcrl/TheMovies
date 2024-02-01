using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class ShowingRepository
    {
        private ObservableCollection<Showing> showings;

        public ShowingRepository()
        {
            showings = new ObservableCollection<Showing>();
            // InitRepo();
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
                    if (showing != null)
                    {
                        showings.Add(showing);
                    }
                    line = myReader.ReadLine();
                }
            }
        }

        public Showing AddShowing(DateTime playingDate, int seatCapacity, Movie movieTBS, Cinema location)
        {
            Showing s = new Showing(playingDate, seatCapacity, movieTBS, location);
            showings.Add(s);
            return s;
        }

        public void DeleteShowing(Showing showing)
        {
            showings.Remove(showing);
        }
    }
}
