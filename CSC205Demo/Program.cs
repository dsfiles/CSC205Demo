using System;

namespace CSC205Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(20));
        }

        public static double Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
