using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfTheWeek)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        price = 8.45;
                    }
                    else if (groupType == "Business")
                    {
                        price = 10.90;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 15;
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        price = 9.80;
                    }
                    else if (groupType == "Business")
                    {
                        price = 15.60;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 20;
                    }
                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        price = 10.46;
                    }
                    else if (groupType == "Business")
                    {
                        price = 16;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 22.50;
                    }
                    break;
            }
            double totalPrice = peopleCount * price;

            if (peopleCount >= 30 && groupType == "Students")
            {
                totalPrice *= 0.85;
            }
            else if (peopleCount >= 100 && groupType == "Business")
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (peopleCount >= 10 && peopleCount <= 20 && groupType == "Regular")
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
