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
    
}
