using System;
using System.Linq;
using System.Text;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            StringBuilder toReverse1 = new StringBuilder();
            toReverse1.Append(Console.ReadLine());
            while (toReverse1.ToString() != "end")
            {
                string temp1 = toReverse1.ToString();
                toReverse1.Clear().Append(string.Join("", temp1.Reverse()));
                Console.WriteLine($"{temp1} = {toReverse1}");
                toReverse1.Clear().Append(Console.ReadLine());
            }
        }
    }
}
