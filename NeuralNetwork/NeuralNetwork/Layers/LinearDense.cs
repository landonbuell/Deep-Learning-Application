﻿using System;
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
            _layerParameters = new LinearDenseParameters();
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
            double[,] Z = _layerParameters.Call(X);
        }

        public override void InitializeLayer()
        {
            // Determine input,output shapes
            InputShape = PrevLayer.OutputShape;
            OutputShape = InputShape;
            _layerActivations = new LayerActivations(_shapeOutput);
            int prevNodes = InputShape[1];

            // Format Parameters 
            _layerParameters = new LinearDenseParameters(new int[2] { Nodes, prevNodes },
                                                        new int[1] { Nodes } );

        public override void GetLayerParams()
        {
            // get the Layer Params Object
            throw new NotImplementedException();
        }

    }
   
}
