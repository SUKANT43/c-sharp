using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }

    class Disp2
    {
        public static void disp2()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(10, 20));
            Console.WriteLine(calc.Add(10.5, 20.3));
            Console.WriteLine(calc.Add(10, 20,30));

        }
    }
}
