using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Judge
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individual = new Dictionary<string, int>();
            string[] regData = Console.ReadLine().Split(" -> ");

            while (regData[0] != "no more time")
            {
                string student = regData[0];
                string contest = regData[1];
                int points = int.Parse(regData[2]);

                if (!contestData.ContainsKey(contest))
                {
                    contestData.Add(contest, new Dictionary<string, int>());
                    contestData[contest].Add(student, points);
                }
                else
                {
                    if (contestData[contest].ContainsKey(student))
                    {
                        if (contestData[contest][student] < points)
                        {
                            contestData[contest][student] = points;
                        }
                    }
                    else
                    {
                        contestData[contest].Add(student, points);
                    }
                }

                regData = Console.ReadLine().Split(" -> ");
            }

            foreach (var contest in contestData)
            {
                foreach (var student in contest.Value)
                {
                    if (!individual.ContainsKey(student.Key))
                    {
                        individual.Add(student.Key, student.Value);
                    }
                    else
                    {
                        individual[student.Key] += student.Value;
                    }
                }
            }

            foreach (var contest in contestData)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int i = 1;
                foreach (var student in contest.Value.OrderByDescending(p => p.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"{i}. {student.Key} <::> {student.Value}");
                    i++;
                }
            }

            int j = 1;
            Console.WriteLine("Individual standings: ");
            foreach (var student in individual.OrderByDescending(i => i.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{j}. {student.Key} -> {student.Value}");
                j++;
            }
        }
    }
}
