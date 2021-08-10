using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class MixedUpLists
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            while (numbers2.Count > 0 && numbers1.Count > 0)
            {
                result.Add(numbers1[0]);
                numbers1.RemoveAt(0);
                result.Add(numbers2[numbers2.Count - 1]);
                numbers2.RemoveAt(numbers2.Count - 1);

            }

            if (numbers1.Count > 0)
            {
                numbers1.Sort();
                result.Sort();
                Console.WriteLine(string.Join(" ", result.FindAll(x => x > numbers1[0] && x < numbers1[1])));
            }
            else
            {
                numbers2.Sort();
                result.Sort();
                Console.WriteLine(string.Join(" ", result.FindAll(x => x > numbers2[0] && x < numbers2[1])));
            }
        }
    }
}
