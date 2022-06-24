using System;
public enum Season
{ //names of enum members
    Spring,
    Summer,
    Autumn,
    Winter
}
public class EnumConversionExample
{
    public static void Main()
    {
        Season a = Season.Autumn;
        Console.WriteLine($"Integral value of {a} is {(int)a}");
        var b = (Season)1;
        Console.WriteLine(b);  // output: Summer
        var c = (Season)4;
        Console.WriteLine(c);  // output: 4
    }
}