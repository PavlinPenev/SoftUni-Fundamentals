using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            string input = Console.ReadLine();
            List<string> deck = new List<string>();

            while (input != "Ready")
            {
                string[] commands = input.Split();
                string operation = commands[0];
                string cardName = commands[1];
                switch (operation)
                {
                    case "Add":
                        if (!cards.Contains(cardName))
                        {
                            Console.WriteLine("Card not found.");
                            break;
                        }

                        deck.Add(cardName);
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);
                        if (index < 0 || index >= cards.Count || !cards.Contains(cardName))
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                        deck.Insert(index, cardName);
                        break;
                    case "Remove":
                        if (!deck.Contains(cardName))
                        {
                            Console.WriteLine("Card not found.");
                            break;
                        }

                        deck.Remove(cardName);
                        break;
                    case "Swap":
                        string cardName1 = commands[2];
                        int indexCard = deck.FindIndex(c => c == cardName);
                        int indexCard1 = deck.FindIndex(c => c == cardName1);
                        string temp = deck[indexCard];
                        deck[indexCard] = deck[indexCard1];
                        deck[indexCard1] = temp;
                        break;
                    case "Shuffle":
                        deck.Reverse();
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
