using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public abstract class Perceptron
    {
        // Parent Class for All Perceptrons

        #region Properties
        public string ModelName { get; protected set; }

        public string ModelType { get; protected set; }

        public ActivationFunction Activation { get; protected set; }

        public ObjectiveFunction Objective { get; protected set; }

        protected int _inputShape;
        protected int _outputShape;

        protected Array _weights;
        protected Array _bias;

        #endregion

        protected Perceptron(string name, int features )
        {
            // Constructor for Perceptron Base Class

            ModelName = name;
            ModelType = "BasePerceptron";
            _inputShape = features;
            Activation = new Identity();
            Objective = new MeanSquaredError();

        }

        public void Call (double[,] X)
        {
            // Call Perceptron w/  inputs X
            
        }

        public void TrainModel(double[,] X, double[] Y)
        {
            // Train model give data X,Y

        }

    }


    public class RegressorPerceptron : Perceptron
    {
        // Perceptron for classifier problems

        protected new double[] _weights;

        protected new double _bias;

        public RegressorPerceptron (string name, int features) : base(name, features)
        {
            ModelType = "RegressionPerceptron";
            _outputShape = 1;
        }
    }
}
