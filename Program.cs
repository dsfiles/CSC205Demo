using System;
public class Program {
    public static void Main(string[] args) {
        int[] a = { 1, 2, 3, 4 };
        Console.WriteLine("before:");
        foreach (int i in a) Console.WriteLine(i);
        ModifyArray(a);
        Console.WriteLine("after:");
        foreach (int i in a) Console.WriteLine(i);
    }
    static void ModifyArray(int[] b) {
        for (int i = 0; i < b.Length; i++)
        {
            b[i]++;
        }
    }
}