using System;

namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPow(number, power));
        }

        static double MathPow(double n, int p)
        {
            double powerNumber = n;
            for (int i = 1; i < p; i++)
            {
                powerNumber *= n;
            }

            return powerNumber;
        }
    }
}
