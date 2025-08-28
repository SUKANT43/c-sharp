using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CourseId { get; set; }
    public int Marks { get; set; }
}

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
    new Student { Id = 1, Name = "Alice",   CourseId = 1, Marks = 90 },
    new Student { Id = 2, Name = "Bob",     CourseId = 2, Marks = 75 },
    new Student { Id = 3, Name = "Charlie", CourseId = 1, Marks = 85 },
    new Student { Id = 4, Name = "David",   CourseId = 3, Marks = 70 },
    new Student { Id = 5, Name = "Eve",     CourseId = 2, Marks = 95 }
        };

        List<Course> courses = new List<Course>
        {
            new Course { Id = 1, Title = "Math" },
            new Course { Id = 2, Title = "Science" },
            new Course { Id = 3, Title = "History" }
        };

        var studentCourses = students.Join(
            courses,
            s=>s.CourseId,
            c=>c.Id,
            (s, c) => new {s.Name,c.Title}
            );

        foreach(var sc in studentCourses)
        {
            Console.WriteLine($"Name: {sc.Name}, Course: {sc.Title}");
        }

        var CourseCount = students.GroupBy(s => s.CourseId)
            .Select(c => new
            {
                CourseId = c.Key,
                CourseCount = c.Count()
            });

        foreach(var sc in CourseCount)
        {
            Console.WriteLine($"CourseId: {sc.CourseId}, CourseCount: {sc.CourseCount}");
        }

        var averageMarks = students.GroupBy(s => s.CourseId)
            .Select(k => new {
                CourseId = k.Key,
                avg = k.Average(s => s.Marks)
            });
        foreach(var st in averageMarks)
        {
            Console.WriteLine($"Course id: {st.CourseId}, Average Marks: {st.avg}");
        }

        var HighScore = students.GroupBy(s=>s.CourseId)
            .Select(r=>new
            {
                CourseId=r.Key,
                Topper=r.OrderByDescending(s=>s.Marks).First()
            });

        foreach(var sc in HighScore)
        {
            Console.WriteLine($"Course: {sc.CourseId}, Topper: {sc.Topper}");
        }

        var groupNameByCourse = students.GroupBy(s => s.CourseId)
            .Select(r => new
            {
                CourseId = r.Key,
                Names = r.Select(s => s.Name).ToList()
            });

        foreach(var gn in groupNameByCourse)
        {
            Console.WriteLine($"CourseId:{gn.CourseId}");
            Console.Write("Name List");
            foreach(var n in gn.Names)
            {
                Console.WriteLine(n);
            }
        }



        Console.ReadLine();

    }
}
