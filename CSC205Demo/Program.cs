using System;
namespace CSC205Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var t = new Time();
            //Console.WriteLine($"{t.hour}:{t.minute}:{t.second}");
            
            var t2 = new Time(11, 5, 23.4567);
            //Console.WriteLine($"{t2.hour}:{t2.minute}:{t2.second}");

            Time.WriteTime(t2);
            Time.WriteTime2(t2);
            t2.WriteTime3();
            t2.WriteTime4(t2);

        }
    }
    
}
