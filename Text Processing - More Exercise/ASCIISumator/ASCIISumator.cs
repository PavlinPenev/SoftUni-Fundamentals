using System;
using System.Text;

namespace ASCIISumator
{
    class ASCIISumator
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int min = Math.Min(first, second);
            int max = Math.Max(first, second);
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());
            int sum = 0;
            foreach (var @char in input.ToString())
            {
                if (@char > min && @char < max)
                {
                    sum += @char;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
