using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1
{
    public class TestComplex
    {
        public static void Test(Complex c1, Complex c2, string testName)
        {         
            const double Epsilon = 0.000001;

            Console.Write(testName + ": ");

            if (Math.Abs(c1.realPart - c2.realPart) < Epsilon && Math.Abs(c1.imaginaryPart - c2.imaginaryPart) < Epsilon) {
                Console.WriteLine("OK");
            } else {
                Console.WriteLine("Chyba: Očekávaná hodnota: {0}, Skutečná hodnota: {1}", c1, c2);
            }
        }
    }
}
