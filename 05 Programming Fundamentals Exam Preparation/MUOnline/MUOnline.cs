using System;
using System.Collections.Generic;
using System.Linq;

namespace MUOnline
{
    class MUOnline
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int bitcoins = 0;
            List<string> rooms = Console.ReadLine().Split('|').ToList();
            bool dead = false;
            foreach (var room in rooms)
            {
                if (dead)
                {
                    break;
                }
                string[] command = room.Split();
                switch (command[0])
                {
                    case "potion":
                        int initialHp = hp;
                        hp += int.Parse(command[1]);
                        int healAmount = int.Parse(command[1]);
                        if (hp > 100)
                        {
                            hp = 100;
                            healAmount = hp - initialHp;
                        }

                        Console.WriteLine($"You healed for {healAmount} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");
                        break;
                    case "chest":
                        bitcoins += int.Parse(command[1]);
                        Console.WriteLine($"You found {int.Parse(command[1])} bitcoins.");
                        break;
                    default:
                        string monster = command[0];
                        hp -= int.Parse(command[1]);
                        if (hp <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            int roomNumber = rooms.IndexOf(room) + 1;
                            Console.WriteLine($"Best room: {roomNumber}");
                            dead = true;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }

                        break;
                }
            }

            if (hp > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {hp}");
            }
        }
    }
}
