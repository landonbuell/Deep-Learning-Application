using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

using NeuralNetwork.Layers;
using NeuralNetwork.LayerUtilities;
using NeuralNetwork.DoubleLinkedGraphs;
using System.Runtime.InteropServices;
using System.ComponentModel;
using NeuralNetwork.Optimizers;
using NeuralNetwork.ObjectiveFunctions;

namespace NeuralNetwork
{
    namespace Models
    {
        public class BaseNetwork
        {
            // Base Model Class - All Inheritance from here
            public string _modelName;
            public string _modelType;
            protected int _layerCounter;
            protected bool _isAssembled;
            protected int _batchSize;

            protected List<BaseLayer> _layerList;
            protected ComputationalGraph _layerGraph;

            protected BaseOptimizer _Optimizer;
            protected BaseCostFunction _Objective;

            public BaseNetwork(string name)
            {
                // Constructor for BaseModel Class (Empty)
                this._modelName = name;
                this._modelType = "BaseNetworkType";
                this._layerCounter = 0;
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = new ComputationalGraph();
                this._layerList = new List<BaseLayer>();
            }

            public BaseNetwork(string name, ComputationalGraph existingGraph)
            {
                // Constructor for BaseModel Class (given Graph)
                this._modelName = name;
                this._modelType = "BaseNetworkType";
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = existingGraph;
                this._layerList = existingGraph.GetGraphList;
                this._layerCounter = _layerList.Count;
            }

            public BaseNetwork(string name, List<BaseLayer> exisitingLayers)
            {
                // Constructor for BaseModel Class (given Layers)
                this._modelName = name;
                this._modelType = "BaseNetworkType";
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = new ComputationalGraph(exisitingLayers);
                this._layerList = _layerGraph.GetGraphList;
                this._layerCounter = _layerList.Count;
            }

            public List<BaseLayer> GetLayerList 
            { 
                get { return _layerGraph.GetGraphList; }
            }

            public BaseOptimizer ModelOptimizer
            {
                get { return _Optimizer; }
                set { _Optimizer = value; }
            }

            public BaseCostFunction ObjectiveFunction
            {
                get { return _Objective; }
                set { _Objective = value; }
            }

            public BaseNetwork AddLayer(BaseLayer newLayer)
            {
                // Add New Layer to the Tail of Graph             
                _layerGraph.AddTailNode(newLayer);
                newLayer.FormatLayerParams();
                _layerList = _layerGraph.GetGraphList;
                _layerCounter = _layerList.Count;
                return this;
            }

            public BaseLayer PopLayer(int index = -1)
            {
                // Remove Layer At Index
                throw new NotImplementedException();
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
           
            public BaseNetwork AssembleModel()
            {
                // Prepare this Model for Usage
                _batchSize = _layerList[0].InputShape[0];

                throw new NotImplementedException();
                
                _isAssembled = true;
                return this;
            }

            public void ModelSummary()
            {
                // Print Summary of this Model's Layers and Parameters
                Console.WriteLine("{0} Summary",_modelName);

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
    
