
using NeuralNetwork.LayerUtilities;


namespace NeuralNetwork
{
    namespace Layers
    {
        public class LinearDense : BaseLayer
        {

            public int Nodes { get; private set; }

            public LinearDense(string name, int nodes) : base(name)
            {
                // Constructor for Linear Dense Layer Class
                LayerType = "LinearDense";
                Nodes = nodes;
                
                
            }

            public LinearDense(string name, int nodes, BaseActivationFunction actFunc,
                BaseInitializer weightsInit, BaseInitializer biasesInit) : 
                base(name,actFunc,weightsInit,biasesInit)
            {
                // Constructor for Linear Dense Layer Class
                LayerType = "LinearDense";
                Nodes = nodes;
                
            }

            public override void FormatLayer()
            {
                // Set Shapes for This Layer
                _shapeInput = PrevLayer.OutputShape;
                _shapeOutput = new int[] { _shapeInput[0], Nodes };
                _shapeActivation = _shapeOutput;

                int[] weightsShape = new int[] { Nodes, _shapeInput[1] };
                int[] biasesShape = new int[] { 1, Nodes };

                // Create Layer Paramaters for this Object
                _layerActivations = new LayerActivations(_shapeActivation);
                _layerParameters = new LayerParameters(weightsShape, biasesShape);

                

                // Initialize the Weights & Biases

                Initialized = true;
            }
        }
    }
}
