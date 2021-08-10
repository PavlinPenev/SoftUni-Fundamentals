using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        list.Add(int.Parse(action[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(action[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(action[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
