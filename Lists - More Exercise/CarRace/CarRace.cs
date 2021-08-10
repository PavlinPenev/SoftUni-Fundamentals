using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class CarRace
    {
        static void Main(string[] args)
        {
            List<int> checkpointTime = Console.ReadLine().Split().Select(int.Parse).ToList();
            int middleIndex = checkpointTime.Count / 2;

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < middleIndex; i++)
            {
                leftRacerTime += checkpointTime[i];
                if (checkpointTime[i] == 0)
                {
                    leftRacerTime *= 0.80;
                }
            }

            for (int i = checkpointTime.Count - 1; i >= middleIndex + 1; i--)
            {
                rightRacerTime += checkpointTime[i];
                if (checkpointTime[i] == 0)
                {
                    rightRacerTime *= 0.80;
                }
            }

            if (leftRacerTime > rightRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(rightRacerTime, 1)}");
            }
            else if (rightRacerTime > leftRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftRacerTime, 1)}");
            }
        }
    }
}
