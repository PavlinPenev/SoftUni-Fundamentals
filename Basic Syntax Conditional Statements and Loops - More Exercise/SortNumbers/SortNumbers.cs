using System;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double[] values = { x, y, z };
            Array.Sort(values);
            Array.Reverse(values);

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
