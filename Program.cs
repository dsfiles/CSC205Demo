// Abstract class
using System;
class Sort { 
    static void Main()
    {
        int[] x = { 5, 1, 2, 4, 0, -10 };
        int[] a = { 2, 3, 7, 9 };
        int[] b = { -60, 1, 4, 8, 10, 20, 30 };
        int[] c = new int[a.Length + b.Length];
        Merge(a, b, c);
        foreach (int item in c)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeSort(int[] x)
    {
        if (x.Length == 1) return;
        int mid = x.Length / 2;
        
        int[] p = new int[mid];
        for (int i = 0; i < mid; i++) p[i] = x[i];

        int[] q = new int[x.Length-mid];
        for (int i = 0; q[i] < x.Length;i++) q[i] = x[i];    


    }
    static void Merge(int[] a, int[] b, int[] c)
    {
        int i = 0, j = 0, k = 0;
        while (i<a.Length & j<b.Length)
        {
            if(a[i] < b[j])
                c[k++] = a[i++];            
            else
                c[k++] = b[j++];
        }
        while (i < a.Length)
            c[k++] = a[i++];   

        while (j < b.Length)
            c[k++] = b[j++];
    }
}
