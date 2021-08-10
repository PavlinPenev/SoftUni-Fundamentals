using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divisor = 0;
            bool isDivisible = false;
            if (number % 10 == 0)
            {
                divisor = 10;
                isDivisible = true;
            }
            else if (number % 7 == 0)
            {
                divisor = 7; 
                isDivisible = true;    
            }
            else if (number % 6 == 0)
            {
                divisor = 6;
                isDivisible = true;
            }
            else if (number % 3 == 0)
            {
                divisor = 3;
                isDivisible = true;
            }
            else if (number % 2 == 0)
            {
                divisor = 2;
                isDivisible = true;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {divisor}");
            }
        }
    }
}
