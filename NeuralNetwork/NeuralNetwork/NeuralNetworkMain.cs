
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

            NetworkA.AddLayer(new InputLayer("Input", new int[] {4}));
            
            NetworkA.AddLayer(new LinearDense("Dense1", 8));
            NetworkA.AddLayer(new LinearDense("Dense2", 10));

            NetworkA.AddLayer(new OutputLayer("Output", 2));

            List<BaseLayer> NetworkALayers = NetworkA.GetLayerList;

            NetworkA.ModelSummary();

            Console.WriteLine("=)");

        }
    }
}
