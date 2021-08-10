using System;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            
            
            double sum = 0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                double inputDouble = double.Parse(input);
                if (inputDouble != 0.1 && inputDouble != 0.2 && inputDouble != 0.5 && inputDouble != 1 && inputDouble != 2)
                {
                    Console.WriteLine($"Cannot accept {inputDouble}");
                }
                else
                {
                    sum += inputDouble;
                }
                input = Console.ReadLine();
            }
            double price = 0;
            string product = string.Empty;
            string input2 = Console.ReadLine().ToLower();
            while (input2 != "end")
            {
                switch (input2)
                {
                    case "nuts":
                        price = 2;
                        product = input2;
                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "water":
                        price = 0.7;
                        product = input2;
                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps":
                        price = 1.5;
                        product = input2;
                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda":
                        price = 0.8;
                        product = input2;
                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke":
                        price = 1;
                        product = input2;
                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input2 = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
