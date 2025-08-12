 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class EmployeeSeperator
    {
        public delegate void EmployeeSeperatedEventHandler();
        public event EmployeeSeperatedEventHandler EmployeesSeperated;
        public void Seperate()
        {
            EmployeesSeperated?.Invoke();
        }
    }
    
}
