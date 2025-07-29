using CalcLib;
using CalcLib.Calc1.Calc2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = Calc.Add(12, 12);
            Console.WriteLine(j.ToString());
            Console.ReadLine();
            Calc1.Add(10, 10);
        }
    }
}
