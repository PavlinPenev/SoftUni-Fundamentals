using System;

namespace Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string input = Console.ReadLine();
                int digit = (int)char.GetNumericValue(input[input.Length - 1]);
                int offset = 0;
                char print = '\0';
                if (digit == 2 || digit == 3 || digit == 4 || digit == 5 || digit == 6 || digit == 7)
                {
                    offset = (digit - 2) * 3;
                    print = (char)(offset + (input.Length - 1) + 97);
                }
                else if (digit == 9 || digit == 8)
                {
                    offset = ((digit - 2) * 3) + 1;
                    print = (char)(offset + (input.Length - 1) + 97);
                }
                else if (digit == 0)
                {
                    print = ' ';
                }
                Console.Write(print);
            }
        }
    }
}
