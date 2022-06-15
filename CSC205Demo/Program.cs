using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() {
            var t1 = new Time();
            var t2 = new Time(9, 35, 28);
            // invoke WriteTime1 to display t2
            Time.WriteTime1(t2);
            // invoke WriteTime2 to display t2
            t2.WriteTime2();
            // two ways to invoke WriteTime3 to display t2
            t2.WriteTime3(t2);
            t1.WriteTime3(t2);
            //public static void WriteTime1(Time t)
            //public void WriteTime2()
            //public void WriteTime3(Time t)
        }
    }
}
