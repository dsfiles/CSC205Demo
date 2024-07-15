using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4 };
        //int[] b = a;
        int[] b = new int[a.Length];
        for (int i = 0; i<a.Length; i++)
        {
            b[i] = a[i];
        }

        b[0] = 5;

        Console.WriteLine("array a:");
        foreach (int i in a) Console.WriteLine(i);

        Console.WriteLine("array b:");
        foreach (int i in b) Console.WriteLine(i);
    }
}