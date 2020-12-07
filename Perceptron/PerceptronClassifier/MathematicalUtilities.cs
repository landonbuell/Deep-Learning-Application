﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PerceptronClassifier
{
    public static class LinearAlgebra
    {
        public static double[,] Transpose2D(double[,] A)
        {
            // Tranpose 2D Array A
            double[,] B = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    B[i, j] = A[j, i];
            return B;
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

        public static double ScalarProduct(double[] A, double[] B)
        {
            // Compute Dot Product of A & B
            Debug.Assert(A.Length == B.Length);
            double C = 0.0;
            for (int i = 0; i < A.Length; i++)
                C += A[i] * B[i];
            return C;
        }

        public static double[,] MatrixProduct2D(double[,] A, double[,] B)
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

        public static double[,] IdentityMatrix (int sideLength)
        {
            // Create square identity matrix
            double[,] ID = new double[sideLength, sideLength];
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    if (i == j) { ID[i, j] = 1.0; }
                    else ID[i,j] { ID[i, j] = 0.0; }
                }
            }
            return ID;
        }
    }

    public static class VectorOperations
    {
        // Static class to perform vector operations

        public static double[] VectorAdd1D(double[] A, double[] B)
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

        public static double[,] VectorAdd2D (double[,] A,double[,] B)
        {
            // Element-wise Add vectors
            Debug.Assert(A.Length == B.Length);
            double[,] C = new double[A.GetLength(0),A.GetLength(1)];

            return C;
        }
    }
}