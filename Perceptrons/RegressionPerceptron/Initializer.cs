using System;
using System.Collections;


namespace RegressionPerceptron
{
    public abstract class Initializer
    {
        // Parent initializer Class
        public int[] Shape { get; protected set; }
        public int _rank;

        public Initializer(int[] shape)
        {
            // Constructor for Parent Initializer Instance
            Shape = shape;
            _rank = Shape.Length;
        }

        protected virtual double[] Init1D()
        {
            // Initialize 1D parameter Array
            return new double[Shape[0]];
        }

        protected virtual double[,] Init2D()
        {
            // Initialize 2D parameter array
            return new double[Shape[0], Shape[1]];
        }

        public virtual Array Call()
        {
            // Create Parameter Array
            if (_rank == 1) { return Init1D(); }
            else if (_rank == 2) { return Init2D(); }
            else { throw new RankException("Rank must be <= 2")};
        }

    }

    public class UniformInitializer : Initializer
    {
        // Initialize Paramaters with a constant value
        protected double _value;

        public UniformInitializer(int[] shape, double val) : base(shape)
        {
            // Constructor for ConstantInitializer Instance
            _value = val;
        }

        protected override double[] Init1D()
        {
            // Initialize 1D parameter Array
            double[] X = base.Init1D();
            for (int i = 0; i < Shape[0]; i++)
            {
                X[i] = _value;
            }       
            return X;
        }

        protected override double[,] Init2D()
        {
            // Initialize 1D parameter Array
            double[,] X = base.Init2D();
            for (int i = 0; i < Shape[0]; i++)
            {
                for (int j = 0; j < Shape[1]; j++)
                {
                    X[i, j] = _value;
                }
            }
            return X;
        }


    }


}