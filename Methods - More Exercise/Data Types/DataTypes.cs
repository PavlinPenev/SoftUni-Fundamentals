using System;

namespace DataTypes
{
    class DataTypes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string final = string.Empty;

            switch (input)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    final = InputOperation(intInput);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    final = $"{InputOperation(doubleInput):f2}";
                    break;
                case "string":
                    string stringInput = Console.ReadLine();
                    final = InputOperation(stringInput);
                    break;
            }


            Console.WriteLine(final);
        }

        static string InputOperation(int input)
            => (input * 2).ToString();

        static double InputOperation(double input)
            => input * 1.5;

        static string InputOperation(string input)
            =>$"${input}$";
    }
}
