using System;
public class Program
{
    static void Main()
    {

        Sum(10);
    }

    static void Sum(int n)
    {
        int result = 0, i = 1;
        while (i <= n)
        {
            result += i; // result = result + i;
            i++; // i = i + 1;
        }
        Console.WriteLine(result);
    }
}