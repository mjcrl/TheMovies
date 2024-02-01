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
            Movie m1 = new Movie("peepee", "poopoo", "53", "David", DateTime.Parse("03-04-2020 21:00:00"));
            Movie m2 = new Movie("pingpong filmen", "Horror", "2 minutter", "Michael Bay", DateTime.Parse("02-02-2024 16:30:00"));
            Movie m3 = new Movie("Avatar 3", "?", "480 minutter", "Steven Spielberg", DateTime.Parse("02-02-2024 16:32:00"));
            Movie m4 = new Movie("Fast and Furious 19", "Family", "420 minutter", "Optimus Prime", DateTime.Parse("03-03-2056 11:00:00"));
            Cinema c1 = new Cinema("Odense", "Cinemaxx");
            Cinema c2 = new Cinema("Odense", "Nordisk Filmbiograf");
            Cinema c3 = new Cinema("Aarhus", "Imax");
            Cinema c4 = new Cinema("København", "Pers hjemmebiograf");
            Showing s1 = new Showing(DateTime.Parse("03-04-2020 23:00:00"), 50, m1, c3);
            Showing s2 = new Showing(DateTime.Parse("05-11-2024 16:30:00"), 50, m3, c1);
            Showing s3 = new Showing(DateTime.Parse("07-06-2025 11:20:00"), 50, m2, c3);
            Showing s4 = new Showing(DateTime.Parse("07-06-2025 11:22:00"), 50, m3, c3);
            showings.Add(s1); showings.Add(s2); showings.Add(s3); showings.Add(s4);
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

        public ObservableCollection<Showing> GetAll()
        {
            return showings;
        }
    }
}
