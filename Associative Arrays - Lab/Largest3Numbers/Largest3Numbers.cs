using System;
using System.Linq;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).OrderByDescending(i => i).Take(3).ToArray()));
        }
    }
}
