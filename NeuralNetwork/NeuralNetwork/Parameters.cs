using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{

    namespace Parameters
    {
        public class BaseParameterArray
        {
            // All Weights/Biases are a parameter
            private bool _trainable;
            private int[] _shape;

            public BaseParameterArray(int[] shape, bool trainable = true)
            {
                this._shape = shape;
                this._trainable = trainable;
            }

            public int[] GetShape() { return _shape; }

            public bool IsTrainable() { return _trainable; }
        }

        public class WeightArray : BaseParameterArray
        {
            public WeightArray (int[] shape, bool trainable = true) : base(shape, trainable)
            {
                // Constructor Method of Weight Array Class
            }
        }

        public class BiasArray : BaseParameterArray
        {

        }
        
    }
    
}
