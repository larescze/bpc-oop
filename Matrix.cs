using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    public class Matrix
    {
        private double[,] matrix;
        private int Rows
        {
            get { return matrix.GetLength(0); }
        }
        private int Columns
        {
            get { return matrix.GetLength(1); }
        }
        
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows == m2.Rows && m2.Columns == m2.Columns)
            {
                double[,] matrix = new double[m1.Rows, m2.Columns];

                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int column = 0; column < m2.Columns; column++)
                    {
                        matrix[row, column] = m1.matrix[row, column] + m2.matrix[row, column];
                    }
                }

                return new Matrix(matrix);
            }

            throw new ArgumentException("Matrix are not same size");
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows == m2.Rows && m2.Columns == m2.Columns)
            {
                double[,] matrix = new double[m1.Rows, m2.Columns];

                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int column = 0; column < m2.Columns; column++)
                    {
                        matrix[row, column] = m1.matrix[row, column] - m2.matrix[row, column];
                    }
                }

                return new Matrix(matrix);
            }

            throw new ArgumentException("Matrix are not same size");
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m2.Columns == m2.Rows)
            {
                double[,] matrix = new double[m1.Rows, m2.Columns];
                double temp;

                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int column = 0; column < m2.Columns; column++)
                    {
                        temp = 0;

                        for (int i = 0; i < m2.Columns; i++)
                        {
                            temp += m1.matrix[row, i] * m2.matrix[i, column];
                        }

                        matrix[row, column] = temp;
                    }
                }

                return new Matrix(matrix);
            }

            throw new ArgumentException("Matrix can't be multiplied");
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            for (int row = 0; row < m1.Rows; row++)
            {
                for (int column = 0; column < m2.Columns; column++)
                {
                    if (m1.matrix[row, column] != m2.matrix[row, column])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public static Matrix operator -(Matrix m)
        {
            double[,] matrix = new double[m.Rows, m.Columns];

            for (int row = 0; row < m.Rows; row++)
            {
                for (int column = 0; column < m.Columns; column++)
                {
                    matrix[row, column] = m.matrix[row, column] * (-1);
                }
            }

            return new Matrix(matrix);
        }

        public double Determinant()
        {
            if (this.Rows == this.Columns)
            {
                if (this.Rows == 1)
                {
                    return this.matrix[0, 0];
                }
                else if (this.Rows == 2)
                {
                    return this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[0, 1] * this.matrix[1, 0];
                }
                else if (this.Columns == 3)
                {
                    return this.matrix[0, 0] * (this.matrix[1, 1] * this.matrix[2, 2] - this.matrix[1, 2] * this.matrix[2, 1])
                         - this.matrix[0, 1] * (this.matrix[1, 0] * this.matrix[2, 2] - this.matrix[1, 2] * this.matrix[2, 0])
                         + this.matrix[0, 2] * (this.matrix[1, 0] * this.matrix[2, 1] - this.matrix[1, 1] * this.matrix[2, 0]);
                }

                throw new ArgumentException("The dimension of a matrix is greater than 3x3");
            }

            throw new ArgumentException("Matrix is not square");
        }

        public override string ToString()
        {
            StringBuilder matrix =  new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int column = 0; column < this.Columns; column++)
                {
                    if (this.matrix[row, column] >= 0)
                    {
                        matrix.Append(" ");
                    }

                    matrix.Append(this.matrix[row, column] + " ");
                }

                matrix.AppendLine();
            }

            return matrix.ToString();
        }
    }
}
