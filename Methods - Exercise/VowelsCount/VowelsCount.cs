using System;
using System.Linq;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            VowelCount(input);
        }

        static void VowelCount(string text)
        {
            Console.WriteLine(text.Where(symbol=> symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u').Count());
        }
    }
}
