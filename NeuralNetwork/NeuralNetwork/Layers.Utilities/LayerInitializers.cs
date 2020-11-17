using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{  
    public abstract class BaseInitializer
    {
        // Parent Paramater Intializer Class
        protected int[] _shape;
        protected Type _dataType;
        protected int _randomSeed;

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
        // Initialize Weights with uniform 

        public Uniform(int[] shape) : base(shape)
        {
            // Constructor given initial shape
        }
    }
}
