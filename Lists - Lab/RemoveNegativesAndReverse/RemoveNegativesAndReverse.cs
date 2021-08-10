using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.RemoveAll(x => x < 0);
            list.Reverse();

            Console.WriteLine(list.Count == 0 ? "empty" : string.Join(" ", list));
        }
    }
}
