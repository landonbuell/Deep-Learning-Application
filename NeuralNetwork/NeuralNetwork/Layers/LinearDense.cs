using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using NeuralNetwork.Layers.Utilities;
using NeuralNetwork.Mathematics;

namespace NeuralNetwork.Layers
{    
    public class Dense : NetworkLayer
    {

        public int Nodes { get; protected set; }

        #region DenseConstructors

        public Dense(string name, int nodes) : base(name)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new DenseActivations(LayerName, LayerType);
            
        }

        public Dense(string name, int nodes, ActivationFunction actFunc) : base(name,actFunc)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new DenseActivations(LayerName, LayerType);
        }

        public Dense(string name, int nodes, ActivationFunction actFunc,
            BaseInitializer weightsInit , BaseInitializer biasesInit) : base(name,actFunc,weightsInit,biasesInit)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new DenseActivations(LayerName, LayerType);
        }

        #endregion

        #region DenseActivations

        internal class DenseActivations : LayerActivations
        {
            // Activations for Linear Dense layers
            public new double[,] Linear { get; set; }
            public new double[,] Final { get; set; }

            internal DenseActivations(string name, string type) : base(name, type)
            {
                // Constructor for Linear Dense Layers

            }
        }

        #endregion

        #region DenseParameters

        protected class DenseParameters : LayerParameters
        {
            // Parameters Object for Linear Dense Layer
        }

        #endregion

        public new virtual void InitializeLayer()
        {
            // Determine Input Shape
            InputShape[0] = 1;
            InputShape[1] = PrevLayer.OutputShape[1];

            // Determine Output Shape
            OutputShape[0] = 1;
            OutputShape[1] = Nodes;

            // Activeations Shape
            _layerActivations.Shape = OutputShape;
            
            // Weight + Bias Shape

                               
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
            throw new RankException();
        }

        public new virtual double[,,,] Call(double[,,,] X)
        {
            // Call Layer w/ 4D Inputs X
            throw new RankException();
        }

        #endregion

    }

}
