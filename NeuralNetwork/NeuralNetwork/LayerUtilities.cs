using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace NeuralNetwork
{

    namespace LayerUtilities
    {
        public class LayerParameters
        {
            // All Weights/Biases are a parameter
            private bool _trainable;
            private int[] _shape;

            public LayerParameters(int[] shape, bool trainable = true)
            {
                this._shape = shape;
                this._trainable = trainable;
            }

            public int[] GetShape() { return _shape; }

            public bool IsTrainable() { return _trainable; }
        }

        public class LayerActivations
        {
            // Hold Activation objects
            public int[] Shape { get; set; }



        }

        public class BaseInitializer
        {
            // Initializer Class to Initialize Layer Params



        }

    }

}
