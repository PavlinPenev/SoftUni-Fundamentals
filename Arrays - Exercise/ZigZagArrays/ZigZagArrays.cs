using System;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int[] numbers1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                numbers[i] = i % 2 == 0 ? int.Parse(input[0]) : int.Parse(input[1]);
                numbers1[i] = i % 2 == 0 ? int.Parse(input[1]) : int.Parse(input[0]);
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", numbers1));
        }
    }
}
