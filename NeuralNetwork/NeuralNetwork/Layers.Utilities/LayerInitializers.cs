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

        public virtual Array Call (int[] shape)
        {
            // Call Initializer, Return Empty array of shape
            return Array.CreateInstance(typeof(double), shape);
        }
    }

    public class UniformInitializer : BaseInitializer
    {
        // Initialize Weights with uniform average

        public Array Call(int[] shape, double value = 0.0)
        {
            Array X = Array.CreateInstance(typeof(double), shape);


            return X;
        }
    }

    public class ConstantInitializer : BaseInitializer
    {

    }

    public class IdentityInitializer : BaseInitializer
    {

    }

    public class GaussianIntializer : BaseInitializer
    {

    }
}
