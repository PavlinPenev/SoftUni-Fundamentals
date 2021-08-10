using System;
using System.Linq;
using System.Text;

namespace SecretChat
{
    class SecretChat
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(":|:");
            while (command[0] != "Reveal")
            {
                string substring = string.Empty;

                switch (command[0])
                {
                    case "InsertSpace":
                        message.Insert(int.Parse(command[1]), ' ');
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        substring = command[1];
                        int index = message.ToString().IndexOf(substring);
                        if (index == -1)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            message.Remove(index, substring.Length);
                            substring = string.Join("", substring.ToCharArray().Reverse());
                            message.Append(substring);
                            Console.WriteLine(message);
                        }

                        break;
                    case "ChangeAll":
                        substring = command[1];
                        string replacement = command[2];
                        while (message.ToString().Contains(substring))
                        {
                            message.Replace(substring, replacement);
                        }

                        Console.WriteLine(message);
                        break;
                }

                command = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
