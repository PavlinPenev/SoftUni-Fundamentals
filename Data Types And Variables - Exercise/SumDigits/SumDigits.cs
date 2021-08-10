using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)char.GetNumericValue(digit);
            }
            Console.WriteLine(sum);
        }
    }
}
