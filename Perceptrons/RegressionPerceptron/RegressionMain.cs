using System;

namespace RegressionPerceptron
{
    class RegressionMain
    {
        static void Main(string[] args)
        {

            // Create Instance of Regressor Perceptron
            RegressorPerceptron Model = new RegressorPerceptron("JARVIS", 4);

            // Initialize Dummy DataSet
            double[,] dataX = new double[4, 1]
                { { 1.0 } , { 2.0 } , { 3.0 }, { 4.0 } };
            double[] dataY = new double[4] { 1.0, 3.0, 5.0, 7.0,  }
            // we should learn y = 2*x - 1
        }
    }
}
