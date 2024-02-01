using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private void InitRepo() { }

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
