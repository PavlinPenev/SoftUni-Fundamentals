using System;

namespace TribonacciSequence
{
    class TribonaciiSequence
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            long[] array = new long[input];
            array = Tribonacci(array);
            Console.WriteLine(string.Join(" ", array));
        }

        static long[] Tribonacci(long[] array)
        {
            if (array.Length <= 3)
            {
                switch (array.Length)
                {
                    case 1:
                        array[0] = 1;
                        break;
                    case 2:
                        array[0] = 1;
                        array[1] = 1;
                        break;
                    case 3:
                        array[0] = 1;
                        array[1] = 1;
                        array[2] = 2;
                        break;
                }
            }
            if (array.Length > 3)
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                for (long i = 3; i < array.Length; i++)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }

            return array;
        }
    }
}
