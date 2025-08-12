 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class EmployeeEventArgs:EventArgs
    {
        public int EmpId { get; set; }
        public string name { get; set; }

    }
    class EmployeeSeperator
    {
        public delegate void EmployeeSeperatedEventHandler();
        //public event EmployeeSeperatedEventHandler EmployeesSeperated;
        public event EventHandler<EmployeeEventArgs> EmployeesSeperated;
        public void Seperate()
        {
            EmployeeEventArgs employeeEventArgs = new EmployeeEventArgs { EmpId=123,name="sukant"};
            EmployeesSeperated?.Invoke(this,employeeEventArgs);
        }
    }
    
}
