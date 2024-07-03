using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            int p = (int)pi;
            double q = Math.Round(pi * 20.1);

            Console.WriteLine(p);
            Console.WriteLine(q); 
            Console.ReadKey();
        }
    }
}
