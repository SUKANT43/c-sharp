using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{

    class Student2
    {
        private string name;
        private int age;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
    }

    class Disp2
    {
        public static void disp2()
        {
            Student2 s = new Student2();
            s.Name="Sukant";
            s.Age = 20;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
        }
    }
}
