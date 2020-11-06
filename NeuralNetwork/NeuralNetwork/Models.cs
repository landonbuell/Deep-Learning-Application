using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.Parameters;

namespace NeuralNetwork
{
    namespace Models
    {
        public class BaseNetwork
        {
            // Base Model Class - All Inheritance from here
            public string _modelName;
            public string _modelType;

            private PointerLayer _headNode = new PointerLayer("HeadNode");
            private PointerLayer _tailNode = new PointerLayer("TailNode");

            public BaseNetwork (string name)
            {
                // Constructor for BaseModel Class
                this._modelName = name;
                this._modelType = "BaseNetworkType";

                // Join Sentinel Nodes
                this._headNode.NextLayer = _tailNode;
                this._tailNode.PrevLayer = _headNode;
            }

            public BaseNetwork AddTailLayer (BaseLayer newLayer)
            {
                // Add Layer to Tail of this Neural network
                BaseLayer oldTail = _tailNode.PrevLayer;
                oldTail.NextLayer = newLayer;
                newLayer.PrevLayer = oldTail;
                newLayer.NextLayer = _tailNode;
                _tailNode.PrevLayer = newLayer;
                return this;
            }

            public List<BaseLayer> GetLayers()
            {
                List<BaseLayer> layers = new List<BaseLayer>();
                
            }

        }

        public class LinearNetwork : BaseNetwork
        {

            public LinearNetwork(string name ): base(name)
            {
                // Constructor for LinearNetwork Object
                this._modelType = "LinearNetworkType";
            }

        }
    }
}
    
