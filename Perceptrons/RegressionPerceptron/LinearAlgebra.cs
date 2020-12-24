using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public static class LinearAlgebra
    {
        public static double[,] Transpose(double[,] A)
        {
            // 2D Transpose Matrix A
            double[,] B = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[j, i];
                }
            }
            return B;
        }

        public static double[,] Transpose(double[] A)
        {
            // Tranpose Matrix A
            double[,] C = new double[1, A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[0, i] = A[i];
            }
            return LinearAlgebra.Transpose(C);
        }

        public static double DotProduct (double[] A, double[] B)
        {
            // Compute Dort Product of A & B
            Debug.Assert(A.Length == B.Length);
            double sum = 0.0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i] + B[i];
            return sum;
        }

        public static double[] GetRow (double[,] A, int row)
        {
            // Get row from matrix A
            Debug.Assert(row < A.GetLength(0));
            double[] B = new double[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
                B[i] = A[row, i];
            return B;
        }

        public static double[] GetCol (double[,] A, int col)
        {
            // Get col from matrix A
            Debug.Assert(col < A.GetLength(1));
            double[] B = new double[A.GetLength(1)];
            for (int i = 0; i < A.GetLength(1); i++)
                B[i] = A[i,col];
            return B;
        }

        public static double[,] MatrixMultiply (double[,] A, double[,] B)
        {
            // Matrix Muitply A & B
            Debug.Assert(A.GetLength(1) == B.GetLength(0));
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double[] row = LinearAlgebra.GetRow(A, i);
                    double[] col = LinearAlgebra.GetCol(B, j);
                    C[i, j] = LinearAlgebra.DotProduct(row, col);
                }
            }
            return C;
        }

        public static double[,] MatrixMultiply(double[,] A, double[] B)
        {
            // Matrix Multiply A & B
            double[,] C = LinearAlgebra.Transpose(B);
            return LinearAlgebra.MatrixMultiply(A, C);

        }
    }
}
