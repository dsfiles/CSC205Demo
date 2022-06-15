using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() {
            Time t3 = new Time(11, 58, 159);
            
            Time t4 = new Time(11, 28, 9);
            //Console.WriteLine(  Time.IsAfter(t1, t2) );

            Time.AddTime2(t3, t4).WriteTime2();

            Time.Increment(t4, 29);

            //public static void Increment(Time time, double secs)
        }
    }
}
