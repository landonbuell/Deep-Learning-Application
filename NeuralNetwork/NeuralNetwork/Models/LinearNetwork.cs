using System.Text;


using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.Models
{

    public class LinearNetwork : Network
    {
        public LinearNetwork(string name): base(name)
        {
            // Constructor for LinearNetwork Object
            ModelType = "LinearNetworkType";
        }


        public override void ModelSummary()
        {
            // Print Summary of Model to Console
            StringBuilder outputString = new StringBuilder();

        }
    }
    
}
    
