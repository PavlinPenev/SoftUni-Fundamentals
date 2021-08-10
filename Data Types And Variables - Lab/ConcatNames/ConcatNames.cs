using System;

namespace ConcatNames
{
    class ConcatNames
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine($"{a}{c}{b}");
        }
    }
}
