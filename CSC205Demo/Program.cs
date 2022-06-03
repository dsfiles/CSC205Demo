using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings! What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + name);
        Console.ReadKey();
    }
}
