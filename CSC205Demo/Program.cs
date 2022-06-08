// Write down the output then run the program to check your answer
using System;
class CSC205Week04ExerciseOne
{
    static void Main(string[] args)
    {
        Method(3, 5);
        Method(3, 5.0);
        Method(3.0, 5);
        Method(3.0, 5.0);
    }
    public static void Method(int a, int b)
    {
        Console.WriteLine($"a: {a.GetType()}, b: {b.GetType()}");
    }
    public static void Method(double a, int b)
    {
        Console.WriteLine($"a: {a.GetType()}, b: {b.GetType()}");
    }
    public static void Method(double a, double b)
    {
        Console.WriteLine($"a: {a.GetType()}, b: {b.GetType()}");
    }
}
