using System;
public class StaticClass
{
    //public string staticStr = "A static variable (or data member)";
    public string Str { get; set; }
    public void StaticMethod()
    {
        Console.WriteLine(Str);
    }
}
public class Program {
    static void Main(string[] args)
    {
        //StaticClass sc = new StaticClass(); 
        StaticClass sc = new StaticClass {Str = "I'm a property!"};
        Console.WriteLine(sc.Str);
        sc.StaticMethod();
    }
}