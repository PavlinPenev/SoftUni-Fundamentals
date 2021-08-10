using System;
using System.Linq;

namespace PascalsTriangle
{
    class PascalsTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            long[] array = new long[input];
            long[] arrayNew = new long[input];
            long[] print = null;

            array[0] = 1;
            arrayNew[0] = 1;
            Console.WriteLine(1);
            for (int i = 1; i < input; i++)
            {
                for (int j = 1; j < input; j++)
                {

                    arrayNew[j] = array[j] + array[j - 1];

                }

                array = arrayNew.ToArray();
                print = new long[array.Length - array.Count(x => x == 0)];
                for (int j = 0; j < print.Length; j++)
                {
                    print[j] = array[j];
                }
                Console.WriteLine(string.Join(" ", print));
            }
        }
    }
}
