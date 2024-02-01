using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private void InitRepo() { }

        public Showing AddShowing(DateTime playingDate, int seatCapacity, Movie movieTBS)
        {
            Showing s = new Showing(playingDate, seatCapacity, movieTBS);
            showings.Add(s);
            return s;
        }

        public void DeleteShowing(Showing showing)
        {
            showings.Remove(showing);
        }
    }
}
