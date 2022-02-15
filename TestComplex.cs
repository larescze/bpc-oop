using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1
{
    public class TestComplex
    {
        public static void Test(String name, Complex a, Complex b)
        {         
            const double Epsilon = 0.000001;

            Console.Write(name + ": ");

            if (Math.Abs(a.realPart - b.realPart) < Epsilon && Math.Abs(a.imaginaryPart - b.imaginaryPart) < Epsilon) {
                Console.WriteLine("OK");
            } else {
                Console.WriteLine("Chyba: Očekávaná hodnota: " + a + ", Skutečná hodnota: " + b);
            }
        }
    }
}
