using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> dragonTypes = new Dictionary<string, List<Dragon>>();
            for (int i = 0; i < n; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split();
                string type = dragonInfo[0];
                string name = dragonInfo[1];
                int damage = dragonInfo[2] == "null" ? 45 : int.Parse(dragonInfo[2]);
                int health = dragonInfo[3] == "null" ? 250 : int.Parse(dragonInfo[3]);
                int armor = dragonInfo[4] == "null" ? 10 : int.Parse(dragonInfo[4]);
                Dragon currentDragon = new Dragon(name, damage, health, armor);
                if (!dragonTypes.ContainsKey(type))
                {
                    dragonTypes.Add(type, new List<Dragon>());
                    dragonTypes[type].Add(currentDragon);
                }
                else
                {

                    if (dragonTypes[type].Any(d => d.Name == name))
                    {
                        int dragonIndex = dragonTypes[type].FindIndex(i => i.Name == name);
                        dragonTypes[type][dragonIndex] = currentDragon;
                    }
                    else
                    {
                        dragonTypes[type].Add(currentDragon);
                    }
                }
            }

            foreach (var type in dragonTypes)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(d => d.Damage):f2}/{type.Value.Average(d => d.Health):f2}/{type.Value.Average(d => d.Armor):f2})");
                foreach (var dragon in type.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine(dragon);
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public override string ToString()
            => $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
    }
}
