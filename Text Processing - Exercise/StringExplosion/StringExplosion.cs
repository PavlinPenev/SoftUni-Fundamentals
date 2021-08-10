using System;
using System.Text;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            StringBuilder toExplode = new StringBuilder();
            toExplode.Append(Console.ReadLine());
            int bomb = 0;
            for (int i = 0; i < toExplode.Length; i++)
            {
                if (bomb > 0 && toExplode[i] != '>')
                {
                    toExplode.Remove(i, 1);
                    i--;
                    bomb--;
                }
                else if (toExplode[i] == '>')
                {
                    bomb += int.Parse(toExplode[i + 1].ToString());
                }
            }

            Console.WriteLine(toExplode);
        }
    }
}
