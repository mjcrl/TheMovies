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
    public class MovieRepository
    {
        private ObservableCollection<Movie> movies;

        public MovieRepository()
        {
            movies = new ObservableCollection<Movie>();
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
                    if (movie != null)
                    {
                        movies.Add(movie);
                    }
                    line = myReader.ReadLine();
                }
            }
        }

        public Movie AddMovie(string title, string genre, string duration, string instructor, DateTime premiere)
        {
            Movie m = new Movie(title, genre, duration, instructor, premiere);
            movies.Add(m);
            return m;
        }

        public void DeleteMovie(Movie movie)
        {
            movies.Remove(movie);
        }
    }
}
