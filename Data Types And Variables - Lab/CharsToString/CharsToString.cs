using System;

namespace CharsToString
{
    class CharsToString
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{a}{b}{c}");
        }
    }
}
