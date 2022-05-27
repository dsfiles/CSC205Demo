using System;
public class Program
{
    static void Main()
    {
        int result = 0, i = 1;
        while (i <= 10)
        {
            result += i;
            i++;
        }
        Console.WriteLine(result);
    }
}