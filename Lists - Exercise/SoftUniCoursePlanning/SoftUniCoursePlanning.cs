using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            bool end = false;

            while (!end)
            {
                string command = Console.ReadLine();
                if (command == "course start")
                {
                    end = true;
                    continue;
                }

                string[] action = command.Split(':');

                switch (action[0])
                {
                    case "Add":
                        if (schedule.Contains(action[1]))
                        {
                            continue;
                        }
                        schedule.Add(action[1]);
                        break;
                    case "Insert":
                        if (schedule.Contains(action[1]))
                        {
                            continue;
                        }
                        schedule.Insert(int.Parse(action[2]), action[1]);
                        break;
                    case "Remove":
                        schedule.RemoveAll(x => x.Contains(action[1]));
                        break;
                    case "Swap":
                        if (schedule.Contains(action[1]) && schedule.Contains(action[2]))
                        {
                            int indexFirst = schedule.FindIndex(x => x == action[1]);
                            int indexSecond = schedule.FindIndex(x => x == action[2]);

                            string temp = schedule[indexFirst];
                            schedule[indexFirst] = schedule[indexSecond];
                            schedule[indexSecond] = temp;
                            if (indexFirst > 0 && indexFirst < schedule.Count - 1)
                            {
                                if (schedule[indexFirst + 1].Contains("Exercise"))
                                {
                                    schedule.Insert(indexSecond + 1, schedule[indexFirst + 1]);
                                    schedule.RemoveAt(indexFirst + 1);
                                }
                            }

                            if (indexSecond < schedule.Count - 1 && indexSecond > 0)
                            {
                                if (schedule[indexSecond + 1].Contains("Exercise"))
                                {
                                    schedule.Insert(indexFirst + 1, schedule[indexSecond + 1]);
                                    schedule.RemoveAt(indexSecond + 2);
                                }
                            }
                        }

                        break;
                    case "Exercise":
                        if (schedule.Contains(action[1]) && !schedule.Contains($"{action[1]}-Exercise"))
                        {
                            int lessonIndex = schedule.FindIndex(x => x == action[1]);
                            schedule.Insert(lessonIndex + 1, $"{schedule[lessonIndex]}-Exercise");
                        }
                        else if (!schedule.Contains(action[1]) && !schedule.Contains($"{action[1]}-Exercise"))
                        {
                            schedule.Add(action[1]);
                            schedule.Add($"{action[1]}-Exercise");
                        }

                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
