using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerActivations
    {
        // Parent Class for all Layer Activation Objects

        public virtual Array Linear { get; set; }
        public virtual Array Final { get; set; }

        public int[] Shape { get; set; }

        // Activations are formatted s.t. the 0-th axis is always a sample

        public virtual void UpdateShapes(int[] newShape)
        {
            // Update Shapes of activations
            Shape = newShape;
            Linear = Array.CreateInstance(typeof(Double),newShape);
            Final = Array.CreateInstance(typeof(Double),newShape);
        }
    }

    internal class Activations2D : LayerActivations
    {
        // Activations for Linear Dense layers
        public new double[,] Linear { get; set; }
        public new double[,] Final { get; set; }
    }

    internal class Activations3D : LayerActivations
    {
        // Activations for Linear Dense layers
        public new double[,,] Linear { get; set; }
        public new double[,,] Final { get; set; }
    }

}
