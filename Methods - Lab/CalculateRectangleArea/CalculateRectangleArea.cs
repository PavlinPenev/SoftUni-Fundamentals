using System;

namespace CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(width, height));
        }

        static double RectangleArea(double w, double h)
        {
            return w * h;
        }
    }
}
