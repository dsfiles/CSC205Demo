using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        Print(arr, "Original array:"); 

    }

    static void Print(int[] arr, string msg)
    {
        Console.WriteLine(msg);
        foreach (int i in arr) Console.Write(i + " ");
        Console.WriteLine();
    }

    static void Insert(int[] arr, int x, int index) {
        // your code here to insert x at "index" in arr
    }

    static void Remove(int[] arr, int index)
    {
        // your code here to remove the element at "index"
    }


}
