using System;
using System.CodeDom;

class TestClass
{
    public abstract class Shape {
        public const double PI = Math.PI;
        public abstract double Area();
    }
    public class Circle : Shape {
        //double r;
        //public Circle(double r) {
        //    this.r = r;
        //}
        //public override double Area()
        //{
        //    return PI * r * r;
        //}
        public double R {  get; set; }
        public override double Area() => PI * R * R;

    }
    public class Cylinder : Shape {
        private double r, h;
        public Cylinder(double r, double h){
            this.r = r;
            this.h = h;
        }
        public override double Area()
        {
            return 2 * PI * r * r + 2 * PI * r * h;
        }
    }
    static void Main()
    {
        double r = 3.0, h = 5.0;
        Shape c = new Circle() {R=r};
        Shape l = new Cylinder(r, h);
        // Display results.
        Console.WriteLine("Area of Circle   = {0:F1}", c.Area());
        Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
    }
}
