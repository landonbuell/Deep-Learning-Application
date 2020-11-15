using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork
{
    namespace LayerUtilities
    {
        public static partial class LayerUtilitiesMap
        {
            // Dictionary maps String to Activation Function
            public static Dictionary<string, Activation> ActFuncMap = new Dictionary<string, Activation>
            {
                {" ", new Identity() },
                {"Identity",new Identity() },
                {"ReLU",new RectifiedLinearUnit()}
            };
        }

        public class Activation
        { 
            // Base ActivationFunction Class

            public virtual LayerActivations Call(LayerActivations X)
            {
                // Apply Actication Functions to X
                return X;
            }
        }

        public class Identity : Activation
        {

        }

        public class RectifiedLinearUnit : Activation
        {

        }

        public class Softmax : Activation
        {
            public override LayerActivations Call(LayerActivations X)
            {
                
                return X;
            }
        }


    }
}
