using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class EmojiDetector
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex emojiRegex = new Regex(@"([:*])\1(?<emoji>[A-Z][a-z]{2,})\1{2}");
            Regex coolThresholdRegex = new Regex(@"\d");
            MatchCollection coolThresholdMatches = coolThresholdRegex.Matches(input);
            long coolThreshold = 1;
            foreach (Match coolThresholdMatch in coolThresholdMatches)
            {
                coolThreshold *= int.Parse(coolThresholdMatch.ToString());
            }

            MatchCollection emojiMatches = emojiRegex.Matches(input);
            List<string> coolEmojis = new List<string>();
            foreach (Match emoji in emojiMatches)
            {
                string currentEmoji = emoji.Groups["emoji"].Value;
                int emojiThreshold = 0;
                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    emojiThreshold += currentEmoji[i];
                }

                if (emojiThreshold > coolThreshold)
                {
                    coolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
            if (coolEmojis.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
            }
        }
    }
}
