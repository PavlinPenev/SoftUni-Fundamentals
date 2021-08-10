using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class TreasureHunt
    {
        static void Main(string[] args)
        {
            List<string> pirateItems = Console.ReadLine().Split("|").ToList();
            string input = Console.ReadLine();
            List<string> lootedList = new List<string>();
            while (input != "Yohoho!")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Loot":
                        for (int i = 1; i < commands.Length; i++)
                        {
                            if (!pirateItems.Contains(commands[i]))
                            {
                                pirateItems.Insert(0, commands[i]);
                            }
                        }
                        break;
                    case "Drop":
                        if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < pirateItems.Count)
                        {
                            string temp = pirateItems[int.Parse(commands[1])];
                            pirateItems.RemoveAt(int.Parse(commands[1]));
                            pirateItems.Add(temp);
                        }

                        break;
                    case "Steal":
                        int itemsToSteal = int.Parse(commands[1]);
                        if (itemsToSteal > pirateItems.Count)
                        {
                            itemsToSteal = pirateItems.Count;
                        }
                        lootedList = pirateItems.TakeLast(itemsToSteal).ToList();
                        pirateItems.RemoveRange(pirateItems.Count - itemsToSteal, itemsToSteal);
                        Console.WriteLine(string.Join(", ", lootedList));
                        lootedList.Clear();
                        break;
                }

                input = Console.ReadLine();
            }

            if (pirateItems.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }

            double averageSum = 0;
            foreach (var item in pirateItems)
            {
                averageSum += item.Length;
            }

            averageSum /= pirateItems.Count;
            Console.WriteLine($"Average treasure gain: {averageSum:f2} pirate credits.");
        }
    }
}
