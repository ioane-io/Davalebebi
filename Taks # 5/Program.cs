namespace Taks___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car 
            {
                Make = "Honda",
                Model = "Fit Hybrid",
                Year = 2019,
                Price = 8000,
                NumberOfDoors = 4,
                TrunkCapacity = 10
            };
            Motorcycle myMotorcycle = new Motorcycle
            {
                Make = "ford",
                Model = "mustang",
                Year = 2023,
                Price = 10000,
                HasSideCar = false,
                Type = "sport"
            };
            Garage myGarage = new Garage();
            myGarage.AddVehicle(myCar);
            myGarage.AddVehicle(myMotorcycle);
            Console.WriteLine("Information for vehicles in Garage:");
            myGarage.PrintAllVehicles();
            Console.WriteLine();
            decimal totalPrice = myGarage.CalculateTotalPrice();
            Console.WriteLine($"Total Price for all vehicles:  {totalPrice}");
            Console.WriteLine();
            foreach (var vehicle in myGarage.vehicles)
            {
                if (vehicle is IStartable startableVehicle)
                {
                    startableVehicle.Start();
                }
            }
        }
    }
}