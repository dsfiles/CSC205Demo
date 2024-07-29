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
    private int _length, _width;
    public Rectangle(int length, int width)
    { 
        _length = length;
        _width = width;
    }
    public override int GetArea() => _length * _width;
}
class App {
    static void Main() {
        Shape[] shapes = { new Square(5), new Rectangle(3, 4) };
        //Shape sq = new Square(5);
        Console.WriteLine($"Area of the square = {shapes[0].GetArea()}");
        //Shape rec = new Rectangle(3, 4);
        Console.WriteLine($"Area of the rectangle = {shapes[1].GetArea()}");
    }
}