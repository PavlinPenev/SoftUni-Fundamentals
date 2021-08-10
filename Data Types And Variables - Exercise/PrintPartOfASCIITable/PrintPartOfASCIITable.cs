using System;

namespace PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            for (int i = n; i <= n1; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
