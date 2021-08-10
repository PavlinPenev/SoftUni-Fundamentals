using System;

namespace EqualArrays
{
    class EqualArrays
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] input1 = Console.ReadLine().Split();
            int sum = 0;
            bool notIdentical = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (notIdentical)
                {
                    break;
                }
                if (input[i] == input1[i])
                {
                    sum += int.Parse(input[i]);
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    notIdentical = true;
                }
            }
            if (!notIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
