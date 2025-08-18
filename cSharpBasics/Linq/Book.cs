using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }

    class Disp2
    {
        public static void Display() {
            List<Author> authors = new List<Author>
            {
                 new Author{ AuthorId=1, Name="J.K. Rowling" },
                 new Author{ AuthorId=2, Name="George R.R. Martin" },
                 new Author{ AuthorId=3, Name="J.R.R. Tolkien" }
            };

            List<Book> books = new List<Book>
            {
                new Book{ BookId=1, Title="Harry Potter", AuthorId=1 },
                new Book{ BookId=2, Title="Game of Thrones", AuthorId=2 },
                new Book{ BookId=3, Title="The Hobbit", AuthorId=3 },
                new Book{ BookId=4, Title="Fantastic Beasts", AuthorId=1 }
            };
            Console.WriteLine();
            Console.WriteLine("Number of books published by a author using query: ");

            var numberOfBooksByAuthor = from a in authors
                                        select new
                                        {
                                            AuthorName = a.Name,
                                            BookCount = (from b in books
                                                         where b.AuthorId == a.AuthorId
                                                         select b).Count()
                                        };


            foreach (var a in numberOfBooksByAuthor)
            {
                Console.WriteLine($"Name: {a.AuthorName}, Number of Books: {a.BookCount}");
            }
            Console.WriteLine();
            Console.WriteLine("Number of books published by a author using query Syntax: ");


            var numberOfBooksByAuthor2 = authors.Select(a => new
            {
                AuthorName = a.Name,
                BookCount = books.Count(b => a.AuthorId == b.AuthorId)
            });

            foreach (var a in numberOfBooksByAuthor2)
            {
                Console.WriteLine($"Name: {a.AuthorName}, Number of Books: {a.BookCount}");
            }


        }
    }
}
