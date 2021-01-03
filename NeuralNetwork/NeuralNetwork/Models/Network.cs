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

        public int CurrentBatchSize { get; protected set; }
        public bool Assembled { get; protected set; }

        protected int _layerCounter;

        protected List<Layer> _layerList;
        protected LinearGraph _layerGraph;

        protected Optimizer _optimizer;
        protected ObjectiveFunction _objective;


        #region NetworkConstructors

        public Network(string name)
        {
            // Constructor for BaseModel Class (Empty)
            ModelName = name;
            ModelType = "BaseNetworkType";
            _layerCounter = 0;
            Assembled = false;

            // Intialize Graph & layer List for this Model
            _layerGraph = new LinearGraph();
            _layerList = new List<Layer>();
        }

        public Network(string name, LinearGraph existingGraph)
        {
            // Constructor for BaseModel Class (given Graph)
            ModelName = name;
            ModelType = "BaseNetworkType";
            Assembled = false;

            // Intialize Graph & layer List for this Model
            _layerGraph = existingGraph;
            _layerList = existingGraph.GraphList;
            _layerCounter = _layerList.Count;
        }

        public Network(string name, List<NetworkLayer> exisitingLayers)
        {
            // Constructor for BaseModel Class (given Layers)
            ModelName = name;
            ModelType = "BaseNetworkType";
            Assembled = false;

            // Intialize Graph & layer List for this Model
            _layerGraph = new LinearGraph(exisitingLayers);
            _layerList = _layerGraph.GraphList;
            _layerCounter = _layerList.Count;
        }

        #endregion

        #region NetworkProperties

        public List<Layer> LayerList 
        { 
            get { return _layerGraph.GraphList; }
        }

        public Layer Input
        {
            get { return _layerGraph.HeadNode.NextLayer; }
        }

        public Layer Output
        {
            get { return _layerGraph.TailNode.PrevLayer; }
        }

        public Optimizer ModelOptimizer
        {
            get { return _optimizer; }
            protected set { _optimizer = value; }
        }

        public ObjectiveFunction ObjectiveFunction
        {
            get { return _objective; }
            protected set { _objective = value; }
        }

        #endregion

        public Network AddLayer(Layer newLayer)
        {
            // Add New Layer to the Tail of Graph             
            _layerGraph.AddTailNode(newLayer);
            _layerList = _layerGraph.GraphList;
            _layerCounter = _layerList.Count;
            return this;
        }

        public Layer PopLayer(int index = -1)
        {
            // Remove Layer At Index
            throw new NotImplementedException();
        }

        #region CallNetwork

        protected double[] Call (double[] input)
        {
            // Execute Forward Pass on this model
            Layer currentLayer = _layerGraph.HeadNode.NextLayer;
            double[] X = input;

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

        protected double[,] Call(double[,] input)
        {
            // Execute Forward Pass on this model
            Layer currentLayer = _layerGraph.HeadNode.NextLayer;
            double[,] X = input;

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

        protected double[,,] Call(double[,,] input)
        {
            // Execute Forward Pass on this model
            Layer currentLayer = _layerGraph.HeadNode.NextLayer;
            double[,,] X = input;

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

        protected double[,,,] Call(double[,,,] input)
        {
            // Execute Forward Pass on this model
            Layer currentLayer = _layerGraph.HeadNode.NextLayer;
            double[,,,] X = input;

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

        #endregion

        public void Fit (double[,] X , int[,] Y , int batchSize , int epochs)
        {
            // Fit Model to Input Data
            throw new NotImplementedException();
        }

        public void Predict (double[,] X, int batchSize)
        {
            // Fit Model to Input Data
            throw new NotImplementedException();
        }

        #region NetworkMethods

        public void AssembleModel()
        {
            // Prepare this Model for Usage
            CurrentBatchSize = _layerList[0].InputShape[0];
            InitializeLayers();
            _isAssembled = true;
        }

        protected void InitializeLayers()
        {
            // Iter through computational graph To Set Weight Params
            Layer currentLayer = _layerGraph.HeadNode;
            while (currentLayer != _layerGraph.TailNode)
            {
                // Iterate through graph & initialize layer
                currentLayer.InitializeLayer();           
                currentLayer = currentLayer.NextLayer;
            }
        }

        public virtual void ModelSummary()
        {
            // Print Summary of this Model's Layers and Parameters
            if (_isAssembled == false) { throw new Exception(); }
            Console.WriteLine("\n{0} Summary:",ModelName);          
        }

        #endregion

    }

}
    
