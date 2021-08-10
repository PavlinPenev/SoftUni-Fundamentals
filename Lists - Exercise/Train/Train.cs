using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string add = Console.ReadLine();
            while (add != "end")
            {
                string[] command = add.Split();
                switch (command[0])
                {
                    case "Add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        int indexOfElement = train.FindIndex(x => x + int.Parse(command[0]) <= maxCapacity);
                        if (indexOfElement == -1)
                        {
                            continue;
                        }
                        train[indexOfElement] += int.Parse(command[0]);
                        break;
                }
                add = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
