using System;
using System.Linq;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] array = { a, b, c };
            Console.WriteLine(NegativePositiveZero(array));
        }

        static string NegativePositiveZero(int[] array)
        {
            string result = string.Empty;

            if (array.Any(x => x == 0))
            {
                result = "zero";
            }
            else if (array.All(x => x > 0))
            {
                result = "positive";
            }
            else if (array.Count(x => x < 0) == 1 || array.Count(x => x < 0) == 3)
            {
                result = "negative";
            }
            else if (array.Count(x => x < 0) == 2)
            {
                result = "positive";
            }

            return result;
        }
    }
}
