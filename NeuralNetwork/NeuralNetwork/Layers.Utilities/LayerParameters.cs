using System;
using System.Diagnostics;
using System.Text;

using NeuralNetwork.Mathematics;


namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerParameters
    {
        // Object to hold weights & biases
        public int[] WeightShape { get; private set; }
        
        public int[] BiasShape { get; private set; }

        public virtual Array Weights { get; protected set; }

        public virtual Array Biases { get; protected set; }

        public LayerParameters() { }

        public LayerParameters(int[] weightShape, int[] biasShape)
        {
            WeightShape = weightShape;
            BiasShape = biasShape;
        }

        public virtual Array Call(Array X)
        {
            // Call LayerParameters w/ Input X;
            return X;
        }
    }

    public class LinearDenseParameters : LayerParameters
    {
        // Weights & biases for Linear Dense layers

        public new double[,] Weights { get; set; }

        public new double[] Biases { get; set; }

        public LinearDenseParameters() : base()
        {
            // Constructor for Linear Dense Weights
        }

        public LinearDenseParameters( int[] weightShape, int[] biasShape) : 
            base(weightShape, biasShape)
        {
            // Constructor for Linear Dense Weighs
            Debug.Assert(weightShape.Length == 2);
            Debug.Assert(biasShape.Length == 1);
        }
        
        public double[,] Call (double[,] X)
        {
            // Matrix Multiply weights by input X
            double[,] Y = LinearAlgebra.MatrixProduct2D(Weights, X);
            // Add Bias to each row in Y
            for (int i = 0; i < Y.GetLength(0); i++)
            {
                // Get the row in Y:
                double[] y = LinearAlgebra.GetRow(Y, i);

            }


        }

    }

   
}
