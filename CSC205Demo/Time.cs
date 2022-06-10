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
            this.hour = 23;
            this.minute = 0;
            this.second = 0.0;
        }
        public Time(int h, int m, double s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }

        public static void WriteTime(Time t)
        {
            Console.Write(t.hour);
            Console.Write(":");
            Console.Write(t.minute);
            Console.Write(":");
            Console.WriteLine(t.second);
        }

        public static void WriteTime2(Time t)
        {   // a version that uses String.Format
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            t.hour, t.minute, (int)t.second));
        }

        public void WriteTime3()
        {  // a version uses this
            Console.WriteLine(this.hour + ":" + this.minute + ":" + this.second);
        }
    }
}