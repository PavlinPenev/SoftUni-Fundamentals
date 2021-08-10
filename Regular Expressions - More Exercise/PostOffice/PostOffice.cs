using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class PostOffice
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            string patternCapitals = @"([#$%*&])(?<capitals>[A-Z]+)\1";
            Match capitalsMatch = Regex.Match(input[0], patternCapitals);
            Dictionary<char, int> capitalDictionary = new Dictionary<char, int>();
            string capitals = capitalsMatch.Groups["capitals"].Value;
            for (int i = 0; i < capitals.Length; i++)
            {
                char capitalLetter = capitals[i];
                int ascii = capitalLetter;
                string patternWordLength = $@"{ascii}:(?<length>[0-9][0-9])";
                Match wordLengthMatch = Regex.Match(input[1], patternWordLength);
                int length = int.Parse(wordLengthMatch.Groups["length"].Value) >= 20 ? 
                    int.Parse(wordLengthMatch.NextMatch().Groups["length"].Value) : int.Parse(wordLengthMatch.Groups["length"].Value);
                string patternWords = $@"(?<=\s|^){capitalLetter}[^\s]{{{length}}}(?=\s|$)";
                Match word = Regex.Match(input[2], patternWords);
                string strWord = word.ToString();
                Console.WriteLine(strWord);
            }
        } 
    }
}
