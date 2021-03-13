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
       
        protected LayerActivations _activations;
        protected LayerParameters _parameters;
        protected ActivationFunction _activationFunction;

        protected Initializer _initWeights0;
        protected Initializer _initWeights1;
        #endregion

        #region LayerConstructors

        public NetworkLayer(string name = " ", Layer next = null, Layer prev = null) :base(name,next,prev)
        {
            // Constructor for NetworkLayer Class (Given only name)
            LayerType = "NetworkLayer";
            
        }

        public NetworkLayer(string name = " ", Layer next = null, Layer prev = null,
            ActivationFunction actFunc = null, Initializer initW0 = null, Initializer initW1 = null) : base(name, next, prev)
        {
            // Constructor for NetworkLayer Class (Given only name)
            LayerType = "NetworkLayer";

            // Set Activation Function
            if (actFunc == null)
                _activationFunction = new Identity();
            else
                _activationFunction = actFunc;

            // Set Bias Initializer
            if (initW0 == null)
                _initWeights0 = new ConstantInitializer(0.0f);
            else
                _initWeights0 = initW0;

            // Set Weights Initializer
            if (initW1 == null)
                _initWeights0 = new ConstantInitializer(0.0f);
            else
                _initWeights1 = initW1;


            // Set Bias Regularizer

            // Set Weight Regularizer

        }
        #endregion

        public virtual List<Array> GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }
    }
}
