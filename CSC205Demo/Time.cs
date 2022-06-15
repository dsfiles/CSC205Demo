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

        public static void WriteTime1(Time t) {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            t.hour, t.minute, (int)t.second));
        }
        public void WriteTime2() {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
             this.hour, this.minute, (int)this.second));
        }
        public void WriteTime3(Time t) {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
             t.hour, t.minute, (int)t.second));
        }

        public static bool IsAfter(Time time1, Time time2)
        {
            if (time1.hour > time2.hour) return true;
            if (time1.hour < time2.hour) return false;
            if (time1.minute > time2.minute) return true;
            if (time1.minute < time2.minute) return false;
            if (time1.second > time2.second) return true;
            return false;
        }

        public static Time AddTime(Time t1, Time t2)
        {
            Time sum = new Time();
            sum.hour = t1.hour + t2.hour;
            sum.minute = t1.minute + t2.minute;
            sum.second = t1.second + t2.second;
            return sum;
        }


    }
}