using System;
using System.Text;

namespace WorldTour
{
    class WorldTour
    {
        static void Main(string[] args)
        {
            StringBuilder destinations = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(':');
            while (command[0] != "Travel")
            {
                switch (command[0])
                {
                    case "Add Stop":
                        int indexAdd = int.Parse(command[1]);
                        string addStop = command[2];
                        if (indexAdd >= 0 && indexAdd <= destinations.Length - 1)
                        {
                            destinations.Insert(indexAdd, addStop);
                        }

                        Console.WriteLine(destinations);
                        break;
                    case "Remove Stop":
                        int startIdx = int.Parse(command[1]);
                        int endIdx = int.Parse(command[2]);
                        if (startIdx >= 0 && startIdx <= destinations.Length - 1 && endIdx >= 0 && endIdx <= destinations.Length - 1)
                        {
                            destinations.Remove(startIdx, endIdx - startIdx + 1);
                        }

                        Console.WriteLine(destinations);
                        break;
                    case "Switch":
                        string oldString = command[1];
                        string newString = command[2];
                        if (destinations.ToString().Contains(oldString) && oldString != newString)
                        {
                            destinations.Replace(oldString, newString);
                        }

                        Console.WriteLine(destinations);
                        break;
                }
                command = Console.ReadLine().Split(':');
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}