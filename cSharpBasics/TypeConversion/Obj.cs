using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class A
    {
        public string name;
        public int age;
    }

    class B : A
    {
        public bool premium;
    }

    class c:B
    {

    }

    class Obj
    {
        public static void Display()
        {
            A objA = new B { name = "Sukant", age = 25, premium = true };

            c objB = objA as c;

            if (objB != null)
            {
                Console.WriteLine("Name: " + objB.name);
                Console.WriteLine("Premium: " + objB.premium);
            }
            else
            {
                Console.WriteLine("Cast failed.");
            }
            Console.ReadLine();
        }

    }
}

