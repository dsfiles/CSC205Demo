using System;
namespace CSC205Demo
{
    using System;
    public class Program {
        public static void Main() 
        {
            int[] count = new int[4];
            count[0] = 7;
            count[1] = count[0] * 2;
            count[2]++;
            count[3] -= 60;

            int[] arr = new int[4];
            arr = count;

            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
