using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

using NeuralNetwork.Layers;
using NeuralNetwork.LayerUtilities;
using NeuralNetwork.DoubleLinkedGraphs;
using System.Runtime.InteropServices;

namespace NeuralNetwork
{
    namespace Models
    {
        public class BaseNetwork
        {
            // Base Model Class - All Inheritance from here
            public string _modelName;
            public string _modelType;
            protected int _layerCounter = 0;
            protected bool _isAssembled = false;

            protected List<BaseLayer> _layerList;
            protected ComputationalGraph _layerGraph;
            

            public BaseNetwork(string name)
            {
                // Constructor for BaseModel Class
                this._modelName = name;
                this._modelType = "BaseNetworkType";

                // Init Layer List & Graph
                _layerList = new List<BaseLayer>();                           
            }

            public int BatchSize { get; set; }

            public BaseNetwork AddLayer(BaseLayer newLayer)
            {
                // Add New Layer to the Tail of the Neural network
                _layerList.Add(newLayer);
                _layerCounter = _layerList.Count;
                newLayer._layerIndex = _layerCounter - 1;
                return this;
            }

            public BaseLayer PopLayer(int index = -1)
            {
                // Remove Layer At Index
                if (index > _layerCounter)
                    throw new ArgumentOutOfRangeException();
                BaseLayer victimLayer = _layerList[index];
                _layerList.RemoveAt(index);
                _layerCounter = _layerList.Count;
                for (int i = 0; i < _layerCounter; i++)
                    _layerList[i]._layerIndex = i;
                return victimLayer;
            }

            private void BuildGraph()
            {
                // Build Computational Graph of Layers
                _layerGraph = new ComputationalGraph();
                for (int i=0; i < _layerCounter; i++)
                {
                    // Add Each layer to Grap & Connect Nodes
                    _layerGraph.AddTailNode(_layerList[i]);
                }
            }

            private void FormatLayerParams()
            {
                // Iter through computational graph To Set Weight Params
                BaseLayer currentLayer = _layerGraph.GetHead.NextLayer;
                while (currentLayer != _layerGraph.GetTail)
                {
                    // Iterate through graph
                    currentLayer.FormatLayerParams();
                    currentLayer = currentLayer.NextLayer;
                }

            }

            public void ModelSummary()
            {
                // Print Summary of this Model's Layers and Parameters
                
            }

            public BaseNetwork AssembleModel()
            {
                // Prepare this Model for Usage
                BatchSize = _layerList[0].InputShape[0];
                BuildGraph();


                _isAssembled = true;
                return this;
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
    
