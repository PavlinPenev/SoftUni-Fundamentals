using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Race
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racerDistance = new Dictionary<string, int>();
            string pattern = @"[A-Z]|[a-z]";
            string pattern1 = @"[0-9]";
            List<string> competitors = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection names = Regex.Matches(input, pattern);
                MatchCollection distance1 = Regex.Matches(input, pattern1);
                string name = string.Join("", names);
                int distance = 0;
                foreach (Match match in distance1)
                {
                    distance += int.Parse(match.Value);
                }
                if (!racerDistance.ContainsKey(name) && competitors.Contains(name))
                {
                    racerDistance.Add(name,0);
                }

                if (competitors.Contains(name))
                {
                    racerDistance[name] += distance;
                }
                input = Console.ReadLine();
            }

            racerDistance = racerDistance.OrderByDescending(r => r.Value).Take(3).ToDictionary(k=>k.Key, v => v.Value);
            Console.WriteLine($"1st place: {racerDistance.First().Key}");
            racerDistance.Remove(racerDistance.First().Key);
            Console.WriteLine($"2nd place: {racerDistance.First().Key}");
            racerDistance.Remove(racerDistance.First().Key);
            Console.WriteLine($"3rd place: {racerDistance.First().Key}");
        }
    }
}
