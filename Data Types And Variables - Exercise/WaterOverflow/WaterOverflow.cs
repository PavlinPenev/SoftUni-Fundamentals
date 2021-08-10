using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int volumeOfTank = 255;
            int pouredWater = 0;

            for (int i = 0; i < n; i++)
            {
                int pourWater = int.Parse(Console.ReadLine());
                if (volumeOfTank < pourWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                volumeOfTank -= pourWater;
                pouredWater += pourWater;
            }
            Console.WriteLine(pouredWater);
        }
    }
}
