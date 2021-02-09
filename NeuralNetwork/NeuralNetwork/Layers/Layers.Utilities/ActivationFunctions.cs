using System;
using System.Collections.Generic;
using System.Diagnostics;

using NeuralNetwork.Mathematics;

namespace NeuralNetwork.Layers.Utilities
{

    public abstract class ActivationFunction
    {
        // Parent Activation Function Class

        public int[] _shapeInOut { get; protected set; }

        #region CallActivationFunction

        public virtual double[] Call(double[] X)
        {
            // Call Function w/ 1D Inputs X
            return X;
        }

        public virtual double[,] Call(double[,] X)
        {
            // Call Function w/ 2D Inputs X
            return X;
        }

        public virtual double[,,] Call(double[,,] X)
        {
            // Call Function w/ 3D Inputs X
            return X;
        }

        public virtual double[,,,] Call(double[,,,] X)
        {
            // Call Function w/ 4D Inputs X
            return X;
        }

        #endregion
    }

    public class Identity : ActivationFunction
    {
        // Identity activation Function
    }

    public class ReLU : ActivationFunction 
    {
        // Rectified Linear Unit Activation Function


    }

}
