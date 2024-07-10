using System;
public class Program
{
    public static void Main(string[] args)
    {
        string str;
        Console.WriteLine("Please enter your name:");
        str = Console.ReadLine();

        Console.WriteLine("Please enter your age (1-99):");
        int age = 0;
        age = Convert.ToInt32(Console.ReadLine());
        Greeting(str, age);
    }
    public static void Greeting(string name, int age)
    {
        Console.WriteLine("Hello " + name + "!");
        if (age > 21)
            Console.WriteLine("you can buy alcohol!");
        else
            Console.WriteLine("Sorry, you can't buy alcohol!");
    }
}
