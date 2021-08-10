using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class ShootForTheWin
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> shotIndeces = new List<int>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                int index = int.Parse(input);
                if (index > targets.Count - 1 || index < 0 || shotIndeces.Contains(index))
                {
                    input = Console.ReadLine();
                    continue;
                }

                int initialValue = targets[index];
                targets[index] = -1;
                shotIndeces.Add(index);
                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] > initialValue && targets[i] != -1)
                    {
                        targets[i] -= initialValue;
                    }
                    else if (targets[i] <= initialValue && targets[i] != -1)
                    {
                        targets[i] += initialValue;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotIndeces.Count} -> {string.Join(" ", targets)}");
        }
    }
}
