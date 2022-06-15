using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() {
            var t1 = new Time();
            var t2 = new Time(9, 35, 28);
            Time.WriteTime1(t2);
            t2.WriteTime2();
            t1.WriteTime3(t2);
            t2.WriteTime3(t2);
        }
    }
}
