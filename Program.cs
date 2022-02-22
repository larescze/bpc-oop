using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(new double[,] { { 3, 2, 7 }, { 2, 4, 0 } });
            Matrix m2 = new Matrix(new double[,] { { 1, 0, 0 }, { 0, 1, 2 } });
            Matrix m3 = new Matrix(new double[,] { { 1, -6, 2 }, { 1, 5, 0 }, { 3, 2, 3 } });
            Matrix m4 = new Matrix(new double[,] { { 6, 1, 1 }, { 4, -2, 5 }, { 2, 8, 7 } });

            Console.WriteLine("Matrix (+):");
            Console.WriteLine(m1 + m2);

            Console.WriteLine("Matrix (-):");
            Console.WriteLine(m1 - m2);

            Console.WriteLine("Matrix (*):");
            Console.WriteLine(m3 * m4);

            Console.WriteLine("Matrix (==): {0}\n", m3 == m4);

            Console.WriteLine("Matrix (!=): {0}\n", m3 != m4);

            Console.WriteLine("Matrix (-u):");
            Console.WriteLine(-m1);

            Console.WriteLine("Matrix determinant: {0}", m4.Determinant());

            Console.ReadLine();
        }
    }
}
