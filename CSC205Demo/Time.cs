using System;
using System.Collections.Generic;
using System.Text;

namespace CSC205Demo
{
    class Time
    {
        public int hour, minute;
        public double second;

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0.0;
        }
        public Time(int h, int m, double s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }

        public static void WriteTime(Time t) {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            t.hour, t.minute, (int)t.second));
        }

        public static void WriteTime2(Time t) {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            t.hour, t.minute, (int)t.second));
        }
        public void WriteTime3() {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
             this.hour, this.minute, (int)this.second));
        }
        public void WriteTime4(Time t) {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
             t.hour, t.minute, (int)t.second));
        }

        //Time.WriteTime(t2);
        //Time.WriteTime2(t2);
        //t2.WriteTime3();
        //t2.WriteTime4(t2);
    }
}