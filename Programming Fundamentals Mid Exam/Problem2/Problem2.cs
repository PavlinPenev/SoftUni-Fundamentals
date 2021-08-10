using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            List<string> oldFavGenres = Console.ReadLine().Split(" | ").ToList();
            string input = Console.ReadLine();

            while (input != "Stop!")
            {
                string[] commands = input.Split();
                string operation = commands[0];
                string genre = commands[1];
                switch (operation)
                {
                    case "Join":
                        if (!oldFavGenres.Contains(genre))
                        {
                            oldFavGenres.Add(genre);
                        }

                        break;
                    case "Drop":
                        if (oldFavGenres.Contains(genre))
                        {
                            oldFavGenres.Remove(genre);
                        }

                        break;
                    case "Replace":
                        string newGenre = commands[2];
                        if (oldFavGenres.Contains(genre) && !oldFavGenres.Contains(newGenre))
                        {
                            int index = oldFavGenres.FindIndex(g => g == genre);
                            oldFavGenres[index] = newGenre;
                        }

                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", oldFavGenres));
        }
    }
}
