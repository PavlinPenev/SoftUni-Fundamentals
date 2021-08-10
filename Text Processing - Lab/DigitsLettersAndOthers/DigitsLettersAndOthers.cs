using System;
using System.Text;

namespace DigitsLettersAndOthers
{
    class DigitsLettersAndOthers
    {
        static void Main(string[] args)
        {
            StringBuilder strToFilter = new StringBuilder();
            strToFilter.Append(Console.ReadLine());
            StringBuilder[] charsArrays = {new StringBuilder(), new StringBuilder(), new StringBuilder()};
            foreach (var @char in strToFilter.ToString())
            {
                if (char.IsDigit(@char))
                {
                    charsArrays[0].Append(@char);
                }
                else if (char.IsLetter(@char))
                {
                    charsArrays[1].Append(@char);
                }
                else
                {
                    charsArrays[2].Append(@char);
                }
            }

            foreach (var @string in charsArrays)
            {
                Console.WriteLine(@string);
            }
        }
    }
}
