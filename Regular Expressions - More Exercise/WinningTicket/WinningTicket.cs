using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string patternTicket = @"([\$#\@\^])\1{5,9}";
            foreach (var ticket in tickets)
            {
                
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string left = ticket.Substring(0, 10);
                string right = ticket.Substring(10, 10);
                Match leftCollection = Regex.Match(left, patternTicket);
                Match rightCollection = Regex.Match(right, patternTicket);
                int minLen = Math.Min(leftCollection.Length, rightCollection.Length);
                if (!leftCollection.Success || !rightCollection.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                string leftMatch = leftCollection.Value.Substring(0,minLen);
                string rightMatch = rightCollection.Value.Substring(0,minLen);

                if (leftMatch.Length >= 6 && leftMatch.Length <= 10 && leftMatch.Equals(rightMatch))
                {
                    Console.WriteLine(leftMatch.Length >= 6 && leftMatch.Length <= 9 ? $"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch[0]}" : $"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch[0]} Jackpot!");
                }
            }
        }
    }
}
