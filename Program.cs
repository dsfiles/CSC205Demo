using System;
using System.CodeDom;

class TestClass
{
    public abstract class Shape {
        public const double PI = Math.PI;
        public abstract double Area();
    }
    public class Circle : Shape {
        public double R {  get; set; }
        public override double Area() => PI * R * R;
    }
    public class Cylinder : Shape {
        public double R {  get; set; }
        public double H { get; set; }
        public override double Area() => 2 * PI * R * R + 2 * PI * R * H;
    }
    static void Main() {
        double r = 3.0, h = 5.0;
        Shape c = new Circle() {R = r};
        Shape l = new Cylinder() { R = r, H = h };
        // Display results.
        Console.WriteLine("Area of Circle   = {0:F1}", c.Area());
        Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
    }
}
