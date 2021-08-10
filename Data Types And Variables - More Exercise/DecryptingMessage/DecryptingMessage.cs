using System;
using System.Text;

namespace DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sb.Append((char)(input + key));
            }
            Console.WriteLine(sb);
        }
    }
}
