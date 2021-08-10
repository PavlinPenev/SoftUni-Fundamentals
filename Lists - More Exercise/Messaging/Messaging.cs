using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Messaging
    {
        static void Main(string[] args)
        {
            List<int> encryptedInts = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (var integer in encryptedInts)
            {
                string intStr = integer.ToString();
                int index = 0;
                for (int i = 0; i < intStr.Length; i++)
                {
                    index += (int)char.GetNumericValue(intStr[i]);
                }

                if (index >= message.Length)
                {
                    while (index >= message.Length)
                    {
                        index = index - message.Length;
                    }
                }

                sb.Append(message[index]);
                message = message.Remove(index, 1);
            }

            Console.WriteLine(sb);
        }
    }
}
