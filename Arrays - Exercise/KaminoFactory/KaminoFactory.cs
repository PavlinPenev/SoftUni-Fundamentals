using System;
using System.Linq;

namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            int sample = 0;
            int sample1 = 0;
            int counter = 0;
            int maxCounter = 0;
            int currentSum = 0;
            int bestSum = 0;
            int bestIndex = int.MaxValue;
            int bestCounter = 0;
            int[] bestDNA = null;
            string inputDNA = Console.ReadLine();

            while (inputDNA != "Clone them!")
            {

                currentSum = 0;
                maxCounter = 0;
                counter = 0;
                int[] arrayDNA = inputDNA.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < arrayDNA.Length; j++)
                {
                    if (arrayDNA[j] == 0)
                    {
                        counter = 0;
                        continue;
                    }

                    counter++;
                    currentSum++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }

                sample++;
                string targetString = new string('1', maxCounter);
                int leftIndex = string.Join("", arrayDNA).IndexOf(targetString);
                if (maxCounter >= bestCounter && leftIndex < bestIndex || maxCounter == bestCounter && leftIndex == bestIndex && currentSum > bestSum)
                {
                    bestCounter = maxCounter;
                    bestIndex = leftIndex;
                    bestSum = currentSum;
                    sample1 = sample;
                    bestDNA = arrayDNA;
                }
                inputDNA = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {sample1} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
