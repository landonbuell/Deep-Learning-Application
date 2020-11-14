
using NeuralNetwork.LayerUtilities;


namespace NeuralNetwork
{
    namespace Layers
    {
        public class BaseLayer
        {

            public string LayerName { get; protected set; }

            public string LayerType { get; protected set; }

            public int LayerIndex { get; protected set; }

            protected Initializer _layerWeightsInitializer;
            protected Initializer _layerBiasesInitializer;
             
            protected LayerActivations _layerActivations;   
            protected BaseLayerParameters _layerParams;
            protected Activation _layerActFunc;
            
            protected int[] _inputShape;
            protected int[] _outputShape;
            protected int[] _activationShape;
            
            protected int batchSize;
            
            private BaseLayer _nextLayer;
            private BaseLayer _prevLayer;

            public BaseLayer(string name, string actFunc = "Identity", string initFunc = "Uniform" )
            {
                // Constructor for BaseLayer Class (Given only name)
                LayerName = name;
                LayerType = "BaseLayer";
                
            }

            public BaseLayer (string name, Activation actFunc, Initializer paramsIntializer)
            {
                // Constructor for BaseLayer Class (Given only name)
                LayerName = name;
                LayerType = "BaseLayer";

                // Set Activation Function & Parameter Intializer
            }

            public BaseLayer NextLayer
            {
                // Get or Set Next Layer
                get { return _nextLayer; }
                set { _nextLayer = value; }                   
            }

            public BaseLayer PrevLayer
            {
                // Get or Set Previous Layer
                get { return _prevLayer; }
                set { _prevLayer = value;}
            }

            public int[] InputShape 
            {
                // Get or set input array shape
                get { return _inputShape; }
                set { _inputShape = value; }
            }

            public int[] OutputShape
            {
                // Get or set output array shape
                get { return _outputShape; }
                set { _outputShape = value; }
            }

            public int[] ActivationShape
            {
                // Get or Set activation array shape
                get { return _activationShape; }
                set { _activationShape = value; }
            }

            public virtual void FormatLayerParams()
            {
                // Format The Layer Params Object
                // No Parameters to Format in BaseLayer Type
                // Called when Layer is added to a Computational graph
            }

            public virtual LayerParameters GetLayerParams()
            {
                // get the Layer Params Object
                return _layerParams;
            }

            public virtual LayerActivations Call (LayerActivations X)
            {
                // Call BaseLayer w/ Inputs X   
                LayerActivations Y = _layerActFunc.Call(X);
                return Y;
            }
        }

    }
   
}
