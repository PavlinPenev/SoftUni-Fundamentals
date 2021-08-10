using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> listNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listNums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int decider = Math.Min(listNums.Count, listNums1.Count);
            int restValues = Math.Max(listNums.Count, listNums1.Count);
            for (int i = 0; i < decider; i++)
            {
                result.Add(listNums[i]);
                result.Add(listNums1[i]);
            }

            if (listNums.Count != listNums1.Count)
            {
                for (int i = decider; i < restValues; i++)
                {
                    result.Add(listNums.Count >= listNums1.Count ? listNums[i] : listNums1[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
