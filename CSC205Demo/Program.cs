using System;
public class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("Abby");
        Console.WriteLine(p.Name);
        p.Name = "Tom";
        Console.WriteLine(p.Name);
    }
}
