using System;
using System.Linq;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long leftSum = 0;
            long rightSum = 0;
            bool isPrinted = false;
            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (j > i)
                    {
                        rightSum += input[j];
                    }
                    else if (j == i)
                    {
                        continue;
                    }
                    else if (j < i)
                    {
                        leftSum += input[j];
                    }



                }
                if (rightSum == leftSum && input.Length > 2)
                {
                    Console.WriteLine(i);
                    isPrinted = true;
                    break;
                }
            }
            if (rightSum != leftSum && isPrinted == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
