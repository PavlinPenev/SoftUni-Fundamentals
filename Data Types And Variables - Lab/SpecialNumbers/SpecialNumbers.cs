using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int currentDigit = i % 10;
                int previousDigit = (i / 10) % 10;
                Console.WriteLine($"{i} -> {currentDigit + previousDigit == 5 || currentDigit + previousDigit == 7 || currentDigit + previousDigit == 11}");
            }
        }
    }
}
