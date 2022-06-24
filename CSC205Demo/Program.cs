using System;
namespace CSC205Quiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 5, 1, 4 };
            int tmp;
            Console.WriteLine("The original array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\nThe modified array :");
            foreach (int i in a)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}