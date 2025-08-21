using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Student3
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Disp3
    {
        public static void disp3()
        {
            Student3 s1 = new Student3
            {
                Name = "Sukant",
                Age = 24
            };

            Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");

        }
    }
}
