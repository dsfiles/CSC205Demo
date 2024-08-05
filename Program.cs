using System;
using System.Collections;
public class StackExample
{
    public static void Main()
    {   // Creates and initializes a new Stack.
        var myStack = new Stack();
        myStack.Push("Apple");
        myStack.Push("Orange");
        myStack.Push("Banana");
        Console.WriteLine($"myStack count: {myStack.Count}");
        // Displays the items in the stack
        foreach (var obj in myStack) { Console.WriteLine(obj); }
        myStack.Pop(); // pop the top item then display the stack again
        Console.WriteLine("\nAfter removing the top item::");
        foreach (var obj in myStack) { Console.WriteLine(obj); }
    }
}
// for more, visit:
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-8.0
