class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }

    public LibraryBook(string title, string author, bool available)
    {
        Title = title;
        Author = author;
        Available = available;
    }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"{Title} by {Author} has been borrowed successfully!");
        }
        else
        {
            Console.WriteLine($"{Title} by {Author} is currently unavailable.");
        }
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Available: {Available}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create book objects
        LibraryBook book1 = new LibraryBook("The Lord of the Rings", "J.R.R. Tolkien", true);
        LibraryBook book2 = new LibraryBook("Pride and Prejudice", "Jane Austen", true);
        LibraryBook book3 = new LibraryBook("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", false);

        // Borrow book1
        book1.BorrowBook();

        // Display information for all books
        Console.WriteLine("Library Status:");
        book1.DisplayBookInfo();
        book2.DisplayBookInfo();
        book3.DisplayBookInfo();
    }
}
