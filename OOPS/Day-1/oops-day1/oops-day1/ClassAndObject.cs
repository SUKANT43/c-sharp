using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_day1
{
    //1. basic class and object
    class Person
    {
        public string Name;
        public int Age;
        public static int Value = 100;


        static Person()
        {
            Console.WriteLine("Static Value");
            Value = 100;
        }
    }



    //2. With Constructor
    class Student
    {
        public string Name;
        public int Roll;

        //a. Default Constructor
        public Student()
        {
            Name = "unkown";
            Roll = 0;
        }

        //b. Parameterized Constructor
        public Student(string Name,int Roll)
        {
            this.Name = Name;
            this.Roll = Roll;
        }

        //c. Copy Constructor
        public Student(Student s)
        {
            Name = s.Name;
            Roll = s.Roll;
        }

        //method
        public void Details()
        {
            Console.WriteLine($"Name: {Name}, Roll: {Roll}");
        }
    }



    class Dis1
    {
        public static void disp()
        {

            //1. basic class and object
            Person p1 = new Person();
            Console.WriteLine(Person.Value);
            p1.Name = "sukant c";
            p1.Age = 20;
            Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");

            //2. With Constructors
            Student s1 = new Student("Sukant C",101);
            s1.Details();

            //object initalizer
            Student s2 = new Student { Name = "Ravi", Roll = 100 };

            List<Student> list =new List<Student> 
             {
                new Student { Name = "Sukant", Roll = 101 },
                new Student { Name = "Sukant", Roll = 101 },
                new Student { Name = "Sukant", Roll = 101 },
            };

        }
    }
}
