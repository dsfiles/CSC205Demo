using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Demo
{
    internal class Program
    {

        public static void Zoop()
        {
            Baffle();
            Console.Write("You wugga ");
            Baffle();
        }

        public static void Main(string[] args)
        {
            Console.Write("No, I ");
            Zoop();
            Console.Write("I ");
            Baffle();
        }

        public static void Baffle()
        {
            Console.Write("wug");
            Ping();
        }
        public static void Ping()
        {
            Console.WriteLine(".");
        }
    }
}
