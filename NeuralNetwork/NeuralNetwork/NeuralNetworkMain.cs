
using System;

using NeuralNetwork.Models;
using NeuralNetwork.Layers;

namespace NeuralNetwork
{
    class NeuralNetworkMain
    {
        static void Main(string[] args)
        {
            LinearNetwork NetworkA = new LinearNetwork("NetworkA");

            NetworkA.AddLayer(new InputLayer("Input", new int[] {1,12}));
            
            NetworkA.AddLayer(new LinearDense("Dense1", 8));
            NetworkA.AddLayer(new LinearDense("Dense2", 16));
            NetworkA.AddLayer(new LinearDense("Dense3", 10));

            NetworkA.AddLayer(new OutputLayer("Output", 2));

            NetworkA.AssembleModel();

            Console.WriteLine("=)");

        }
    }
}
