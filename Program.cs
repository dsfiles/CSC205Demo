using System;

public class Automobile
{
    public static int NumberOfWheels = 4;
    public static int SizeOfGasTank
    {
        get { return 15; } // SizeOfGasTank is C# property
    }
    public static void Drive()
    {
        Console.WriteLine("I'm driving!");
    }
    // Other non-static fields and properties...
}
public class Program
{
    public static void Main(string[] args)
    {
        Automobile.Drive();
        Console.WriteLine(Automobile.NumberOfWheels);
        var car = new Automobile();
        Console.WriteLine(Automobile.SizeOfGasTank);
        // car.Drive() does not work
    }
}