using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.LayerUtilities
{
    public class BaseActivations
    {
        // Hold Activation objects
        public double[,] FinalActivations { get; set; }

        public double[,] LinearActivations { get; set; }
    }
    
}
