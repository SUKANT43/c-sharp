using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string section { get; set; }
        public Student(string id, string name, string section)
        {
            this.id = id;
            this.name = name;
            this.section = section;
        }
    }

    class Obj
    {
        public static void Display()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("S01", "Alice", "A"));
            list.Add(new Student("S02", "Bob", "A"));
            list.Add(new Student("S03", "Charlie", "B"));
            list.Add(new Student("S04", "David", "B"));
            list.Add(new Student("S05", "Emma", "C"));
            list.Add(new Student("S06", "Frank", "C"));
            list.Add(new Student("S07", "Grace", "A"));
            list.Add(new Student("S08", "Henry", "B"));
            list.Add(new Student("S09", "Ivy", "C"));
            list.Add(new Student("S11", "Bala", "A"));
            list.Add(new Student("S10", "Jack", "A"));

            var listOfSectionA=from ls in list
                               where ls.section=="A"
                               orderby ls.name
                                select ls;

            var listOfSectionA2 = list.Where(ls => ls.section == "A")
                .OrderByDescending(ls=>ls.name);
            foreach (var student in listOfSectionA)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Section: {student.section}");
            }
            Console.WriteLine();
            Console.WriteLine("2nd type: ");
            foreach (var student in listOfSectionA2)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Section: {student.section}");
            }

        }
    }
}
