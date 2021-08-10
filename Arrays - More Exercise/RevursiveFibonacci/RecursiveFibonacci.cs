using System;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        private static long[] arrayFibonacci;
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            arrayFibonacci = new long[n + 1];
            GetFibonacci(n);


            Console.WriteLine(arrayFibonacci[n]);
            static long GetFibonacci(long index)
            {
                if (arrayFibonacci[index] != 0)
                {
                    return arrayFibonacci[index];
                }
                if (index <= 2)
                {
                    arrayFibonacci[index] = 1;
                    return arrayFibonacci[index];
                }
                arrayFibonacci[index] = GetFibonacci(index - 1) + GetFibonacci(index - 2);
                return arrayFibonacci[index];
            }
        }
    }
}
