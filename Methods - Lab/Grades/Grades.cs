using System;

namespace Grades
{
    class Grades
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine(Grade(input));
        }

        static string Grade(double n)
        {
            string grade = String.Empty;
            if (n >= 2.00 && n < 3)
            {
                grade = "Fail";
            }
            else if (n < 3.50)
            {
                grade = "Poor";
            }
            else if (n < 4.5)
            {
                grade = "Good";
            }
            else if (n < 5.5)
            {
                grade = "Very good";
            }
            else if (n <= 6.00)
            {
                grade = "Excellent";
            }

            return grade;
        }
    }
}
