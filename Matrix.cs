using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    internal class Matrix
    {
        private double[,] matrix;

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            try
            {
                if (m1.matrix.GetLength(0) == m2.matrix.GetLength(0) && m1.matrix.GetLength(1) == m2.matrix.GetLength(1))
                {
                    double[,] matrix = new double[m1.matrix.GetLength(0), m2.matrix.GetLength(1)];

                    for (int i = 0; i < m1.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < m1.matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
                        }
                    }

                    return new Matrix(matrix);
                } 
                else
                {
                    throw new ArgumentException("Matrix are not same size");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return null;
            }
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            try
            {
                if (m1.matrix.GetLength(0) == m2.matrix.GetLength(0) && m1.matrix.GetLength(1) == m2.matrix.GetLength(1))
                {
                    double[,] matrix = new double[m1.matrix.GetLength(0), m2.matrix.GetLength(1)];

                    for (int i = 0; i < m1.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < m1.matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = m1.matrix[i, j] - m2.matrix[i, j];
                        }
                    }

                    return new Matrix(matrix);
                }
                else
                {
                    throw new ArgumentException("Matrix are not same size");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return null;
            }
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            try
            {
                if (m1.matrix.GetLength(1) == m2.matrix.GetLength(0))
                {
                    double[,] matrix = new double[m1.matrix.GetLength(0), m2.matrix.GetLength(1)];
                    double temp;

                    for (int i = 0; i < m1.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < m2.matrix.GetLength(1); j++)
                        {
                            temp = 0;

                            for (int k = 0; k < m1.matrix.GetLength(1); k++)
                            {
                                temp += m1.matrix[i, k] * m2.matrix[k, j];
                            }

                            matrix[i, j] = temp;
                        }
                    }

                    return new Matrix(matrix);
                }
                else
                {
                    throw new ArgumentException("Matrix can't be multiplied");
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return null;
            }
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            try
            {
                for (int i = 0; i < m1.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.matrix.GetLength(1); j++)
                    {
                        if (m1.matrix[i, j] != m2.matrix[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return false;
            }
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            try
            {
                return !(m1 == m2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return false;
            }
        }

        public static Matrix operator -(Matrix m)
        {
            try
            {
                double[,] matrix = new double[m.matrix.GetLength(0), m.matrix.GetLength(1)];

                for (int i = 0; i < m.matrix.GetLength(1); i++)
                {
                    for (int j = 0; j < m.matrix.GetLength(0); j++)
                    {
                        matrix[j, i] = m.matrix[j, i] * (-1);
                    }
                }

                return new Matrix(matrix);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return null;
            }
        }

        public double Determinant()
        {
            try
            {
                if (this.matrix.GetLength(0) == this.matrix.GetLength(1)) 
                { 
                    if (this.matrix.GetLength(0) == 1)
                    {
                        return this.matrix[0, 0];
                    }
                    else if (this.matrix.GetLength(0) == 2)
                    {
                           return this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[0, 1] * this.matrix[1, 0];
                    }
                    else if (this.matrix.GetLength(1) == 3)
                    {
                        return this.matrix[0, 0] * (this.matrix[1, 1] * this.matrix[2, 2] - this.matrix[1, 2] * this.matrix[2, 1])
                             - this.matrix[0, 1] * (this.matrix[1, 0] * this.matrix[2, 2] - this.matrix[1, 2] * this.matrix[2, 0])
                             + this.matrix[0, 2] * (this.matrix[1, 0] * this.matrix[2, 1] - this.matrix[1, 1] * this.matrix[2, 0]);
                    }
                    else
                    {
                       throw new ArgumentException("Dimension is greater than 3x3");
                    }
                } 
                else
                {
                   throw new ArgumentException("Matrix is not square");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return 0;
            }
        }

        public override string ToString()
        {
            String matrix = "";

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    matrix += this.matrix[i, j] + " ";
                }

                matrix += "\n";
            }

            return matrix;
        }
    }
}
