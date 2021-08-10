using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Prates
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            string[] cityReg = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            while (cityReg[0] != "Sail")
            {
                if (!cities.ContainsKey(cityReg[0]))
                {
                    cities.Add(cityReg[0], new City(int.Parse(cityReg[1]), int.Parse(cityReg[2])));
                }
                else
                {
                    cities[cityReg[0]].Gold += int.Parse(cityReg[2]);
                    cities[cityReg[0]].Population += int.Parse(cityReg[1]);
                }
                cityReg = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] events = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (events[0] != "End")
            {
                switch (events[0])
                {
                    case "Plunder":
                        string town = events[1];
                        int people = int.Parse(events[2]);
                        int gold = int.Parse(events[3]);
                        cities[town].Gold -= gold;
                        cities[town].Population -= people;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (cities[town].Gold <= 0 || cities[town].Population <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(town);
                        }

                        break;
                    case "Prosper":
                        string townPr = events[1];
                        int goldPr = int.Parse(events[2]);
                        if (goldPr < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            events = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        }

                        cities[townPr].Gold += goldPr;
                        Console.WriteLine($"{goldPr} gold added to the city treasury. {townPr} now has {cities[townPr].Gold} gold.");
                        break;
                }
                events = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(c => c.Value.Gold).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    class City
    {
        public City(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
