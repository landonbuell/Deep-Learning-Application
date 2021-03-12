using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
   public abstract class LayerParameters
    { 
        // Parent Class for LayerParameters
        // All shapes are transposed
        protected int[] _shapeWeights0;
        protected int[] _shapeWeights1;

        protected Initializer _initWeights0;
        protected Initializer _initWeights1;

        protected Array _weights0;
        protected Array _weights1;
        
        public bool Initialized { get; set; }
        
       
        public LayerParameters(int[] shapeW0, int[] shapeW1, Initializer initW0, Initializer initW1)
        {
            // Constructor for 
            _shapeWeights0 = shapeW0;
            _shapeWeights1 = shapeW1;

        }

        protected virtual void Initialize()
        {
            // Initialize Weights0 (bias)
            _initWeights0.Shape = _shapeWeights0;
            _initWeights1.Shape = _shapeWeights1;
            Initialized = true;
        }  
    }
}
