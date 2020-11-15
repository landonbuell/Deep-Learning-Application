
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

            public override void FormatLayerParams()
            {
                // Set Shapes for This Layer
                _shapeInput = PrevLayer.OutputShape;
                int prevBatch = _shapeInput[1];
                int prevNodes = _shapeInput[1];

                // Set Activation Shape & Output Shape
                _shapeActivation = new int[2] { prevBatch, Nodes };
                _shapeOutput = _shapeActivation;

                // Initialize the Weights & Biases

                Initialized = true;
            }
        }
    }
}
