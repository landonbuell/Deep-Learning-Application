using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace NeuralNetwork.Layers
{
    public class PointerLayer : Layer
    {
        // Pointer Layer Only Points to another layer
        // Is used as Head/Tail Nodes in Layer Graph

        public PointerLayer(string name = " ", Layer next = null, Layer prev = null) : base(name,next,prev)
        {
            // Constructor for PointerLayer

            // Empty???
        }
    }   
}
