using System;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentDigit = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= number; i++)
            {
                currentDigit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = ((sum == 5) || (sum == 7) || (sum == 11));
                Console.WriteLine("{0} -> {1}", currentDigit, isSpecialNumber);
                sum = 0;
                i = currentDigit;
            }
        }
    }
}
