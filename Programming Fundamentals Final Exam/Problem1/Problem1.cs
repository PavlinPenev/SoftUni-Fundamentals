using System;
using System.Text;

namespace Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            StringBuilder email = new StringBuilder(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Complete")
            {
                switch (commands[0])
                {
                    case "Make":
                        if (commands[1] == "Upper")
                        {
                            email.Replace(email.ToString(), email.ToString().ToUpper());
                        }
                        else
                        {
                            email.Replace(email.ToString(), email.ToString().ToLower());
                        }

                        Console.WriteLine(email);
                        break;
                    case "GetDomain":
                        int count = int.Parse(commands[1]);
                        string substring = email.ToString().Substring(email.Length - count, count);
                        Console.WriteLine(substring);
                        break;  
                    case "GetUsername":
                        int @index = email.ToString().IndexOf('@');
                        if (@index == -1)
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            substring = email.ToString().Substring(0, @index);
                            Console.WriteLine(substring);
                        }

                        break;
                    case "Replace":
                        char toReplace = char.Parse(commands[1]);
                        while (email.ToString().Contains(toReplace))
                        {
                            email.Replace(toReplace, '-');
                        }

                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        char[] asciiArray = email.ToString().ToCharArray();
                        foreach (var c in asciiArray)
                        {
                            Console.Write((int)c + " ");
                        }

                        break;
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
