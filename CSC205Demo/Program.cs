using System;
namespace CSC205Demo
{
    public class Program {
        public static void Main()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random.NextDouble();
                Console.WriteLine(x);
            }


        }
    }
}
