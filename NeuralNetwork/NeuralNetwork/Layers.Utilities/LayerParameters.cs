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
    }
}
