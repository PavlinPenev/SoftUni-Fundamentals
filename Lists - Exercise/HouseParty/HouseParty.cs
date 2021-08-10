using System;
using System.Collections.Generic;

namespace HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string[] guestStatus = Console.ReadLine().Split();
                switch (guestStatus[2])
                {
                    case "not":
                        if (guestList.Contains(guestStatus[0]))
                        {
                            guestList.Remove(guestStatus[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{guestStatus[0]} is not in the list!");
                        }

                        break;
                    default:
                        if (guestList.Contains(guestStatus[0]))
                        {
                            Console.WriteLine($"{guestStatus[0]} is already in the list!");
                        }
                        else
                        {
                            guestList.Add(guestStatus[0]);
                        }

                        break;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
