using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SantasSecretHelper
{
    class SantasSecretHelper
    {
        static void Main(string[] args)
        {
            int subtractor = int.Parse(Console.ReadLine());
            string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-!:>]*!(?<behaviour>[GN])!";
            List<string> goodChildren = new List<string>();
            string childData = Console.ReadLine();
            while (childData != "end")
            {
                char[] child = childData.ToCharArray();
                for (int i = 0; i < childData.Length; i++)
                {
                    child[i] = (char)(child[i] - subtractor);
                }
                childData = string.Join("", child);
                Match childMatch = Regex.Match(childData, pattern);
                string name = childMatch.Groups["name"].Value;
                string behaviour = childMatch.Groups["behaviour"].Value;
                if (behaviour == "G")
                {
                    goodChildren.Add(name);
                }
                childData = Console.ReadLine();
            }

            foreach (var child in goodChildren)
            {
                Console.WriteLine(child);
            }
        }
    }
}
