using System;
using System.Collections.Generic;
using System.Text;

namespace TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            List<int> integers = new List<int>();
            List<char> chars = new List<char>();

            foreach (var character in str)
            {
                if (char.IsDigit(character))
                {
                    integers.Add((int)char.GetNumericValue(character));
                }
                else if (!char.IsDigit(character))
                {
                    chars.Add(character);
                }
            }

            List<int> takes = new List<int>();
            List<int> skips = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takes.Add(integers[i]);
                }
                else
                {
                    skips.Add(integers[i]);
                }
            }

            for (int i = 0; i < takes.Count; i++)
            {
                if (takes[i] > chars.Count)
                {
                    takes[i] = chars.Count;
                }
                sb.Append(string.Join("", chars), 0, takes[i]);
                chars.RemoveRange(0, takes[i]);
                if (skips[i] > chars.Count)
                {
                    skips[i] = chars.Count;
                }
                chars.RemoveRange(0, skips[i]);
            }

            Console.WriteLine(sb);
        }
    }
}
