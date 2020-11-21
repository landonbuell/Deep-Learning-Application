using System.Text;
using System.Transactions;
using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.Models
{

    public class LinearNetwork : BaseNetwork
    {
        public LinearNetwork(string name): base(name)
        {
            // Constructor for LinearNetwork Object
            this.ModelType = "LinearNetworkType";
        }

        public override void ModelSummary()
        {
            // Print Summary of this model
        }
    }
    
}
    
