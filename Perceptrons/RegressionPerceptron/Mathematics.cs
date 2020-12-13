using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RegressionPerceptron
{
    public static class LinearAlgebra
    {
        public static double DotProduct(double[] A, double[] B)
        {
            // Compute Dot Product of A & B
            Debug.Assert(A.Length == B.Length);
            double product = 0.0;
            for (int i = 0; i < A.Length; i++)
            {
                product += A[i] * B[i];
            }
            return product;
        }

        public static double[] GetRow (double[,] A, int row)
        {
            // Get All all elements in row of A
            int rowLength = A.GetLength(1);
            double[] B = new double[rowLength];
            for (int i = 0; i < rowLength; i++)
            {
                B[i] = A[row, i];
            }
            return B;
        }

        public static double[] GetCol(double[,] A, int col)
        {
            // Get All all elements in row of A
            int colLength = A.GetLength(0);
            double[] B = new double[colLength];
            for (int i = 0; i < colLength; i++)
            {
                B[i] = A[col, i];
            }
            return B;
        }

        public static double[,] MatrixProduct (double[,] A, double[,] B)
        {
            // Compute 2D matrix product of A * B
            if (A.GetLength(1) != B.GetLength(0)) 
                { throw new ArgumentException(); }
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    double[] row = LinearAlgebra.GetRow(A, i);
                    double[] col = LinearAlgebra.GetCol(B, j);
                    C[i, j] = LinearAlgebra.DotProduct(row, col);
                }
            }
            return C;
        }
    }

    public static class ArrayTools
    {
        // Tools for Array operations

        public static double[,] Transpose2D (double[,] A)
        {
            // Transpose 2D array
            double[,] B = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            return B;
        }

        public static double[,] MakeArray2D (double[] A)
        {
            // Make a 1D Array into a 2D array
            double[,] B = new double[1, A.Length];
            for (int i = 0; i < A.Length; i++)
                B[0, i] = A[i];
            return B;
        }
    }
}
