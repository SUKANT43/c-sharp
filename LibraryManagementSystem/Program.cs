public class Program
{
    public static void Main(string[] args)
    {

        Console.ReadLine();
    }
}

abstract class Book
{
    private string title;
    private string author;
    private int year;
    public bool IsBorrowed { get; private set; }

    public string Title
    {
        get
        {
            return title;
        }
        set => title = value;
    }

    public string Author
    {
        get => author;
        set => author = value;
    }

    public int Year
    {
        get => year;
        set => year = value;
    }

    protected Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void Borrow() => IsBorrowed = true;
    public void Return() => IsBorrowed = false;

    public abstract void Display();

}
class PrintedBook : Book
{
    public PrintedBook(string title, string author, int year) : base(title, author, year) { }

    public override void Display()
    {
        Console.WriteLine($"[Printed Book] {Title} by {Author} ({Year})");
    }
    
    
}