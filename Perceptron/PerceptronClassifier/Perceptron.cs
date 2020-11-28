using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronClassifier
{
    public class Perceptron
    {
        public string Name { get; protected set; }

        public int InputShape { get; protected set; }

        public int OutputShape { get; protected set; }

        public double LearningRate { get; protected set; }

        protected int _weightShape;
        protected int _biasShape;

        protected ParameterStruct Parameters;

        public Perceptron(string name, int inputShape, int outputShape, double learningRate)
        {
            // Constructor for Perceptrom
            Name = name;
            InputShape = inputShape;
            OutputShape = outputShape;
            LearningRate = LearningRate;

            _weightShape = InputShape;
            _biasShape = 1;

        }


        protected struct ParameterStruct
        {
            public double[,] Weights { get; private set; }

            public double[] Bias { get; private set; }

            public ParameterStruct()
            {

            }



        }

        protected void Call(double[,] X0)
        {
            // Call Perceptron w/ Inputs X
            double[,] X1 = LinearAlgebra.Transpose2D(X0);
            double[,] Wx = LinearAlgebra.MatrixProduct2D(Parameters.Weights, X1);


        }

        public void ModelTrain(double[,] X, double[,] Y)
        {
            // Train model
        }


    }
}
