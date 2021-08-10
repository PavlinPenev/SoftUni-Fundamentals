using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double kegVolume = 0;
            double currentKegVolume = 0;
            string biggestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                currentKegVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (currentKegVolume > kegVolume)
                {
                    kegVolume = currentKegVolume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
