using System;

namespace Orders
{
    class Orders
    {
        static void Main()
        {
            string product = Console.ReadLine();
            //coffee – 1.50
            //water – 1.00
            //coke – 1.40
            //snacks – 2.00
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TotalPrice(product, quantity):f2}");
        }

        static double TotalPrice(string text, int number)
        {
            double price = 0;
            switch (text)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            return price * number;
        }
    }
}
