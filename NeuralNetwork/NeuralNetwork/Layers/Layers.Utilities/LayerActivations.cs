using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{

    public abstract class LayerActivations
    {
        protected Array _affine;
        protected Array _final;
        protected int[] _shape;
        protected int _rank;
    }

    internal class LayerActivations1D : LayerActivations
    {
        // 2D layer Activations structure

        protected new float[] _affine;
        protected new float[] _final;

        internal LayerActivations1D(int[] shape) : base()
        {
            // Constructor for 1D Layer Activations
            _rank = 1;
            if (shape.Length != _rank)
                throw new ArgumentException("Shape for LayerActivations1D must be 1");
            _shape = shape;
            _affine = (float[])Array.CreateInstance(typeof(float), shape);
            _final = (float[])Array.CreateInstance(typeof(float), shape);

        }

        public float[] Affine
        {
            // Get or set Affine Activations
            get { return _affine; }
            internal set { _affine = value; }
        }

        public float[] Final
        {
            // Get ot Set Final Activations
            get { return _final; }
            internal set { _final = value; }
        }

        public int[] GetShape { get { return _shape; } }

        public int GetRank { get { return _rank; } }
    }

    internal class LayerActivations2D : LayerActivations
    {
        // 2D layer Activations structure

        protected new float[,] _affine;
        protected new float[,] _final;

        internal LayerActivations2D(int[] shape) : base()
        {
            // Constructor for 2D Layer Activations
            _rank = 2;
            if (shape.Length != _rank)
                throw new ArgumentException("Shape for LayerActivations1D must be 2");
            _shape = shape;
            _affine = (float[,])Array.CreateInstance(typeof(float), shape);
            _final = (float[,])Array.CreateInstance(typeof(float), shape);
        }

        public float[,] Affine
        {
            // Get or set Affine Activations
            get { return _affine; }
            internal set { _affine = value; }
        }

        public float[,] Final
        {
            // Get ot Set Final Activations
            get { return _final; }
            internal set { _final = value; }
        }

        public int[] GetShape { get { return _shape; } }

        public int GetRank { get { return _rank; } }
    }

    internal class LayerActivations3D : LayerActivations
    {
        // 3D layer Activations structure

        protected new float[,,] _affine;
        protected new float[,,] _final;

        internal LayerActivations3D(int[] shape) : base()
        {
            // Constructor for 1D Layer Activations
            _rank = 3;
            if (shape.Length != _rank)
                throw new ArgumentException("Shape for LayerActivations1D must be 3");
            _shape = shape;
            _affine = (float[,,])Array.CreateInstance(typeof(float), shape);
            _final = (float[,,])Array.CreateInstance(typeof(float), shape);

        }

        public float[,,] Affine
        {
            // Get or set Affine Activations
            get { return _affine; }
            internal set { _affine = value; }
        }

        public float[,,] Final
        {
            // Get ot Set Final Activations
            get { return _final; }
            internal set { _final = value; }
        }

        public int[] GetShape { get { return _shape; } }

        public int GetRank { get { return _rank; } }
    }

    internal class LayerActivations4D : LayerActivations
    {
        // 3D layer Activations structure

        protected new float[,,,] _affine;
        protected new float[,,,] _final;

        internal LayerActivations4D(int[] shape) : base()
        {
            // Constructor for 1D Layer Activations
            _rank = 4;
            if (shape.Length != _rank)
                throw new ArgumentException("Shape for LayerActivations1D must be 4");
            _shape = shape;
            _affine = (float[,,,])Array.CreateInstance(typeof(float), shape);
            _final = (float[,,,])Array.CreateInstance(typeof(float), shape);
        }

        public float[,,,] Affine
        {
            // Get or set Affine Activations
            get { return _affine; }
            internal set { _affine = value; }
        }

        public float[,,,] Final
        {
            // Get ot Set Final Activations
            get { return _final; }
            internal set { _final = value; }
        }

        public int[] GetShape { get { return _shape; } }

        public int GetRank { get { return _rank; } }
    }
}
