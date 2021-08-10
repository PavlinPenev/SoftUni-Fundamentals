using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(string.Join("", str.Reverse()));
        }
    }
}
