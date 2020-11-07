using NeuralNetwork.LayerUtilities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace NeuralNetwork
{
    namespace ActivationFunctions
    {
        public class Activation
        { 
            // Base ActivationFunction Class

            public static LayerActivations Call(LayerActivations X)
            {
                // Apply Actication Functions to X
                return X;
            }
        }


    }
}
