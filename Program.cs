using System;
public struct Book // change class to struct to see the difference
{
    public string title, isbn;
    public double price;
}
public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "Think Sharp";
        book1.isbn = "N/A";
        book1.price = 0.0;
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");

        Book book2 = book1;
        Console.WriteLine($"title: {book2.title}, ISBN: {book2.isbn}, Price: {book2.price}");

        book2.title = "The C# Player's Guide";
        book2.isbn = "978-0985580155";
        book2.price = 34.95;

        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
        Console.WriteLine($"title: {book2.title}, ISBN: {book2.isbn}, Price: {book2.price}");
    }
}
