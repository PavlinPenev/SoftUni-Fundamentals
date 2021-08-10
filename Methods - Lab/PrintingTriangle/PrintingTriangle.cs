using System;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintFirstHalf(input);
            PrintSecondHalf(input);
        }

        static void PrintFirstHalf(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        static void PrintSecondHalf(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
