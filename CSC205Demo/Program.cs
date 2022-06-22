using System;
class Point
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    // remove (by commenting out) the following Equals method to see if the result is different
    public override bool Equals(object obj)
    {   // If this and obj do not refer to the same type, then they are not equal.
        if (obj.GetType() != this.GetType()) return false;
        // Return true if x and y fields match.
        var other = (Point)obj;
        return (this.x == other.x) && (this.y == other.y);
    }
    public override String ToString()
    {
        return $"({x}, {y})";
    }
}

public sealed class App
{
    static void Main()
    {
        var p1 = new Point(1, 2);
        var p2 = p1;
        var p3 = new Point(1, 2);
        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1.Equals(p3));
        Console.WriteLine($"p1's value is: {p1.ToString()}");
    }
}
