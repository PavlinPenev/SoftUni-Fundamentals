using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"([@*])(?<tag>[A-Z][a-z]{2,})\1: \[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$";
            for (int i = 0; i < n; i++)
            {
                string validation = Console.ReadLine();
                Match valid = Regex.Match(validation, pattern);
                if (!valid.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string tag = valid.Groups["tag"].Value;
                int first = char.Parse(valid.Groups[2].Value);
                int second = char.Parse(valid.Groups[3].Value);
                int third = char.Parse(valid.Groups[4].Value);
                Console.WriteLine($"{tag}: {first} {second} {third}");
            }
        }
    }
}
