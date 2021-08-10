using System;

namespace MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string text)
        {
            Console.WriteLine(text.Length % 2 == 0 ? $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}" : text[text.Length / 2]);
        }
    }
}
