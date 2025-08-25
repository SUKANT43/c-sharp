using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class DataManagement
    {
       private List<Student> students = new List<Student>();
       private List<Faculty> faculties = new List<Faculty>();
       private List<Course> courses = new List<Course>();

        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public void AddFacultie(Faculty fac)
        {
            faculties.Add(fac);
        }

        public void AddCourse(Course cr)
        {
            courses.Add(cr);
        }

        public IEnumerable<Student> ListOfStudentsByMark()
        {
            return students.OrderBy(st => st.Marks);
        }


    }
}
