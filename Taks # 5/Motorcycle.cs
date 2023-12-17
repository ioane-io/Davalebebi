using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taks___5
{
    public class Motorcycle : Vehicle, IStartable
    {
        public bool HasSideCar { get; set; }
        public string Type { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Has Side Car: {HasSideCar}");
            Console.WriteLine($"Type: {Type}");
        }
        public void Start()
        {
            Console.WriteLine($"Starting motorcycle");
        }
    }
}