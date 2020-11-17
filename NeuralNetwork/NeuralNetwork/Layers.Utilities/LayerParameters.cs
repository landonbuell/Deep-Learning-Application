using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;


namespace NeuralNetwork.Layers.Utilities
{
    public struct LayerParameters
    {
        // Internally Defined Struct to hold Weights & Biases
        private int[] _weightShape;
        private int[] _biasShape;

        public Array Weights { get; private set; }

        public Array Biases { get; private set; }

        public LayerParameters(int[] weightShape, int[] biasShape)
        {
            _weightShape = weightShape;
            _biasShape = biasShape;

            Weights = Array.CreateInstance(typeof(double), _weightShape);
            Biases = Array.CreateInstance(typeof(double), _biasShape);
        }

        private void GenerateParams(BaseInitializer init, int[] shape)
        {
            // Generate this layers Paramaters


        }

    }

    
}
