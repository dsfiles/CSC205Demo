using System;

namespace CSC205Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(Fibonacci2(10));
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

        public static double Fibonacci2(int n)
        {
            double n1 = 1, n2 = 1, temp;
            int i = 0;
            while (i < n-1)
            {
                temp = n1 + n2;
                n1 = n2;
                n2 = temp;
                i = i + 1;
            }
            return n2;
        }

    }
}
