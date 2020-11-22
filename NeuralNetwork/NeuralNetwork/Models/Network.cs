using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.Layers.Utilities;
using NeuralNetwork.ObjectiveFunctions;
using NeuralNetwork.ComputationalGraphs;
using NeuralNetwork.Optimizers;


namespace NeuralNetwork.Models
{
    public class Network
    {
        // Base Model Class - All Inheritance from here

        public string ModelName { get; protected set; }

        public string ModelType { get; protected set; }

        public int BatchSize { get; protected set; }

        protected int _layerCounter;
        protected bool _isAssembled;

        protected List<NetworkLayer> _layerList;
        protected LinearGraph _layerGraph;

        protected Optimizer _Optimizer;
        protected ObjectiveFunction _Objective;


        #region NetworkConstructors

        public Network(string name)
        {
            // Constructor for BaseModel Class (Empty)
            this.ModelName = name;
            this.ModelType = "BaseNetworkType";
            this._layerCounter = 0;
            this._isAssembled = false;

            // Intialize Graph & layer List for this Model
            this._layerGraph = new LinearGraph();
            this._layerList = new List<NetworkLayer>();
        }

        public Network(string name, LinearGraph existingGraph)
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

        public Network(string name, List<NetworkLayer> exisitingLayers)
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

        #endregion

        #region NetworkProperties

        public List<NetworkLayer> GetLayerList 
        { 
            get { return _layerGraph.GetGraphList; }
        }

        public Optimizer ModelOptimizer
        {
            get { return _Optimizer; }
            protected set { _Optimizer = value; }
        }

        public ObjectiveFunction ObjectiveFunction
        {
            get { return _Objective; }
            protected set { _Objective = value; }
        }

        #endregion

        public Network AddLayer(NetworkLayer newLayer)
        {
            // Add New Layer to the Tail of Graph             
            _layerGraph.AddTailNode(newLayer);
            _layerList = _layerGraph.GetGraphList;
            _layerCounter = _layerList.Count;
            return this;
        }

        public NetworkLayer PopLayer(int index = -1)
        {
            // Remove Layer At Index
            throw new NotImplementedException();
        }
    
        public Network AssembleModel()
        {
            // Prepare this Model for Usage
            BatchSize = _layerList[0].InputShape[0];
            InitializeLayers();
                
                
            _isAssembled = true;
            return this;
        }

        protected void InitializeLayers()
        {
            // Iter through computational graph To Set Weight Params
            NetworkLayer currentLayer = _layerGraph.HeadNode.NextLayer;
            while (currentLayer != _layerGraph.TailNode)
            {
                // Iterate through graph
                currentLayer.InitializeLayer();
                currentLayer = currentLayer.NextLayer;
            }
        }

        protected Array Call (Array input)
        {
            // Execute Forward Pass on this model
            NetworkLayer currentLayer = _layerGraph.HeadNode.NextLayer;
            Array X = input;

            // Pass Through the Network
            while (currentLayer != _layerGraph.TailNode)
            {
                // Iterate through graph
                X = currentLayer.Call(X);
                currentLayer = currentLayer.NextLayer;
            }
            // Return the Last Activations Object
            return X;
        }

        public void Fit (double[,] X , int[,] Y , int batchSize , int epochs)
        {
            // Fit Model to Input Data
            throw new NotImplementedException();
        }

        public void Predict (double[,] X, int[,] Y, int batchSize)
        {
            // Fit Model to Input Data
            throw new NotImplementedException();
        }

        public virtual void ModelSummary()
        {
            // Print Summary of this Model's Layers and Parameters
            if (_isAssembled == false) { throw new Exception(); }
            Console.WriteLine("\n{0} Summary:",ModelName);
               
        }

    }
    
}
    
