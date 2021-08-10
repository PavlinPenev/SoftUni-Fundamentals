using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class NeedForSpeedIII
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                cars.Add(car[0], new Car(int.Parse(car[1]), int.Parse(car[2])));
            }

            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "Stop")
            {
                string car = string.Empty;
                int distance = 0;
                int fuel = 0;
                switch (command[0])
                {
                    case "Drive":
                        car = command[1];
                        distance = int.Parse(command[2]);
                        fuel = int.Parse(command[3]);
                        if (cars[car].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car].Fuel -= fuel;
                            cars[car].Mileage += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (cars[car].Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }

                        break;
                    case "Refuel":
                        car = command[1];
                        fuel = int.Parse(command[2]);
                        cars[car].Fuel += fuel;
                        if (cars[car].Fuel > 75)
                        {
                            fuel -= cars[car].Fuel - 75;
                            cars[car].Fuel = 75;
                        }

                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        break;
                    case "Revert":
                        car = command[1];
                        distance = int.Parse(command[2]);
                        cars[car].Mileage -= distance;
                        if (cars[car].Mileage < 10000)
                        {
                            cars[car].Mileage = 10000;
                            command = Console.ReadLine().Split(" : ");
                            continue;
                        }
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");

                        break;
                }
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var car in cars.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public Car(int mileage, int fuel)
        {
            Mileage = mileage;
            Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
