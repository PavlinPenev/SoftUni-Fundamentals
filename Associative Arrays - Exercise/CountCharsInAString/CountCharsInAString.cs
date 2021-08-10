using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class CountCharsInAString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && !charsCount.ContainsKey(text[i]))
                {
                    charsCount.Add(text[i], 1);
                    continue;
                }

                if (text[i] != ' ')
                {
                    charsCount[text[i]]++;
                }
            }

            foreach (var @char in charsCount)
            {
                Console.WriteLine($"{@char.Key} -> {@char.Value}");
            }
        }
    }
}
