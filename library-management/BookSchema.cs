public class BookSchema
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Stock { get; set; }

    public BookSchema(int id, string title, string author, int stock)
    {
        Id = id;
        Title = title;
        Author = author;
        Stock = stock;
    }
}
