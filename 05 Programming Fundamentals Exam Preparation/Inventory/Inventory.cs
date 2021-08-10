using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] commands = input.Split(" - ");
                switch (commands[0])
                {
                    case "Collect":
                        if (!inventory.Contains(commands[1]))
                        {
                            inventory.Add(commands[1]);
                        }

                        break;
                    case "Drop":
                        if (inventory.Contains(commands[1]))
                        {
                            inventory.Remove(commands[1]);
                        }

                        break;
                    case "Combine Items":
                        string[] items = commands[1].Split(":");
                        if (inventory.Contains(items[0]))
                        {
                            int index = inventory.FindIndex(s => s == items[0]);
                            inventory.Insert(index + 1, items[1]);
                        }

                        break;
                    case "Renew":
                        if (inventory.Contains(commands[1]))
                        {
                            int indexRenew = inventory.FindIndex(i => i == commands[1]);
                            string item = inventory[indexRenew];
                            inventory.RemoveAt(indexRenew);
                            inventory.Add(item);
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
