using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers
{
    public abstract class Layer
    {

        protected Layer _layerNext;
        protected Layer _layerPrev;

        protected int[] _shapeInput;
        protected int[] _shapeOutput;

        #region LayerConstructors

        public Layer(string name)
        {
            // Constructor for Base Layer Type
            LayerName = name;
            LayerType = "Layer";
            BatchSize = 1;
        }

        public Layer(string name, int batchSize)
        {
            // Constructor for Base Layer Type
            LayerName = name;
            LayerType = "Layer";
            BatchSize = batchSize; ;
        }

        #endregion

        #region LayerProperties

        public string LayerName { get; protected set; }
        public string LayerType { get; protected set; }

        public int LayerIndex { get; set; }
        public bool Initialized { get; protected set; }

        public int BatchSize { get; set; }

        public Layer NextLayer
        {
            // Get or Set Next Layer
            get { return _layerNext; }
            set { _layerNext = value; }
        }

        public Layer PrevLayer
        {
            // Get or Set Previous Layer
            get { return _layerPrev; }
            set { _layerPrev = value; }
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
            // Initialize Layer (Do nothing)
            Initialized = true;
        }

        #region CallLayer

        public virtual double[] Call(double[] X)
        {
            // Call Layer w/ 1D Inputs X
            return X;
        }

        public virtual double[,] Call(double[,] X)
        {
            // Call Layer w/ 2D Inputs X
            return X;
        }

        public virtual double[,,] Call(double[,,] X)
        {
            // Call Layer w/ 3D Inputs X
            return X;
        }

        public virtual double[,,,] Call(double[,,,] X)
        {
            // Call Layer w/ 4D Inputs X
            return X;
        }

        #endregion
    }
}
