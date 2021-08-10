using System;

namespace PoundsToDollars
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            decimal converted = (decimal)input * 1.31M;
            Console.WriteLine($"{converted:f3}");
        }
    }
}
