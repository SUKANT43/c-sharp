using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }

    class Disp
    {
        public static void display()
        {
            List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "C# Basics", Author = "John" },
            new Book { Id = 2, Title = "LINQ in Depth", Author = "Alice" },
            new Book { Id = 3, Title = "ASP.NET Core", Author = "John" },
            new Book { Id = 4, Title = "Entity Framework", Author = "David" }
        };

            /* Console.WriteLine("Book Written by John:");
             var listOfBooksWrittenByJohn = books.Where(b => b.Author == "John")
             .Select(b => new { b.Title });*/

            /*Console.WriteLine("Longest Title");
            var longestTitle = books.OrderByDescending(b => b.Title.Length)
                                   // .FirstOrDefault();
             Console.WriteLine(longestTitle.Title);*/


            /*var bookWritenByJohn = books.Where(b => b.Author == "John")
                                    .Count();
            Console.WriteLine(bookWritenByJohn);*/

            /*var orderBooks = books.OrderBy(b => b.Title)
                               .Select(b=>new { b.Title});*/

            /*var authorAlice = books.Any(b => b.Author == "Alice");
            Console.WriteLine(authorAlice);*/

            /*var bookStartsWithA = books.Where(b => b.Title.StartsWith("A"))
                                        .FirstOrDefault();
            Console.WriteLine(bookStartsWithA.Title);*/


            /*var bookLengthMoreThan10 = books.Where(b => b.Title.Length > 10)
                .Select(b => new { b.Title });*/

            /*var nameContainsO = books.Where(b => b.Author.Contains("o"))
                .Select(b => new { b.Author });*/

            /* var lastBook = books.LastOrDefault();
             Console.WriteLine(lastBook.Title);*/

            /*var totalTitleLength = books.Sum(b => b.Title.Length);
            Console.WriteLine(totalTitleLength);*/

            /*var smallTitle = books.Min(b => b.Title.Length);
            Console.WriteLine(smallTitle);*/


            List<int> list = new List<int>();
            foreach (var b in list)
            {
                Console.WriteLine();
            }
        }
    }
}
