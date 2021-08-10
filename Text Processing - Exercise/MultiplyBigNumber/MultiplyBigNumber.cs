using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            BigInteger bigNum = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine(bigNum * multiplier);
        }
    }
}
