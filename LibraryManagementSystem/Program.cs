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
    

}