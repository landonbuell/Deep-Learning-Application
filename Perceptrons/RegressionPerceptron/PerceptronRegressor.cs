using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    class PerceptronRegressor : Perceptron
    {

        // Regression Perceptron

        public PerceptronRegressor(string name, int inputNodes) : base(name, inputNodes)
        {
            // Constructor for PerceptronRegressor
            ModelType = "PerceptronRegressor";
            _outputNodes = 1;

            // Weights Initializer

        }

        #region CallRegressor

        public override double[] Call(double[] X)
        {
            // Call perceptron with Inputs X
            

            return X;
        }

        public override double[,] Call(double[,] X)
        {
            // Call perceptron with Inputs X
            return X;
        }

        #endregion

    }
}
