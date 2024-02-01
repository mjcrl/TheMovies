using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Showing : SuperObject
    {
        #region Properties
        public DateTime PlayingDate { get; set; }
        public int SeatCapacity { get; set; }
        public Movie MovieTBS { get; set; }
        public Cinema Location { get; set; }

        #endregion

        #region Constructors
        public Showing(DateTime playingDate,  int seatCapacity, Movie movieTBS, Cinema location)
        {
            PlayingDate = playingDate;
            SeatCapacity = seatCapacity;
            MovieTBS = movieTBS;
            Location = location;
        }
        #endregion
    }
}
