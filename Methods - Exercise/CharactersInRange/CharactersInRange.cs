using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            PrintCharsBetween(char1, char2);
        }

        static void PrintCharsBetween(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
    }
}
