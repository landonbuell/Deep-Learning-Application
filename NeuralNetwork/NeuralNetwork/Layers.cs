using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Activations;

namespace NeuralNetwork
{
    namespace Layers
    {
        public class BaseLayer
        {
            private int[] _inputShape = new int[] { 0, 0 };
            private int[] _outputShape;
            public string _layerName;
            public int _layerIndex;

            public BaseLayer()
            {
                // Constructor for BaseLayer Class
            }

            public int[] InputShape 
            {
                // Get or set input Shape
                get { return _inputShape; }
                set { _inputShape = value; }
            }
            public int[] OutputShape
            {
                // Get or set input Shape
                get { return _outputShape; }
                set { _outputShape = value; }
            }

            public double[,] Call (double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }


        }


        public class LinearDense
        {

        }

    }
   
}
