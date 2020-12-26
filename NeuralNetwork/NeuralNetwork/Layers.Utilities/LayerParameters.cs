using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerParameters
    {
        // Parent Class for LayerParameters
        // All shapes are transposed
        protected int[] _shapeWeights;
        protected int[] _shapeBiases;

        public virtual Array Weights { get; protected set; }
        public virtual Array Biases { get; protected set; }

        public bool Initialized { get; protected set; }
        

        public LayerParameters(int[] shapeWeights, int[] shapeBiases)
        {
            // Constructor for LayerParameters Instance
            _shapeWeights = shapeWeights;
            _shapeBiases = shapeBiases;
            Initialized = false;
        }

        public virtual void InitializeParameters(Initializer weightsInit, Initializer biasesInit)
        {
            // Initializer Parameters
            Weights = Array.CreateInstance(typeof(Double), _shapeWeights);
            Biases = Array.CreateInstance(typeof(Double), _shapeBiases);
            Initialized = true;
        }

    }

    internal class DenseParameters : LayerParameters
    {
        // Parameters for Dense Layer

        public new double[,] Weights { get; protected set; }
        public new double[] Biases { get; protected set; }

        public DenseParameters(int[] shapeWeights, int[] shapeBiases) : base(shapeWeights, shapeBiases)
        {
            // Constructor for Dense Layer Parameters
        }

        public override void InitializeParameters(Initializer weightsInit, Initializer biasesInit)
        {
            // Initialize Weight & Bias Arrays
            Weights = weightsInit.Init2D();
            Biases = biasesInit.Init1D();
            Initialized = true;
        }
    }


   

}
