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
        public class BaseLayer
        {
            public string _layerName;
            public int _layerIndex;
            public string _layerType;

            protected LayerActivations _layerActivations;
            protected Initializer _layerParamsInit;
            protected LayerParameters _layerParams;
            protected Activation _layerActFunc;
            
            protected int[] _inputShape;
            protected int[] _outputShape;
            protected int[] _activationShape;
            
            protected int batchSize;
            
            private BaseLayer _nextLayer;
            private BaseLayer _prevLayer;

            public BaseLayer(string name)
            {
                // Constructor for BaseLayer Class (Given only name)
                _layerName = name;
                _layerType = "BaseLayer";
                
            }

            public BaseLayer (string name, Activation actFunc, Initializer paramsIntializer)
            {
                // Constructor for BaseLayer Class (Given only name)
                _layerName = name;
                _layerType = "BaseLayer";

                // Set Activation Function & Parameter Intializer
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
                set { _prevLayer = value;}
            }

            public int[] InputShape 
            {
                // Get or set input array shape
                get { return _inputShape; }
                set { _inputShape = value; }
            }

            public int[] OutputShape
            {
                // Get or set output array shape
                get { return _outputShape; }
                set { _outputShape = value; }
            }

            public int[] ActivationShape
            {
                // Get or Set activation array shape
                get { return _activationShape; }
                set { _activationShape = value; }
            }

            public virtual void FormatLayerParams()
            {
                // Format The Layer Params Object
                // No Parameters to Format in BaseLayer Type
                // Called when Layer is added to a Computational graph
            }

            public virtual LayerParameters GetLayerParams()
            {
                // get the Layer Params Object
                return _layerParams;
            }

            public static LayerActivations Call (LayerActivations X)
            {
                // Call BaseLayer w/ Inputs X   
                return X;
            }
        }

        public class PointerLayer : BaseLayer
        {
            // Pointer Layer Only Points to another layer
            // Is used as Head/Tail Nodes in Layer Graph

            public PointerLayer (string name) : base(name)
            {
                // Constructor for PointerLayer
                _layerType = "PointerLayer";
                NextLayer = null;
                PrevLayer = null;
            }

        }

        public class InputLayer : BaseLayer
        {
            public InputLayer (string name, int[] sampleShape , int batchSize = 1) : base(name)
            {
                // Constructor for Input Layer
                _layerType = "Inputlayer";

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
        }

        public class OutputLayer : LinearDense
        {
            public OutputLayer(string name, int nodes) : base(name, nodes)
            {
                // Constructor for Input Layer
                _layerType = "OutputLayer";

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

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                _inputShape = PrevLayer.OutputShape;
                _outputShape = new int[] { Nodes, _inputShape[1] };
                _activationShape = _outputShape;

                // Send shape to Paramaters Object
                _layerParams = new LinearDenseParameters(_layerParamsInit,true);
                _layerParams.Initialize(_inputShape, _outputShape);

            }

    

        }

    }
   
}
