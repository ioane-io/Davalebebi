using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks___5
{
    public class Garage
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var vehicle in vehicles)
            {
                total += vehicle.Price;
            }
            return total;
        }
    }
}
