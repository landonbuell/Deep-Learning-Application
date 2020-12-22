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

        protected BaseInitializer _weightsInitializer;
        protected BaseInitializer _biasesInitializer;

        #endregion

        #region LayerConstructors

        public NetworkLayer(string name) : base(name)
        {
            // Constructor for BaseLayer Class (Given only name)
            LayerType = "NetworkLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = new Identity();
            _weightsInitializer = new UniformInitializer();
            _biasesInitializer = new UniformInitializer();

        }

        public NetworkLayer(string name, ActivationFunction actFunc) : base(name)
        {
            // Constructor for BaseLayer Class 
            LayerType = "NetworkLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _weightsInitializer = new UniformInitializer();
            _biasesInitializer = new UniformInitializer();
        }

        public NetworkLayer(string name, ActivationFunction actFunc,
            BaseInitializer weightsInit, BaseInitializer biasesInit) : base(name)
        {
            // Constructor for BaseLayer Class 
            LayerType = "BaseLayer";

            // Set Activation Function Instance & Initializers
            _activationFunction = actFunc;
            _weightsInitializer = weightsInit;
            _biasesInitializer = biasesInit;
        }

        #endregion

        public new virtual void InitializeLayer()
        {
            // Determine input,output shapes
            InputShape = PrevLayer.OutputShape;
            OutputShape = InputShape;

            // Format Activations Object
            

        }

        public virtual void GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }
    }
}
