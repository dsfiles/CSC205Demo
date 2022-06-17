using System;
namespace CSC205Demo
{
    public class Program {
        public static void Main()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rnd.Next(7));
            }
            
        }
    }
}
