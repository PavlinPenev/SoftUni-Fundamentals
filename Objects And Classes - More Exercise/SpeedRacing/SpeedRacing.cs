using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car currentCar = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] action = command.Split();
                int carIndex = cars.FindIndex(c => c.Model == action[1]);
                cars[carIndex].Drive(double.Parse(action[2]));
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }
        public override string ToString()
            => $"{Model} {FuelAmount:f2} {TraveledDistance}";

        public void Drive(double km)
        {
            if (km * FuelConsumption <= FuelAmount)
            {
                FuelAmount -= km * FuelConsumption;
                TraveledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
