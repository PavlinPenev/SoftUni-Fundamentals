using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class MemoryGame
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            int moves = 0;
            while (input != "end")
            {
                string[] indeces = input.Split();
                int index1 = int.Parse(indeces[0]);
                int index2 = int.Parse(indeces[1]);
                moves++;
                if (index2 < 0 || index2 >= elements.Count || index1 < 0 || index1 >= elements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int addIndex = elements.Count / 2;
                    elements.Insert(addIndex, $"-{moves}a");
                    elements.Insert(addIndex, $"-{moves}a");
                }
                else if (elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    string itemDelete = elements[index1];
                    elements.RemoveAll(e => e == itemDelete);
                }
                else if (elements[index1] != elements[index2])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sorry you lose :({Environment.NewLine}{string.Join(" ", elements)}");
        }
    }
}
