using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;


namespace NeuralNetwork
{
    namespace LayerUtilities
    {
        public class BaseLayerParameters
        {
            // Object that holds and acts on Weights & biases    
            protected Initializer _weightsInit;
            protected Initializer _biasesInit;

            protected readonly Random Generator = new Random();

            // Shape of Weights & Biases
            public int[] WeightShape { get; set; }
            public int[] BiasShape { get; set; }

            // Weights & Biases
            protected double[,] _W;
            protected double[] _b;

            public BaseLayerParameters(bool trainable)
            {
                IsTrainable = trainable;
            }

            public BaseLayerParameters(bool trainable, int[] weightShape, int[] biasShape)
            {
                IsTrainable = trainable;
                WeightShape = weightShape;
                BiasShape = biasShape;
            }

            public bool IsTrainable { get; protected set; }

            public virtual void Initialize ()
            {
                // Initialize These Parameters
                // No params for parent LayerParameter Type
            }

            protected double[,] GenerateWeights()
            {
                // Generate Elements in Weight Matrix
                double[,] array = new double[WeightShape[0], WeightShape[1]];
                for (int i = 0; i < _W.GetLength(0); i++)
                {
                    for (int j = 0; j < _W.GetLength(1); j++)
                    {
                        double randomVal = 10 * (Generator.NextDouble() - 0.5);
                        array[i, j] = randomVal;
                    }
                }
                return array;
            }

            protected double[] GenerateBiases()
            {
                // Generate Elements in Weight Matrix
                double[] array = new double[BiasShape[0]];
                for (int i = 0; i < _W.GetLength(0); i++)
                {
                    double randomVal = 10 * (Generator.NextDouble() - 0.5);
                    array[i] = randomVal;
                }
                return array;
            }

            public double[,] GetWeights
            {
                get { return _W; }
                set { _W = value; }
            }

            public double[] GetBiases
            {
                get { return _b; }
                set { _b = value; }
            }
        }

        public class LinearDenseParameters : BaseLayerParameters
        {
            // Parameters Objects for LinearDenseLayer
            

            public LinearDenseParameters(bool trainable) : base(trainable)            
            {
                // Initialize LinearDenseParameters Instance
            }

            public override void Initialize()
            {
                // Initialize These Parameters
                GenerateWeights();
                GenerateBiases();
            }
        }

        public class Convolution2DParamaters : BaseLayerParameters
        {
            // Parameters Objects for Convoltion2DLayer

            public Convolution2DParamaters(bool trainable) :  base(trainable)
            {
                // Initialize LinearDenseParameters Instance
            }
        }
    }
}
