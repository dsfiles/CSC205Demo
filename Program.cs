using System;
public class Book
{
    public string title;
    public string isbn;
    public double price;
    public Book()
    {
        title = "";
        isbn = "";
        price = 0.0;
    }
    public Book(string t, string i, double p)
    {
        title = t;
        isbn = i;
        price = p;
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("C# 9 and .NET 5", "180056810X", 42.74);
        Console.WriteLine(book1.title);
        Book book2 = new Book("C# in Depth", "1617294535", 38.99);
        Console.WriteLine(book2.title);
        Book book3 = new Book();
        Console.WriteLine("book 3 title: " + book3.title);

    }
}
