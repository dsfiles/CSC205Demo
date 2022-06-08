using System;
namespace CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var t = new Time();
            //t.hour = 11;
            //t.minute = 45;
            //t.second = 22;
            Console.WriteLine($"{t.hour}:{t.minute}:{t.second}");
            var t2 = new Time(11, 55, 23.0);
            Console.WriteLine($"{t2.hour}:{t2.minute}:{t2.second}");
        }
    }
    public class Time
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
    }
}
