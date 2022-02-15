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

            TestComplex.Test(complex1 + complex2, new Complex(4, 9), String.Format("({0}) + ({1})", complex1, complex2));
            TestComplex.Test(complex1 - complex2, new Complex(2, 5), String.Format("({0}) - ({1})", complex1, complex2));
            TestComplex.Test(complex1 * complex2, new Complex(-11, 23), String.Format("({0}) * ({1})", complex1, complex2));
            TestComplex.Test(complex1 / complex2, new Complex(4, 9), String.Format("({0}) / ({1})", complex1, complex2));
            TestComplex.Test(-complex1, new Complex(-3,-2), String.Format("-({0})", complex1));

            Console.WriteLine("{0} == {1}: {2}", complex1, complex2, complex1 == complex2);
            Console.WriteLine("{0} != {1}: {2}", complex1, complex2, complex1 != complex2);
            
            Console.WriteLine("Modul of {0} is {1}", complex1, complex1.Modul());
            Console.WriteLine("Argument of is {1}", complex1, complex1.Argument());

            Console.ReadLine();
        }
    }
}
