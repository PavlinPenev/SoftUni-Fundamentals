using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class ListOfProducts
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < input; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
