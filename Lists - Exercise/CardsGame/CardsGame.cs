using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                int firstElement1 = 0;
                int firstElement2 = 0;
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstElement1 = firstPlayer[0];
                    firstElement2 = secondPlayer[0];
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                    firstPlayer.Add(firstElement1);
                    firstPlayer.Add(firstElement2);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    firstElement1 = secondPlayer[0];
                    firstElement2 = firstPlayer[0];
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.Add(firstElement1);
                    secondPlayer.Add(firstElement2);
                }
                else if (firstPlayer[0] == secondPlayer[0])
                {
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
            }

            Console.WriteLine(firstPlayer.Count < secondPlayer.Count ? $"Second player wins! Sum: {secondPlayer.Sum()}" : $"First player wins! Sum: {firstPlayer.Sum()}");
        }
    }
}
