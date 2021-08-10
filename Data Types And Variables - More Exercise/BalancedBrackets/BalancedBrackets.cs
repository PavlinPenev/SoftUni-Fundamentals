using System;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int counter1 = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();


                if (input == "(")
                {
                    counter++;
                }
                else if (input == ")")
                {
                    counter1++;
                    if (counter - counter1 != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            Console.WriteLine(counter == counter1 ? "BALANCED" : "UNBALANCED");
        }
    }
}
