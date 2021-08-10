using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            double input3 = double.Parse(Console.ReadLine());
            PrintClosestToCenter(input, input1, input2, input3);
        }

        static void PrintClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double distance2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            Console.WriteLine(distance1 < distance2 ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }
    }
}
