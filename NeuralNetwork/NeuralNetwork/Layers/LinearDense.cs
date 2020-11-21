using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using NeuralNetwork.Layers.Utilities;
using NeuralNetwork.Mathematics;

namespace NeuralNetwork.Layers
{    
    public class LinearDense : NetworkLayer
    {

        public int Nodes { get; private set; }

        #region LinearDenseConstructors

        public LinearDense(string name, int nodes) : base(name)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "LinearDense";
            Nodes = nodes;              
        }

        public LinearDense(string name, int nodes, ActivationFunction actFunc) : base(name,actFunc)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "LinearDense";
            Nodes = nodes;
        }

        public LinearDense(string name, int nodes, ActivationFunction actFunc,
            BaseInitializer weightsInit , BaseInitializer biasesInit) : base(name,actFunc,weightsInit,biasesInit)
        {
            // Constructor for Linear Dense Layer Class
            LayerType = "LinearDense";
            Nodes = nodes;
        }

        #endregion

        public void Call(double [,] X)
        {
            // Call Layer w/ Inputs X
        }

        public override void FormatLayer()
        {
            // Determine input,output shapes
            InputShape = PrevLayer.OutputShape;
            OutputShape = InputShape;

            // Format Activations struct 
            _layerActivations = new LayerActivations(_shapeOutput);
        }

        public override void GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }

    }
   
}
