using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Attributes
{   
    [AttributeUsage(AttributeTargets.Class)]
    public class MainClass:Attribute
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(Calculator.Add(10, 20));
            Console.WriteLine(Calculator.Add(new List<int> { 10,20,30}));
            Console.ReadLine();
        }
    }

    [MainClass]
    public class Calculator:MainClass
    {
        [Obsolete("Use Add(List<int> Numbers) Method")]//obsolete means this is a outdated
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(List<int>Numbers)
        {
            int add = 0;
            foreach(int n in Numbers)
            {
                add += n;
            }
            return add;
        }
    }

}
