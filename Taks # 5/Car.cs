using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taks___5
{


    public class Car : Vehicle, IStartable
    {
        public int NumberOfDoors { get; set; }
        public decimal TrunkCapacity { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Trunk Capacity: {TrunkCapacity}");
        }

        public void Start()
        {
            Console.WriteLine($"Starting Car");
        }
    }
}


