using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() {
            Time t1 = new Time(11, 58, 31);
            Time t2 = new Time(11, 58, 31);
            Console.WriteLine(  Time.IsAfter(t1, t2) );

            //public static bool IsAfter(Time time1, Time time2)
            //{
            //    if (time1.hour > time2.hour) return true;
            //    if (time1.hour < time2.hour) return false;
            //    if (time1.minute > time2.minute) return true;
            //    if (time1.minute < time2.minute) return false;
            //    if (time1.second > time2.second) return true;
            //    return false;
            //}

        }
    }
}
