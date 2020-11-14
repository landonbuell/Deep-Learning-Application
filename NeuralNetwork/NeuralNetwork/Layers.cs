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
            public InputLayer (string name, int[] sampleShape , int batchSize = 1) : base(name)
            {
                // Constructor for Input Layer
                LayerType = "Inputlayer";

                _inputShape = new int[1 + sampleShape.Length];
                _inputShape[0] = batchSize;
                sampleShape.CopyTo(_inputShape, 1);
                _activationShape = _inputShape;
                _outputShape = _inputShape;

                // No weights or activations for this layer Type (null)
            }

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                

            }

            public override LayerActivations Call(LayerActivations X)
            {
                // Call This Layer w/ Inputs X
                return X;
            }
        }

        public class OutputLayer : LinearDense
        {
            public OutputLayer(string name, int nodes) : base(name, nodes)
            {
                // Constructor for Input Layer
                LayerType = "OutputLayer";

            }

            public override LayerActivations Call (LayerActivations X)
            {
                // Call This layer w/ Inputs X
                return X;
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
                _
                _layerParams = new LinearDenseParameters()
                
            }

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                _inputShape = PrevLayer.OutputShape;



            }

    

        }

    }
   
}
