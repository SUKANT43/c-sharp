using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
    }

    class Employee : Person
    {
        public string Company;
        public Employee(string name,string company) : base(name)
        {
            Company = company;
        }
    }

    class Disp4
    {
        public static void disp4()
        {
            Employee emp1 = new Employee("Sukant C", "Lucid Imaging");
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Company);
        }
    }
}
