namespace _2._7;

class Program
{
    static void Main(string[] args)
    {
        string? GetAuthor(Book? book)
        {
            return book?.Author;
        }

        Book? book1 = new Book { Title = "1984", Author = "George Orwell" };
        Book? book2 = new Book { Title = "Unknown", Author = null };
        Book? book3 = null;

        Console.WriteLine(GetAuthor(book1) ?? "No author provided");
        Console.WriteLine(GetAuthor(book2) ?? "No author provided");
        Console.WriteLine(GetAuthor(book3) ?? "No book provided");
    }
}