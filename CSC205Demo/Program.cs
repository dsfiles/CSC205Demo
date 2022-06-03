using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter the first interger:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second interger:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third interger:");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The largest number is {LargestOfThree(a, b, c)}");
    }
    public static int LargestOfThree(int a, int b, int c)
    {
        int result;
        if (a >= b && a >= c)
        {
            result = a;
        }
        else if (b >= c && b >= a)
        {
            result = b;
        }
        else
        {
            result = c;
        }
        return result;
    }
}
