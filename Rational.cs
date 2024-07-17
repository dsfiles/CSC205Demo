using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Demo
{
    internal class Rational
    {
        public int numerator, denominator;
        public Rational() { 
            this.numerator = 0;
            this.denominator = 1;
        }

        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static void WriteRational(Rational r)
        {
            Console.WriteLine( r.numerator + "/" + r.denominator);
        }
    }
}
