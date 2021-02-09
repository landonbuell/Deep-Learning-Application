using System;

namespace RegressionPerceptron
{
    class RegressionMain
    {
        static void Main(string[] args)
        {

            // Create Data Set
            double[,] X = new double[,]
            {
                { 1.0, 1.0, 1.0 },
                { 2.0, 2.0, 2.0 },
                { 3.0, 3.0, 3.0 },
                { 4.0, 4.0, 4.0 }
            };
            double[,] Y = new double[,]
            {
                { -1.0, 5.0, 13.0, 17.0},
            };

            // Parameters should be: w = [1,2,3] b = [-1]


            // Create Perceptron
            PerceptronRegressor JARVIS = new PerceptronRegressor("JARVIS", 3);
            JARVIS


        }
    }
}
