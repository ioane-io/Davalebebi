using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taks___5
{
    public abstract class Vehicle
    {
        //public vehicle(string make, string model, int year, decimal price)
        //{
        //    make = make;
        //    model = model;
        //    year = year;
        //    price = price;
        //}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public abstract void DisplayInfo();
    }  
}