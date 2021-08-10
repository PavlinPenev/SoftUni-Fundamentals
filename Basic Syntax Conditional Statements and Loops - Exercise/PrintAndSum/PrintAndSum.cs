using System;

namespace PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine($"{Environment.NewLine}Sum: {sum}");
        }
    }
}
