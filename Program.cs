// Abstract class
using System;
class Sort { 
    static void Main()
    {
        int[] x = { 5, 1, 2, 4, 0, -10 };
        MergeSort(x);
        foreach (int item in x)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeSort(int[] x)
    {
        if (x.Length == 1 || x.Length ==0) return;
        
        int mid = x.Length / 2;
        
        int[] p = new int[mid];
        for (int i = 0; i < mid; i++) p[i] = x[i];
        ;
        int[] q = new int[x.Length-mid];
        for (int i = mid; i < x.Length;i++) q[i-mid] = x[i];
        ;
        MergeSort(p);
        MergeSort(q);
        ;
        Merge(p, q, x); 

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
