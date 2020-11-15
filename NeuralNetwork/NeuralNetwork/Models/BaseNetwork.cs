using System;
using System.Collections.Generic;

using NeuralNetwork.Layers;
using NeuralNetwork.LayerUtilities;
using NeuralNetwork.ObjectiveFunctions;
using NeuralNetwork.ComputationalGraphs;
using NeuralNetwork.Optimizers;



namespace NeuralNetwork
{
    namespace Models
    {
        public class BaseNetwork
        {
            // Base Model Class - All Inheritance from here

            public string ModelName { get; protected set; }

            public string ModelType { get; protected set; }

            public int BatchSize { get; protected set; }

            protected int _layerCounter;
            protected bool _isAssembled;

            protected List<BaseLayer> _layerList;
            protected LinearGraph _layerGraph;

            protected BaseOptimizer _Optimizer;
            protected BaseCostFunction _Objective;

            public BaseNetwork(string name)
            {
                // Constructor for BaseModel Class (Empty)
                this.ModelName = name;
                this.ModelType = "BaseNetworkType";
                this._layerCounter = 0;
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = new LinearGraph();
                this._layerList = new List<BaseLayer>();
            }

            public BaseNetwork(string name, LinearGraph existingGraph)
            {
                // Constructor for BaseModel Class (given Graph)
                this.ModelName = name;
                this.ModelType = "BaseNetworkType";
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = existingGraph;
                this._layerList = existingGraph.GetGraphList;
                this._layerCounter = _layerList.Count;
            }

            public BaseNetwork(string name, List<BaseLayer> exisitingLayers)
            {
                // Constructor for BaseModel Class (given Layers)
                this.ModelName = name;
                this.ModelType = "BaseNetworkType";
                this._isAssembled = false;

                // Intialize Graph & layer List for this Model
                this._layerGraph = new LinearGraph(exisitingLayers);
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
                protected set { _Optimizer = value; }
            }

            public BaseCostFunction ObjectiveFunction
            {
                get { return _Objective; }
                protected set { _Objective = value; }
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
                BatchSize = _layerList[0].InputShape[0];
                FormatLayerParams();
                
                
                _isAssembled = true;
                return this;
            }

            protected LayerActivations Call (LayerActivations inputArray)
            {
                // Execute Forward Pass on this model
                BaseLayer currentLayer = _layerGraph.GetHead.NextLayer;
                LayerActivations X = inputArray;

                // Pass Through the Network
                while (currentLayer != _layerGraph.GetTail)
                {
                    // Iterate through graph
                    X = currentLayer.Call(X);
                    currentLayer = currentLayer.NextLayer;
                }
                // Return the Last Activations Object
                return X;
            }

            public void FitModel(double[,] X , int[,] Y , int batchSize , int epochs)
            {
                // Fit Model to Input Data
                throw new NotImplementedException();
            }

            public void EvalModel(double[,] X, int[,] Y, int batchSize)
            {
                // Fit Model to Input Data
                throw new NotImplementedException();
            }

            public void ModelSummary()
            {
                // Print Summary of this Model's Layers and Parameters
                if (_isAssembled == false) { throw new Exception(); }
                Console.WriteLine("\n{0} Summary:",ModelName);
                

            }

        }
    }
}
    
