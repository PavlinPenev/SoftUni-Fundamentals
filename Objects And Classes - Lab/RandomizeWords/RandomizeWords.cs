using System;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                input[i] = input[rnd.Next(0, input.Length - 1)];
                int index = Array.FindIndex(input, x => x == input[i]);
                input[index] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
