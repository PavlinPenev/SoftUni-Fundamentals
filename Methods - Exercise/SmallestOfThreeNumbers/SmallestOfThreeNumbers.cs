using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            PrintSmallest(n1, n2, n3);
        }

        static void PrintSmallest(int a, int b, int c)
        {
            int[] array = { a, b, c };
            Console.WriteLine(array.Min());
        }
    }
}
