using System;
using System.Text;

namespace TheImitationGame
{
    class TheImitationGame
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split('|');
            while (command[0] != "Decode")
            {
                switch (command[0])
                {
                    case "Move":
                        int substringLength = int.Parse(command[1]);
                        string temp = message.ToString().Substring(0, substringLength);
                        message.Remove(0, substringLength);
                        message.Append(temp);
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        string value = command[2];
                        message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        while (message.ToString().Contains(command[1]))
                        {
                            message.Replace(command[1], command[2]);
                        }

                        break;
                }
                command = Console.ReadLine().Split('|');
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
