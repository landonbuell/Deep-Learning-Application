using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public struct LayerActivations
    {
        // Internally defined Struct to hold Layer Activations
        private int[] _shape;
        private int _rank;

        public Array LinearActivations { get; set; }

        public Array OutputActivations { get; set; }

        public LayerActivations(int[] shape)
        {
            _shape = shape;
            _rank = _shape.Length;

            LinearActivations = Array.CreateInstance(typeof(double), _shape);
            OutputActivations = Array.CreateInstance(typeof(double), _shape);

        }
    }

}
