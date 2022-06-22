//textbook page 153-154
using System;
namespace ThinkSharp
{
    public class Time
    {
        public int Hour, Minute;
        public double Second;
        public Time()
        { this.Hour = 0; this.Minute = 0; this.Second = 0.0; }
        public Time(int hour, int minute, double second)
        {
            this.Hour = hour; this.Minute = minute;
            this.Second = second;
        }
        public Time(double seconds)
        {
            Hour = (int)(seconds / 3600.0);
            seconds -= Hour * 3600.0;
            Minute = (int)(seconds / 60.0);
            Second = seconds - (Minute * 60.0);
        }
        public double ToSeconds()
        {
            int minutes = Hour * 60 + Minute;
            return minutes * 60 + Second;
        }
        public string ToString()
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2}",
            Hour, Minute, (int)Second);
        }
        public bool IsAfter(Time time)
        { return ToSeconds() > time.ToSeconds(); }
        public void AddTime(Time time)
        {
            Hour += time.Hour;
            Minute += time.Minute;
            Second += time.Second;
            adjustForOverflow();
        }
        public void Increment(double seconds)
        { Second += seconds; adjustForOverflow(); }
        private void adjustForOverflow()
        {
            while (Second >= 60.0)
            { Second -= 60.0; Minute += 1; }
            while (Minute > 59)
            { Minute -= 60; Hour += 1; }
        }
    } // end of class Time

    public class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            Console.WriteLine(t.ToString());
            var dt1 = new DateAndTime();
            var dt2 = new DateAndTime(20, 4, 2014, 12, 0, 0);
            Console.WriteLine(dt1.ToString());
            Console.WriteLine($"{dt2.Year}, {dt2.Month},  {dt2.Day}, {dt2.Hour}, {dt2.Minute}, {dt2.Second}");
        }
    }

    public class DateAndTime : Time
    {
        public int Day, Month, Year;
        public DateAndTime() : base()
        { Day = 0; Month = 0; Year = 0; }
        public DateAndTime(int day, int month, int year,
        int hour, int minute, double second)
        : base(hour, minute, second)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void Increment(double seconds)
        {
            base.Increment(seconds);
            adjustForOverflow();
        }

        private void adjustForOverflow()
        {
            while (Hour > 23)
            {
                Hour -= 24;
                Day += 1;
            }
            // TODO: Day overflows into Month
            // TODO: Month overflows into Year
        }
    }
}