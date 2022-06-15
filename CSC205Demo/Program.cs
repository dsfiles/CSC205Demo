using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() {
            Time t3 = new Time(11, 58, 11);
            Time t4 = new Time(11, 58, 11);
            //Console.WriteLine(  Time.IsAfter(t1, t2) );

            Time.AddTime(t3, t4).WriteTime2();

            //public static Time AddTime(Time t1, Time t2)
            //{
            //    Time sum = new Time();
            //    sum.hour = t1.hour + t2.hour;
            //    sum.minute = t1.minute + t2.minute;
            //    sum.second = t1.second + t2.second;
            //    return sum;
            //}
        }
    }
}
