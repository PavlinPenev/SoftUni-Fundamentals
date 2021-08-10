using System;

namespace Calculations
{
    class Calculations
    {
        static void Main()
        {
            //add, multi,sub,divide
            string command = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine(Add(n1, n2));
            }
            else if (command == "multiply")
            {
                Console.WriteLine(Multiply(n1, n2));
            }
            else if (command == "subtract")
            {
                Console.WriteLine(Subtract(n1, n2));
            }
            else if (command == "divide")
            {
                Console.WriteLine(Divide(n1, n2));
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
