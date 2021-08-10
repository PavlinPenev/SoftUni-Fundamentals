using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string keyPattern = @"[STARstar]";
            string attackPattern = @"\@(?<planet>[A-Z][a-z]+)[^\@\-!:>]*?:(?<population>\d+)[^\@\-!:>]*?!(?<attackType>A|D)![^\@\-!:>]*?->(?<soldierCount>\d+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());
                int decryptorKey = Regex.Matches(encryptedMessage.ToString(), keyPattern).Count;
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    encryptedMessage.Replace(encryptedMessage[j], (char) (encryptedMessage[j] - decryptorKey), j, 1);
                }

                MatchCollection matches = Regex.Matches(encryptedMessage.ToString(), attackPattern);
                string planetName = string.Empty;
                string attackType = string.Empty;
                foreach (Match match in matches)
                {
                    planetName = match.Groups["planet"].Value;
                    attackType = match.Groups["attackType"].Value;
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(p=> p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p=> p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
