﻿using System;

namespace SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * 2 - 1);
                sum += i * 2 - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
