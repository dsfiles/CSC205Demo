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
            Console.WriteLine("first line");
            NewLine(); NewLine(); NewLine();
            Console.WriteLine("last line");
            Console.ReadKey();
        }
        static void NewLine()
        {
            Console.WriteLine("---");
        }
    }
}
