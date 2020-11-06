using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{

    namespace LayerParameters
    {
        public class BaseLayerParameters
        {
            // All Weights/Biases are a parameter
            private bool _trainable;
            private int[] _shape;

            public BaseLayerParameters(int[] shape, bool trainable = true)
            {
                this._shape = shape;
                this._trainable = trainable;
            }

            public int[] GetShape() { return _shape; }

            public bool IsTrainable() { return _trainable; }
        }

        

        
        
    }
    
}
