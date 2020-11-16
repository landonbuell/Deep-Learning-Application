using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    namespace LayerUtilities
    {
        public class BaseInitializer
        {
            // Parent Paramater Intializer Class
            private int[] _shape;
            private Type _dataType;

            public BaseInitializer(int[] shape)
            {
                // Initializer
            }

            public static Array Call (int[] shape)
            {
                // Call Initializer, Return Empty array of shape
                return Array.CreateInstance(typeof(double), shape);
            }
        }

        public class Uniform : BaseInitializer
        {
            // Initialize
        }


    }
}
