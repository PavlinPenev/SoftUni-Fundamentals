using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class DrumSet
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drums = drumQuality.ToList();

            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        if (savings >= drumQuality[i] * 3)
                        {
                            drums[i] = drumQuality[i];
                            savings -= drumQuality[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            drumQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
