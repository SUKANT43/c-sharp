using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class StudentDetails
    {
        public string id;
        public string name;
    }

    class Result
    {
        public string id;
        public int mark;
    }

    class Manipulate
    {
        public static void display()
        {
            List<StudentDetails> listOfStudents = new List<StudentDetails>()
            {
                new StudentDetails { id = "S01", name = "Alice" },
                new StudentDetails { id = "S02", name = "Bob" },
                new StudentDetails { id = "S03", name = "Charlie" },
                new StudentDetails { id = "S04", name = "David" },
                new StudentDetails { id = "S05", name = "Eva" },
                new StudentDetails { id = "S06", name = "Frank" },
                new StudentDetails { id = "S07", name = "Grace" },
                new StudentDetails { id = "S08", name = "Henry" },
                new StudentDetails { id = "S09", name = "Ivy" },
                new StudentDetails { id = "S10", name = "Jack" }
            };
            List<Result> listOfResult = new List<Result>()
            {
                new Result { id = "S01", mark = 85 },
                new Result { id = "S02", mark = 72 },
                new Result { id = "S03", mark = 90 },
                new Result { id = "S04", mark = 65 },
                new Result { id = "S05", mark = 78 },
                new Result { id = "S06", mark = 88 },
                new Result { id = "S07", mark = 92 },
                new Result { id = "S08", mark = 59 },
                new Result { id = "S09", mark = 74 },
                new Result { id = "S10", mark = 81 }
            };
            Console.WriteLine();
            Console.WriteLine("Join both result and student using query:");


            var FinalResult = (from s in listOfStudents
                               join r in listOfResult
                               on s.id equals r.id
                               orderby s.id
                               select new { s.id, s.name, r.mark });

            foreach (var res in FinalResult)
            {
                Console.WriteLine($"Id: {res.id} Name: {res.name} Mark: {res.mark}");
            }

            var FinalResult2 = listOfStudents
                .Join(listOfResult,
                s => s.id,
                r => r.id,
                (s, r) => new { s.id, s.name, r.mark })
                .OrderBy(x => x.id)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("Join using query syntax:");
            foreach (var res in FinalResult2)
            {
                Console.WriteLine($"Id: {res.id} Name: {res.name} Mark: {res.mark}");
            }
        }
    }
}
