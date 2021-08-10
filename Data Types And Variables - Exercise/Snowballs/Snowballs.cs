using System;
using System.Numerics;

namespace Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            sbyte numberOfSnowBalls = sbyte.Parse(Console.ReadLine());
            BigInteger bestSnowballValue = 0;
            string result = string.Empty;
            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                short snowInSnowball = short.Parse(Console.ReadLine());
                short timeForSnowball = short.Parse(Console.ReadLine());
                byte qualityOfSnowball = byte.Parse(Console.ReadLine());
                if (BigInteger.Pow((snowInSnowball / timeForSnowball), qualityOfSnowball) > bestSnowballValue)
                {
                    bestSnowballValue = (BigInteger.Pow((snowInSnowball / timeForSnowball), qualityOfSnowball));
                    result = $"{snowInSnowball} : {timeForSnowball} = {bestSnowballValue} ({qualityOfSnowball})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
