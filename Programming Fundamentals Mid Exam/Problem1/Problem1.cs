using System;

namespace Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int biscuitesPerWorkerDaily = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int biscuitsMonthlyFactory2 = int.Parse(Console.ReadLine());

            double biscuitsMonthly = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i >= 3)
                {
                    biscuitsMonthly += Math.Floor((biscuitesPerWorkerDaily * workersCount) * 0.75);
                    continue;
                }

                biscuitsMonthly += biscuitesPerWorkerDaily * workersCount;
            }

            Console.WriteLine($"You have produced {biscuitsMonthly} biscuits for the past month.");
            double differenceBiscuits = Math.Abs(biscuitsMonthly - biscuitsMonthlyFactory2);
            Console.WriteLine(biscuitsMonthly > biscuitsMonthlyFactory2 ? $"You produce {differenceBiscuits / biscuitsMonthlyFactory2 * 100:f2} percent more biscuits." : $"You produce {differenceBiscuits / biscuitsMonthlyFactory2 * 100:f2} percent less biscuits.");
        }
    }
}
