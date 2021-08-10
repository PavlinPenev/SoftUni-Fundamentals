using System;

namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            string[] arrayInput = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            string tempNumber = string.Empty;

            for (int i = 0; i < n; i++)
            {
                tempNumber = arrayInput[0];
                for (int j = 0; j < arrayInput.Length - 1; j++)
                {
                    arrayInput[j] = arrayInput[j + 1];
                }

                arrayInput[arrayInput.Length - 1] = tempNumber;
            }

            Console.WriteLine(string.Join(" ", arrayInput));
        }
    }
}
