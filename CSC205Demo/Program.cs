using System;
namespace CSC205Demo
{
    using System;
    public class Book
    {
        public string title;
        public string isbn;
        public double price;
        public Book()
        {   title = ""; isbn = ""; price = 0.0; }
        public Book(string t, string i, double p) {
            title = t; isbn = i; price = p;
        }
        public void Display(){ 
            Console.WriteLine($"Title: {this.title}, ISBN: {this.isbn}, Price: {this.price}"); 
        }
    }
    public class Program {
        public static void Main(string[] args) {
            var book1 = new Book();
            book1.Display();

            Book book2 = new Book("C# in Depth", "1617294535", 38.99);
            book2.Display();
        }
    }
}
