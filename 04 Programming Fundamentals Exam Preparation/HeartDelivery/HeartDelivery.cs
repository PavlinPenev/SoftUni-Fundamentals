using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class HeartDelivery
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int currentIndex = 0;
            int initialIndex = 0;
            while (input != "Love!")
            {
                string[] jump = input.Split();
                currentIndex += int.Parse(jump[1]);
                if (currentIndex > integers.Count - 1)
                {
                    currentIndex = 0;
                }

                if (integers[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    initialIndex = currentIndex;
                    input = Console.ReadLine();
                    continue;
                }

                integers[currentIndex] -= 2;
                initialIndex = currentIndex;

                if (integers[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            Console.WriteLine(integers.All(i => i == 0) ? "Mission was successful." : $"Cupid has failed {integers.Count(i => i > 0)} places.");
        }
    }
}
