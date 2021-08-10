using System;

namespace ComputerStore
{
    class ComputerStore
    {
        static void Main(string[] args)
        {
            double price = 0;
            string price1 = string.Empty;
            while (true)
            {
                price1 = Console.ReadLine();
                if (price1 == "special" || price1 == "regular")
                {
                    break;
                }

                double price11 = double.Parse(price1);
                if (price11 < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                price += price11;

            }

            double priceNoTax = price;
            price *= 1.20;
            double taxes = price - priceNoTax;
            if (price1 == "special")
            {
                price *= 0.90;
            }

            if (price == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!{Environment.NewLine}Price without taxes: {priceNoTax:f2}${Environment.NewLine}Taxes: {taxes:f2}${Environment.NewLine}-----------{Environment.NewLine}Total price: {price:f2}$");
            }
        }
    }
}
