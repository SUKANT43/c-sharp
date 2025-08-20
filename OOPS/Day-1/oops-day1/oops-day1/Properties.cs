using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_day1
{
    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    name = "Unkown";
                else
                    name = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
    class Disp2
    {
        public static void disp()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Sukant";
            emp1.Salary = 50000;

            Employee emp2 = new Employee();
            emp2.Name = "";   
            emp2.Salary = -20000;

            Console.WriteLine("Employee 1 -> Name: " + emp1.Name + ", Salary: " + emp1.Salary);
            Console.WriteLine("Employee 2 -> Name: " + emp2.Name + ", Salary: " + emp2.Salary);

        }
    }
}
