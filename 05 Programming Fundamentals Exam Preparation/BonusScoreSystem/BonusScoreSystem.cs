using System;

namespace BonusScoreSystem
{
    class BonusScoreSystem
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            double addBonus = double.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendancees = 0;
            for (int i = 0; i < students; i++)
            {
                int currentAttendancees = 0;
                int attends = int.Parse(Console.ReadLine());
                double bonus = (double)attends / lectures * (5 + addBonus);
                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxAttendancees = attends;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendancees} lectures.");
        }
    }
}
