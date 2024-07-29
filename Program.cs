using System;
abstract class Shape {
    public abstract int GetArea();
}
class Square : Shape {
    private int _side;
    public Square(int n) => _side = n;
    public override int GetArea() => _side * _side;
}
class Rectangle : Shape {
    // your code here
}
class App {
    static void Main() {
        var sq = new Square(5);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
        //var rec = new Rectangle(3, 4);
        //Console.WriteLine($"Area of the rectangle = {rec.GetArea()}");
    }
}