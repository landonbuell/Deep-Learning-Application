
using System;

using NeuralNetwork.Models;
using NeuralNetwork.Layers;
using System.Collections.Generic;

namespace NeuralNetwork
{
    class NeuralNetworkMain
    {
        static void Main(string[] args)
        {
            LinearNetwork NetworkA = new LinearNetwork("NetworkA");

            NetworkA.AddLayer(new InputLayer("Input", new int[] {2, 4}));
            
            NetworkA.AddLayer(new Dense("Dense1", 8));
            NetworkA.AddLayer(new Dense("Dense2", 10));

            NetworkA.AddLayer(new OutputLayer("Output", 2));

            List<Layer> NetworkALayers = NetworkA.LayerList;

            NetworkA.AssembleModel();

            NetworkA.ModelSummary();

            Console.WriteLine("=)");

        }
    }
}
