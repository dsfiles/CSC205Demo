using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        var numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");

        // A stack can be enumerated without disturbing its contents.
        Console.WriteLine("Contents of the stack:");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nPopping '{0}'", numbers.Pop());
        Console.WriteLine("Peek at next item: {0}",
            numbers.Peek()); // Peek does not remove the item
        Console.WriteLine("Contents of the stack now:");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
} //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-8.0
