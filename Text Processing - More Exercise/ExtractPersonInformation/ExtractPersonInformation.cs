using System;
using System.Text;

namespace ExtractPersonInformation
{
    class ExtractPersonInformation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder info = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                StringBuilder individual = new StringBuilder();
                individual.Append(Console.ReadLine());
                int indexNameStart = individual.ToString().IndexOf('@');
                int indexNameEnd = individual.ToString().IndexOf('|');
                string name = individual.ToString().Substring(indexNameStart + 1, indexNameEnd - indexNameStart - 1);
                int indexAgeStart = individual.ToString().IndexOf('#');
                int indexAgeEnd = individual.ToString().IndexOf('*');
                string age = individual.ToString().Substring(indexAgeStart + 1, indexAgeEnd - indexAgeStart - 1);
                info.Append($"{name} is {age} years old.\n");
            }

            Console.WriteLine(info.ToString().TrimEnd('\n'));
        }
    }
}
