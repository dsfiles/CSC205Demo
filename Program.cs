using System;
public class Cat
{
    // Auto-implemented properties.
    public int Age { get; set; }
    public string Name { get; set; }
    public Cat() { }
    public Cat(string name)
    {
        this.Name = name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat { Age = 10, Name = "Fluffy" };
        Cat sameCat = new Cat("Fluffy") { Age = 10 };
        Cat sameSameCat = new Cat() { Age=10, Name="Fluffy"};
        Console.WriteLine($"cat name: {cat.Name}, cat age: {cat.Age}");
        Console.WriteLine($"cat name: {sameCat.Name}, cat age: {sameCat.Age}");
        Console.WriteLine($"cat name: {sameSameCat.Name}, cat age: {sameSameCat.Age}");

    }
}
