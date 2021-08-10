using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split();

                Student currentStudent = new Student(studentData[0], studentData[1], double.Parse(studentData[2]));
                students.Add(currentStudent);
            }

            students = students.OrderByDescending(st => st.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
            => $"{FirstName} {SecondName}: {Grade:f2}";
    }
}
