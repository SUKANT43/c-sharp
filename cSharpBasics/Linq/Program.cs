using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var evens = from num in numbers
                        where num % 2 == 0
                        select num;

            var evens2 = numbers.Where(num => num % 2 == 0);
            Console.WriteLine(string.Join(", ", evens));
            Console.WriteLine(string.Join(" ,",evens2));
            Linq.Obj.Display();
            Console.ReadLine();
        }
    }
}
