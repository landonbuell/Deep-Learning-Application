using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Mathematics;
using NeuralNetwork.Exceptions;

namespace NeuralNetwork.Layers
{
    public interface ILayer
    {
        // Layer Interface
        
    }

    public abstract class Layer
    {
        protected Layer _layerNext;
        protected Layer _layerPrev;

        protected int[] _shapeInput;
        protected int[] _shapeOutput;

        public string LayerName { get; protected set; }
        public string LayerType { get; protected set; }

        public int LayerIndex { get; set; }
        public bool Initialized { get; protected set; }

        #region LayerConstructors

        public Layer(string name = " ", Layer next = null, Layer prev = null)
        {
            // Constructor for Base Layer Type
            LayerName = name;
            LayerType = "Layer";

            _layerNext = next;
            _layerPrev = prev;

            _shapeInput = null;
            _shapeOutput = null;

            LayerIndex = -1;
            Initialized = false;            
        }

        #endregion

        #region LayerProperties

        public Layer NextLayer
        {
            // Get or Set Next Layer
            get { return _layerNext; }
            internal set { _layerNext = value; }
        }

        public Layer PrevLayer
        {
            // Get or Set Previous Layer
            get { return _layerPrev; }
            internal set { _layerPrev = value; }
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

        #endregion

        public virtual void InitializeLayer()
        {
            // Initialize layer for Network
            Initialized = true;
        }

        protected bool TestShape(Array X)
        {
            // Test In given shape matches Input
            int[] shapeX = ArrayTools.GetShape(X);
            bool shapesMatch = _shapeInput.SequenceEqual(shapeX);
            if (shapesMatch == false) 
                throw new ArrayShapeException(this, shapeX);
            else 
                return true; 
        }

        #region CallLayer

        public virtual float[] Call(float[] X)
        {
            // Call Layer w/ 1D Inputs X    
            return X;
        }

        public virtual float[,] Call(float[,] X)
        {
            // Call Layer w/ 2D Inputs X
            return X;
        }

        public virtual float[,,] Call(float[,,] X)
        {
            // Call Layer w/ 3D Inputs X
            return X;
        }

        public virtual float[,,,] Call(float[,,,] X)
        {
            // Call Layer w/ 4D Inputs X
            return X;
        }

        #endregion
    }
}
