using System;
using System.Numerics;

namespace SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            BigInteger yieldExtracted = 0;
            BigInteger yieldExctractedDaily = 0;
            int days = 0;
            while (startingYield >= 100)
            {
                yieldExctractedDaily = startingYield;
                yieldExtracted += yieldExctractedDaily;
                startingYield -= 10;
                if (yieldExtracted >= 26)
                {
                    yieldExtracted -= 26;
                }

                days++;
            }

            if (yieldExtracted >= 26)
            {
                yieldExtracted -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(yieldExtracted);
        }
    }
}
