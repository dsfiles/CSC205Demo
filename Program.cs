using CSC205Demo;
using System;
namespace CSC205Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            Console.WriteLine(t1.ToString());

            Time t2 = new Time(1, 19);
            Console.WriteLine(t2);

            Time t3 = new Time(3, 50, 23);
            Console.WriteLine(t3);
            t3.WriteTime();
           
        }
    }
}

