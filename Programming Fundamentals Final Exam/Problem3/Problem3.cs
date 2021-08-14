using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            string[] command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "EndDay")
            {
                switch (command[0])
                {
                    case "Add":
                        string[] animalInfo = command[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                        string name = animalInfo[0];
                        int foodQty = int.Parse(animalInfo[1]);
                        string area = animalInfo[2];
                        if (!animals.ContainsKey(name))
                        {
                            animals.Add(name, new Animal());
                            animals[name].FoodNeed += foodQty;
                            animals[name].Area = area;
                        }
                        else
                        {
                            animals[name].FoodNeed += foodQty;
                        }

                        
                        break;
                    case "Feed":
                        string[] feedInfo = command[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                        name = feedInfo[0];
                        foodQty = int.Parse(feedInfo[1]);
                        if (animals.ContainsKey(name))
                        {
                            animals[name].FoodNeed -= foodQty;
                            if (animals[name].FoodNeed <= 0)
                            {
                                Console.WriteLine($"{name} was successfully fed");
                                animals.Remove(name);
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, int> animalsCount = new Dictionary<string, int>();

            Console.WriteLine("Animals:");
            foreach (var animal in animals.OrderByDescending(a => a.Value.FoodNeed).ThenBy(a => a.Key))
            {
                if (!animalsCount.ContainsKey(animal.Value.Area))
                {
                    animalsCount.Add(animal.Value.Area, 1);
                }
                else
                {
                    animalsCount[animal.Value.Area]++;
                }
                Console.WriteLine($" {animal.Key} -> {animal.Value.FoodNeed}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in animalsCount.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }

        }
    }

    class Animal
    {
        public long  FoodNeed { get; set; }
        public string  Area{ get; set; }
    }
}
