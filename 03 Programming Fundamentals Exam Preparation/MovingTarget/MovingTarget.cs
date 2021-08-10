using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class MovingTarget
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] command = input.Split().ToArray();
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);
                switch (command[0])
                {
                    case "Shoot":
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= value;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int start = index - value;
                        int end = index + value;
                        if (start >= 0 && end < targets.Count)
                        {
                            targets.RemoveRange(start, end - start + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
