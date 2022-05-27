using System;
namespace CSC205Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 0, minute = 14, second = 0;
            int secondSinceMidnight;
            secondSinceMidnight = hour * 60 * 60 + minute * 60 + second;
            Console.WriteLine("Number of seconds since midnight: " + secondSinceMidnight);
            Console.WriteLine("Number of seconds remaining in the day: " + (24 * 60 * 60 - secondSinceMidnight));
            Console.WriteLine("Fraction of the day that has passed: " + (double)secondSinceMidnight / (24 * 60 * 60) * 100);
        }
    }
}