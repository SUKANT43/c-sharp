public class ManageBook
{
    private static List<BookSchema> books = new List<BookSchema>();

    public static void AddBook(int id, string title, string author, int Stock)
    {
        BookSchema newBook = new BookSchema(id, title, author, Stock);
        books.Add(newBook);
        Console.WriteLine($"Book '{title}' added successfully.");
    }
    public static void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Console.WriteLine("Available Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Stock: {book.Stock}");
        }
    }

    public static void RemoveBook(int id)
    {
        var bookToRemove = books.FirstOrDefault(b => b.Id == id);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book with ID {id} removed successfully.");
        }
        else
        {
            Console.WriteLine($"No book found with ID {id}.");
        }
    }

    public static void UpdateBookStock(int id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                if(book.Stock <= 0)
                {
                    Console.WriteLine($"No stock available for {book.Title} with ID {id}.");
                    return;
                }
                book.Stock--;
                Console.WriteLine("Now you have borrowed a book.");
                Console.WriteLine($"Remaining stock for {book.Title} is now {book.Stock}.");
            }
        }
    }
}