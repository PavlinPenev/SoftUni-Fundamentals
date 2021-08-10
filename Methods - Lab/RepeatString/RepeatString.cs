using System;

namespace RepeatString
{
    class RepeatString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStr(input, count));
        }

        static string RepeatStr(string text, int c)
        {
            string newString = string.Empty;
            for (int i = 0; i < c; i++)
            {
                newString += text;
            }

            return newString;
        }
    }
}
