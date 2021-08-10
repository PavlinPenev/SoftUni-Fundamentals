using System;

namespace SoftUniReception
{
    class SoftUniReception
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double hours = 0;
            while (students > 0)
            {
                students -= employee3 + employee2 + employee1;
                hours++;
                if (hours % 4 == 0 && hours >= 4)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
