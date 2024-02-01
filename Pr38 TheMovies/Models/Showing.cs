﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Showing
    {
        #region Properties
        public DateTime PlayingDate { get; set; }
        public int SeatCapacity { get; set; }

        #endregion

        #region Constructors
        public Showing(DateTime playingDate,  int seatCapacity)
        {
            PlayingDate = playingDate;
            SeatCapacity = seatCapacity;
        }
        #endregion
    }
}
