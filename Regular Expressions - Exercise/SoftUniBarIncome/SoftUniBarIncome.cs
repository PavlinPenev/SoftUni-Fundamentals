using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.0-9]*?<(?<product>\w+)>[^|$%.0-9]*?\|(?<count>\d+)\|[^|$%.0-9]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double sum = 0;
            while (order != "end of shift")
            {
                string name = string.Empty;
                string product = string.Empty;
                int count = 0;
                double price = 0;
                double total = 0;
                MatchCollection matches = Regex.Matches(order, pattern);
                foreach (Match match in matches)
                {
                    name = match.Groups["name"].Value;
                    product = match.Groups["product"].Value;
                    count = int.Parse(match.Groups["count"].Value);
                    price = double.Parse(match.Groups["price"].Value);
                }
                total = price * count;
                sum += total;
                if (Regex.IsMatch(order, pattern))
                {
                    Console.WriteLine($"{name}: {product} - {total:f2}");
                }

                order = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
