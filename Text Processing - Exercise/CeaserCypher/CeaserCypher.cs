using System;
using System.Diagnostics;
using System.Text;

namespace CeaserCypher
{
    class CeaserCypher
    {
        static void Main(string[] args)
        {
            StringBuilder toCypher1 = new StringBuilder();
            toCypher1.Append(Console.ReadLine());
            StringBuilder cypher = new StringBuilder();
            foreach (var @char in toCypher1.ToString())
            {
                cypher.Append((char) (@char + 3));
            }

            Console.WriteLine(cypher);
        }
    }
}
