
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
            NetworkA.AddLayer(new DenseLayer("Dense1", 8));
            NetworkA.AddLayer(new DenseLayer("Dense2", 10));
            NetworkA.AddLayer(new OutputLayer("Output", 2));
            NetworkA.AssembleModel();

            NetworkA.ModelSummary();


            Console.WriteLine("=)");
        }
    }
}
