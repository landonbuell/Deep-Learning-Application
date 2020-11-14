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
        public class LayerParameters
        {
            // Object that holds and act on Weights & biases
            private bool _trainable;
            private Initializer _initializer;

            protected int[] _weightShape;
            protected int[] _biasShape;

            public LayerParameters ( Initializer initInst, bool trainable)
            {
                _initializer = initInst;
                _trainable = trainable;
            }


            public virtual void Initialize (int[] inputShape, int[] outputShape)
            {
                // Initialize These Parameters
            }

            public virtual void Call()
            {
                // Call this Layer's Parameters
            }


        }

        public class LinearDenseParameters : LayerParameters
        {
            // Parameters Objects for LinearDenseLayer

            public LinearDenseParameters(Initializer initInst, bool trainable) : 
                base(initInst,trainable )
            {
                // Initialize LinearDenseParameters Instance
            }

            public override void Initialize (int[] inputShape, int[] outputShape)
            {
                // Initialize Parameters in Dense Layer
                _weightShape = new int[] { outputShape[0] , inputShape[0]};
                _biasShape = new int[] { outputShape[0] , 1 };
                
                // Use Initializer Instance to Generate Weights & baises

            }

        }

        public class Convolution2DParamaters : LayerParameters
        {
            // Parameters Objects for Convoltion2DLayer

            public Convolution2DParamaters(Initializer initInst, bool trainable) :
                base(initInst, trainable)
            {
                // Initialize LinearDenseParameters Instance
            }
        }
    }
}
