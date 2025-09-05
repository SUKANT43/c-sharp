using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // ======================
    // OOP: Base Class
    // ======================
    abstract class Book
    {
        private string title;
        private string author;
        private int year;
        public bool IsBorrowed { get; private set; }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }

        protected Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void Borrow() => IsBorrowed = true;
        public void Return() => IsBorrowed = false;

        // Polymorphism
        public abstract void Display();
    }

    // ======================
    // Inherited Classes
    // ======================
    class PrintedBook : Book
    {
        public PrintedBook(string title, string author, int year) : base(title, author, year) { }

        public override void Display()
        {
            Console.WriteLine($"[Printed Book] {Title} by {Author} ({Year})");
        }
    }

    class EBook : Book
    {
        public double FileSizeMB { get; set; }

        public EBook(string title, string author, int year, double size) : base(title, author, year)
        {
            FileSizeMB = size;
        }

        public override void Display()
        {
            Console.WriteLine($"[E-Book] {Title} by {Author} ({Year}) - {FileSizeMB}MB");
        }
    }

    // ======================
    // Member Class
    // ======================
    class Member
    {
        public string Name { get; set; }

        public Member(string name)
        {
            Name = name;
        }

        public void NotifyBookIssued(object sender, Book book)
        {
            Console.WriteLine($"📢 {Name} notified: You borrowed '{book.Title}'");
        }

        public void NotifyBookReturned(object sender, Book book)
        {
            Console.WriteLine($"📢 {Name} notified: You returned '{book.Title}'");
        }
    }

    // ======================
    // Delegates and Events
    // ======================
    public delegate void BookOperation(Book book);

    class Library
    {
        public List<Book> Books { get; } = new List<Book>();

        // Events
        public event EventHandler<Book> OnBookIssued;
        public event EventHandler<Book> OnBookReturned;

        public void AddBook(Book book) => Books.Add(book);

        public void BorrowBook(Book book)
        {
            if (!book.IsBorrowed)
            {
                book.Borrow();
                OnBookIssued?.Invoke(this, book);
            }
            else
            {
                Console.WriteLine($"❌ Book '{book.Title}' is already borrowed.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (book.IsBorrowed)
            {
                book.Return();
                OnBookReturned?.Invoke(this, book);
            }
            else
            {
                Console.WriteLine($"❌ Book '{book.Title}' was not borrowed.");
            }
        }
    }

    // ======================
    // Program Execution
    // ======================
    class Program
    {
        static void Main(string[] args)
        {
            // Create library
            Library library = new Library();

            // Add books
            library.AddBook(new PrintedBook("The Hobbit", "J.R.R. Tolkien", 1937));
            library.AddBook(new PrintedBook("1984", "George Orwell", 1949));
            library.AddBook(new EBook("Clean Code", "Robert C. Martin", 2008, 5.6));
            library.AddBook(new EBook("C# in Depth", "Jon Skeet", 2019, 8.1));
            library.AddBook(new PrintedBook("Pride and Prejudice", "Jane Austen", 1813));

            // Members
            Member alice = new Member("Alice");
            Member bob = new Member("Bob");

            // Subscribe members to events
            library.OnBookIssued += alice.NotifyBookIssued;
            library.OnBookIssued += bob.NotifyBookIssued;
            library.OnBookReturned += alice.NotifyBookReturned;

            // Delegate for book operations
            BookOperation borrowOp = library.BorrowBook;
            BookOperation returnOp = library.ReturnBook;

            // Borrow and return using delegates
            Console.WriteLine("\n--- Borrowing Books ---");
            borrowOp(library.Books[0]); // Alice + Bob notified
            borrowOp(library.Books[1]);

            Console.WriteLine("\n--- Returning Books ---");
            returnOp(library.Books[0]); // Only Alice notified

            // ======================
            // LINQ Queries
            // ======================
            Console.WriteLine("\n--- LINQ Queries ---");

            // Find all books by Orwell
            var orwellBooks = library.Books.Where(b => b.Author == "George Orwell");
            Console.WriteLine("Books by George Orwell:");
            foreach (var b in orwellBooks) b.Display();

            // Available books
            var available = library.Books.Where(b => !b.IsBorrowed);
            Console.WriteLine("\nAvailable Books:");
            foreach (var b in available) b.Display();

            // Sorted by year
            var sorted = library.Books.OrderBy(b => b.Year);
            Console.WriteLine("\nBooks Sorted by Year:");
            foreach (var b in sorted) b.Display();

            // Count borrowed
            int borrowedCount = library.Books.Count(b => b.IsBorrowed);
            Console.WriteLine($"\nBorrowed Books Count: {borrowedCount}");
        }
    }
}
