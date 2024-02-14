using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIntoDatabase
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public Car(string make,  string model, int year, string description)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Description = description;
        }

    }
}
