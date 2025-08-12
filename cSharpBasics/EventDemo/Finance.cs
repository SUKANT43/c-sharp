using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Finance
    {
        private EmployeeSeperator employeeSeperator;
        public Finance(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeesSeperated += EmployeeSeperatedEventHandler;
        }

        public void EmployeeSeperatedEventHandler()
        {
            Console.WriteLine("Finance department: employee seperation process related to finance");
        }
    }
}
