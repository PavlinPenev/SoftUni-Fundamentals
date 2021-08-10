using System;

namespace AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int result = 0;

            result = SubFromSum(SumFirstTwo(n1, n2), n3);
            Console.WriteLine(result);
        }

        static int SumFirstTwo(int x, int y)
        => x + y;
        

        static int SubFromSum(int x, int y)
        => x - y;
    }
}
