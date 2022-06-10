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
            Console.Write(t.second);
        }

    }
}
