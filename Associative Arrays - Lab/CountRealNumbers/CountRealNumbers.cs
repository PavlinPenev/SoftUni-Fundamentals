using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> numbersOccurances = new SortedDictionary<int, int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (!numbersOccurances.ContainsKey(integers[i]))
                {
                    numbersOccurances.Add(integers[i], 1);
                    continue;
                }

                numbersOccurances[integers[i]]++;
            }

            foreach (var number in numbersOccurances)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
