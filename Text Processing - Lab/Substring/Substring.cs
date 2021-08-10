using System;
using System.Text;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            StringBuilder keyWord = new StringBuilder();
            keyWord.Append(Console.ReadLine().ToLower());
            StringBuilder stringToFilter = new StringBuilder();
            stringToFilter.Append(Console.ReadLine());
            while (stringToFilter.ToString().Contains(keyWord.ToString()))
            {
                int index = stringToFilter.ToString().IndexOf(keyWord.ToString());
                stringToFilter.Remove(index, keyWord.Length);
            }

            Console.WriteLine(stringToFilter);
        }
    }
}
