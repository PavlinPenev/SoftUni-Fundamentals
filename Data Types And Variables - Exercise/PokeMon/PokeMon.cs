using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int pokeCounter = 0;
            int NOriginal = N;
            while (N >= M)
            {
                N -= M;
                pokeCounter++;
                if (N == NOriginal / 2 && N >= Y && Y > 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokeCounter);
        }
    }
}
