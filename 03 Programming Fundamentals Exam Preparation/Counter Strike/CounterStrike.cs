using System;

namespace CounterStrike
{
    class CounterStrike
    {
        static void Main(string[] args)
        {
            double initialHP = double.Parse(Console.ReadLine());
            string distance = Console.ReadLine();
            int wins = 0;
            bool dead = false;
            while (distance != "End of battle")
            {
                if (initialHP < double.Parse(distance))
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialHP} energy");
                    dead = true;
                    break;
                }
                initialHP -= double.Parse(distance);
                wins++;
                if (wins % 3 == 0)
                {
                    initialHP += wins;
                }

                distance = Console.ReadLine();
            }

            if (!dead)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {initialHP}");
            }
        }
    }
}
