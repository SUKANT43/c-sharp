using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    class Parent
    {
        public void ShowParent()
        {
            Console.WriteLine("This is Parent class.");
        }
    }

    class Child : Parent
    {
        public void ShowChild()
        {
            Console.WriteLine("This is Child class.");
        }
    }

    class Disp
    {
        public static void disp()
        {
            Child c1 = new Child();
            c1.ShowParent();
            c1.ShowChild();
        }
    }
}
