using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace NeuralNetwork.Layers
{
    public class PointerLayer : NetworkLayer
    {
        // Pointer Layer Only Points to another layer
        // Is used as Head/Tail Nodes in Layer Graph

        public PointerLayer (string name) : base(name)
        {
            // Constructor for PointerLayer
            LayerType = "PointerLayer";
            NextLayer = null;
            PrevLayer = null;
        }

        public override void InitializeLayer()
        {
            // Initialize Pointer Layer (Do nothing)
            Initialized = true;
        }
    }   
}
