using System;
public static class StaticClass
{
    public static string staticStr = "A static variable (or data member)";
    public static void StaticMethod()
    {
        Console.WriteLine(staticStr);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        // StaticClass sc = new StaticClass(); // can’t be instantiated!
        Console.WriteLine(StaticClass.staticStr);
        StaticClass.StaticMethod();
    }
}