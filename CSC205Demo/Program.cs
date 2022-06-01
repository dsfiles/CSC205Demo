using System;
namespace CSC205Quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Median(1, 2, 3));
            Console.WriteLine(Median(1, 3, 2));
            Console.WriteLine(Median(2, 1, 3));
            Console.WriteLine(Median(2, 3, 1));
            Console.WriteLine(Median(3, 2, 1));
            Console.WriteLine(Median(3, 1, 2));
            Console.WriteLine(Median(2, 2, 1));
            Console.WriteLine(Median(2, 2, 3));
            Console.WriteLine(Median(2, 3, 2));
            Console.WriteLine(Median(1, 2, 2));
            Console.WriteLine(Median(3, 2, 2));
        }

        static double Median(double x, double y, double z)
        {
            // Checking for y
            if ((x < y && y < z) || (z < y && y < x))
            {
                return y;
            }
            // Checking for z
            else if ((x < z && z < y) || (y < z && z < x))
            {
                return z;
            }
            // Default to x since we know at this point x is middle
            else return x;
        }

    }
}
