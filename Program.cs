using System;

public class Program
{
    static void Main()
    {
        int i = 3;
        Console.WriteLine(i);   
        Console.WriteLine(i++); 
        Console.WriteLine(i);   
        double a = 1.5;
        Console.WriteLine(a);   
        Console.WriteLine(++a); 
        Console.WriteLine(a);   
        int x, y, z = 1;
        x = z++;
        y = ++z;
        Console.WriteLine(x);   
        Console.WriteLine(y);   
    }

}
