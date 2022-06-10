using System;
namespace CSC205Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var t = new Time();
            Console.WriteLine($"{t.hour}:{t.minute}:{t.second}");
            
            var t2 = new Time(11, 55, 23.0);
            Console.WriteLine($"{t2.hour}:{t2.minute}:{t2.second}");

            Time.WriteTime(t2);
            //public static void WriteTime(Time t)
            //{
            //    Console.Write(t.hour);
            //    Console.Write(":");
            //    Console.WriteLine(t.minute);
            //}
        }
    }
    
}
