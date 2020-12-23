using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public class ModelActivations
    {

        public int[] Shape { get; protected set; }

        public double[,] Linear { get; protected set; }
        public double[,] Final { get; protected set; }

    }
}
