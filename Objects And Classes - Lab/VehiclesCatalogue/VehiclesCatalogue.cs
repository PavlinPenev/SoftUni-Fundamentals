using System;
using System.Collections.Generic;
using System.Linq;

namespace VehiclesCatalogue
{
    class VehiclesCatalogue
    {
        static void Main(string[] args)
        {
            Catalogue vehCatalogue = new Catalogue();
            AddVehicles(vehCatalogue);
            PrintVehicles(vehCatalogue);
        }

        private static void PrintVehicles(Catalogue vehCatalogue)
        {
            if (vehCatalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in vehCatalogue.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehCatalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in vehCatalogue.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }

        private static void AddVehicles(Catalogue vehCatalogue)
        {
            bool end = false;
            vehCatalogue.Cars = new List<Car>();
            vehCatalogue.Trucks = new List<Truck>();
            while (!end)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    end = true;
                    continue;
                }

                string[] vehicleData = input.Split("/");

                switch (vehicleData[0])
                {
                    case "Truck":
                        Truck newTruck = new Truck();
                        newTruck.Brand = vehicleData[1];
                        newTruck.Model = vehicleData[2];
                        newTruck.Weight = vehicleData[3];
                        vehCatalogue.Trucks.Add(newTruck);
                        break;
                    case "Car":
                        Car newCar = new Car();
                        newCar.Brand = vehicleData[1];
                        newCar.Model = vehicleData[2];
                        newCar.HorsePower = vehicleData[3];
                        vehCatalogue.Cars.Add(newCar);
                        break;
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Catalogue
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
