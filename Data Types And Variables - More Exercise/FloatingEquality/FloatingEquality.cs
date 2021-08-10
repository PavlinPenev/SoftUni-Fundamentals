using System;

namespace FloatingEquality
{
    class FloatingEquality
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal n1 = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001M;

            decimal diffInNumbers = Math.Abs(n1 - n);
            Console.WriteLine(diffInNumbers < eps);
        }
    }
}
