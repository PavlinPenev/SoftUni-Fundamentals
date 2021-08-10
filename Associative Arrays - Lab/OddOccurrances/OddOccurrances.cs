using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrances
{
    class OddOccurrances
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordsOccurances = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsOccurances.ContainsKey(words[i]))
                {
                    wordsOccurances.Add(words[i], 1);
                    continue;
                }
                wordsOccurances[words[i]]++;
            }

            Console.WriteLine(string.Join(" ", wordsOccurances.Where(v => v.Value % 2 != 0).Select(v => v.Key)));
        }
    }
}
