using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using NeuralNetwork.LayerUtilities;


namespace NeuralNetwork
{
    namespace Layers
    {
        public class PointerLayer : BaseLayer
        {
            // Pointer Layer Only Points to another layer
            // Is used as Head/Tail Nodes in Layer Graph

            public PointerLayer (string name) : base(name)
            {
                // Constructor for PointerLayer
                LayerType = "PointerLayer";
                NextLayer = null;
                PrevLayer = null;
            }
        }

        public class InputLayer : BaseLayer
        {
            // Format an Input array to be digested by Neural network

            public InputLayer (string name, int[] sampleShape , int batchSize = 1) : base(name)
            {
                // Constructor for Input Layer
                LayerType = "Inputlayer";

                // Format the InputShape
                _shapeInput = new int[1 + sampleShape.Length];
                _shapeInput[0] = batchSize;
                sampleShape.CopyTo(_shapeInput, 1);
                // Set Activation Shape & Output Shape
                _shapeActivation = _shapeInput;
                _shapeOutput = _shapeInput;

                // No weights or activations for this layer Type (null)
                LayerIndex = 0;
            }

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                // Already Taken care of in Constructor - do nothing!
            }

        }

        public class OutputLayer : LinearDense
        {
            public OutputLayer(string name, int nodes) : base(name, nodes)
            {
                // Constructor for Input Layer
                LayerType = "OutputLayer";

            }

        }

        public class LinearDense : BaseLayer
        {

            public int Nodes { get; private set; }

            public LinearDense(string name, int nodes) : base(name)
            {
                // Constructor for Linear Dense Layer Class
                LayerType = "LinearDense";
                Nodes = nodes;
                _layerParams = new LinearDenseParameters(true);
                
            }

            public LinearDense(string name, int nodes, Activation actFunc,
                Initializer weightsInit, Initializer biasesInit) : 
                base(name,actFunc,weightsInit,biasesInit)
            {
                // Constructor for Linear Dense Layer Class
                LayerType = "LinearDense";
                Nodes = nodes;
                _layerParams = new LinearDenseParameters(true);
            }

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                _shapeInput = PrevLayer.OutputShape;
                int prevBatch = _shapeInput[1];
                int prevNodes = _shapeInput[1];

                // Set Activation Shape & Output Shape
                _shapeActivation = new int[2] { prevBatch, Nodes };
                _shapeOutput = _shapeActivation;

                // Initialize the Weights & Biases
                _layerParams.WeightShape = new int[] { Nodes, prevNodes };
                _layerParams.BiasShape = new int[] { Nodes };
                _layerParams.Initialize();
                Initialized = true;
            }

            public override LayerActivations Call (LayerActivations X)
            {
                // Call this layer w/ Layer Activations
                double[,] x = Mathematics.LinearAlgebra.Transpose(X.FinalActivations);

                return _layerActivations;
            }

    

        }

    }
   
}
