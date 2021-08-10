using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class AdAstra
    {
        static void Main(string[] args)
        {
            string foodInfo = Console.ReadLine();
            string pattern = @"([#|])(?<name>[A-Za-z\s]+)\1(?<expDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,4}|10000)\1";
            MatchCollection foodMatches = Regex.Matches(foodInfo, pattern);
            List<Food> food = new List<Food>();
            foreach (Match foodMatch in foodMatches)
            {
                string name = foodMatch.Groups["name"].Value;
                string date = foodMatch.Groups["expDate"].Value;
                int calories = int.Parse(foodMatch.Groups["calories"].Value);
                Food currentFood = new Food(name, date, calories);
                food.Add(currentFood);
            }

            double days = Math.Floor((double)food.Select(f=>f.Calories).Sum() / 2000);
            Console.WriteLine($"You have food to last you for: {days} days!");
            Console.WriteLine(string.Join(Environment.NewLine, food));
        }
    }

    class Food
    {
        public Food(string name, string date, int calories)
        {
            Name = name;
            Date = date;
            Calories = calories;
        }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }

        public override string ToString()
            => $"Item: {Name}, Best before: {Date}, Nutrition: {Calories}";
    }
}
