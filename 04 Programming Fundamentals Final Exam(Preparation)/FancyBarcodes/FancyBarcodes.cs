using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class FancyBarcodes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            for (int i = 0; i < n; i++)
            {
                string productGroup = string.Empty;
                string input = Console.ReadLine();
                Match barcodes = Regex.Match(input, pattern);
                string digitPattern = @"\d";
                if (!barcodes.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                MatchCollection digits = Regex.Matches(barcodes.ToString(), digitPattern);
                if (!digits.Any())
                {
                    productGroup = "00";
                }
                else
                {
                    foreach (Match digit in digits)
                    {
                        productGroup += digit.ToString();
                    }
                }
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
