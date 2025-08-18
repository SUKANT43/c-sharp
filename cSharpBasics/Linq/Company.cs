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
            foreach(var e in highSalry)
            {
                Console.WriteLine($"Name: {e.Name} Salary: {e.Salary}");
            }
        }
    }
}
