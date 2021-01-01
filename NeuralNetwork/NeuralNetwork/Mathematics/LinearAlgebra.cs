using System;
using System.Diagnostics;
using System.Numerics;
using System.Data;

namespace NeuralNetwork.Mathematics
{
    public static class LinearAlgebra
    {
        public static double[,] Transpose (double[,] A)
        {
            // Tranpose 2D Array A
            double[,] B = new double[A.GetLength(1),A.GetLength(0)] ;
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    B[i, j] = A[j, i];
            return B;
        }

        public static double[,] Transpose (double[] A)
        {
            // Transpose 1D Array A
            double[,] B = ArrayTools.Make2D(A);
            return Transpose(A);
        }

        public static double[] GetRow(double[,] A, int row)
        {
            // Get All elements in specified Row of matrix A
            Debug.Assert(row < A.GetLength(0));
            double[] B = new double[A.GetLength(1)];
            for (int i = 0; i < A.GetLength(1); i++)
                B[i] = A[row, i];
            return B;
        }

        public static double[] GetCol(double[,] A, int col)
        {
            // Get All elements in specified Row of matrix A
            Debug.Assert(col < A.GetLength(1));
            double[] B = new double[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
                B[i] = A[i, col];
            return B;
        }

        public static double ScalarProduct (double[] A, double[] B)
        {
            // Compute Dot Product of A & B
            Debug.Assert(A.Length == B.Length);
            double C = 0.0;
            for (int i = 0; i < A.Length; i++)
                C += A[i] * B[i];
            return C;
        }

        public static double[,] MatrixProduct (double[,] A, double[,] B)
        {
            // Compute Matrix Product of A & B
            Debug.Assert(A.GetLength(1) == B.GetLength(0));
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double[] a = GetRow(A, i);
                    double[] b = GetCol(B, j);
                    C[i, j] = ScalarProduct(a, b);
                }
            }
            return C;
        }

        public static double[,] MatrixProduct (double[,] A, double[] B)
        {
            // Compute Matrix Product of A & B
            double[,] C = LinearAlgebra.Transpose(B);
            return MatrixProduct(A, C);
        }

        public static double[,] MatrixProduct (double[] A, double[,] B)
        {
            // Compute Matrix Product of A & B
            double[,] C = ArrayTools.Make2D(A);
            return MatrixProduct(C, B);
        }

        public static double[,] MatrixAdd (double[,] A, double[,] B)
        {
            // Element-wise Addtiona of A + B
            Debug.Assert(A.GetLength(0) == B.GetLength(0));
            Debug.Assert(A.GetLength(1) == B.GetLength(1));
            double[,] C = new double[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }

        public static double[,] MatrixAdd(double[,] A, double[] B)
        {
            // Element-wise Addtion of A + B
            Debug.Assert(A.GetLength(1) == B.Length);
            double[,] C = new double[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[j];
                }
            }
            return C;
        }

    }

    public static class VectorOperations
    {
        // Static class to perform vector operations

        public static double[] VectorAdd1D (double[] A , double[] B)
        {
            // Element-wise addition of vectors A & B
            Debug.Assert(A.Length == B.Length);
            double[] C = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i] + B[i];
            return C;
        }

        public static double[] VectorSub1D(double[] A, double[] B)
        {
            // Element-wise subtraction of vectors A & B
            Debug.Assert(A.Length == B.Length);
            double[] C = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i] - B[i];
            return C;
        }
    }

}
