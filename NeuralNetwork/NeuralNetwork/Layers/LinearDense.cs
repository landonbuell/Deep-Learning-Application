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


        #endregion

        public override void FormatLayer()
        {
            // Set Shapes for This Layer
            _shapeInput = PrevLayer.OutputShape;
            _shapeOutput = new int[] { _shapeInput[0], Nodes };

            int[] weightsShape = new int[] { Nodes, _shapeInput[1] };
            int[] biasesShape = new int[] { 1, Nodes };

            // Create Layer Paramaters for this Object
            _layerActivations = new LayerActivations(_shapeOutput);


                

            // Initialize the Weights & Biases

            Initialized = true;
        }

    }
   
}
