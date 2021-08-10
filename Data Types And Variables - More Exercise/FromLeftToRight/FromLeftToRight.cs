using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToRight
{
    class FromLeftToRight
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string[] input = Console.ReadLine().Split();
                BigInteger[] numbers = { BigInteger.Parse(input[0]), BigInteger.Parse(input[1]) };

                BigInteger max = BigInteger.Abs(numbers.Max());
                input[1] = max.ToString();
                BigInteger sum = 0;

                foreach (var digit in input[1])
                {
                    sum += (BigInteger)char.GetNumericValue(digit);
                }
                Console.WriteLine(BigInteger.Abs(sum));
            }
        }
    }
}
