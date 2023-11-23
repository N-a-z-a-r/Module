using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Абстрактний клас "Транспортний засіб"
    public abstract class Transport
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Transport(string model, int year)
        {
            Model = model;
            Year = year;
        }
    }
}
