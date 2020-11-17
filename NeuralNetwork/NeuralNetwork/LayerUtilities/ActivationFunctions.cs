using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork.LayerUtilities
{

    public class BaseActivationFunction
    {
        // Parent Activation Function Class
        protected BaseActivations Call (BaseActivations X)
        {
            // Apply Activation Function to Inputs X

            return X;
        }
    }
}
