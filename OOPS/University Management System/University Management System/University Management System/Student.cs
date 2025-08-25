using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Student:Person
    {
        public override string Id { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public int Marks { get; set; }
        public string Department { get; set; }
        public int Attendance { get; set; }

        public delegate void CheckStudentCriteria(Student st);
        public event CheckStudentCriteria AttendanceCriteria;
        public event CheckStudentCriteria ResultCriteria;
        public void AttendanceAlert()
        {
            AttendanceCriteria?.Invoke(this);
            ResultCriteria?.Invoke(this);
        }
    }
}
