using System;

namespace PerceptronClassifier
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            // Create Data Set
            double[,] X = new double[,]
            {
                {0 , 0 , 1 },
                {0 , 0 , 1 },
                {1 , 0 , 1 },
                {1 , 1 , 1 }
            };
            double[,] Y = new double[,]
            {
                {0 },{1 },{1 }, {0 }
            };


            Perceptron Network = new Perceptron("JARVIS", 3, 1, 1.0);




        }
    }
}
