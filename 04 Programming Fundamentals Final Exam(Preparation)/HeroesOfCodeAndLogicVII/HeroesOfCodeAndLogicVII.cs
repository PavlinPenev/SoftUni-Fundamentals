using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class HeroesOfCodeAndLogicVII
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            string name = string.Empty;
            int HP = 0;
            int MP = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                name = input[0];
                HP = int.Parse(input[1]);
                MP = int.Parse(input[2]);

                heroes.Add(name, new int[] { HP, MP });

            }

            string[] line = Console.ReadLine()
             .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

            string command = string.Empty;
            string rivale = string.Empty;
            int amount = 0;
            while (line[0] != "End")
            {
                command = line[0].ToLower();

                name = line[1];

                switch (command)
                {
                    case "castspell":

                        MP = int.Parse(line[2]);
                        rivale = line[3];

                        if (heroes[name][1] >= MP)
                        {
                            heroes[name][1] -= MP;

                            Console.WriteLine($"{name} has successfully cast {rivale} and now has {heroes[name][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {rivale}!");
                        }
                        break;


                    case "takedamage":

                        int damage = int.Parse(line[2]);
                        rivale = line[3];

                        heroes[name][0] -= damage;

                        if (heroes[name][0] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {rivale} and now has {heroes[name][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {rivale}!");
                            heroes.Remove(name);
                        }
                        break;


                    case "heal":

                        amount = int.Parse(line[2]);

                        if (heroes[name][0] + amount > 100)
                        {
                            int healedPoints = 100 - heroes[name][0];
                            Console.WriteLine($"{name} healed for {healedPoints} HP!");

                            heroes[name][0] = 100;
                        }
                        else
                        {
                            Console.WriteLine($"{name} healed for {amount} HP!");
                            heroes[name][0] += amount;
                        }
                        break;

                    case "recharge":
                        amount = int.Parse(line[2]);

                        if (heroes[name][1] + amount > 200)
                        {
                            int points = 200 - heroes[name][1];
                            heroes[name][1] = 200;
                            Console.WriteLine($"{name} recharged for {points} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} recharged for {amount} MP!");
                            heroes[name][1] += amount;
                        }
                        break;
                }
                line = Console.ReadLine()
                        .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
            }

            heroes = heroes.OrderByDescending(n => n.Value[0])
                .ThenBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in heroes)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}