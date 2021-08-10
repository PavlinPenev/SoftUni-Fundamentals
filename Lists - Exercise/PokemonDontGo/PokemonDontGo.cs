using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> allPokemon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (allPokemon.Count > 0)
            {
                int indexPokemon = int.Parse(Console.ReadLine());

                if (indexPokemon < 0)
                {
                    int caughtPokemon = allPokemon[0];
                    sum += caughtPokemon;
                    allPokemon[0] = allPokemon[allPokemon.Count - 1];
                    for (int i = 0; i < allPokemon.Count; i++)
                    {

                        if (allPokemon[i] <= caughtPokemon)
                        {
                            allPokemon[i] += caughtPokemon;
                        }
                        else
                        {
                            allPokemon[i] -= caughtPokemon;
                        }
                    }
                }

                else if (indexPokemon >= allPokemon.Count)
                {
                    int caughtPokemon = allPokemon[allPokemon.Count - 1];
                    sum += caughtPokemon;
                    allPokemon[allPokemon.Count - 1] = allPokemon[0];
                    for (int i = 0; i < allPokemon.Count; i++)
                    {

                        if (allPokemon[i] <= caughtPokemon)
                        {
                            allPokemon[i] += caughtPokemon;
                        }
                        else
                        {
                            allPokemon[i] -= caughtPokemon;
                        }
                    }
                }
                else
                {
                    sum += allPokemon[indexPokemon];
                    int caughtPokemon = allPokemon[indexPokemon];
                    allPokemon.RemoveAt(indexPokemon);
                    for (int i = 0; i < allPokemon.Count; i++)
                    {

                        if (allPokemon[i] <= caughtPokemon)
                        {
                            allPokemon[i] += caughtPokemon;
                        }
                        else
                        {
                            allPokemon[i] -= caughtPokemon;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
