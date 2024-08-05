using System;
using System.Collections.Generic;
class Example
{
    public static void Main()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        // A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
        Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("\nItems in the queue now:");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1
