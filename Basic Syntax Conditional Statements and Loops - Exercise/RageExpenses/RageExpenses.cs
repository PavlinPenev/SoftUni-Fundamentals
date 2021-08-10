using System;

namespace RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int[] counters = { 0, 0, 0, 0 };
            double sum = 0;

            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    //headset
                    counters[0]++;
                    sum += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    //mouse
                    counters[1]++;
                    sum += mousePrice;
                }
                if (i % 6 == 0)
                {
                    //keyboard
                    counters[2]++;
                    counters[0] = 0;
                    counters[1] = 0;
                    sum += keyboardPrice;
                }
                if (counters[2] == 2)
                {
                    //display
                    counters[3]++;
                    counters[2] = 0;
                    sum += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
