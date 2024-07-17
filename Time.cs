using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Demo
{
    internal class Time
    {
        public int hour, minute;
        public double second;

        //Here is an example for the Time class:
        public Time()
        {
            hour = 1;
            minute = 2;
            second = 3.0;
        }

        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = 1.0;
        }
        public Time(int hour, int minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
        {
            return this.hour + ":" + this.minute + ":" + this.second;
        }
        public void WriteTime()
        {
            //Console.WriteLine(this.hour + ":" + this.minute + ":" + this.second);
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:0.00}", this.hour, this.minute, this.second));

        }
        public void WriteTime2(Time t)
        {
            Console.WriteLine(t.hour + ":" + t.minute + ":" + t.second);
        }
        public static void WriteTime(Time t)
        {
            Console.WriteLine(t.hour + ":" + t.minute + ":" + t.second);
        }


    }
}
