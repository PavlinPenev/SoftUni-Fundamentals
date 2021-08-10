using System;
using System.Text;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char divMult = input[i][0];
                char addSub = input[i][input[i].Length - 1];
                input[i] = input[i].Remove(0, 1);
                input[i] = input[i].Remove(input[i].Length - 1, 1);
                double number = double.Parse(input[i]);
                if (char.IsUpper(divMult))
                {
                    number /= divMult - 64;
                }
                else if (char.IsLower(divMult))
                {
                    number *= divMult - 96;
                }

                if (char.IsUpper(addSub))
                {
                    number -= addSub - 64;
                }
                else if (char.IsLower(addSub))
                {
                    number += addSub - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{Math.Round(sum, 2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}
