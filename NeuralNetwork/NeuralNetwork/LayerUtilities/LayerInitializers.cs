using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    namespace LayerUtilities
    {

        public static partial class LayerUtilitiesMap
        {
            // Dictionary maps String to Activation Function
            public static Dictionary<string, Initializer> InitializerMap = new Dictionary<string, Initializer>
            {
                
            };
        }

        public class Initializer
        {
            // Initializer Class to Initialize Layer Params
            private int[] _weightsShape;
            private int[] _biasesShape;

            public Initializer()
            {
                // Constructor For Base intialize Class
            }


        }

    }
}
