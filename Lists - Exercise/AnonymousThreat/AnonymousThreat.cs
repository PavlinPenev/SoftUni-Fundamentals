using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] action = command.Split();
                switch (action[0])
                {
                    case "merge":
                        Merge(int.Parse(action[1]), int.Parse(action[2]), list);
                        break;
                    case "divide":
                        Divide(int.Parse(action[1]), int.Parse(action[2]), list);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static void Merge(int startIndex, int endIndex, List<string> list)
        {
            if (startIndex < 0 && endIndex < 0 || startIndex >= list.Count && endIndex >= list.Count)
            {
                return;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex > list.Count - 1)
            {
                endIndex = list.Count - 1;
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                list[startIndex] += list[i];
            }

            list.RemoveRange(startIndex + 1, endIndex - startIndex);
        }

        static void Divide(int index, int partitions, List<string> list)
        {

            int partitionLength = list[index].Length / partitions;
            if (list[index].Length < partitions)
            {
                return;
            }
            string temp = string.Empty;
            for (int i = 0; i < partitions; i++)
            {
                temp += list[index].Substring(0, partitionLength) + " ";
                list[index] = list[index].Remove(0, partitionLength);
            }
            temp = temp.TrimEnd();
            temp += list[index];
            temp = temp.TrimEnd();
            list.RemoveAt(index);
            list.InsertRange(index, temp.Split().ToList());
        }
    }
}
