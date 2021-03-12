using System;
using System.Collections.Generic;

using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.Layers
{
    public abstract class NetworkLayer : Layer
    {
        // NetworkLayer Class
        // All NetworkLayers have Weights, Biases, Activations

        #region LayerAttributes

        protected ActivationFunction _activationFunction;
        protected LayerActivations _layerActivations;
        protected LayerParameters _layerParameters;

        protected Initializer _initializerWeights;
        protected Initializer _initializerBiases;

        #endregion

        #region LayerConstructors

        public NetworkLayer(string name = " ", Layer next = null, Layer prev = null) :base(name,next,prev)
        {
            // Constructor for NetworkLayer Class (Given only name)
            LayerType = "NetworkLayer";
        }

        public NetworkLayer(string name) : base(name)
        {
            // Constructor for BaseLayer Class (Given only name)
            LayerType = "NetworkLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = new Identity();
            _initializerWeights = new ConstantInitializer(0.0);
            _initializerBiases = new ConstantInitializer(0.0);
        }

        public NetworkLayer(string name, ActivationFunction actFunc) : base(name)
        {
            // Constructor for BaseLayer Class 
            LayerType = "NetworkLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _initializerWeights = new ConstantInitializer(0.0);
            _initializerBiases = new ConstantInitializer(0.0);
        }

        public NetworkLayer(string name, ActivationFunction actFunc,
            Initializer weightsInit, Initializer biasesInit) : base(name)
        {
            // Constructor for BaseLayer Class 
            LayerType = "NetworkLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _initializerWeights = weightsInit;
            _initializerBiases = biasesInit;
        }

        #endregion

        public virtual List<Array> GetLayerParams()
        {
            // get the Layer Params Object
            return new List<Array>
            {
                _layerParameters.Weights,
                _layerParameters.Biases
            };            
        }
    }
}
