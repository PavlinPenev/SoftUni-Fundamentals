using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            RandomPhraseGenerator phrase = new RandomPhraseGenerator(phrases, events, authors, cities);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(phrase.GetRandomPhrase(phrase.Phrases) + " " + phrase.GetRandomPhrase(phrase.Events) + " " + phrase.GetRandomPhrase(phrase.Authors) + " - " + phrase.GetRandomPhrase(phrase.Cities));
            }
        }
    }

    class RandomPhraseGenerator
    {
        public RandomPhraseGenerator(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }

        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }

        public string GetRandomPhrase(List<string> phrases)
        {
            Random rnd = new Random();
            return phrases[rnd.Next(phrases.Count)];
        }
    }
}
