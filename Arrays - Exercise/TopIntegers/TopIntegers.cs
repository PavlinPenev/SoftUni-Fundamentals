using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = false;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    if (arrayInput[i] > arrayInput[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (i == arrayInput.Length - 1)
                {
                    isBigger = true;
                }
                if (isBigger)
                {
                    Console.Write(arrayInput[i] + " ");
                }
            }
        }
    }
}
