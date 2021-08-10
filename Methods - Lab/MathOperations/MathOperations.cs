using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(n1, op, n2));
        }

        static int Calculate(int n1, char op, int n2)
        {
            int result = 0;
            switch (op)
            {
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '+':
                    result = n1 + n2;
                    break;
            }

            return result;
        }
    }
}
