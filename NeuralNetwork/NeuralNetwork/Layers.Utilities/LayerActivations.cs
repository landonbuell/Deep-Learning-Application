using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public class LayerActivations
    {
        // Parent Class for all Layer Activation Objects

        protected string _parentLayerName;
        protected string _parentLayerType;

        public virtual Array Linear { get; protected set; }
        public virtual Array Final { get; protected set; }

        public int[] Shape { get; set; }

        // Activations are formatted s.t. the first axis is always a sample

        public LayerActivations(string parentName, string parentType)
        {
            // Constructor for LayerActivations
            _parentLayerName = parentName;
            _parentLayerType = parentType;
        }

        public virtual void UpdateShapes(int[] newShape)
        {
            // Update Shapes of activations
            Shape = newShape;
            Linear = Array.CreateInstance(typeof(Double),newShape);
            Final = Array.CreateInstance(typeof(Double),newShape);
        }
    }

    internal class DenseActivations : LayerActivations
    {
        // Activations for Linear Dense layers
        public new double[,] Linear { get; set; }
        public new double[,] Final { get; set; }

        internal DenseActivations(string name, string type, int Nodes) : base(name, type)
        {
            // Constructor for Linear Dense Layers
            int[] shape = new int[] { 1, Nodes };
            Shape = new int[] { 1, Nodes };
            Linear = new double[1, Nodes];
            Final = new double[1, Nodes];
        }

        public override void UpdateShapes(int[] newShape)
        {
            // Update the Shapes for Dense Layers
            Debug.Assert(newShape.Length == 2);
            base.UpdateShapes(newShape);
        }

    }

}
