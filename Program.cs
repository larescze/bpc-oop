using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Complex complex1 = new Complex(3, 2);
            Complex complex2 = new Complex(1, 7);
            Complex complex3 = new Complex(5, 3);

            TestComplex.Test(complex1 + " + " + complex2, complex1 + complex2, new Complex(4, 9));
            TestComplex.Test(complex1 + " - " + complex2, complex1 - complex2, new Complex(2, 5));
            TestComplex.Test(complex1 + " * " + complex2, complex1 * complex2, new Complex(-11, 23));
            TestComplex.Test(complex1 + " / " + complex2, complex1 / complex2, new Complex(4, 9));
            TestComplex.Test("-(" + complex1 + ")", -complex1, new Complex(-3,-2));

            Console.WriteLine(complex1 + " == " + complex2 + ": " + (complex1 == complex2));
            Console.WriteLine(complex1 + " != " + complex2 + ": " + (complex1 != complex2));
            
            Console.WriteLine("Modul of " + complex1 + ": " + complex1.Modul());
            Console.WriteLine("Argument of " + complex1 + ": " + complex1.Argument());

            Console.ReadLine();
        }
    }
}
