﻿using System;

using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork
{
    namespace Layers
    {
        public class BaseLayer
        {

            public string LayerName { get; protected set; }

            public string LayerType { get; protected set; }

            public int LayerIndex { get; set; }

            public bool Initialized { get; protected set; }

            protected 

            protected int batchSize;
            protected int[] _shapeInput;
            protected int[] _shapeOutput;
            protected int[] _shapeActivation;
            
            private BaseLayer _layerNext;
            private BaseLayer _layerPrev;

            public BaseLayer(string name)
            {
                // Constructor for BaseLayer Class (Given only name)
                LayerName = name;
                LayerType = "BaseLayer";
                
                Initialized = false;


            }

            public BaseLayer (string name, Activation actFunc, 
                Initializer weightsInit, Initializer biasesInit)
            {
                // Constructor for BaseLayer Class 
                LayerName = name;
                LayerType = "BaseLayer";
                
                Initialized = false;

            }

            public BaseLayer NextLayer
            {
                // Get or Set Next Layer
                get { return _layerNext; }
                set { _layerNext = value; }                   
            }

            public BaseLayer PrevLayer
            {
                // Get or Set Previous Layer
                get { return _layerPrev; }
                set { _layerPrev = value;}
            }

            public int[] InputShape 
            {
                // Get or set input array shape
                get { return _shapeInput; }
                set { _shapeInput = value; }
            }

            public int[] OutputShape
            {
                // Get or set output array shape
                get { return _shapeOutput; }
                set { _shapeOutput = value; }
            }

            public int[] ActivationShape
            {
                // Get or Set activation array shape
                get { return _shapeActivation; }
                set { _shapeActivation = value; }
            }

            public virtual void FormatLayerParams()
            {
                // Format The Layer Params Object
                _shapeInput = _layerPrev._shapeOutput;
                _shapeActivation = _shapeInput;
                _shapeOutput = _shapeInput;
            }

            public virtual void GetLayerParams()
            {
                // get the Layer Params Object
                throw new NotImplementedException();
            }

            public virtual LayerActivations Call (LayerActivations X)
            {
                // Call BaseLayer w/ Inputs X
                return X;
            }
        }

    }
   
}