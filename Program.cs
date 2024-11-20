using System;
public struct Book {
    public string title, isbn;
    public double price;
    public static void IncreasePrice(Book b)
    {
        b.price += 10.0;
        Console.WriteLine("price increased by $10!");
    }
}
public class Program {
    public static void Main(string[] args) {
        //Book book1;
        Book book1 = new Book();
        //Console.WriteLine(book1.price);
        book1.title = "C# Programming";
        book1.isbn = "180056810X";
        book1.price = 42.74;
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
        Book.IncreasePrice(book1);
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
    }
}
