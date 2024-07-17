using CSC205Demo;

public class Program
{
    static void Main(string[] args)
    {
        Rational r1 = new Rational();
        Rational r2 = new Rational(1, 3);
        Rational.WriteRational(r1);
        Rational.WriteRational(r2);
    }
}