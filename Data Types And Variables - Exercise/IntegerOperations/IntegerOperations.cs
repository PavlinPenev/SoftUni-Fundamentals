using System;

namespace IntegerOperations
{
    class IntegerOperations
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(((number + number1) / number2) * number3);
        }
    }
}
