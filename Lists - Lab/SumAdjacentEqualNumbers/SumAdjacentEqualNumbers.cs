using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> listDec = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < listDec.Count; i++)
            {
                if (i == listDec.Count - 1)
                {
                    continue;
                }
                if (listDec[i] == listDec[i + 1])
                {
                    listDec[i] = listDec[i] + listDec[i + 1];
                    listDec.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", listDec));
        }
    }
}
