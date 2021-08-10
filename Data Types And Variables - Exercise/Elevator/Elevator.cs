using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            Console.WriteLine(people % capacityElevator == 0 ? people / capacityElevator : people / capacityElevator + 1);
        }
    }
}
