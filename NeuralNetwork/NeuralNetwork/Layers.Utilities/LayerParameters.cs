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
        public int[] WeightShape { get; private set; }
        
        public int[] BiasShape { get; private set; }

        public Array Weights { get; private set; }

        public Array Biases { get; private set; }

        public LayerParameters(int[] weightShape, int[] biasShape)
        {
            WeightShape = weightShape;
            BiasShape = biasShape;

            Weights = Array.CreateInstance(typeof(double), WeightShape);
            Biases = Array.CreateInstance(typeof(double), BiasShape);
        }

        private void GenerateParams(BaseInitializer init, int[] shape)
        {
            // Generate this layers Paramaters


        }

    }

    
}
