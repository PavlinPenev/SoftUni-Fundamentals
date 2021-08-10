using System;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lengthFolded = inputArray.Length / 4;
            int[] firstElements = new int[lengthFolded];

            int[] arrayFolded = new int[lengthFolded * 2];
            int[] summedArray = new int[arrayFolded.Length];

            for (int i = 0; i < lengthFolded; i++)
            {
                firstElements[i] = inputArray[i];
            }

            Array.Reverse(firstElements);
            for (int i = 0; i < lengthFolded; i++)
            {
                arrayFolded[i] = firstElements[i];
            }

            for (int j = 0; j < arrayFolded.Length / 2; j++)
            {
                arrayFolded[arrayFolded.Length / 2 + j] = inputArray[inputArray.Length - 1 - j];
            }

            for (int j = 0; j < lengthFolded; j++)
            {
                for (int i = 0; i <= lengthFolded + arrayFolded.Length; i++)
                {
                    if (i == lengthFolded + arrayFolded.Length)
                    {
                        break;
                    }
                    inputArray[i] = inputArray[i + 1];
                }
            }
            for (int i = 0; i < arrayFolded.Length; i++)
            {
                summedArray[i] = arrayFolded[i] + inputArray[i];
            }

            Console.WriteLine(string.Join(" ", summedArray));
        }
    }
}
