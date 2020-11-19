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

        public static void Iterate(Array X)
        {
            // Iterate through all elements of array recursivly
            int[] shapeX = ArrayTools.GetShape(X);
            while (true)
            {

            }



            throw new NotImplementedException();

        }

    }

}
