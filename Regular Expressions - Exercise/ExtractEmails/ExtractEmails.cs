using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string patternEmail = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*\@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, patternEmail);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
