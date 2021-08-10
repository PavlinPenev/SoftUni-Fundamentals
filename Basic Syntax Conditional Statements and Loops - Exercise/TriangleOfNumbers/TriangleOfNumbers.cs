using System;

namespace TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int u = 1; u <= i; u++)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n");
            }
        }
    }
}
