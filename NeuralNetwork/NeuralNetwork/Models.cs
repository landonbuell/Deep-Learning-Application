using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.Parameters;

namespace NeuralNetwork
{
    namespace Models
    {

        public class BaseModel
        {
            // Base Model Class - All Inheritance from here
            public string _modelName;
            public string _modelType = "BaseFeedForward";
            public List<BaseLayer> _layers;

            public BaseModel (string name)
            {
                // Constructor for BaseModel Class
                this._modelName = name;
                this._layers = new List<BaseLayer>();
            }


        }

        public class FeedForward
        {

            public FeedForward()
            {

            }

        }
    }
}
    
