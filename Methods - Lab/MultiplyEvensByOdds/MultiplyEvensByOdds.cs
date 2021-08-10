using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            int oddSum = GetSumOdds(input);
            int evenSum = GetSumEvens(input);
            Console.WriteLine(MultiplyEO(oddSum, evenSum));

        }

        static int GetSumEvens(int n)
        {
            string inputArray = n.ToString();
            int sumEven = 0;
            foreach (var digit in inputArray)
            {
                if (digit % 2 == 0)
                {
                    sumEven += (int)char.GetNumericValue(digit);
                }
            }

            return sumEven;
        }

        static int GetSumOdds(int n)
        {
            string inputArray = n.ToString();
            int sumOdds = 0;
            foreach (var digit in inputArray)
            {
                if (digit % 2 != 0)
                {
                    sumOdds += (int)char.GetNumericValue(digit);
                }
            }

            return sumOdds;
        }

        static int MultiplyEO(int n, int n1)
        {
            int result = n * n1;
            return result;
        }
    }
}
