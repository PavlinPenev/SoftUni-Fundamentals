using System;
using System.Text;

namespace PasswordReset
{
    class PasswordReset
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "Done")
            {
                switch (commands[0])
                {
                    case "TakeOdd":
                        string temp = string.Empty;
                        for (int i = 1; i < password.Length; i+=2)
                        {
                            temp += password.ToString()[i];
                        }

                        password.Replace(password.ToString(), temp);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);
                        password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        if (password.ToString().Contains(commands[1]))
                        {
                            while (password.ToString().Contains(commands[1]))
                            {
                                password.Replace(commands[1], commands[2]);
                            }

                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
