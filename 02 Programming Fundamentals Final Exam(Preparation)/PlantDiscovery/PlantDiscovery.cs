using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class PlantDiscovery
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plant = Console.ReadLine().Split("<->");
                if (!plants.ContainsKey(plant[0]))
                {
                    plants.Add(plant[0], new Plant());
                }

                plants[plant[0]].Rarity = int.Parse(plant[1]);
                plants[plant[0]].Rating = new List<double>();
            }

            string[] command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Exhibition")
            {
                string[] plant = command[1].TrimStart().Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                if (!plants.ContainsKey(plant[0]))
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                switch (command[0])
                {
                    case "Rate":
                        plants[plant[0]].Rating.Add(double.Parse(plant[1]));
                        break;
                    case "Update":
                        plants[plant[0]].Rarity = int.Parse(plant[1]);
                        break;
                    case "Reset":
                        plants[command[1].TrimStart()].Rating.Clear();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                plant.Value.AvgRating = plant.Value.Rating.Count == 0 ? 0.00 : plant.Value.Rating.Average();
            }
            foreach (var plant in plants.OrderByDescending(p => p.Value.Rarity).ThenByDescending(p => p.Value.AvgRating))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AvgRating:f2}");
            }
        }
    }

    class Plant
    {
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
        public double AvgRating { get; set; }
    }
}
