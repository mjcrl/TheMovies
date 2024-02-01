using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Movie : SuperObject
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Instructor { get; set; }
        public DateTime Premiere { get; set; }

        public Movie(string title, string genre, string duration, string instructor, DateTime premiere)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
            Instructor = instructor;
            Premiere = premiere;
        }
    }
}
