using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class It
    {
        public EmployeeSeperator employeeSeperator;
        public It(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeesSeperated += EmployeeSeperatedEventHandler;
        }
        public void EmployeeSeperatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("It department: employee seperation process related to finance");
        }

    }
}
