using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryFarm = new Dictionary<string, int>();
            legendaryFarm.Add("shards", 0);
            legendaryFarm.Add("fragments", 0);
            legendaryFarm.Add("motes", 0);

            while (legendaryFarm["shards"] < 250 && legendaryFarm["fragments"] < 250 && legendaryFarm["motes"] < 250)
            {
                List<string> items = Console.ReadLine().ToLower().Split().ToList();
                while (items.Count != 0)
                {
                    int quantity = int.Parse(items[0]);
                    string item = items[1];
                    if (!legendaryFarm.ContainsKey(item))
                    {
                        legendaryFarm.Add(item, quantity);
                        items.RemoveRange(0, 2);
                        continue;
                    }


                    legendaryFarm[item] += quantity;
                    items.RemoveRange(0, 2);
                    if (legendaryFarm["shards"] >= 250 || legendaryFarm["fragments"] >= 250 || legendaryFarm["motes"] >= 250)
                    {
                        break;
                    }
                }
            }

            Dictionary<string, int> legendaryItems = legendaryFarm.Take(3).ToDictionary(i => i.Key, i => i.Value);
            int winnerValue = legendaryItems.Values.Max();
            string winnerKey = legendaryItems.First(i => i.Value == winnerValue).Key;
            string winner = string.Empty;
            switch (winnerKey)
            {
                case "shards":
                    winner = "Shadowmourne";
                    break;
                case "fragments":
                    winner = "Valanyr";
                    break;
                case "motes":
                    winner = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{winner} obtained!");
            legendaryItems[winnerKey] -= 250;

            legendaryFarm.Remove("shards");
            legendaryFarm.Remove("fragments");
            legendaryFarm.Remove("motes");
            foreach (var item in legendaryItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in legendaryFarm.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
