using System;
using System.Linq;

namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(isEqual(input));
                input = Console.ReadLine();
            }
        }
        static string isEqual(string text)
        {
            string reversed = string.Join("", text.Reverse());
            if (text == reversed)
            {
                return "true";
            }

            return "false";
        }
    }
}
