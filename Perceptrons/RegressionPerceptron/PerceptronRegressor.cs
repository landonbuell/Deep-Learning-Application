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
            ModelType = "PerceotronRegressor";
            _outputNodes = 1;

            // Weights Initializer
        }

    }
}
