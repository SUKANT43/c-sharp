using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class A
    {
        string name;
        int age;
    }

    class B : A
    {
        bool premium;
    }
    class Obj
    {
        public static void Display()
        {
            A objA=new B();
            B objB = objA as B;
            if (objB != null)
            {
                Console.WriteLine("Casting successful");
            }
            else
            {
                Console.WriteLine("Casting failed");
            }
            Console.ReadLine();
        }
    }
}
