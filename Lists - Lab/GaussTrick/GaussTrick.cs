using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
            List<int> listNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sumNums = new List<int>();

            for (int i = 0; i < listNums.Count / 2; i++)
            {
                sumNums.Add(listNums[i] + listNums[listNums.Count - 1 - i]);
            }

            if (listNums.Count % 2 != 0)
            {
                sumNums.Add(listNums[listNums.Count / 2]);
            }

            Console.WriteLine(String.Join(" ", sumNums));
        }
    }
}
