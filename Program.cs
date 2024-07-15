using CSC205Demo;
using System;
namespace CSC205Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            Console.WriteLine(t1);

            Time t2 = new Time();
            Console.WriteLine(t2);

            Time t3 = new Time(3, 50, 23);
            Console.WriteLine(t3);
        }
    }
}
//public Time()
//{
//    this.hour = 1;
//    this.minute = 2;
//    this.second = 3.0;
//}
