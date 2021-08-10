using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            Console.WriteLine(BiggerValue(type, value1, value2));
        }

        static string BiggerValue(string type, string v1, string v2)
        {
            int result = 0;
            char resultChar = 'a';
            string resultStr = String.Empty;
            switch (type)
            {
                case "int":
                    int value1 = int.Parse(v1);
                    int value2 = int.Parse(v2);
                    result = Math.Max(value1, value2);
                    break;
                case "char":
                    char value1Char = char.Parse(v1);
                    char value2Char = char.Parse(v2);
                    resultChar = (char)Math.Max(value1Char, value2Char);
                    break;
                case "string":
                    result = v1.CompareTo(v2);
                    if (result >= 0)
                    {
                        resultStr = v1;
                    }
                    else if (result <= 0)
                    {
                        resultStr = v2;
                    }

                    break;
            }

            if (type == "int")
            {
                return result.ToString();
            }
            if (type == "char")
            {
                return resultChar.ToString();
            }
            if (type == "string")
            {
                return resultStr;
            }

            return "Invalid";
        }
    }
}
