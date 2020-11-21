using System;

namespace NeuralNetwork.Layers
{
    public class InputLayer : NetworkLayer
    {
        // Format an Input array to be digested by Neural network

        public InputLayer (string name, int[] sampleShape , int batchSize = 1) : base(name)
        {
            // Constructor for Input Layer
            LayerType = "Inputlayer";

            // Format the InputShape
            _shapeInput = new int[1 + sampleShape.Length];
            _shapeInput[0] = batchSize;
            sampleShape.CopyTo(_shapeInput, 1);
            // Set Activation Shape & Output Shape
            _shapeActivation = _shapeInput;
            _shapeOutput = _shapeInput;

            // No weights or activations for this layer Type (null)
            LayerIndex = 0;
        }

    }
    
}
