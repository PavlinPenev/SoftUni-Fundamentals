using System;

namespace Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string personAgeStatus = string.Empty;

            if (age >= 0 && age <= 2)
            {
                personAgeStatus = "baby";
            }
            else if (age <= 13)
            {
                personAgeStatus = "child";
            }
            else if (age <= 19)
            {
                personAgeStatus = "teenager";
            }
            else if (age <= 65)
            {
                personAgeStatus = "adult";
            }
            else if (age > 65)
            {
                personAgeStatus = "elder";
            }
            Console.WriteLine(personAgeStatus);
        }
    }
}
