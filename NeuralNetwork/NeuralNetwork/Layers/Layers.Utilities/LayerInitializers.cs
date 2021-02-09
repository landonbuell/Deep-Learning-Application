using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{  
    public abstract class Initializer
    {
        // Parent Paramater Intializer Class
        protected int[] _shape;
        protected int _rank;
        protected Type _dataType;
        protected int _randomSeed;

        #region InitializerConstructors

        public Initializer()
        {
            // Constructor for BaseInititializer Object
            _dataType = typeof(double);
            _randomSeed = 0;
        }

        public Initializer(int[] shape)
        {
            // Constructor for BaseInititializer Object
            _shape = shape;
            _rank = shape.Length;
            _dataType = typeof(double);
            _randomSeed = 0;
        }

        #endregion

        public int[] Shape
        {
            get { return _shape; }
            set
            {
                _shape = value;
                _rank = _shape.Length;
            }
        }

        #region BaseInit

        public virtual double[] Init1D()
        {
            // Call Initializer 1D
            if (_rank != 1) { throw new RankException("Rank must == 1"); }
            double[] outputArray = (double[])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual double[,] Init2D()
        {
            // Call Initializer 2D
            if (_rank != 2) { throw new RankException("Rank must == 2"); }
            double[,] outputArray = (double[,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual double[,,] Init3D()
        {
            // Call Initializer 3D
            if (_rank != 3) { throw new RankException("Rank must == 3"); }
            double[,,] outputArray = (double[,,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual double[,,,] Init4D()
        {
            // Call Initializer 4D
            if (_rank != 4) { throw new RankException("Rank must == 4"); }
            double[,,,] outputArray = (double[,,,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        #endregion
    }

    internal class ConstantInitializer : Initializer
    {
        // Initialize Weights with uniform average
        protected double _value;

        public ConstantInitializer(double val) : base()
        {
            // Constructor for Unifrom Initializer class
            _value = val;
        }

        public ConstantInitializer (int[] shape, double val): base(shape)
        {
            // Constructor for Unifrom Initializer class
            _value = val;
        }

        #region ConstantInit

        public override double[] Init1D()
        {
            // Call Initializer 1D
            double[] outputArray = base.Init1D();
            for (int i = 0; i < _shape[0]; i++)
            {
                outputArray[i] = _value;
            }
            return outputArray;
        }

        public override double[,] Init2D()
        {
            // Call Initializer 3D
            double[,] outputArray = base.Init2D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    outputArray[i,j] = _value;
                }
            }
            return outputArray;
        }

        public override double[,,] Init3D()
        {
            // Call Initializer 3D
            double[,,] outputArray = base.Init3D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    for (int k = 0; k < _shape[2]; k++)
                    {
                        outputArray[i, j, k] = _value;
                    }
                }
            }
            return outputArray;
        }

        public override double[,,,] Init4D()
        {
            // Call Initializer 3D
            double[,,,] outputArray = base.Init4D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    for (int k = 0; k < _shape[2]; k++)
                    {
                        for (int l = 0; l < _shape[4]; l++)
                        {
                            outputArray[i, j, k, l] = _value;
                        }
                    }
                }
            }
            return outputArray;
        }

        #endregion
    }

    internal class IdentityInitializer : Initializer
    {
        public IdentityInitializer() : base()
        {
            // Constructor for IdentityInitializer
        }

        public IdentityInitializer(int[] shape) : base(shape)
        {
            // Constructor for IdentityInitializer
        }
    }

    internal class UniformInitializer : Initializer
    {

        public UniformInitializer() : base()
        {
            // Constructor for UniformInitializer
        }

        public UniformInitializer(int[] shape) : base(shape)
        {
            // Constructor for UniformInitializer
        }
    }

    internal class GaussianIntializer : Initializer
    {
        protected double _mean;
        protected double _var;

        public GaussianIntializer(double mean, double var) : base()
        {
            // Constructor for GaussianInitializer
            _mean = mean;
            _var = var;
        }

        public GaussianIntializer(int[] shape, double mean, double var): base(shape)
        {
            // Constructor for GaussianInitializer
            _mean = mean;
            _var = var;
        }
    }
}
