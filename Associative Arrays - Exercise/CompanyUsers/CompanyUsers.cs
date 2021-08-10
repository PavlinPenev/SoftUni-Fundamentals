using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class CompanyUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string[] employeeData = Console.ReadLine().Split(" -> ");
            while (employeeData[0] != "End")
            {
                string company = employeeData[0];
                string employeeID = employeeData[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(employeeID);
                    employeeData = Console.ReadLine().Split(" -> ");
                    continue;
                }

                if (!companies[company].Contains(employeeID))
                {
                    companies[company].Add(employeeID);
                }
                employeeData = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine(company.Key);
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", company.Value));
            }
        }
    }
}
