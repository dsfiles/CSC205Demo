using System;

public class ExceptionTest
{
    static double SafeDivision(double x, double y)
    {
        //if (y == 0) throw new DivideByZeroException();
        return x / y;
    }
    public static void Main()
    {
        // Change the values to see exception handling behavior.
        double a = 98, b = 2;
        double result;
        result = SafeDivision(a, b);
        Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
        
        //try
        //{
        //    result = SafeDivision(a, b);
        //    Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Attempted divide by zero.");
        //}
    }
}
