using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (sumDividesEight(i) && hasOneOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool sumDividesEight(int x)
        {
            string number = x.ToString();
            double sum = 0;
            foreach (var VARIABLE in number)
            {
                sum += (int)char.GetNumericValue(VARIABLE);
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool hasOneOdd(int x)
        {
            string number = x.ToString();
            foreach (var VARIABLE in number)
            {
                if ((int)char.GetNumericValue(VARIABLE) % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
