using System;

namespace NeuralNetwork.Mathematics
{
    public static class ArrayTools
    {
        // Tools for Arrays:
        public static int[] GetShape (Array X)
        {
            // Get shape of Array X, return int arr of length rank
            int[] shape = new int[X.Rank];
            for (int i = 0; i < X.Rank; i++)
            {
                shape[i] = X.GetLength(i);
            }
            return shape;
        }

        public static double[,] Make2D (double[] A)
        {
            // Make Input Array A into 2D Array
            double[,] B = new double[1, A.Length];
            for (int i = 0; i < A.Length; i++)
                B[0, i] = A[i];
            return B;
        }

        public static double[] Make1D(double[,] A)
        {
            // Make 2D Array X into 1D
            int newSize = A.GetLength(0) * A.GetLength(1);
            double[] B = new double[newSize];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i + j] = A[i, j];
                }
            }
            return B;
        }
    }

}
