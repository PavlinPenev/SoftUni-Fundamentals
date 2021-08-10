using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class SoftUniParking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] register = Console.ReadLine().Split();
                string operation = register[0];
                string user = register[1];
                switch (operation)
                {
                    case "register":
                        string licensePlate = register[2];
                        if (!registeredUsers.ContainsKey(user))
                        {
                            registeredUsers.Add(user, licensePlate);
                            Console.WriteLine($"{user} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;
                    case "unregister":
                        if (registeredUsers.ContainsKey(user))
                        {
                            registeredUsers.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }

                        break;
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
