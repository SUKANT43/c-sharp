using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSeperator employeeSeperator = new EmployeeSeperator();
            Finance finance = new Finance(employeeSeperator);
            It it = new It(employeeSeperator);
            employeeSeperator.Seperate();
            Console.ReadLine();
        }
    }
}
