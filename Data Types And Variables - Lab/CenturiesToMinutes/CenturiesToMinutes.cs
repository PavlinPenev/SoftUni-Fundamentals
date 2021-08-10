using System;

namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine()) * 100;
            decimal days = (int)(centuries * 365.2422);
            int hours = (int)days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centuries / 100} centuries = {centuries} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
