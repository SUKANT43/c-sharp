using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Management_System
{
    class DataManagement
    {
        private List<Student> students = new List<Student>
        {
            new Student{Id="S1", Name="Rahul", Age=20, Marks=85, Attendance=90, Department="CSE"},
            new Student{Id="S2", Name="Sneha", Age=21, Marks=72, Attendance=82, Department="CSE"},
            new Student{Id="S3", Name="Amit", Age=22, Marks=65, Attendance=60, Department="ECE"},
            new Student{Id="S4", Name="Priya", Age=19, Marks=38, Attendance=70, Department="ECE"},
            new Student{Id="S5", Name="Vikram", Age=20, Marks=91, Attendance=88, Department="ME"},
            new Student{Id="S6", Name="Rohit", Age=23, Marks=55, Attendance=68, Department="ME"},
            new Student{Id="S7", Name="Kiran", Age=21, Marks=76, Attendance=95, Department="IT"},
            new Student{Id="S8", Name="Neha", Age=22, Marks=44, Attendance=72, Department="IT"},
            new Student{Id="S9", Name="Ankit", Age=20, Marks=88, Attendance=85, Department="EEE"},
            new Student{Id="S10", Name="Meera", Age=19, Marks=92, Attendance=98, Department="EEE"},
            new Student{Id="S11", Name="Suresh", Age=22, Marks=30, Attendance=55, Department="CSE"},
            new Student{Id="S12", Name="Pooja", Age=21, Marks=67, Attendance=78, Department="CSE"},
            new Student{Id="S13", Name="Deepak", Age=23, Marks=82, Attendance=64, Department="ECE"},
            new Student{Id="S14", Name="Lakshmi", Age=20, Marks=47, Attendance=81, Department="ECE"},
            new Student{Id="S15", Name="Manish", Age=22, Marks=74, Attendance=89, Department="ME"},
            new Student{Id="S16", Name="Anjali", Age=19, Marks=95, Attendance=93, Department="ME"},
            new Student{Id="S17", Name="Sameer", Age=21, Marks=36, Attendance=69, Department="IT"},
            new Student{Id="S18", Name="Divya", Age=22, Marks=61, Attendance=77, Department="IT"},
            new Student{Id="S19", Name="Arjun", Age=20, Marks=58, Attendance=80, Department="EEE"},
            new Student{Id="S20", Name="Kavya", Age=21, Marks=89, Attendance=87, Department="EEE"},
        };

        private List<Faculty> faculties = new List<Faculty>
        {
            new Faculty{Id="F1", Name="Dr. Sharma", Subject="Algorithms", Department="CSE"},
            new Faculty{Id="F2", Name="Dr. Gupta", Subject="Databases", Department="CSE"},
            new Faculty{Id="F3", Name="Dr. Rao", Subject="Networks", Department="ECE"},
            new Faculty{Id="F4", Name="Dr. Menon", Subject="Digital Circuits", Department="ECE"},
            new Faculty{Id="F5", Name="Dr. Singh", Subject="Thermodynamics", Department="ME"},
            new Faculty{Id="F6", Name="Dr. Iyer", Subject="Fluid Mechanics", Department="ME"},
            new Faculty{Id="F7", Name="Dr. Thomas", Subject="Web Development", Department="IT"},
            new Faculty{Id="F8", Name="Dr. Pillai", Subject="Operating Systems", Department="IT"},
            new Faculty{Id="F9", Name="Dr. Nair", Subject="Power Systems", Department="EEE"},
            new Faculty{Id="F10", Name="Dr. Das", Subject="Control Systems", Department="EEE"},
        };

        private List<Course> courses = new List<Course>
        {
            new Course{Id="C1", CourseName="Data Structures", Credits=4, FacultyId=1},
            new Course{Id="C2", CourseName="DBMS", Credits=3, FacultyId=2},
            new Course{Id="C3", CourseName="Computer Networks", Credits=3, FacultyId=3},
            new Course{Id="C4", CourseName="Digital Electronics", Credits=4, FacultyId=4},
            new Course{Id="C5", CourseName="Thermal Engg", Credits=3, FacultyId=5},
            new Course{Id="C6", CourseName="Fluid Dynamics", Credits=4, FacultyId=6},
            new Course{Id="C7", CourseName="Full Stack Web Dev", Credits=3, FacultyId=7},
            new Course{Id="C8", CourseName="Operating Systems", Credits=4, FacultyId=8},
            new Course{Id="C9", CourseName="Power Electronics", Credits=3, FacultyId=9},
            new Course{Id="C10", CourseName="Control Engg", Credits=4, FacultyId=10},
        };

        public delegate void CheckStudentCriteria(IEnumerable<Student> student);
        public event CheckStudentCriteria AttendanceCriteria;
        public event CheckStudentCriteria ResultCriteria;

        public void Notify()
        {
            AttendanceCriteria?.Invoke(students);
            ResultCriteria?.Invoke(students);
        }

        public void FindStudent(string rollNo)
        {
            var st = students.FirstOrDefault(s => s.Id == rollNo);
            if (st != null)
            {
                Console.WriteLine($"\n🔍 Found Student: {st.Id} - {st.Name}, Marks: {st.Marks}, Attendance: {st.Attendance}%");
                AttendanceCriteria?.Invoke(new List<Student> { st });
                ResultCriteria?.Invoke(new List<Student> { st });
            }
            else
            {
                Console.WriteLine($"\n❌ Student with Roll No {rollNo} not found.");
            }
        }

        public void ListStudents()
        {
            Console.WriteLine("\n📌 List of Students:");
            foreach (var st in students)
            {
                Console.WriteLine($"{st.Id} - {st.Name}, Dept: {st.Department}, Marks: {st.Marks}, Attendance: {st.Attendance}%");
            }
        }

        public void ListCourses()
        {
            Console.WriteLine("\n📌 List of Courses:");
            foreach (var cr in courses)
            {
                Console.WriteLine($"{cr.Id} - {cr.CourseName}, Credits: {cr.Credits}, FacultyId: {cr.FacultyId}");
            }
        }

        public void ListFaculties()
        {
            Console.WriteLine("\n📌 List of Faculties:");
            foreach (var fac in faculties)
            {
                Console.WriteLine($"{fac.Id} - {fac.Name}, Subject: {fac.Subject}, Dept: {fac.Department}");
            }
        }

        public void GetStudentsSortedByMarks()
        {
            Console.WriteLine("\n📌 List of Students by Mark:");

            var StudentByMarks = students.OrderByDescending(st => st.Marks);
            foreach (var st in StudentByMarks)
            {
                Console.WriteLine($"{st.Id} - {st.Name}, Dept: {st.Department}, Marks: {st.Marks}, Attendance: {st.Attendance}%");
            }
        }

        public void GetAverageMarksByDepartment()
        {
            Console.WriteLine("\n📌 Average Mark By Departments:");
            var AverageMarksByDepartment = students.GroupBy(s => s.Department)
                                                 .Select(g=>new {Department=g.Key,
                                                     AvgMark =g.Average(s=>s.Marks) });

            foreach (var item in AverageMarksByDepartment)
            {
                Console.WriteLine($"Department: {item.Department}, Average Marks: {item.AvgMark}");
            }

        }

        public void GetFacultiesWithMoreThanTwoCourses()
        {
            Console.WriteLine("\n📌 Faculties More than Two Course:");
            var FacultiesWithMoreThanTwoCourses = faculties.Where(f => f.Name.Count() > 2);
            foreach (var item in FacultiesWithMoreThanTwoCourses)
            {
                Console.WriteLine($"Name: {item.Name}");
            }


        }

        public void GroupStudentsByDepartment()
        {
            Console.WriteLine("\n📌 Group Students By Department:");
            var groupedStudents = students.GroupBy(s => s.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    ListOfStudents = g.Select(s => s.Name).ToList()
                });
            foreach (var dept in groupedStudents)
            {
                Console.WriteLine($"\nDepartment: {dept.Department}");
                foreach (var studentName in dept.ListOfStudents)
                {
                    Console.WriteLine($" - {studentName}");
                }
            }
        }

        public void GetDepartmentWiseStudentCount()
        {
            Console.WriteLine("\n📌 Count of Sudents by Department:");
            var stud = students.GroupBy(s => s.Department)
                .Select(g => new
                {
                    Dep = g.Key,
                    Coun = g.Count()
                });

            foreach (var s in stud)
            {
                Console.WriteLine($"Department: {s.Dep}, Count: {s.Coun}");
            }
        }

        public void GetTop3StudentsByMarks()
        {
            Console.WriteLine("\n📌 Top Three Mark Getters:");
            var stud = students.OrderByDescending(s => s.Marks).Take(3);
            foreach (var s in stud)
            {
                Console.WriteLine($"Name: {s.Name}, Marks: {s.Marks}, Department: {s.Department}");
            }

        }
    }
}
