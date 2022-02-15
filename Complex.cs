using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1
{
    public class Complex
    {
        public double realPart;
        public double imaginaryPart;

        public Complex(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public static Complex operator +(Complex c1, Complex c2) 
        {
            c1.realPart += c2.realPart;
            c1.imaginaryPart += c2.imaginaryPart;

            return c1;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            c1.realPart -= c2.realPart;
            c1.imaginaryPart -= c2.imaginaryPart;

            return c1;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            double realPart = c1.realPart * c2.realPart - c1.imaginaryPart * c2.imaginaryPart;
            double imaginaryPart = c1.realPart * c2.imaginaryPart + c1.imaginaryPart * c2.realPart;

            return new Complex(realPart, imaginaryPart);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double realPart = (c1.realPart * c2.realPart + c1.imaginaryPart * c2.imaginaryPart) / (c2.realPart * c2.realPart + c2.imaginaryPart * c2.imaginaryPart);
            double imaginaryPart = (c1.imaginaryPart * c2.realPart - c1.realPart * c2.imaginaryPart) / (c2.realPart * c2.realPart + c2.imaginaryPart * c2.imaginaryPart);

            return new Complex(realPart, imaginaryPart);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.realPart == c2.realPart && c1.imaginaryPart == c2.imaginaryPart;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.realPart != c2.realPart || c1.imaginaryPart != c2.imaginaryPart;
        }

        public static Complex operator -(Complex number)
        {
            return new Complex(-number.realPart, -number.imaginaryPart);
        }

        public double Modul()
        {
            return Math.Sqrt(this.realPart * this.realPart + this.imaginaryPart * this.imaginaryPart);
        }

        public double Argument()
        {
            return Math.Atan2(this.realPart, this.imaginaryPart);
        }

        public override string ToString()
        {
            if (this.imaginaryPart < 0)
            {
                return this.realPart + this.imaginaryPart + "i";
            }

            return this.realPart + " + " + this.imaginaryPart + "i";
        }
    }
}
