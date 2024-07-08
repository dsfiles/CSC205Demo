// Collatz Conjecture textbook page 63 
using System;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer (>1) to check Collatz Conjecture:");
        int n = int.Parse(Console.ReadLine());
        Sequence(n);
    }
    public static void Sequence(int n)
    {
        while (n != 1)
        {
            Console.WriteLine(n);
            if (n % 2 == 0)
            { // n is even
                n = n / 2;
            }
            else
            { // n is odd
                n = n * 3 + 1;
            }
        }
    }
}
