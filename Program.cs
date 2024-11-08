// Abstract class
using System;
class Sort { 
    static void Main()
    {
        int[] a = { 2, 3, 7, 9 };
        int[] b = { 0, 1, 4, 8 };
        int[] c = new int[8];
        MergeArray(a, b, c);
        foreach (int item in c)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeArray(int[] a, int[] b, int[] c)
    {
        int i = 0, j = 0, k = 0;
        while (i<4 & j<4)
        {
            if(a[i] < b[j])
            {
                c[k] = a[i];
                i++; k++;
            }
            else
            {
                c[k] = b[j];
                j++; k++;
            }
        }

    }
}
