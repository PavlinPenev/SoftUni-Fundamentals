using System;

namespace EvenNumber
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int input = 0;
            while (!flag)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0 || input % 2 == 1 || input % 2 == -1)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    flag = true;
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(input)}");
        }
    }
}
