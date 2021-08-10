using System;

namespace NxNMatrix
{
    class NxNMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
