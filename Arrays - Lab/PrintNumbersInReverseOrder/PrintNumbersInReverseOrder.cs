using System;
using System.Linq;

namespace PrintNumbersInReverseOrder
{
    class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] array = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
