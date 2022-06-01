using System;
class Program
{
    static void Main(string[] args)
    {
        double x1, volume, c2;
        double a = 1.0, b = 2.83, c = 1.22;
        double r = 1.0;
        double theta = 0.523599;
        x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3.0);
        c2 = Math.Pow(Math.Sin(theta), 2) + Math.Pow(Math.Cos(theta), 2);
        Console.WriteLine(x1);
        Console.WriteLine(volume);
        Console.WriteLine(c2);
    }
}