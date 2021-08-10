using System;
using System.Linq;

namespace SumEvenNumbers
{
    class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var item in input.Where(n => n % 2 == 0))
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
