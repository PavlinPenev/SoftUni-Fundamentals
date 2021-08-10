using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class RawData
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < input; i++)
            {
                string[] vehicleData = Console.ReadLine().Split();
                Engine newEngine = new Engine(int.Parse(vehicleData[1]), int.Parse(vehicleData[2]));
                Cargo newCargo = new Cargo(int.Parse(vehicleData[3]), vehicleData[4]);
                Car newCar = new Car(vehicleData[0], newEngine, newCargo);
                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    List<Car> fragile = cars.FindAll(c => c.Cargo.CargoType == "fragile").ToList();
                    foreach (var car in fragile.Where(c => c.Cargo.CargoWeight < 1000))
                    {
                        Console.WriteLine(car);
                    }

                    break;
                case "flamable":
                    List<Car> flamable = cars.FindAll(c => c.Cargo.CargoType == "flamable").ToList();
                    foreach (var car in flamable.Where(c => c.Engine.EnginePower > 250))
                    {
                        Console.WriteLine(car);
                    }

                    break;
            }
        }
    }

    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public override string ToString()
        {
            return Model;
        }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            CargoWeight = weight;
            CargoType = type;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
