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

        public virtual Array Call (Array inputArray)
        {
            // Apply Activation Function to Inputs X
            Debug.Assert(ArrayTools.GetShape(inputArray) == _shapeInOut);
            return inputArray;
        }
    }

    public class Identity : ActivationFunction
    {
        // Identity activation Function
    }

    public class ReLU : ActivationFunction 
    {
        // Rectified Linear Unit Activation Function

        public override Array Call(Array inputArray)
        {
            // Apply Activation Function to Inputs X
            Debug.Assert(ArrayTools.GetShape(inputArray) == _shapeInOut);
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Visit Every item in the array
                if (i < 0) { }
            }
            

            return inputArray;
        }

    }

}
