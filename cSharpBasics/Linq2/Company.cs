using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int CompanyId { get; set; }
    }

    class Disp2
    {
        public static void display()
        {
                List<Company> companies = new List<Company>()
                {
                new Company { CompanyId = 1, CompanyName = "Microsoft" },
                new Company { CompanyId = 2, CompanyName = "Google" },
                new Company { CompanyId = 3, CompanyName = "Amazon" }
                };

            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmployeeId = 1, EmployeeName = "John", CompanyId = 1 },
                new Employee { EmployeeId = 2, EmployeeName = "Alice", CompanyId = 2 },
                new Employee { EmployeeId = 3, EmployeeName = "David", CompanyId = 1 },
                new Employee { EmployeeId = 4, EmployeeName = "Steve", CompanyId = 3 },
                new Employee { EmployeeId = 5, EmployeeName = "Emma", CompanyId = 2 }
            };

            var employeeAndTheirCompany = employees.Join(
                companies,
                e=>e.CompanyId,
                c=>c.CompanyId,
                (e, c)=>new
                {
                    EmployeeName=e.EmployeeName,
                    CompanyName=c.CompanyName
                }
                );
            foreach (var item in employeeAndTheirCompany)
            {
                Console.WriteLine($"{item.EmployeeName} works at {item.CompanyName}");
            }

        }
    }
}
