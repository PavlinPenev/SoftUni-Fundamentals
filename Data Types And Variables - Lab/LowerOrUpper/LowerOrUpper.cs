using System;

namespace LowerOrUpper
{
    class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol > 64 && symbol < 91)
            {
                Console.WriteLine("upper-case");
            }
            else if (symbol > 96 && symbol < 123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
