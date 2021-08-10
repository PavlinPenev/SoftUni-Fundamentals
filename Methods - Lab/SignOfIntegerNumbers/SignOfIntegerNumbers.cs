using System;

namespace SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Print(input);
        }

        static void Print(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
                return;
            }
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
                return;
            }
            Console.WriteLine($"The number {n} is negative.");
        }
    }
}
