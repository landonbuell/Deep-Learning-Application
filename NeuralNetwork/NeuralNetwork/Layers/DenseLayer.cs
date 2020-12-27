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

        public int Nodes { get; protected set; }

        #region DenseConstructors

        public DenseLayer(string name, int nodes) : base(name)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new Activations2D();  
        }

        public DenseLayer(string name, int nodes, ActivationFunction actFunc) : base(name,actFunc)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new Activations2D();
        }

        public DenseLayer(string name, int nodes, ActivationFunction actFunc,
            Initializer weightsInit , Initializer biasesInit) : base(name,actFunc,weightsInit,biasesInit)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new Activations2D();
        }

        #endregion
      
        public override void InitializeLayer()
        {
            // Determine Shapes
            InputShape = PrevLayer.OutputShape;
            OutputShape = new int[2] { InputShape[0], Nodes };

            // Get Shapes of Layer Parameters
            int[] shapeWeights = new int[] { InputShape[1], Nodes};
            int[] shapeBiases = new int[] { Nodes };
            _initializerWeights.Shape = shapeWeights;
            _initializerBiases.Shape = shapeBiases;

            // Initialize Layer Parameters
            _layerParameters = new DenseParameters(shapeWeights,shapeBiases);
            _layerParameters.InitializeParameters(_initializerWeights, _initializerBiases);

            // Housekeeping 
            Initialized = true;
        }

        public override void GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }

        #region CallLayer

        public new virtual double[] Call(double[] X)
        {
            // Call Layer w/ 1D Inputs X
            
            return X;
        }

        public new virtual double[,] Call(double[,] X)
        {
            // Call Layer w/ 2D Inputs X
            return X;
        }

        public new virtual double[,,] Call(double[,,] X)
        {
            // Call Layer w/ 3D Inputs X
            throw new RankException("Rank invalid, must be <= 2");
        }

        public new virtual double[,,,] Call(double[,,,] X)
        {
            // Call Layer w/ 4D Inputs X
            throw new RankException("Rank invalid, must be <= 2");
        }

        #endregion
    }
}
