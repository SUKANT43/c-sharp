using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Course
    {
       public string Id { get; set; }
       public string CourseName { get; set; }
       public int Credits { get; set; }
       public int FacultyId { get; set; }
    }
}
