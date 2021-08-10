using System;
using System.Text;

namespace RepeatStrings
{
    class RepeatStrings
    {
        static void Main(string[] args)
        {
            string[] toRepeat = Console.ReadLine().Split();
            StringBuilder finalString = new StringBuilder();
            foreach (var word in toRepeat)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    finalString.Append(word);
                }
            }

            Console.WriteLine(finalString);
        }
    }
}
