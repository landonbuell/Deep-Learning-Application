﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public abstract class Perceptron
    {
        // Parent Perceptron 
        public string ModelName { get; protected set; }
        public string ModelType { get; protected set; }
        public int CurrentBatchSize { get; protected set; }

        protected int _inputNodes;
        protected int _outputNodes;
   
        protected ModelActivations _activations;
        protected ModelParameters _parameters;

        protected int[] _weightShape;
        protected int[] _biasShape;

        protected Initializer _weightsInitializer;
        protected Initializer _biasInitializer;

        #region PerceptronConstructors

        public Perceptron(string name, int inputNodes)
        {
            // Constructor for Base Perceptron Class
            ModelName = name;
            ModelType = "BasePerceptron";
            _inputNodes = inputNodes;
            CurrentBatchSize = 1;
            // Other Parameters

        }

        public Perceptron(string name, int inputNodes,
            Initializer weightsInit, Initializer biasInit)
        {
            // Constructor for Base Perceptron Class
            ModelName = name;
            ModelType = "BasePerceptron";
            _inputNodes = inputNodes;
            CurrentBatchSize = 1;

            // Other Parameters
            _weightsInitializer = weightsInit;
            _biasInitializer = biasInit;

        }

        #endregion

        public virtual double[] Call(double[] X)
        {
            // Call perceptron with Inputs X
            return X;
        }

        public virtual double[,] Call(double[,] X)
        {
            // Call perceptron with Inputs X
            return X;
        }


    }
}