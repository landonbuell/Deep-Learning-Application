namespace NeuralNetwork.Layers
{
    public class OutputLayer : DenseLayer
    {

        public OutputLayer(string name, int nodes) : base(name, nodes)
        {
            // Constructor for Input Layer
            LayerType = "OutputLayer";
        }
    }
    
}
