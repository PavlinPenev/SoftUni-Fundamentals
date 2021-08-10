using System;
using System.Collections.Generic;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] input1 = Console.ReadLine().Split();
            List<string> stringsList = new List<string>();

            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == input1[i])
                    {
                        stringsList.Add(input[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", stringsList));
        }
    }
}
