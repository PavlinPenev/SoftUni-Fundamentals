using System;

namespace GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            bool hasMoney = true;
            double moneySpent = 0;
            while (hasMoney)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    hasMoney = false;
                    continue;
                }

                switch (game)
                {
                    case "OutFall 4":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            moneySpent += 39.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 39.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    case "CS: OG":
                        if (money >= 15.99)
                        {
                            money -= 15.99;
                            moneySpent += 15.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 15.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    case "Zplinter Zell":
                        if (money >= 19.99)
                        {
                            money -= 19.99;
                            moneySpent += 19.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 19.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    case "Honored 2":
                        if (money >= 59.99)
                        {
                            money -= 59.99;
                            moneySpent += 59.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 59.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    case "RoverWatch":
                        if (money >= 29.99)
                        {
                            money -= 29.99;
                            moneySpent += 29.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 29.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            moneySpent += 39.99;
                            Console.WriteLine($"Bought {game}");
                        }
                        else if (money < 39.99 && money > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            hasMoney = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }
            Console.WriteLine(money > 0 ? $"Total spent: ${moneySpent:f2}. Remaining: ${money:f2}" : "Out of money!");
        }
    }
}
