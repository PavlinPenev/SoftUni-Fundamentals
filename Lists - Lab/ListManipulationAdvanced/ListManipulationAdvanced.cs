using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalList = list.ToList();
            
            bool changesMade = false;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        finalList.Add(int.Parse(action[1]));
                        changesMade = true;
                        break;
                    case "Remove":
                        finalList.Remove(int.Parse(action[1]));
                        changesMade = true;
                        break;
                    case "RemoveAt":
                        finalList.RemoveAt(int.Parse(action[1]));
                        changesMade = true;
                        break;
                    case "Insert":
                        finalList.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        changesMade = true;
                        break;
                    case "Contains":
                        Contains(finalList, int.Parse(action[1]));
                        break;
                    case "PrintEven":
                        PrintEven(finalList);
                        break;
                    case "PrintOdd":
                        PrintOdd(finalList);
                        break;
                    case "GetSum":
                        PrintSum(finalList);
                        break;
                    case "Filter":
                        PrintFilter(finalList, action[1], int.Parse(action[2]));
                        break;
                }
                command = Console.ReadLine();
            }

            if (finalList != list && changesMade)
            {
                Console.WriteLine(string.Join(" ", finalList));
            }

        }

        private static void PrintFilter(List<int> list, string condition, int n)
        {
            switch (condition)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", list.Where(x => x < n)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", list.Where(x => x > n)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", list.Where(x => x >= n)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", list.Where(x => x <= n)));
                    break;
            }
        }

        static void Contains(List<int> list, int n)
        {
            Console.WriteLine(list.Contains(n) ? "Yes" : "No such number");
        }

        static void PrintEven(List<int> list)
        {
            List<int> result = list.ToList();

            result.RemoveAll(x => x % 2 != 0);
            Console.WriteLine(string.Join(" ", result));
        }
        static void PrintOdd(List<int> list)
        {
            List<int> result = list.ToList();

            result.RemoveAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", result));
        }

        static void PrintSum(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }
    }
}
