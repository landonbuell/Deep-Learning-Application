using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Mathematics;
using NeuralNetwork.Layers;

namespace NeuralNetwork.Exceptions
{
    public class ArrayShapeException : Exception
    {

        private StringBuilder exceptionString;

        public ArrayShapeException(Layer layer, int[] shape) : base()
        {
            // Constructor for Base Exception Class
            
            exceptionString.Append("Invalid input shape to layer" + layer.LayerName);
            exceptionString.Append("\n\tDesired Shape: " + layer.InputShape);
            exceptionString.Append("\n\tProvided Shape: " + shape);
            Console.WriteLine(exceptionString.ToString());
        }
    }
}
