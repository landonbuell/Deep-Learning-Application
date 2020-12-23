using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public abstract class Perceptron
    {
        public string ModelName { get; protected set; }
        public string ModelType { get; protected set; }
        public int CurrentBatchSize { get; protected set; }

        protected int _inputNodes;
        protected int _outputNodes;
   
        protected ModelActivations _activations;
        protected ModelParameters _parameters;

        protected Initializer _weightsInitializer;
        protected Initializer _biasInitializer;

        public Perceptron(string name, int inputNodes)
        {
            // Constructor for Base Perceptron Class
            ModelName = name;
            ModelType = "BasePerceptron";
            _inputNodes = inputNodes;

            // Other Parameters

        }

        public Perceptron(string name, int inputNodes,
            Initializer weightsInit, Initializer biasInit)
        {
            // Constructor for Base Perceptron Class
            ModelName = name;
            ModelType = "BasePerceptron";
            _inputNodes = inputNodes;

            // Other Parameters

        }


    }
}
