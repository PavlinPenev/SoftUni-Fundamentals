using System;

namespace PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(grade >= 3 ? "Passed!" : "Failed!");
        }
    }
}
