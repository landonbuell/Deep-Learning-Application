using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.LayerUtilities;


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

            protected int[] _inputShape;
            protected int[] _outputShape;
            protected int[] _activationShape;
            protected int batchSize;
            
            private BaseLayer _nextLayer;
            private BaseLayer _prevLayer;
            

            public BaseLayer(string name)
            {
                // Constructor for BaseLayer Class
                _layerType = "BaseLayer";
                _layerName = name;

                // Set Supproting Data
                try { _layerIndex = PrevLayer._layerIndex + 1; }
                catch { _layerIndex = 0; }
                
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

                // Set Other properties
                

            }
        }

        public class InputLayer : BaseLayer
        {
            public InputLayer (string name, int[] inputShape) : base(name)
            {
                // Constructor for Input Layer
                _layerType = "Input";
                _inputShape = inputShape;
                _outputShape = inputShape;
                _activationShape = inputShape;

            }
        }

        public class OutputLayer : LinearDense
        {
            public OutputLayer(string name, int nodes) : base(name, nodes)
            {
                // Constructor for Input Layer
                _layerType = "Output";

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
