using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main()
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] vehData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Vehicle currentCar = new Vehicle(vehData[0], vehData[1], vehData[2], double.Parse(vehData[3]));
                catalogue.Add(currentCar);

                input = Console.ReadLine();
            }

            string typeInput = Console.ReadLine();
            while (typeInput != "Close the Catalogue")
            {
                int index = catalogue.FindIndex(t => t.Model == typeInput);
                Console.WriteLine(catalogue[index]);
                typeInput = Console.ReadLine();
            }

            double avgHPCars = catalogue.FindAll(c => c.Type == "car").Select(c => c.HorsePower).Sum() / (double)catalogue.Count(c => c.Type == "car");
            double avgHPTrucks = catalogue.FindAll(c => c.Type == "truck").Select(c => c.HorsePower).Sum() / (double)catalogue.Count(t => t.Type == "truck");
            Console.WriteLine(Double.IsNaN(avgHPCars) ? "Cars have average horsepower of: 0.00." : $"Cars have average horsepower of: {avgHPCars:f2}.");
            Console.WriteLine(Double.IsNaN(avgHPTrucks) ? "Trucks have average horsepower of: 0.00." : $"Trucks have average horsepower of: {avgHPTrucks:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, double hp)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = hp;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
            =>$"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" + $"Model: {Model}{Environment.NewLine}" + $"Color: {Color}{Environment.NewLine}" + $"Horsepower: {HorsePower}";
    }
}
