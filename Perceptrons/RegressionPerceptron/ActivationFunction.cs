using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionPerceptron
{
    public abstract class ActivationFunction
    {
        

        protected void Call(double[,] X)
        {
            // Call Thus activation function w/ Inputs X
        }
    }

    public class Identity : ActivationFunction
    {
        // Identity Activation Function


    }


}
