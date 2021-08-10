using System;
using System.Linq;

namespace WordFilter
{
    class WordFilter
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray()));
        }
    }
}
