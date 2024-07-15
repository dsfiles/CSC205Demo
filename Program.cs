using CSC205Demo;
using System;
namespace CSC205Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            Console.WriteLine(t1.hour);
            Console.WriteLine(t1.minute);
            Console.WriteLine(t1.second);

            Time t2 = new Time();
            Console.WriteLine(t2.hour);
            Console.WriteLine(t2.minute);
            Console.WriteLine(t2.second);

            Time t3 = new Time(3, 50, 23);
            Console.WriteLine(t3.hour);
            Console.WriteLine(t3.minute);
            Console.WriteLine(t3.second);

        }
    }
}
//public Time()
//{
//    this.hour = 1;
//    this.minute = 2;
//    this.second = 3.0;
//}
