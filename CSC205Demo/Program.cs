using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        var fibonacciNumbers = new List<int> { 1, 1 };
        while (fibonacciNumbers.Count < 10)
        {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(previous + previous2);
        }

        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }
}