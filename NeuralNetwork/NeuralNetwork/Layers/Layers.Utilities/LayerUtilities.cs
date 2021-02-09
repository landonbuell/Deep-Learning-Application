using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    internal static class LayerUtilities
    {

        internal static ActivationFunction StringToActivationFunction(string activationFunction)
        {
            // Map String to Activation Function
            Dictionary<string, ActivationFunction> _stringToActivationFunction = new Dictionary<string, ActivationFunction>();
            try
            {
                return _stringToActivationFunction[activationFunction];
            }
            catch (KeyNotFoundException)
            {
                return new Identity();
            }
        }

        internal static Initializer StringToInitializer(string initializer)
        {
            // Map String to Initializer
            Dictionary<string, Initializer> _stringToInitializer = new Dictionary<string, Initializer>();
            try
            {
                return _stringToInitializer[initializer];
            }
            catch (KeyNotFoundException)
            {
                throw new NotImplementedException();
            }
        }

    }
}
