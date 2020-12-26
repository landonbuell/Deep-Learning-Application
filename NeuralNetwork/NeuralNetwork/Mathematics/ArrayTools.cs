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

    }

}
