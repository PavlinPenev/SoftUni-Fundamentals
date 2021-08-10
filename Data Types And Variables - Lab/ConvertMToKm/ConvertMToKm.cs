using System;

namespace ConvertMToKm
{
    class ConvertMToKm
    {
        static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());
            decimal converted = (decimal)input / 1000;
            Console.WriteLine($"{converted:f2}");
        }
    }
}
