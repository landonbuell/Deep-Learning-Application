using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerParameters
    {
        // Parent Class for LayerParameters
        // All shapes are transposed
        public int[] WeightShape { get; protected set; }
        public int[] BiasShape { get; protected set; }



    }
}
