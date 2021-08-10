using System;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagonArray = new int[n];
            int peopleCount = 0;
            for (int i = 0; i < n; i++)
            {
                int wagonPeople = int.Parse(Console.ReadLine());
                wagonArray[i] = wagonPeople;
                peopleCount += wagonPeople;
            }
            Console.WriteLine(string.Join(" ", wagonArray));
            Console.WriteLine($"{peopleCount}");
        }
    }
}
