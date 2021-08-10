using System;

namespace MultiplicationTableV2
{
    class MultiplicationTableV2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
                return;
            }

            for (int i = n; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
