using System.Text;
using System.Transactions;
using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork
{
    namespace Models
    {

        public class LinearNetwork : BaseNetwork
        {

            public LinearNetwork(string name): base(name)
            {
                // Constructor for LinearNetwork Object
                this.ModelType = "LinearNetworkType";
            }

        }
    }
}
    
