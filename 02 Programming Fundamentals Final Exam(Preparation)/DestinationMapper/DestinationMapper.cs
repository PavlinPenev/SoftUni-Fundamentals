using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class DestinationMapper
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])([A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            MatchCollection places = Regex.Matches(input, pattern);
            Console.WriteLine($"Destinations: {string.Join(", ", places.Select(g => g.Groups[2].Value))}");
            Console.WriteLine($"Travel Points: {string.Join("", places.Select(g => g.Groups[2].Value)).Length}");
        }
    }
}
