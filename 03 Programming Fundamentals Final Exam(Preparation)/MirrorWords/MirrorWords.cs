using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class MirrorWords
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            MatchCollection mirrorWords = Regex.Matches(input, pattern);
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{mirrorWords.Count} word pairs found!");
            }

            List<string> mirrors = new List<string>();
            foreach (Match match in mirrorWords)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string wordTwo = match.Groups["wordTwo"].Value;
                wordTwo = string.Join("", wordTwo.ToCharArray().Reverse());
                if (wordTwo == wordOne)
                {
                    wordOne += " <=> " + string.Join("", wordTwo.ToCharArray().Reverse());
                    mirrors.Add(wordOne);
                }
            }

            if (mirrors.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
            }
        }
    }
}
