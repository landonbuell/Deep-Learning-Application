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


            public virtual void Initialize (int[] inputShape, int nodes)
            {
                // Initialize These Parameters
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

            public override void Initialize (int[] inputShape, int nodes)
            {
                // Initialize Parameters in Dense Layer
                _weightShape = new int[] { nodes, inputShape[0]};
                _biasShape = new int[] { nodes, 1 };


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
