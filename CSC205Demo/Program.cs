using System;
public class Program
{
    static void Main()
    {
        CountDown(5);
    }
    static void CountDown(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Blastoff!");
        }
        else
        {
            Console.WriteLine(n);
            CountDown(n - 1);
        }
    }
}
