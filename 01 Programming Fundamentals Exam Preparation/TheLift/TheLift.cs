using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class TheLift
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                while (wagons[i] < 4)
                {
                    if (peopleWaiting <= 0)
                    {
                        break;
                    }
                    peopleWaiting--;
                    wagons[i]++;
                }
            }

            if (peopleWaiting <= 0 && !wagons.All(w => w == 4))
            {
                Console.WriteLine($"The lift has empty spots!{Environment.NewLine}{string.Join(" ", wagons)}");
            }
            else if (peopleWaiting > 0 && wagons.All(w => w == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!{Environment.NewLine}{string.Join(" ", wagons)}");
            }
            else if (peopleWaiting <= 0 && wagons.All(w => w == 4))
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
