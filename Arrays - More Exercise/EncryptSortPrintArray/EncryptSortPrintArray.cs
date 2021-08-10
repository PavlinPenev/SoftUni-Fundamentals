using System;
using System.Linq;

namespace EncryptSortPrintArray
{
    class EncryptSortPrintArray
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] sums = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                string inputString = Console.ReadLine();
                sums[i] = sumVowelsConsonants(inputString);
            }
            Console.WriteLine(string.Join(Environment.NewLine, sums.OrderBy(s=>s)));
        }
        static int sumVowelsConsonants(string text)
        {
            int sum = 0;
            foreach (char element in text)
            {
                if (element == 'a' || element == 'A' || element == 'e' || element == 'E' || element == 'i' || element == 'I' || element == 'u' || element == 'U' || element == 'o' || element == 'O')
                {
                    sum += (int)element * text.Length;
                }
                else
                {
                    sum += (int)element / text.Length;
                }
            }
            return sum;
        }
    }
}
