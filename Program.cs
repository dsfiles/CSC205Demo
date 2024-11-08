// Abstract class
using System;
class Sort { 
    static void Main()
    {
        int[] x = { 5, 1, 2, 4, 0};
        MergeSort(0, x.Length-1, x);
        foreach (int item in x)
        {
            Console.WriteLine(item);
        }
    }
    static void MergeSort(int left, int right, int[] x)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        
        MergeSort(left, mid, x);
        MergeSort(mid+1, right, x);
        
        Merge(left, right, mid, x); 
    }
    static void Merge(int left, int right, int mid, int[] c) {
        int[] m = new int[c.Length];
       
        int i = 0, j = mid, k = 0;
        
        while (i<=mid-1 & j<c.Length) {
            if(c[i] < c[j])
                m[k++] = c[i++];            
            else
                m[k++] = c[j++];
        }
        while (i < c.Length)
            m[k++] = c[i++];   

        while (j < c.Length)
            m[k++] = c[j++];

        c = m;

    }
}
