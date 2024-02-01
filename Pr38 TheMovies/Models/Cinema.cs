using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Cinema
    {
        public string City { get; set; }
        public string Name { get; set; }

        public Cinema(string city, string name)
        {
            City = city;
            Name = name;
        }
    }
}
