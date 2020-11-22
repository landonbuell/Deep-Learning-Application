using System;
using System.Collections.Generic;

using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.Layers
{
    public abstract class NetworkLayer
    {
        // NetworkLayer Class
        // All Layers use in Neural Network Stack must inherit from here

        #region LayerAttributes

        public string LayerName { get; protected set; }
        public string LayerType { get; protected set; }
        public int LayerIndex { get; set; }
        public bool Initialized { get; protected set; }

        protected ActivationFunction _activationFunction;
        protected LayerActivations _layerActivations;
        protected LayerParameters _layerParameters;

        protected BaseInitializer _weightsInitializer;
        protected BaseInitializer _biasesInitializer;

        protected int _batchSize;
        protected int[] _shapeInput;
        protected int[] _shapeOutput;

        protected NetworkLayer _layerNext;
        protected NetworkLayer _layerPrev;

        #endregion

        #region LayerConstructors

        public NetworkLayer(string name) 
        {
            // Constructor for BaseLayer Class (Given only name)
            LayerName = name;
            LayerType = "NetworkLayer";
            Initialized = false;

            // Set Activation Function Instance & Initializers
            _activationFunction = new Identity();
            _weightsInitializer = new UniformInitializer();
            _biasesInitializer = new UniformInitializer();

        }

        public NetworkLayer(string name, ActivationFunction actFunc) 
        {
            // Constructor for BaseLayer Class 
            LayerName = name;
            LayerType = "NetworkLayer";
            Initialized = false;

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _weightsInitializer = new UniformInitializer();
            _biasesInitializer = new UniformInitializer();
        }

        public NetworkLayer(string name, ActivationFunction actFunc,
            BaseInitializer weightsInit, BaseInitializer biasesInit) 
        {
            // Constructor for BaseLayer Class 
            LayerName = name;
            LayerType = "BaseLayer";

            // Set some default properties
            Initialized = false;

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _weightsInitializer = weightsInit;
            _biasesInitializer = biasesInit;
        }

        #endregion

        #region LayerProperties

        public NetworkLayer NextLayer
        {
            // Get or Set Next Layer
            get { return _layerNext; }
            set { _layerNext = value; }
        }

        public NetworkLayer PrevLayer
        {
            // Get or Set Previous Layer
            get { return _layerPrev; }
            set { _layerPrev = value; }
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

        #endregion

        #region LayerStructs

        protected struct LayerActivations
        {
            // Internally defined Struct to hold Layer Activations
            private int[] _shape;
            private int _rank;

            public Array LinearActivations { get; set; }

            public Array OutputActivations { get; set; }

            public LayerActivations(int[] shape)
            {
                _shape = shape;
                _rank = _shape.Length;

                LinearActivations = Array.CreateInstance(typeof(double), _shape);
                OutputActivations = Array.CreateInstance(typeof(double), _shape);

            }

        }

        #endregion
        
        public virtual void InitializeLayer()
        {
            // Determine input,output shapes
            InputShape = PrevLayer.OutputShape;
            OutputShape = InputShape;
            
            // Format Activations struct 
            _layerActivations = new LayerActivations(_shapeOutput);
        }

        public virtual Array Call(Array X)
        {
            // Call Layer w/ Inputs X
            _layerActivations.LinearActivations = X;
            _layerActivations.OutputActivations = X;
            return X;
        }

        public virtual void GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }
    }
}
