using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using NeuralNetwork.Layers.Utilities;
using NeuralNetwork.Mathematics;

namespace NeuralNetwork.Layers
{    
    public class DenseLayer : NetworkLayer
    {

        public int Neurons { get; protected set; }

        #region DenseConstructors

        public DenseLayer(int neurons, string name = " ", Layer next = null, Layer prev = null) : base(name,next,prev)
        {
            LayerType = "DenseLayer";
            Neurons = neurons;

            _parameters = new DenseParameters();
            _activations = new LayerActivations2D();
            _activationFunction = new Identity();

            // Set Weight + Bias Initializers
            _initWeights0 = new ConstantInitializer(0.0f);
            _initWeights0 = new ConstantInitializer(0.0f);

            // Set Weight + Bias Regularizer?
        }

        public DenseLayer(int neurons, ActivationFunction actFunc = null, Initializer initW0 = null, Initializer initW1 = null,
            string name = " ", Layer next = null, Layer prev = null) : base(name, next, prev, actFunc, initW0, initW1)
        {
            LayerType = "DenseLayer";
            Neurons = neurons;

            _parameters = new DenseParameters();
            _activations = new LayerActivations2D();
        }




        #endregion

        public override void InitializeLayer()
        {
            // Determine Shapes
            
            // Get Shapes of Layer Parameters
            
            // Initialize Layer Parameters
            

            // Housekeeping 
            Initialized = true;
        }

        #region CallLayer

        public new virtual float[] Call(float[] X)
        {
            // Call Layer w/ 1D Inputs X
            return X;
        }

        public new virtual float[,] Call(float[,] X)
        {
            // Call Layer w/ 2D Inputs X
            return X;
        }

        public new virtual float[,,] Call(float[,,] X)
        {
            // Call Layer w/ 3D Inputs X
            throw new RankException("Rank invalid, Inputs to DenseLayer must be <= 2");
        }

        public new virtual float[,,,] Call(float[,,,] X)
        {
            // Call Layer w/ 4D Inputs X
            throw new RankException("Rank invalid, Inputs to DenseLayer must be <= 2");
        }

        #endregion

        protected class DenseParameters : LayerParameters
        {

        }
    }
}
