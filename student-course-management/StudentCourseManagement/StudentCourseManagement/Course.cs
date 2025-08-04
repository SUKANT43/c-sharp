using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseManagement
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int CourseId, string CourseName)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Course Id: {CourseId}" +$" Course Name: {CourseName}");
        }
    }
}
