using System;
using System.Collections.Generic;
class Example {
    public static void Main() {
        var numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        // A queue can be enumerated without disturbing its contents.
        Console.WriteLine("Contents of queue:");
        foreach (var number in numbers) {
            Console.WriteLine(number);
        }
        
        var numbersStack = new Stack<string>();
        foreach (var number in numbers) {
            numbersStack.Push(number);
        }
       
        Console.WriteLine("Contents of stack:");
        foreach (var number in numbersStack) {
            Console.WriteLine(number); ;
        }

        Console.WriteLine("Contents of queue again:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}
