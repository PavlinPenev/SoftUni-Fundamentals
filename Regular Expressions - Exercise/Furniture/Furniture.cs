using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            List<string> orders = new List<string>();
            string order = Console.ReadLine();
            double sum = 0;

            while (order != "Purchase")
            {
                orders.Add(order);
                order = Console.ReadLine();
            }

            string pattern = @"\>*(?<furniture>\w+)\<*(?<price>[0-9.]+|[0-9]+)!(?<quantity>\d+)";
            MatchCollection matchedOrders = Regex.Matches(string.Join(" ", orders), pattern);
            Console.WriteLine("Bought furniture:");
            foreach (Match orderID in matchedOrders)
            {
                double price = double.Parse(orderID.Groups["price"].Value);
                int quantity = int.Parse(orderID.Groups["quantity"].Value);
                string furniture = orderID.Groups["furniture"].Value;
                sum += price * quantity;
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
