using System;

using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.Layers
{
    public class InputLayer : NetworkLayer
    {
        // Format an Input array to be digested by Neural network

        protected new Layer _layerPrev;

        #region InputLayerConstructors

        public InputLayer(string name, int[] sampleShape, int batchSize = 1) : base(name)
        {
            // Constructor for Input Layer
            LayerType = "InputLayer";

            // Determine input & Output Shape
            int[] inputShape = new int[1 + sampleShape.Length];
            sampleShape.CopyTo(inputShape, 1);
            InputShape = inputShape;
            OutputShape = InputShape;

        }

        public InputLayer(string name, int[] sampleShape, int batchSize,
            ActivationFunction actFunc) : base(name, actFunc)
        {
            // Constructor for Input Layer
            LayerType = "InputLayer";

            // Determine input & Output Shape
            int[] inputShape = new int[1 + sampleShape.Length];
            sampleShape.CopyTo(inputShape, 1);
            InputShape = inputShape;
            OutputShape = InputShape;
        }

        #endregion

        public override void InitializeLayer()
        {
            // Determine input,output shapes
            _layerActivations = new LayerActivations(LayerName,LayerType);
            Initialized = true;
        }


    }

}
