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
            _dataType = typeof(float);
            _randomSeed = 0;
        }

        public Initializer(int[] shape)
        {
            // Constructor for BaseInititializer Object
            _shape = shape;
            _rank = shape.Length;
            _dataType = typeof(float);
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

        public virtual float[] Init1D()
        {
            // Call Initializer 1D
            if (_rank != 1) { throw new RankException("Rank must == 1"); }
            float[] outputArray = (float[])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual float[,] Init2D()
        {
            // Call Initializer 2D
            if (_rank != 2) { throw new RankException("Rank must == 2"); }
            float[,] outputArray = (float[,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual float[,,] Init3D()
        {
            // Call Initializer 3D
            if (_rank != 3) { throw new RankException("Rank must == 3"); }
            float[,,] outputArray = (float[,,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        public virtual float[,,,] Init4D()
        {
            // Call Initializer 4D
            if (_rank != 4) { throw new RankException("Rank must == 4"); }
            float[,,,] outputArray = (float[,,,])Array.CreateInstance(_dataType, _shape);
            return outputArray;
        }

        #endregion
    }

    internal class ConstantInitializer : Initializer
    {
        // Initialize Weights with uniform average
        protected float _value;

        public ConstantInitializer(float val = 0.0f) : base()
        {
            // Constructor for Unifrom Initializer class
            _value = val;
        }

        public ConstantInitializer (int[] shape, float val = 0.0f): base(shape)
        {
            // Constructor for Unifrom Initializer class
            _value = val;
        }

        #region Initialize

        public override float[] Init1D()
        {
            // Call Initializer 1D
            float[] outputArray = base.Init1D();
            for (int i = 0; i < _shape[0]; i++)
            {
                outputArray[i] = _value;
            }
            return outputArray;
        }

        public override float[,] Init2D()
        {
            // Call Initializer 3D
            float[,] outputArray = base.Init2D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    outputArray[i,j] = _value;
                }
            }
            return outputArray;
        }

        public override float[,,] Init3D()
        {
            // Call Initializer 3D
            float[,,] outputArray = base.Init3D();
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

        public override float[,,,] Init4D()
        {
            // Call Initializer 3D
            float[,,,] outputArray = base.Init4D();
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
        public IdentityInitializer(float _value = 1.0f, float _value = 1.0f) : base()
        {
            // Constructor for IdentityInitializer
        }

        public IdentityInitializer(int[] shape) : base(shape)
        {
            // Constructor for IdentityInitializer
        }

        #region Initialize

        public override float[] Init1D()
        {
            // Call Initializer 1D
            float[] outputArray = base.Init1D();
            for (int i = 0; i < _shape[0]; i++)
            {
                if (i == 0)
                    outputArray[i] = 1.0f;
                else
                    outputArray[i] = 0.0f;
            }
            return outputArray;
        }

        public override float[,] Init2D()
        {
            // Call Initializer 3D
            float[,] outputArray = base.Init2D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {

                    if (i == j)
                        outputArray[i,j] = 1.0f;
                    else
                        outputArray[i,j] = 0.0f;
                }
            }
            return outputArray;
        }

        public override float[,,] Init3D()
        {
            // Call Initializer 3D
            float[,,] outputArray = base.Init3D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    for (int k = 0; k < _shape[2]; k++)
                    {
                        if (i == j && i == k)
                            outputArray[i, j, k] = 1.0f;
                        else
                            outputArray[i, j, k] = 0.0f;
                    }
                }
            }
            return outputArray;
        }

        public override float[,,,] Init4D()
        {
            // Call Initializer 3D
            float[,,,] outputArray = base.Init4D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    for (int k = 0; k < _shape[2]; k++)
                    {
                        for (int l = 0; l < _shape[4]; l++)
                        {
                            if (i == j && i == k && i==l)
                                outputArray[i, j, k, l] = 1.0f;
                            else
                                outputArray[i, j, k, l] = 0.0f;
                        }
                    }
                }
            }
            return outputArray;
        }

        #endregion
    }

    internal class RandomUniformInitializer : Initializer
    {

        private int _seed;
        private int _valMin;
        private int _valMax;
        private Random _randNum;

        public RandomUniformInitializer(int randSeed = 0, int valMin = 0, int valMax = 1) : base()
        {
            // Constructor for UniformInitializer
            
        }

        public RandomUniformInitializer(int[] shape, int randSeed = 0, int bndLow = 0, int bndHigh = 1) : base(shape)
        {
            // Constructor for UniformInitializer
        }

        #region Initialize

        public override float[] Init1D()
        {
            // Call Initializer 1D
            float[] outputArray = base.Init1D();
            for (int i = 0; i < _shape[0]; i++)
            {
                outputArray[i] = _randNum.
            }
            return outputArray;
        }

        public override float[,] Init2D()
        {
            // Call Initializer 3D
            float[,] outputArray = base.Init2D();
            for (int i = 0; i < _shape[0]; i++)
            {
                for (int j = 0; j < _shape[1]; j++)
                {
                    outputArray[i, j] = _value;
                }
            }
            return outputArray;
        }

        public override float[,,] Init3D()
        {
            // Call Initializer 3D
            float[,,] outputArray = base.Init3D();
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

        public override float[,,,] Init4D()
        {
            // Call Initializer 3D
            float[,,,] outputArray = base.Init4D();
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

    internal class RandomGaussianIntializer : Initializer
    {
        protected float _mean;
        protected float _var;

        public RandomGaussianIntializer(float mean, float var) : base()
        {
            // Constructor for GaussianInitializer
            _mean = mean;
            _var = var;
        }

        public RandomGaussianIntializer(int[] shape, float mean, float var): base(shape)
        {
            // Constructor for GaussianInitializer
            _mean = mean;
            _var = var;
        }
    }
}
