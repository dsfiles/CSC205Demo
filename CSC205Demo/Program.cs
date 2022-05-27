using System;
public class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 6)
        {
            WriteMultiples(i);
            i++;
        }
    }
    static void WriteMultiples(int n)
    {
        int i = 1;
        while (i <= 6)
        {
            Console.Write(n * i + " ");
            i++;
        }
        Console.WriteLine();
    }
}
