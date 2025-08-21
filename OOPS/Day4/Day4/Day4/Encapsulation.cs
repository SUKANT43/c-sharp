using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Student
    {
        private string name;
        private int age;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
    class Disp1
    {
        public static void disp1()
        {
            Student s1 = new Student();
            s1.SetName("Sukant C");
            s1.SetAge(20);
            Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.GetAge());
        }
    }
}
