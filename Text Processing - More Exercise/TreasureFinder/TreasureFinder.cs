using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class TreasureFinder
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder foundTreasure = new StringBuilder();
            StringBuilder coordinates = new StringBuilder();
            coordinates.Append(Console.ReadLine());
            string temp = string.Empty;
            while (coordinates.ToString() != "find")
            {
                while (coordinates.Length > 0)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        temp += (char) (coordinates[0] - key[i]);
                        coordinates.Remove(0, 1);
                        if (coordinates.Length == 0)
                        {
                            break;
                        }
                    }
                }
                int indexTreasure = temp.IndexOf('&');
                string found = temp.Substring(0, indexTreasure + 1);
                temp = temp.Replace(found, "Found ");
                int indexAt = temp.IndexOf('&');
                int indexCoorStart = temp.IndexOf('<');
                string at = temp.Substring(indexAt, indexCoorStart - indexAt + 1);
                temp = temp.Replace(at, " at ");
                int indexEnd = temp.IndexOf('>');
                temp = temp.Remove(indexEnd, 1);
                foundTreasure.Append(temp);
                foundTreasure.Append('\n');
                coordinates.Append(Console.ReadLine());
            }

            Console.WriteLine(foundTreasure.ToString().TrimEnd('\n'));
        }
    }
}
