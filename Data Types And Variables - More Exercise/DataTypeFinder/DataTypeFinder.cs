using System;

namespace DataTypeFinder
{
    class DataTypeFinder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isChar = char.TryParse(input, out char _);
                bool isInt = int.TryParse(input, out int _);
                bool isFloat = float.TryParse(input, out float _);
                bool isBool = bool.TryParse(input, out bool _);
                string type = string.Empty;

                if (isInt)
                {
                    type = "integer";
                }
                else if (isFloat)
                {
                    type = "floating point";
                }
                else if (isChar)
                {
                    type = "character";
                }
                else if (isBool)
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }
                Console.WriteLine($"{input} is {type} type");
                input = Console.ReadLine();
            }
        }
    }
}
