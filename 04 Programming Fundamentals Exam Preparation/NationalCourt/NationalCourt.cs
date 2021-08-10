using System;

namespace NationalCourt
{
    class NationalCourt
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int customers = int.Parse(Console.ReadLine());

            int counter = 0;
            double hours = 0;
            while (customers > 0)
            {
                customers -= employee3 + employee2 + employee1;
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
