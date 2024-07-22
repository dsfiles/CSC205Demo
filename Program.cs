using System;

public class Counter
{
    public static int instances = 0;
    public Counter()
    { instances++; }
}
public class App
{
    static void Main(String[] args)
    {
        Counter c0 = new Counter();
        Console.WriteLine($"{Counter.instances} instance(s) of the Counter class!");
        Counter c1 = new Counter();
        Console.WriteLine($"{Counter.instances} instance(s) of the Counter class!");
        Counter c2 = new Counter();
        Console.WriteLine($"{Counter.instances} instance(s) of the Counter class!");
        Counter c3 = new Counter();
        Console.WriteLine($"{Counter.instances} instance(s) of the Counter class!");
        Counter c4 = new Counter();
        Console.WriteLine($"{Counter.instances} instance(s) of the Counter class!");
    }
}
