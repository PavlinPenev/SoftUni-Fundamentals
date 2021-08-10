using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();
            int[] inputInts = Array.ConvertAll(inputChar, c => (int)char.GetNumericValue(c));
            int lengthCounter = input.Length - 1;
            int sum = 0;

            while (lengthCounter >= 0)
            {
                int factorial = 1;

                for (int i = 1; i <= inputInts[lengthCounter]; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                lengthCounter--;
            }
            Console.WriteLine(sum == int.Parse(input) ? "yes" : "no");
        }
    }
}
