using System;

using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork
{
    namespace Layers
    {
        public abstract class BaseLayer
        {

            public string LayerName { get; protected set; }

            public string LayerType { get; protected set; }

            public int LayerIndex { get; set; }

            public bool Initialized { get; protected set; }

            protected BaseActivations _layerActivations;
            protected BaseActivationFunction _activationFunction;
            protected BaseLayerParameters _layerParameters;

            protected BaseInitializer _weightsInitializer;
            protected BaseInitializer _biasesInitializer;

            protected int batchSize;
            protected int[] _shapeInput;
            protected int[] _shapeOutput;
            protected int[] _shapeActivation;
            
            private BaseLayer _layerNext;
            private BaseLayer _layerPrev;

            public BaseLayer(string name)
            {
                // Constructor for BaseLayer Class (Given only name)
                LayerName = name;
                LayerType = "BaseLayer";
                
                Initialized = false;
            }

            public BaseLayer (string name, BaseActivationFunction actFunc,
                BaseInitializer weightsInit, BaseInitializer biasesInit)
            {
                // Constructor for BaseLayer Class 
                LayerName = name;
                LayerType = "BaseLayer";
                
                Initialized = false;

            }

            public BaseLayer NextLayer
            {
                // Get or Set Next Layer
                get { return _layerNext; }
                set { _layerNext = value; }                   
            }

            public BaseLayer PrevLayer
            {
                // Get or Set Previous Layer
                get { return _layerPrev; }
                set { _layerPrev = value;}
            }

            public int[] InputShape 
            {
                // Get or set input array shape
                get { return _shapeInput; }
                set { _shapeInput = value; }
            }

            public int[] OutputShape
            {
                // Get or set output array shape
                get { return _shapeOutput; }
                set { _shapeOutput = value; }
            }

            public int[] ActivationShape
            {
                // Get or Set activation array shape
                get { return _shapeActivation; }
                set { _shapeActivation = value; }
            }

            public virtual void FormatLayerParams()
            {
                // Format The Layer Params Object
                _shapeInput = _layerPrev._shapeOutput;
                _shapeActivation = _shapeInput;
                _shapeOutput = _shapeInput;
            }

            protected struct LayerParameters
            {
                // Internally Defined Struct to hold Weights & Biases
                private int[] _weightShape;
                private int[] _biasShape;

                public LayerParameters(int[] weightShape, int[] biasShape)
                {
                    _weightShape = weightShape;
                    _biasShape = biasShape;
                }


            }

            protected struct LayerActivations
            {
                // Internally defined Struct to hold Layer Activations
                private int[] _shape;
                private int _rank;

                public Array LinearActivations { get; private set; }

                public Array OutputActivations { get; private set; }

                public LayerActivations(int[] shape)
                {
                    _shape = shape;
                    _rank = _shape.Length;

                    LinearActivations = Array.CreateInstance(typeof(double), _shape);
                    OutputActivations = Array.CreateInstance(typeof(double), _shape);
                    
                }

                


            }

            public virtual void GetLayerParams()
            {
                // get the Layer Params Object
                throw new NotImplementedException();
            }

        }
    } 
}
