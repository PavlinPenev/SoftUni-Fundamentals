using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] data = input.Split(" | ");
                    string user = data[1];
                    string side = data[0];
                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides.Add(side, new List<string>());
                    }
                    if (!forceSides[side].Contains(user) && !forceSides.Values.Any(s => s.Contains(user)))
                    {
                        forceSides[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = data[0];
                    string side = data[1];
                    if (!forceSides.Values.Any(u => u.Contains(user)))
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var sides in forceSides)
                        {
                            if (sides.Value.Contains(user))
                            {
                                sides.Value.Remove(user);
                            }
                        }

                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }

            forceSides = forceSides.OrderByDescending(u => u.Value.Count).ThenBy(s => s.Key).ToDictionary(s => s.Key, ul => ul.Value);
            foreach (var side in forceSides)
            {
                side.Value.Sort();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join($"\n! ", side.Value));
                }
            }
        }
    }
}
