using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int Salary { get; set; }
    }

    class Disp
    {
        public static void display()
        {
            List<Company> companies = new List<Company>()
            {
                new Company{CompanyId=1, CompanyName="Google"},
                new Company{CompanyId=2, CompanyName="Microsoft"},
                new Company{CompanyId=3, CompanyName="Amazon"}
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee{EmployeeId=1, Name="Alice", CompanyId=1, Salary=70000},
                new Employee{EmployeeId=2, Name="Bob", CompanyId=1, Salary=50000},
                new Employee{EmployeeId=3, Name="Charlie", CompanyId=2, Salary=80000},
                new Employee{EmployeeId=4, Name="David", CompanyId=2, Salary=60000},
                new Employee{EmployeeId=5, Name="Eve", CompanyId=3, Salary=90000}

            };

            var highSalry = from emp in employees
                            where emp.Salary > (from x in employees select x.Salary).Average()
                            select new { emp.Name, emp.Salary };

            Console.WriteLine();
            Console.WriteLine("Salary higher than average using query: ");
            foreach (var e in highSalry)
            {
                Console.WriteLine($"Name: {e.Name} Salary: {e.Salary}");
            }
            var avg = employees.Average(e => e.Salary);
            var lowSalary = employees.Where(e => e.Salary < avg)
                .Select(e => new { e.Name, e.Salary });

            Console.WriteLine();
            Console.WriteLine("Salary lower than average using query syntax: ");
            foreach (var e in lowSalary)
            {
                Console.WriteLine($"Name: {e.Name} Salary: {e.Salary}");

            }


            Console.WriteLine();
            Console.WriteLine("Company named google using Query: ");

            var googleEmployees = from emp in employees
                                  where emp.CompanyId == (from comp in companies where comp.CompanyName == "Google" select comp.CompanyId).FirstOrDefault()
                                  select new{emp.Name, emp.Salary};

            foreach(var emp in googleEmployees)
            {
                Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");
            }

            Console.WriteLine();
            Console.WriteLine("Company named google using Query Syntax: ");

            var googleEmployee2 = employees
                .Where(e => e.CompanyId == companies.Where(c => c.CompanyName == "Google")
                .Select(c => c.CompanyId)
                .FirstOrDefault())
                .Select(e => new { e.Name, e.Salary });
            foreach (var emp in googleEmployee2)
            {
                Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");
            }



        }


    }
}
