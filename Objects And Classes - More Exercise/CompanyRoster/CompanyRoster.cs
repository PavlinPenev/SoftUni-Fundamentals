using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class CompanyRoster
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeesOriginal = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] employeeData = Console.ReadLine().Split();
                Employee newEmployee = new Employee(employeeData[0], double.Parse(employeeData[1]), employeeData[2]);
                employeesOriginal.Add(newEmployee);
            }

            List<Employee> employees = employeesOriginal.ToList();
            double biggestAVGSalary = double.MinValue;
            string departmentHighestAVG = string.Empty;
            employees = employees.OrderBy(em => em.Department).ToList();
            while (employees.Count > 0)
            {
                string department = employees[0].Department;

                double sum = 0;
                int counter = 0;
                while (employees[0].Department == department)
                {
                    sum += employees[0].Salary;
                    employees.RemoveAt(0);
                    counter++;
                    if (employees.Count == 0)
                    {
                        break;
                    }
                }
                double currentAVGSalary = sum / counter;
                if (currentAVGSalary > biggestAVGSalary)
                {
                    biggestAVGSalary = currentAVGSalary;
                    departmentHighestAVG = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentHighestAVG}");
            foreach (var employee in employeesOriginal.Where(em => em.Department == departmentHighestAVG).OrderByDescending(em => em.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public override string ToString()
            => $"{Name} {Salary:f2}";
    }
}
