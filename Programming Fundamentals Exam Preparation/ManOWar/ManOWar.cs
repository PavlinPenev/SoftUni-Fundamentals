using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class ManOWar
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxCapacitySection = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Retire")

            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Fire":
                        int index = int.Parse(commands[1]);
                        int damage = int.Parse(commands[2]);
                        if (index >= 0 && index < warship.Count)
                        {
                            warship[index] -= damage;
                            if (warship[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int indexStart = int.Parse(commands[1]);
                        int indexEnd = int.Parse(commands[2]);
                        int damageW = int.Parse(commands[3]);
                        if (indexStart >= 0 && indexEnd < pirateShip.Count)
                        {
                            List<int> targets = pirateShip.GetRange(indexStart, indexEnd - indexStart + 1).ToList();
                            pirateShip.RemoveRange(indexStart, indexEnd - indexStart + 1);
                            for (int i = 0; i < targets.Count; i++)
                            {
                                targets[i] -= damageW;
                            }
                            pirateShip.InsertRange(indexStart, targets);
                            targets.Clear();
                            if (pirateShip.Any(s => s <= 0))
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }


                        break;
                    case "Repair":
                        int indexR = int.Parse(commands[1]);
                        int health = int.Parse(commands[2]);
                        if (indexR >= 0 && indexR < pirateShip.Count)
                        {
                            pirateShip[indexR] += health;
                            if (pirateShip[indexR] > maxCapacitySection)
                            {
                                pirateShip[indexR] = maxCapacitySection;
                            }
                        }

                        break;
                    case "Status":
                        double repairNeeded = maxCapacitySection * 0.20;
                        Console.WriteLine($"{pirateShip.Count(s => s < repairNeeded)} sections need repair.");
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}
