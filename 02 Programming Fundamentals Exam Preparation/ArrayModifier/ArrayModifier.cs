using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "swap":
                        int index1 = int.Parse(commands[1]);
                        int index2 = int.Parse(commands[2]);
                        int temp = integers[index1];
                        integers[index1] = integers[index2];
                        integers[index2] = temp;
                        break;
                    case "multiply":
                        int indexM1 = int.Parse(commands[1]);
                        int indexM2 = int.Parse(commands[2]);
                        integers[indexM1] *= integers[indexM2];
                        break;
                    case "decrease":
                        for (int i = 0; i < integers.Count; i++)
                        {
                            integers[i] -= 1;
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
