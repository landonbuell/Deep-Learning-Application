using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerActivations
    {
        // Parent Class for all Layer Activation Objects

        protected string _parentLayerName;
        protected string _parentLayerType;

        public virtual Array Linear { get; protected set; }
        public virtual Array Final { get; protected set; }

        public int[] Shape { get; set; }

        public LayerActivations(string parentName, string parentType)
        {
            // Constructor for LayerActivations
            _parentLayerName = parentName;
            _parentLayerType = parentType;
        }

    }
}
