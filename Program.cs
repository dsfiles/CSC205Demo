using System;
namespace ThinkSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] scores = RandomArray(20);
            WriteArray(scores);
            int a = InRange(scores, 90, 100);
            int b = InRange(scores, 80, 90);
            int c = InRange(scores, 70, 80);
            int d = InRange(scores, 60, 70);
            int f = InRange(scores, 0, 60);
            Console.WriteLine($"{a}, {b}, {c}, {d}, {f}");
        }

        public static int InRange(int[] array, int low, int high)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item >= low && item < high)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] RandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
