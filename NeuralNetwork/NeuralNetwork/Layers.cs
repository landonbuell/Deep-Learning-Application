using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using NeuralNetwork.Activations;
using NeuralNetwork.LayerParameters;

namespace NeuralNetwork
{
    namespace Layers
    {
        
        public class BaseLayer
        {
            public string _layerName;
            public int _layerIndex;
            public string _layerType;

            private BaseLayerParameters _weights;
            private BaseLayerParameters _biases;

            private int[] _inputShape = new int[] { 0, 0 };
            private int[] _outputShape;
            private BaseLayer _nextLayer;
            private BaseLayer _prevLayer;
            

            public BaseLayer(string name)
            {
                // Constructor for BaseLayer Class
                _layerType = "BaseLayer";
            }

            public BaseLayer NextLayer
            {
                // Get or Set Next Layer
                get { return _nextLayer; }
                set { _nextLayer = value; }
            }

            public BaseLayer PrevLayer
            {
                // Get or Set Previous Layer
                get { return _prevLayer; }
                set { _prevLayer = value; }
            }

            public int[] InputShape 
            {
                // Get or set input Shape
                get { return _inputShape; }
                set { _inputShape = value; }
            }
            public int[] OutputShape
            {
                // Get or set input Shape
                get { return _outputShape; }
                set { _outputShape = value; }
            }

            public double[,] Call (double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }


        }

        public class PointerLayer : BaseLayer
        {
            // Pointer Layer Does Nothing!
            // Only Points to another layer
            // Is used as Head/Tail Nodes in Layer Graph

            public PointerLayer (string name) : base(name)
            {
                // Constructor for PointerLayer
                _layerType = "Pointer";
                NextLayer = null;
                PrevLayer = null;
            }
        }

        public class InputLayer : BaseLayer
        {
            public InputLayer (string name) : base(name)
            {
                // Constructor for Input Layer
                _layerType = "Input";

            }
        }


        public class LinearDense : BaseLayer
        {
            public LinearDense(string name, int nodes) : base(name)
            {
                // Constructor for Linear Dense Layer Class
                _layerType = "LinearDense";
                Nodes = nodes;

            }

            public int Nodes { get; set; }
        }

    }
   
}
