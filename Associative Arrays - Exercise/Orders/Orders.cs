using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            List<string> stockUpProducts = Console.ReadLine().Split().ToList();
            while (stockUpProducts[0] != "buy")
            {
                string product = stockUpProducts[0];
                int quantity = int.Parse(stockUpProducts[2]);
                double price = double.Parse(stockUpProducts[1]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                    stockUpProducts = Console.ReadLine().Split().ToList();
                    continue;
                }

                products[product][0] = price;
                products[product][1] += quantity;
                stockUpProducts = Console.ReadLine().Split().ToList();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
