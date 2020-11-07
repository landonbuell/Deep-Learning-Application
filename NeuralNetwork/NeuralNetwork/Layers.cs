using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

            protected LayerParameters _layerParams;
            protected Initializer _layerParamsInit;
            protected LayerActivations _layerActivations;
            protected Activation _layerActFunc;
            
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
            }

            public BaseLayer(string name, string actFuncStr = " ", string initStr = " ")
            {
                // Constructor for BaseLayer Class
                _layerType = "BaseLayer";
                _layerName = name;
                _layerActFunc = LayerUtilitiesMap.ActFuncMap[actFuncStr];
                _layerParamsInit = LayerUtilitiesMap.InitializerMap[initStr];
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

            public virtual void FormatLayerParams()
            {
                // Format The Layer Params Object
                // No Parameters to Format in BaseLayer Type
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
            public InputLayer (string name, int[] inputShape) : base(name)
            {
                // Constructor for Input Layer
                _layerType = "Inputlayer";
                _inputShape = inputShape;
                _outputShape = inputShape;
                _activationShape = inputShape;

                // No weights or activations for this layer Type (null)
            }
        }

        public class OutputLayer : LinearDense
        {
            public OutputLayer(string name, int nodes) : base(name, nodes)
            {
                // Constructor for Input Layer
                _layerType = "OutputLayer";

            }

            public OutputLayer(string name, int nodes, Activation actFunc) : base(name, nodes, actFunc)
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
            public LinearDense(string name, int nodes, string actFuncStr = " ", string initParamStr = " ") : 
                base(name, actFuncStr, initParamStr)
            {
                // Constructor for Linear Dense Layer Class
                _layerType = "LinearDense";
                Nodes = nodes;

            }

            public int Nodes { get; set; }

            public override void FormatLayerParams()
            {
                // Initialize Weights & Biases
                _inputShape = PrevLayer.OutputShape;
                _layerParams.Initialize(_inputShape,Nodes,_layerParamsInit);

            }

    

        }

    }
   
}
