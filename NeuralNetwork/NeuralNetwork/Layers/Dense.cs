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
            _layerActivations = new DenseActivations(LayerName, LayerType, Nodes);
            
        }

        public Dense(string name, int nodes, ActivationFunction actFunc) : base(name,actFunc)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new DenseActivations(LayerName, LayerType, Nodes);
        }

        public Dense(string name, int nodes, ActivationFunction actFunc,
            BaseInitializer weightsInit , BaseInitializer biasesInit) : base(name,actFunc,weightsInit,biasesInit)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "Dense";
            Nodes = nodes;
            _layerActivations = new DenseActivations(LayerName, LayerType, Nodes);
        }

        #endregion
      
        public override void InitializeLayer()
        {
            // Determine Input Shape
            BatchSize = PrevLayer.BatchSize;
            InputShape = PrevLayer.OutputShape;
            OutputShape[0] = BatchSize;
            OutputShape[1] = Nodes;

            // Activations Shape
            _layerActivations.UpdateShapes(OutputShape);                        
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
