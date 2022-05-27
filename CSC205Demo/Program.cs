using System;
public class Program
{
    static void Main()
    {
        Console.WriteLine(Sum(10));
        Console.WriteLine(Sum2(10));
        
    }

    static int Sum(int n)
    {
        int result = 0, i = 1;
        while (i <= n)
        {
            result = result + i;
            i = i + 1;
        }
        return result;
    }

    static int Sum2(int n)
    {
        int result = 0, i = 1;
        do
        {
            result = result + i;
            i = i + 1;
        }
        while (i <= n);
        return result;
    }

}