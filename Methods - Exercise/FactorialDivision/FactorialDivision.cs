using System;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static private double result = 1;
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double factorial = Factorial(n1);
            result = 1;
            double factorial1 = Factorial(n2);

            Console.WriteLine($"{factorial * 1.00 / factorial1:f2}");
        }

        static double Factorial(double x)
        {

            if (x <= 1)
            {
                return result;
            }

            result *= x;
            x--;
            return Factorial(x);
        }
    }
}
