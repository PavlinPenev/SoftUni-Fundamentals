using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLSPrice = (Math.Ceiling((double)studentsCount * 1.1)) * lightsaberPrice;
            double totalRobesPrice = studentsCount * robesPrice;
            double totalBeltsPrice = studentsCount * beltsPrice - ((studentsCount / 6) * beltsPrice);
            double totalPrice = totalLSPrice + totalRobesPrice + totalBeltsPrice;

            double diffInMoney = Math.Abs(moneyAmount - totalPrice);
            Console.WriteLine(totalPrice <= moneyAmount ? $"The money is enough - it would cost {totalPrice:f2}lv." : $"John will need {diffInMoney:f2}lv more.");
        }
    }
}
