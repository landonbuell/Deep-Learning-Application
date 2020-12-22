namespace NeuralNetwork.Layers
{
    public class OutputLayer : Dense
    {

        public OutputLayer(string name, int nodes) : base(name, nodes)
        {
            // Constructor for Input Layer
            LayerType = "OutputLayer";
        }
    }
    
}
