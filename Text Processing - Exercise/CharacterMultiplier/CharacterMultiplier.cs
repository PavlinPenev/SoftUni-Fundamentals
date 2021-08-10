using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();
            List<char> shorter = strings[0].Length < strings[1].Length ? strings[0].ToCharArray().ToList() : strings[1].ToCharArray().ToList();
            List<char> longer = strings[0] == strings[1] ? shorter.ToList() : strings.First(s => s != string.Join("", shorter)).ToCharArray().ToList();
            int sum = 0;
            while (shorter.Count != 0)
            {
                sum += shorter[0] * longer[0];
                shorter.Remove(shorter[0]);
                longer.Remove(longer[0]);
            }

            if (longer.Count > 0)
            {
                foreach (var @char in longer)
                {
                    sum += @char;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
