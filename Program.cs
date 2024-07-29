using System;
public struct Book // change struct to class to see the difference
{
    public string title, isbn;
    public double price;
}
public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.price);
        book1.title = "C# Programming";
        book1.isbn = "180056810X";
        book1.price = 42.74;
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
    }
}
