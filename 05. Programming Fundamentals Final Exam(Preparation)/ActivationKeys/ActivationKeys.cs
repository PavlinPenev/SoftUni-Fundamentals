using System;
using System.Text;

namespace ActivationKeys
{
    class ActivationKeys
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Generate")
            {
                switch (command[0])
                {
                    case "Contains":
                        string substring = command[1];
                        Console.WriteLine(activationKey.ToString().Contains(substring) ? $"{activationKey} contains {substring}" : $"Substring not found!");
                        break;
                    case "Flip":
                        string upLow = command[1];
                        int startIdx = int.Parse(command[2]);
                        int endIdx = int.Parse(command[3]);
                        string substringFlip = activationKey.ToString().Substring(startIdx, endIdx - startIdx);
                        if (upLow == "Upper")
                        {
                            activationKey.Replace(substringFlip, substringFlip.ToUpper());
                        }
                        else
                        {
                            activationKey.Replace(substringFlip, substringFlip.ToLower());
                        }

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }

                command = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
