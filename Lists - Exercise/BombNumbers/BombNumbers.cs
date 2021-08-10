using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bombEffect = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (listInt.Contains(bombEffect[0]))
            {
                int bombIndex = listInt.FindIndex(x => x == bombEffect[0]);
                int leftAoE = bombEffect[1];
                int rightAoE = bombEffect[1];
                if (bombIndex - bombEffect[1] < 0)
                {
                    leftAoE = bombIndex;
                }
                else if (bombIndex + bombEffect[1] >= listInt.Count)
                {
                    rightAoE = listInt.Count - 1 - bombIndex;
                }
                listInt.RemoveRange(bombIndex - leftAoE, leftAoE + rightAoE + 1);

            }
            Console.WriteLine(listInt.Sum());
        }
    }
}
